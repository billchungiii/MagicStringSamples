using DarkLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1 = "Ma";
            string b1 = "gic";
            string s2 = "Magic";
            Compare(a1, b1, s2);
            var darkforce = new DarkForce();
            Compare(a1, b1, s2);

            Console.WriteLine(s2);
            Console.ReadLine();
        }

        private static void Compare(string a1, string b1, string s2)
        {
            Console.WriteLine(($"a2+b2 == s2 : {a1 + b1 == s2}"));
        }
    }
}
