namespace _06_SumIntegers
{
    using System;

    class SumIntegers
    {
        /*	You are given a sequence of positive integer values written into a string, separated by spaces.
        	Write a function that reads these values from given string and calculates their sum.*/

        static void Main()
        {
            Console.Write("Write numbers(separated by space): ");
            string numberStr = Console.ReadLine();
            string[] arrayStr = numberStr.Split(' ');
            int[] array = new int[arrayStr.Length];
            int numbers;

            for (int i = 0; i < arrayStr.Length; i++)
            {
                if (int.TryParse(arrayStr[i], out numbers))
                {
                    array[i] = int.Parse(arrayStr[i]);
                }
                else
                {
                    Console.WriteLine("Error! Write INTS!");

                    return;
                }
            }

            Console.WriteLine("Sum = {0}", CalculateSum(array));

            Main();
        }

        private static int CalculateSum(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }
    }
}
