namespace _03_RefactorLoop
{
    using System;

    public class RefactorLoop
    {
        private const int ExpectedValue = 61;

        public static void Main()
        {
            int[] array = new int[100];
            array = EvaluateArray(array);
            int length = array.Length;

            for (int i = 0; i < length; i++)
            {
                if (array[i] == ExpectedValue)
                {
                    FoundValue();

                    break;
                }
                else
                {
                    Console.WriteLine("Searching at index = {0}", i);
                }
            }
        }

        private static int[] EvaluateArray(int[] array)
        {
            int length = array.Length;

            for (int i = 0; i < length; i++)
            {
                array[i] = i + 1;
            }

            return array;
        }

        private static void FoundValue()
        {
            Console.WriteLine("Value found! It equals {0}", ExpectedValue);
        }
    }
}
