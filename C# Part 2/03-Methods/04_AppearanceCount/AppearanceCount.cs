namespace _04_AppearanceCount
{
    using System;

    class AppearanceCount
    {
        /*	Write a method that counts how many times given number appears in given array.
        	Write a test program to check if the method is workings correctly.*/

        static void Main()
        {
            Console.Write("Write array(divided by space): ");
            string str = Console.ReadLine();
            Console.Write("Write a number to search: ");
            string search = Console.ReadLine();

            string[] arrayStr = str.Split(' ');
            int[] array = new int[arrayStr.Length];
            int numbers;
            int n = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (int.TryParse(arrayStr[i], out numbers))
                {
                    array[i] = int.Parse(arrayStr[i]);
                }
                else
                {
                    Console.WriteLine("Error! Write INTS!\n");

                    Main();
                }
            }
            
            if (int.TryParse(search, out numbers))
            {
                n = int.Parse(search);
            }

            Console.WriteLine("{0} appears {1} times\n", n, Check(array, n));

            Main();
        }

        static int Check(int[] numbers, int n)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (n == numbers[i])
                {
                    count++;
                }
            }

            return count;
        }
    }
}
