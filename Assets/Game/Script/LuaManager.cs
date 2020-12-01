using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LuaManager
{
    public static XLua.LuaEnv Env { get; private set; } = null;

    private static bool isInitialzed = false;

    public static void Initialize()
    {
        if (isInitialzed) 
            return;

        Env = new XLua.LuaEnv();

        isInitialzed = true;
    }

    public static void Release()
    {
        Env?.Dispose();
        Env = null;
    }
}
