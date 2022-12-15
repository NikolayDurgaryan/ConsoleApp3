using System;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string result = string.Empty;
            int maxCount = 0;
            int count = 0;
            string[] text = { "lsllsllsfg", "askdjhsak", "lsllslloooooooooooooooooooooooooooooooooooooooooosfg", "lsllsllsfg" };
            for (int i = 0; text.Length > i; i++)
            {
                for (int j = 0; text[i].Length > j; j++)
                {
                    count = 0;
                    for (int r = 0; text.Length > r; r++)
                    {
                        for (int y = 0; text[r].Length > y; y++)
                        {
                            if (text[i][j] == text[r][y])
                            {
                                count++;
                            }
                        }
                    }
                    if (count > maxCount)
                    {
                        maxCount = count;
                        result = text[i][j].ToString();
                    }
                }
            }
            Console.WriteLine($"<< {result} >> is value.{maxCount} is count");



            StringBuilder joinedText = new StringBuilder();
            string allText = string.Empty;

            for (int i = 0; text.Length > i; i++)
            {
                joinedText.Append(text[i]);
            }
            allText = joinedText.ToString();
            int countBuild = 0;
            string resultBuild = string.Empty;
            int maxCountBuild = 0;
            Console.WriteLine(allText);
            for (int i = 0; allText.Length > i; i++)
            {
                countBuild = 0;
                for (int j = 0; allText.Length > j; j++)
                {

                    if (allText[i] == allText[j])
                    {
                        countBuild++;
                    }
                }
                if (countBuild > maxCountBuild)
                {
                    maxCountBuild = countBuild;
                    resultBuild = allText[i].ToString();
                }
            }

            StringBuilder Criteria = new StringBuilder();
            bool uniq = true;
            Criteria.Append(text[0][0]);
            for (int i = 0; text.Length > i; i++)
            {
                for (int j = 0; text[i].Length > j; j++)
                {
                    uniq = true;
                    for (int t = 0; Criteria.Length > t; t++)
                    {
                        if (text[i][j] == Criteria[t])
                        {
                            uniq = false;
                            break;
                        }
                    }
                    if (uniq)
                    {
                        Criteria.Append(text[i][j]);
                    }
                }
            }
            Console.WriteLine(Criteria);



            Console.WriteLine($"<< {resultBuild} >> is value.{maxCountBuild} is count");
            ClassTest classTest = new ClassTest(5);
            ClassTest classTest1 = new ClassTest();
            ClassTest classTest2 = new ClassTest(4, "Adidas");
            Console.WriteLine(classTest.SumNumbersWithRec(3));

            //StaticClass overload
            ClassStaticTest.Wantedsize = 45;
            ClassStaticTest.UpGrateSize();
            ClassStaticTest.Wantedsize = 100;
            ClassStaticTest.UpGrateSize();

            //Struct
            StructTest structTest = new StructTest("145674867");
            StructTest structTes1 = new StructTest();
            StructTest.Count = 4564;

            //Method out ref in
            int Param1 = 1;
            int Param2 = 2;
            int Param3 = 3;
            int Param4 = 4;
            Methods.ChangeParameters(ref Param1, ref Param2, in Param3, out Param4);
            Console.WriteLine(Param1 + "   1");
            Console.WriteLine(Param2 + "   2");
            Console.WriteLine(Param3 + "   3");
            Console.WriteLine(Param4 + "   4");

            //try catch
            try
            {
                Methods.ChangeParameters(ref Param1, ref Param2, in Param4);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n" + e.Source + "\n" + e.Data + "\n");
            }
            finally
            {
                Methods.ChangeParameters(ref Param1, ref Param2, in Param4, out Param3);
                Console.WriteLine(Param1 + "   1" + " Try catch");
                Console.WriteLine(Param2 + "   2" + " Try catch");
                Console.WriteLine(Param3 + "   3" + " Try catch");
                Console.WriteLine(Param4 + "   4" + " Try catch");
            }

            //
            ClassStaticTest.Name = classTest2.Name;
            Console.WriteLine(ClassStaticTest.Name);
        }
    }
}
