namespace _15_NumberCalculations
{
    using System;

    class NumberCalculations
    {
        /*	Modify your last program and try to make it work for any number type, not just integer 
        (e.g. decimal, float, byte, etc.)
        	Use generic method (read in Internet about generic methods in C#).*/

        enum Operation
        {
            Min,
            Max,
            Average,
            Sum,
            Product
        }

        static void Main()
        {
            int[] intValues = { 1, 2, 3, 4 };
            double[] doubleValues = { 23, 654, 213 };
            float[] floatValues = { 1.12f, 5.34f, 1234.546f };

            Console.WriteLine("Min: " + OperateGeneric<int>(intValues, Operation.Min));
            Console.WriteLine("Max: " + OperateGeneric<int>(intValues, Operation.Max));
            Console.WriteLine("Average: " + OperateGeneric<int>(intValues, Operation.Average));
            Console.WriteLine("Sum: " + OperateGeneric<int>(intValues, Operation.Sum));
            Console.WriteLine("Product: " + OperateGeneric<int>(intValues, Operation.Product));
            Console.WriteLine();

            Console.WriteLine("Min: " + OperateGeneric<double>(doubleValues, Operation.Min));
            Console.WriteLine("Max: " + OperateGeneric<double>(doubleValues, Operation.Max));
            Console.WriteLine("Average: " + OperateGeneric<double>(doubleValues, Operation.Average));
            Console.WriteLine("Sum: " + OperateGeneric<double>(doubleValues, Operation.Sum));
            Console.WriteLine("Product: " + OperateGeneric<double>(doubleValues, Operation.Product));
            Console.WriteLine();

            Console.WriteLine("Min: " + OperateGeneric<float>(floatValues, Operation.Min));
            Console.WriteLine("Max: " + OperateGeneric<float>(floatValues, Operation.Max));
            Console.WriteLine("Average: " + OperateGeneric<float>(floatValues, Operation.Average));
            Console.WriteLine("Sum: " + OperateGeneric<float>(floatValues, Operation.Sum));
            Console.WriteLine("Product: " + OperateGeneric<float>(floatValues, Operation.Product));
        }

        private static T OperateGeneric<T>(T[] values, Operation op) where T : IComparable
        {
            T min = values[0];
            T max = values[0];
            dynamic sum = 0;
            dynamic product = 1;
            dynamic wrong = -1;

            for (int i = 0; i < values.Length; i++)
            {
                if (min.CompareTo(values[i]) > 0)
                {
                    min = values[i];
                }
                if (max.CompareTo(values[i]) < 0)
                {
                    max = values[i];
                }
                sum += values[i];
                product *= values[i];
            }

            switch (op)
            {
                case Operation.Min:
                    return min;
                case Operation.Max:
                    return max;
                case Operation.Average:
                    return sum / values.Length;
                case Operation.Sum:
                    return sum;
                case Operation.Product:
                    return product;
                default:
                    return wrong;
            }
        }
    }
}
