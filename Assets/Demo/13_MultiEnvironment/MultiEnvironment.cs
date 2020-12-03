using UnityEngine;

public class MultiEnvironment : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var first = new XLua.LuaEnv();
        var second = new XLua.LuaEnv();

        first.DoString("require LuaScript.somefolder.somescript");

        first.Global.Set<string, int>("A", 10);
        second.Global.Set<string, int>("B", 20);

        Debug.Log(first.Global.Get<int>("A"));      // 10
        //Debug.Log(first.Global.Get<int>("B"));      // Error


        first.DoString("print(A)");

        //Debug.Log(second.Global.Get<int>("A"));     // Error
        Debug.Log(second.Global.Get<int>("B"));     // 20


        first.Dispose();
        second.Dispose();
    }
}
