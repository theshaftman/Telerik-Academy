namespace _10_NFactorial
{
    using System;

    class NFactorial
    {
        /*	Write a program to calculate n! for each n in the range [1..100].*/

        static void Main()
        {
            Console.Write("Write \"N\": ");
            string str = Console.ReadLine();
            int numbers;

            if (int.TryParse(str, out numbers))
            {
                int number = int.Parse(str);

                if (CheckInRange(number))
                {
                    Console.WriteLine("{0}! = {1}", number, Factorial(number));
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Error! Write an INT!\n");
            }

            Main();
        }

        private static bool CheckInRange(int number)
        {
            return (number >= 0 && number <= 100);
        }

        private static int Factorial(int number)
        {
            int factorial = 1;

            while (number > 0)
            {
                factorial *= number;

                number--;
                Factorial(number);
            }

            return factorial;
        }
    }
}
