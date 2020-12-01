using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLuaByFile : MonoBehaviour
{
    private XLua.LuaEnv luaEnv = null;

    void Start()
    {
        luaEnv = new XLua.LuaEnv();

        //luaEnv.DoString("print('hello world by execute string'");
        luaEnv.DoString("require 'LuaScript.helloworld'");
    }

    private void Update()
    {
        luaEnv.Tick();
    }

    private void OnDestroy()
    {
        luaEnv.Dispose();
    }
}
