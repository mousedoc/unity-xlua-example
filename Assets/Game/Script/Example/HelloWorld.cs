using System;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    private void Awake()
    {
        LuaManager.Initialize();
        string smallString = null;
        String bigString = null;

        var result = smallString == bigString;

        // By UnityEngine.Debug
        LuaManager.Env.DoString("CS.UnityEngine.Debug.Log('[Unity] hello world')");

        // By Lua script file (Resources/LuaScript/helloworld.lua.txt)
        LuaManager.Env.DoString("require 'LuaScript.helloworld'");

        LuaManager.Release();
    }
}
