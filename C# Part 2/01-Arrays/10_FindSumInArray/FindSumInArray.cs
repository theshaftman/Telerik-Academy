namespace _10_FindSumInArray
{
    using System;

    class FindSumInArray
    {
        /*	Write a program that finds in given array of integers a 
        sequence of given sum S (if present).*/

        static void Main()
        {
            int[] array = { 4, 3, 1, 4, 2, 5, 8 };
            int sum = 11;
            string result = "";
            
            for (int i = 0; i < array.Length; i++)
            {
                int arrSum = 0;

                for (int j = i; j < array.Length; j++)
                {
                    arrSum += array[j];
                    result += array[j].ToString() + " ";

                    if (arrSum >= sum)
                    {
                        break;
                    }
                }

                if (arrSum == sum)
                {
                    break;
                }

                result = "";
            }

            if (result.Length > 1)
            {
                Console.WriteLine("Result: {0} -> {1}", sum, result);
            }
            else
            {
                Console.WriteLine("Error! There isn`t a sum {0}!", sum);
            }
        }
    }
}
