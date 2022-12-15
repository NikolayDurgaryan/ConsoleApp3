using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class ClassTest
    {
        private int _Size = default;
        public string Name = string.Empty;
        public ClassTest()
        {

        }
        public ClassTest(int value)
        {
            _Size = Math.Abs(value);
        }
        public ClassTest(int value, string name)
        {
            _Size = Math.Abs(value);
            Name = name;
        }
        public int SumNumbersWithRec(int maxValue)
        {
            if (maxValue <= 1)
            {
                return 1;
            }
            return maxValue + SumNumbersWithRec(maxValue - 1);
        }
    }
    public static class ClassStaticTest
    {
        private static int _StandartSize = 44;
        public static int Wantedsize = 46;
        public static void UpGrateSize()
        {
            if (Wantedsize < 50 && Wantedsize > 0)
            {
                _StandartSize = Wantedsize;
                Console.WriteLine(_StandartSize);
            }
            else
            {
                Console.WriteLine("You Can`t change");
            }

        }
        public static string Name = string.Empty;
    }
}
