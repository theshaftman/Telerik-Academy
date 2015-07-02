namespace _05_SortByStringLength
{
    using System;

    class SortByStringLength
    {
        /*	You are given an array of strings. Write a method that sorts the array by the length
        of its elements (the number of characters composing them).*/

        static void Main()
        {
            string[] array = { "hey", "mey", "ab", "hello", "welcome", "bello", "bella"};
            
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i].Length < array[j].Length)
                    {
                        string temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            
            for (int j = 0; j < array.Length; j++)
            {
                Console.Write("{0} ", array[j]);
            }

            Console.WriteLine();
        }
    }
}
