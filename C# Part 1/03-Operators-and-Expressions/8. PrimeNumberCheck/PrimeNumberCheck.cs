using System;

class PrimeNumberCheck
{
    /*Write an expression that checks if given positive integer number n (n = 100) is prime 
     (i.e. it is divisible without remainder only to itself and 1)*/

    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 9, 97, 51, -3, 0 };
        bool isPrime;

        Console.WriteLine("{0,3} {1,6}", "n", "Prime?");

        for (int i = 0; i < numbers.Length; i++)
        {
            isPrime = true;

            if (numbers[i] < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int j = 2; j < numbers[i]; j++)
                {
                    if (numbers[i] % j == 0)
                    {
                        isPrime = false;
                    }
                }
            }

            Console.WriteLine("{0,3} {1,5}", numbers[i], isPrime);
        }

    }
}
