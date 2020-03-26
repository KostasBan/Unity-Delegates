using System;
using UnityEngine;

public class FuncTest : MonoBehaviour
{
    public static Func<string, int> CharCount;

    void Start()
    {
        CharCount = GetLength;
        Debug.Log(CharCount("Hello"));
    }

    private int GetLength(string _str)
    {
        return _str.ToCharArray().Length;
    }
}
