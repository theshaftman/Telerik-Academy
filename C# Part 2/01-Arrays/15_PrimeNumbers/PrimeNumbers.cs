namespace _15_PrimeNumbers
{
    using System;
    using System.Collections.Generic;

    class PrimeNumbers
    {
        /*	Write a program that finds all prime numbers in the range 
        [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.*/

        static void Main()
        {
            int length = 10000000;
            List<bool> primeCheck = new List<bool>();

            for (int l = 0; l < length; l++)
            {
                primeCheck.Add(false);
            }

            int sqrt = (int)Math.Sqrt(length);
            
            for (int i = 2; i < sqrt; i++)
            {
                for (int j = i * i; j < primeCheck.Count; j += i)
                {
                    primeCheck[j] = true;
                }
            }

            Console.WriteLine("Prime numbers: ");

            for (int k = 2; k < primeCheck.Count; k++)
            {
                if (primeCheck[k] == false)
                {
                    Console.Write("{0} ", k);
                }
            }
        }
    }
}
