namespace _21_CombinationsSet
{
    using System;
    using System.Linq;

    class CombinationsSet
    {
        /*	Write a program that reads two numbers N and K and generates 
        all the combinations of K distinct elements from the set [1..N].*/

        static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());
            int[] numbers = Enumerable.Repeat(1, k).ToArray();
            int c;

            if (n >= k)
            {
                Console.WriteLine("Result:");

                do
                {
                    c = 1;
                    if (Check(numbers))
                    {
                        PrintElements(numbers);
                    }

                    for (int i = 0; i < k; i++)
                    {
                        numbers[i] += c;
                        if (numbers[i] <= n)
                        {
                            c = 0;
                            break;
                        }
                        else
                        {
                            numbers[i] = c = 1;
                        }
                    }
                } while (c != 1);
            }
            else
            {
                Console.WriteLine("Error! N >= K!");
            }
            
            Console.WriteLine();
            Main();
        }

        static bool Check(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static void PrintElements(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
