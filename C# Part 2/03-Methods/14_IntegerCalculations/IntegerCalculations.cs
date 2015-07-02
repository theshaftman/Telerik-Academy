namespace _14_IntegerCalculations
{
    using System;

    class IntegerCalculations
    {
        /*	Write methods to calculate minimum, maximum, average, sum and product of given set 
        of integer numbers.
        	Use variable number of arguments.*/

        static void Main()
        {
            Console.Write("Write your set of Integers(decided by space): ");
            string str = Console.ReadLine();
            string[] arrayStr = str.Split(' ');
            int numbers;
            int[] array = new int[arrayStr.Length];

            for (int i = 0; i < arrayStr.Length; i++)
            {
                if (int.TryParse(arrayStr[i], out numbers))
                {
                    array[i] = int.Parse(arrayStr[i]);
                }
                else
                {
                    Console.WriteLine();
                    Main();
                }
            }

            Console.WriteLine("Minimal arguement = {0}", Min(array));
            Console.WriteLine("Maximal arguement = {0}", Max(array));
            Console.WriteLine("Average value = {0}", Average(array));
            Console.WriteLine("Sum = {0}", Sum(array));
            Console.WriteLine("Product = {0}", Product(array));

            Console.WriteLine();
            Main();
        }

        private static int Min(int[] array)
        {
            int min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        private static int Max(int[] array)
        {
            int max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        private static double Average(int[] array)
        {
            double avg = array.Length;
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return (sum / avg);
        }

        private static int Sum(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        private static int Product(int[] array)
        {
            int product = 1;

            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }

            return product;
        }
    }
}
