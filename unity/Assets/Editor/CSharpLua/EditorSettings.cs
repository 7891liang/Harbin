using UnityEngine;

namespace CSharpLua
{
    public class EditorSettings
    {
#if UNITY_EDITOR
        public static class Paths {
            public static readonly string CompiledScriptDir = Application.dataPath + "/CompiledScripts";
            public static readonly string CompiledOutDir = Application.dataPath + "/Resources/Lua/Generates";
            public static readonly string ToolsDir = Application.dataPath + "/../CSharpLuaTools";
            public const string kTempDir = "Assets/CSharpLuaTemp";
            public const string kBaseScripts = "BaseScripts";
            public const string kCompiledScripts = "Assembly-CSharp";
            public const string kBaseScriptsDir = "/" + kBaseScripts;
            public static readonly string SettingFilePath = Application.dataPath + kBaseScriptsDir + "/CSharpLua/Settings.cs";
        }

        public static class Menus {
            public const string kCompile = "CharpLua/Compile";
            public const string kRunFromCSharp = "CharpLua/Switch to RunFromCSharp";
            public const string kRunFromLua = "CharpLua/Swicth to RunFromLua";
        }
#endif

        public const bool kIsRunFromLua = true;
    }
}