using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SizeGetter
{
    public static long GetSize(object obj)
    {
        long size = 0;

        using (Stream s = new MemoryStream())
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(s, obj);
            size = s.Length;
        }

        return size;
    }
}
