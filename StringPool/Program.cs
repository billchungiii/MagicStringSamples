using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            string s1 = "1";
            string s2 = "1";
            string s3 = i.ToString();
            string s4 = string.Intern(s3);
            string s5 = s3.ToString();
            Console.WriteLine($"s1 與 s2 同位址 {object.ReferenceEquals(s1, s2)}");
            Console.WriteLine($"s1 與 s3 同位址 {object.ReferenceEquals(s1, s3)}");
            Console.WriteLine($"s3 與 s4 同位址 {object.ReferenceEquals(s3, s4)}");
            Console.WriteLine($"s1 與 s4 同位址 {object.ReferenceEquals(s1, s4)}");
            Console.WriteLine($"s3 與 s5 同位址 {object.ReferenceEquals(s3, s5)}");
            

            // this is tricky
            Console.WriteLine($"s3 有在字串池嗎? {CheckInterned(s3)}");
            Console.WriteLine($"s4 有在字串池嗎? {CheckInterned(s4)}");
            Console.WriteLine($"2.ToString 有在字串池嗎? {CheckInterned(2.ToString ())}");

            Console.ReadLine();
        }

        private static bool CheckInterned(string s)
        {
            return (string.IsInterned(s) != null);

        }
    }
}
