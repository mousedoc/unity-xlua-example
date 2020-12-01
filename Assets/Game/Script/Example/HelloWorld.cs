using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    private void Awake()
    {
        LuaManager.Initialize();


        LuaManager.Release();
    }
}
