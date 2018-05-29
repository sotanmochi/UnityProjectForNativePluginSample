using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Dllの読み込みに必要
using System.Runtime.InteropServices;

public class NativePluginSample
{
    // Dll内の関数を宣言
    [DllImport("NativePlugin")]
    public extern static int AddInt(int a, int b);
}