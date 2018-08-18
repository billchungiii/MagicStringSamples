using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StringEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            string s1 = i.ToString();
            string s2 = i.ToString();
            bool isRefrenceEqual = object.ReferenceEquals(s1, s2);
            Console.WriteLine($"s1 與 s2 是否參考相等 : {isRefrenceEqual}");

            Console.WriteLine($"s1 位址: { GetObjectAddress(s1)}");
            Console.WriteLine($"s2 位址: { GetObjectAddress(s2)}");

            bool isObjectEqual = object.Equals(s1, s2);
            Console.WriteLine($"s1 與 s2 使用 static object.Equals 是否相等 : {isObjectEqual}");

            bool isEqual = s1.Equals(s2);
            Console.WriteLine($"s1 與 s2 使用 instance string.Equals(string) 是否相等 : {isEqual}");

            bool isOperatorEqual = (s1 == s2);
            Console.WriteLine($"s1 與 s2 使用 == 比較運算子 是否相等 : {isOperatorEqual}");

            Console.ReadLine();

        }

        private static IntPtr GetObjectAddress(object o)
        {
            GCHandle handle = GCHandle.Alloc(o, GCHandleType.Pinned);
            return handle.AddrOfPinnedObject();
        }
    }
}
