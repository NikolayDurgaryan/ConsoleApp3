using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public struct StructTest
    {
        public StructTest(string docNumber)
        {
            _CheckNumber = docNumber;
        }
        static public int Count = 0;
        private string _CheckNumber;
    }
}
