namespace _01_AllocateArray
{
    using System;

    class AllocateArray
    {
        /*	Write a program that allocates array of 20 integers and 
        initializes each element by its index multiplied by 5.*/

        static void Main()
        {
            int[] array = new int[20];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
            }

            for (int j = 0; j < array.Length; j++)
            {
                Console.Write("{0} ", array[j]);
            }

            Console.WriteLine();
        }
    }
}
