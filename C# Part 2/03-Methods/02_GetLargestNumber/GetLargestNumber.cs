namespace _02_GetLargestNumber
{
    using System;

    class GetLargestNumber
    {
        /*	Write a method GetMax() with two parameters that returns the larger of two integers.
        	Write a program that reads 3 integers from the console and prints the largest of them
        using the method GetMax().*/

        static void Main()
        {
            Console.Write("Write 3 integers(divided by space): ");
            string str = Console.ReadLine();
            
            int[] numbers = CheckStr(str);

            if (numbers.Length > 1)
            {
                int max = numbers[0];

                for (int i = 0; i < numbers.Length; i++)
                {
                    max = GetMax(max, numbers[i]);
                }

                Console.WriteLine("Max number: {0}\n", max);
            }
            else
            {
                Console.WriteLine("Error! Write 3 INTS!\n");
            }

            Main();
        }

        static int[] CheckStr(string str)
        {
            string[] arrayStr = str.Split(' ');
            int[] numbers = { 0 };

            try
            {
                if (arrayStr.Length == 3)
                {
                    numbers = new int[arrayStr.Length];

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = int.Parse(arrayStr[i]);
                    }
                }
            }
            catch (Exception) { }
            
            return numbers;
        }

        static int GetMax(int a, int b)
        {
            int max = a;

            if (b > a)
            {
                max = b;
            }

            return max;
        }
    }
}
