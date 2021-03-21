using System;
using System.Runtime.InteropServices;

/// <summary>
/// https://stackoverflow.com/questions/66726597/returning-a-struct-from-pinvoke
/// https://docs.microsoft.com/en-us/dotnet/framework/interop/passing-structures
/// </summary>
namespace PInvokeCheckApi
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Struct4Byte
    {
        public int x1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Struct12Byte
    {
        public int x1;
        public int x2;
        public int x3;
    }

    [StructLayout(LayoutKind.Sequential)]
    public class Class4Byte
    {
        public int x1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public class Class12Byte
    {
        public int x1;
        public int x2;
        public int x3;
    }

    /// <summary>
    /// structures must be explicitly passed by ref
    /// </summary>
    public static class PInvokeCheckUsingStructures
    {

        [DllImport(@"PInvokeCheck.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Function4Byte(ref Struct4Byte s, int x);

        [DllImport(@"PInvokeCheck.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Function12Byte(ref Struct12Byte s, int x);
                
    }

    /// <summary>
    /// classes are automatically passed by reference
    /// </summary>
    public static class PInvokeCheckUsingClasses
    {

        [DllImport(@"PInvokeCheck.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Function4Byte(Class4Byte s, int x);

        [DllImport(@"PInvokeCheck.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Function12Byte(Class12Byte s, int x);

    }


}
