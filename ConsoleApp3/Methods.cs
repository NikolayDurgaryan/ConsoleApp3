using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public static class Methods
    {
        public static void ChangeParameters(ref int a, ref int b, in int d, out int c)
        {
            c = 12;
            a = d * a;
            b = b * d;
        }
        public static void ChangeParameters(ref int a, ref int b, in int d)
        {
            a = d * a;
            b = b * d;
            int f = int.Parse(d.ToString() + "a");
        }
    }
}
