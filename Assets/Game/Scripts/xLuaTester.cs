using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class xLuaTester : MonoBehaviour
{
    private void Start()
    {
        var luaEnv = new XLua.LuaEnv();
        luaEnv.DoString("CS.UnityEngine.Debug.Log('hello world')");
        luaEnv.Dispose();
    }
}
