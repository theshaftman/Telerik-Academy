namespace _02_Exceptions.Model
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Exceptions;

    public static class Operations
    {
        public static T[] Subsequence<T>(T[] array, int startIndex, int count)
        {
            List<T> result = new List<T>();

            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(array[i]);
            }

            return result.ToArray();
        }
        
        public static string ExtractEnding(string str, int count)
        {
            if (count > str.Length)
            {
                throw new UnexpectedValueException("Invalid count!");
            }

            StringBuilder result = new StringBuilder();

            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }

        public static string CheckPrime(int number)
        {
            string result = number.ToString();

            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    result += " is not prime.";

                    return result;
                }
            }

            result += " is prime";

            return result;
        }
    }
}
