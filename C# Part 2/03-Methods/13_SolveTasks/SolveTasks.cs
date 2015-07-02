namespace _13_SolveTasks
{
    using System;
    using System.Linq;

    class SolveTasks
    {
        /*	Write a program that can solve these tasks: 
                o	Reverses the digits of a number
                o	Calculates the average of a sequence of integers
                o	Solves a linear equation a * x + b = 0 
        	Create appropriate methods.
        	Provide a simple text-based menu for the user to choose which task to solve.
        	Validate the input data: 
                o	The decimal number should be non-negative
                o	The sequence should not be empty
                o	a should not be equal to 0 */

        static void Main()
        {
            Console.WriteLine(@"Choose an option from the menu:
1) Reverse Digits of a number
2) Calculates the average of sequence of integers
3) Solves a linear equation ""ax + b = 0""");
            string str = Console.ReadLine();

            switch (str)
            {
                case "1": Console.WriteLine(Reverse()); break;
                case "2": Console.WriteLine(FindAverage()); break;
                case "3": Console.WriteLine(SolveLinearEq()); break;
                default: Console.WriteLine("Error! Try again with a Correct number!");
                    break;
            }

            Console.WriteLine();
            Main();
        }

        private static string Reverse()
        {
            Console.Write("Write a number: ");
            string numberStr = Console.ReadLine();
            string result = string.Empty;
            decimal numbers;

            if (decimal.TryParse(numberStr, out numbers))
            {
                decimal number = decimal.Parse(numberStr);

                if (number >= 0)
                {
                    for (int i = numberStr.Length - 1; i >= 0; i--)
                    {
                        result += numberStr[i];
                    }
                }
                else
                {
                    result = "Negative!";
                }
            }

            return result;
        }

        private static double FindAverage()
        {
            Console.Write("Write a sequence of Integers(divided by space): ");
            string str = Console.ReadLine();
            string[] arrayStr = str.Split(' ');
            double[] array = new double[arrayStr.Length];
            int numbers;

            for (int i = 0; i < arrayStr.Length; i++)
            {
                if (int.TryParse(arrayStr[i], out numbers))
                {
                    array[i] = double.Parse(arrayStr[i]);
                }
                else
                {
                    return -1;
                }
            }

            return array.Average();
        }

        private static string SolveLinearEq()
        {
            Console.WriteLine("\"ax + b = 0\"");
            Console.Write("Write \"a\": ");
            string strA = Console.ReadLine();
            Console.Write("Write \"b\": ");
            string strB = Console.ReadLine();
            int numbers;
            string result = string.Empty;

            if (int.TryParse(strA, out numbers) && int.TryParse(strB, out numbers))
            {
                double a = double.Parse(strA);
                double b = double.Parse(strB);

                if (a > 0)
                {
                    return (-b / a).ToString();
                }
            }

            return result;
        }
    }
}
