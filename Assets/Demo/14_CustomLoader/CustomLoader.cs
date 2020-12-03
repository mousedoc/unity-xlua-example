using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomLoader : MonoBehaviour
{
    private void Start()
    {
        var env = new XLua.LuaEnv();
        env.AddLoader(CustomLoad);

        env.DoString("print('this is CustomLoader'");

        env.Dispose();
        env = null;
    }

    //public delegate byte[] CustomLoader(ref string filepath);
    private byte[] CustomLoad(ref string filePath)
    {
        // Do Somethign

        try
        {

        }
        catch (Exception exception)
        {
            Debug.Log($"[CustomLoader] {exception}");
            return null;
        }

        return null;
    }
}
