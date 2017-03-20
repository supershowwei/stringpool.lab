using System;

namespace StringPoolLab
{
    public static class MemoryAddressExtenstion
    {
        public static string Address(this object me)
        {
            unsafe
            {
                TypedReference tr = __makeref(me);
                var ptr = **(IntPtr**)&tr;
                return "0x" + ptr.ToString("X");
            }
        }
    }
}