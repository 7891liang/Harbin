using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
using UnityEditor;
using CSharpLua;

namespace CSharpLua {
}

public sealed class TestUtils2 {
  public static GameObject Load(string path) {
    GameObject prefab = (GameObject)AssetDatabase.LoadMainAssetAtPath(path);
    return prefab;
  }
}