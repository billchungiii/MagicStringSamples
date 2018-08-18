using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GetStringAddress
{
    class Program
    {
        /// <summary>
        /// 取得字串的位址
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string s1 = "ABC";
            string s2 = "ABC";

            // way 1
            unsafe
            {
                fixed (char* p1 = s1)
                {
                    Console.WriteLine($"s1 位址: {(IntPtr)p1}");
                }

                fixed (char* p2 = s2)
                {
                    Console.WriteLine($"s2 位址: {(IntPtr)p2}");
                }
            }

            // way 2
            GCHandle handle = GCHandle.Alloc(s1, GCHandleType.Pinned);
            IntPtr address = handle.AddrOfPinnedObject();
            Console.WriteLine($"s1 位址: {(IntPtr)address}");

            Console.ReadLine();
        }
    }
}
