using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DarkLibrary
{
    public class DarkForce
    {

        public DarkForce()
        {
            string s1 = "Magic";
            string s2 = "WXYZ";
            var method = typeof(string).GetMethod("FillStringChecked", BindingFlags.Static | BindingFlags.NonPublic);
            var field = typeof(string).GetField("m_stringLength", BindingFlags.Instance | BindingFlags.NonPublic);
            field.SetValue(s1,6);
            method.Invoke(null, new object[] {s1, 0, "123456"});
        }
    }
}
