using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Text;

using UnityEditor;
using UnityEngine;

namespace CSharpLua {
  public static class Compiler {
    private sealed class CompiledFail : Exception {
      public CompiledFail(string message) : base(message) {
      }
    }

    private const string kDotnet = "dotnet";
    private static readonly string compiledScriptDir_ = EditorSettings.Paths.CompiledScriptDir;
    private static readonly string outDir_ = EditorSettings.Paths.CompiledOutDir;
    private static readonly string toolsDir_ = EditorSettings.Paths.ToolsDir;
    private static readonly string csharpLua_ = toolsDir_ + "/CSharp.lua/CSharp.lua.Launcher.dll";
    private static readonly string settingFilePath_ = EditorSettings.Paths.SettingFilePath;

    [MenuItem(EditorSettings.Menus.kCompile)]
    public static void Compile() {
//      if (!CheckDotnetInstall()) {
//        return;
//      }

      if (!File.Exists(csharpLua_)) {
        throw new InvalidProgramException("{csharpLua_} not found");
      }

      if (Directory.Exists(outDir_)) {
        string[] files = Directory.GetFiles(outDir_, "*.lua");
        foreach (string file in files) {
          File.Delete(file);
        }
      }

      List<string> libs = new List<string>();
      AssemblyName assemblyName = new AssemblyName(EditorSettings.Paths.kCompiledScripts);
      Assembly assembly = Assembly.Load(assemblyName);
      foreach (var referenced in assembly.GetReferencedAssemblies()) {
        if (referenced.Name != "mscorlib" && !referenced.Name.StartsWith("System")) {
          string libPath = Assembly.Load(referenced).Location;
          libs.Add(libPath);
        }
      }

      string[] metas = new string[] { toolsDir_ + "/UnityEngine.xml" };
      string lib = string.Join(";", libs.ToArray());
      string meta = string.Join(";", metas);
      #if UNITY_EDITOR_64
      string args = "{csharpLua_}  -s \"{compiledScriptDir_}\" -d \"{outDir_}\" -l \"{lib}\" -m {meta} -c";
#if UNITY_EDITOR_OSX
      string arg = " {0}  -s \"{1}\" -d \"{2}\" -l \"{3}\" -m {4} -c";
      var info = new ProcessStartInfo() {
        FileName = "/usr/local/share/dotnet/dotnet",
        Arguments = string.Format(arg,csharpLua_,compiledScriptDir_,outDir_,lib,meta),
        UseShellExecute = false,
        CreateNoWindow = false,
        RedirectStandardOutput = true,
        RedirectStandardError = true,
        StandardOutputEncoding = Encoding.UTF8,
        StandardErrorEncoding = Encoding.UTF8,
      };
#else
      var info = new ProcessStartInfo() {
        FileName = "dotnet",
        Arguments = string.Format(args,csharpLua_,compiledScriptDir_,outDir_,lib,meta),
        RedirectStandardOutput = true,
        RedirectStandardError = true,
        StandardOutputEncoding = Encoding.UTF8,
        StandardErrorEncoding = Encoding.UTF8,
      };
  #endif
      using (var p = Process.Start(info)) {
        p.WaitForExit();
        if (p.ExitCode == 0) {
          UnityEngine.Debug.Log("compile success");
        } else {
          string outString = p.StandardOutput.ReadToEnd();
          string errorString = p.StandardError.ReadToEnd();
          throw new CompiledFail(string.Format("Compile fail, {0}\n{1}\n{2} {3}",errorString,outString,kDotnet,args));
        }
      }
    }

    private static bool CheckDotnetInstall() {
      bool has = InternalCheckDotnetInstall();
      if (!has) {
        UnityEngine.Debug.LogWarning("not found dotnet");
        if (EditorUtility.DisplayDialog("dotnet未安装", "未安装.NET Core 2.0+运行环境，点击确定前往安装", "确定", "取消")) {
          Application.OpenURL("https://www.microsoft.com/net/download");
        }
      }
      return has;
    }

    private static bool InternalCheckDotnetInstall() {
      var info = new ProcessStartInfo() {
        FileName = kDotnet,
        Arguments = "--version",
        UseShellExecute = false,
        RedirectStandardOutput = true,
        RedirectStandardError = true,
        CreateNoWindow = true,
      };
      try {
        using (var p = Process.Start(info)) {
          p.WaitForExit();
          if (p.ExitCode != 0) {
            return false;
          } else {
            string version = p.StandardOutput.ReadToEnd();
            UnityEngine.Debug.Log("found dotnet " + version);
            return true;
          }
        }
      } catch (Exception e) {
        UnityEngine.Debug.LogException(e);
        return false;
      }
    }

    [MenuItem(EditorSettings.kIsRunFromLua ? EditorSettings.Menus.kRunFromCSharp : EditorSettings.Menus.kRunFromLua)]
    public static void Switch() {
#if UNITY_2017 || UNITY_2018
      const string kFieldName = nameof(BTSettings.kIsRunFromLua);
#else
      const string kFieldName = "kIsRunFromLua";
#endif

      string text = File.ReadAllText(settingFilePath_);
      int begin = text.IndexOf(kFieldName);
      if (begin != -1) {
        int end = text.IndexOf(';', begin + kFieldName.Length);
        if (end != -1) {
          string s = text.Substring(begin, end - begin);
          string[] array = s.Split('=');
          bool v = bool.Parse(array[1]);
          string replace = kFieldName + " = " + (v ? "false" : "true");
          text = text.Replace(s, replace);
          File.WriteAllText(settingFilePath_, text);
          AssetDatabase.Refresh();
        } else {
          throw new InvalidProgramException("field {kFieldName} not found end symbol in {settingFilePath_}");
        }
      } else {
        throw new InvalidProgramException("not found field {kFieldName} in {settingFilePath_}");
      }
    }
  }

#if UNITY_2018
  [InitializeOnLoad]
  public class EditorQuitHandler {
    static void Quit() {
      string tempDir = BTSettings.Paths.kTempDir;
      if (Directory.Exists(tempDir)) {
        Directory.Delete(tempDir, true);
      }
    }

    static EditorQuitHandler() {
      EditorApplication.quitting += Quit;
    }
  }
#endif
}

