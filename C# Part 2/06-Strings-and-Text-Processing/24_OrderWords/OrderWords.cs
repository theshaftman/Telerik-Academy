namespace _24_OrderWords
{
    using System;

    class OrderWords
    {
        /*	Write a program that reads a list of words, separated by spaces and prints the list in an 
        alphabetical order.*/

        static void Main()
        {
            Console.Write("Write a string of words: ");
            string str = Console.ReadLine();
            string[] result = str.Split(' ');
            Array.Sort(result);

            Console.WriteLine("Ordered list of the words:");

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            Console.WriteLine();
            Main();
        }
    }
}
