using XLua;

/// <summary>
/// Static class of wrapping XLua.Env
/// </summary>
public static class LuaManager
{
    /// <summary>
    /// XLua's environment
    /// </summary>
    public static LuaEnv Env { get; private set; } = null;

    /// <summary>
    /// Initializer checker
    /// </summary>
    private static bool isInitialzed = false;

    /// <summary>
    /// Initialize xLua environment
    /// </summary>
    public static void Initialize()
    {
        if (isInitialzed) 
            return;

        Env = new LuaEnv();

        isInitialzed = true;
    }

    /// <summary>
    /// Dispose xLua environment
    /// </summary>
    public static void Release()
    {
        Env?.Dispose();
        Env = null;
    }
}
