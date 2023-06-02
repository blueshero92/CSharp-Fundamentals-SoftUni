using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            GetMax(dataType);
        }

        static void GetMax(string dataType)
        {           

            if (dataType == "string")
            {
                string text1 = Console.ReadLine();
                string text2 = Console.ReadLine();
                GetMax(text1, text2);

            }
            else if (dataType == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                GetMax(num1, num2);

            }
            else
            {
                if (dataType == "char")
                {
                    char symbol1 = char.Parse(Console.ReadLine());
                    char symbol2 = char.Parse(Console.ReadLine());
                    GetMax(symbol1, symbol2);
                }
            }
        }

        private static void GetMax(char symbol1, char symbol2)
        {
            if (symbol1 > symbol2)
            {
                Console.WriteLine(symbol1);
            }
            else
            {
                Console.WriteLine(symbol2);
            }
        }

        private static void GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }
        }

        private static void GetMax(string text1, string text2)
        {

            for (int i = 0; i < text1.Length; i++)
            {
                if (text1[i] != text2[i])
                {
                    if (text1[i] > text2[i])
                    {
                        Console.WriteLine(text1);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(text2);
                        break;
                    }
                }

            }
        }
    }
}
