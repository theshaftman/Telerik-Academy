namespace Statistics
{
    using System;

    public class PrintStatistics 
    {
        public static void PrintArrayStatistics(double[] arr)
        {
            double max = FindMaximalValue(arr);
            Console.WriteLine(max);

            double min = FindMinimalValue(arr);
            Console.WriteLine(min);

            double average = FindAverageValue(arr);
            Console.WriteLine(average);
        }

        private static double FindMaximalValue(double[] array)
        {
            int length = array.Length;
            double max = double.MinValue;

            for (int i = 0; i < length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        private static double FindMinimalValue(double[] array)
        {
            int length = array.Length;
            double min = double.MaxValue;

            for (int i = 0; i < length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        private static double FindAverageValue(double[] array)
        {
            int length = array.Length;
            double sum = 0.0;

            for (int i = 0; i < length; i++)
            {
                sum += array[i];
            }

            double average = sum / length;
            return average;
        }
    }    
}