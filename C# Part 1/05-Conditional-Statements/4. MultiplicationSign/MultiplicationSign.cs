using System;

class MultiplicationSign
{
    /*	Write a program that shows the sign (+, - or 0) of the product of three 
    real numbers, without calculating it. */

    static void Main()
    {
        Console.Write("Write \"A\": ");
        string strA = Console.ReadLine();
        Console.Write("Write \"B\": ");
        string strB = Console.ReadLine();
        Console.Write("Write \"C\": ");
        string strC = Console.ReadLine();

        double numbers;

        if (double.TryParse(strA, out numbers) &&
            double.TryParse(strB, out numbers) &&
            double.TryParse(strC, out numbers))
        {
            double[] numbersDouble = new double[3];
            int minus = 0;
            string result = "+";

            for (int i = 0; i < numbersDouble.Length; i++)
            {
                if (i == 0)
                {
                    numbersDouble[i] = double.Parse(strA);
                }
                else if (i == 1)
                {
                    numbersDouble[i] = double.Parse(strB);
                }
                else
                {
                    numbersDouble[i] = double.Parse(strC);
                }
            }

            for (int j = 0; j < numbersDouble.Length; j++)
            {
                if (numbersDouble[j] < 0)
                {
                    minus++;
                }
                else if (numbersDouble[j] == 0)
                {
                    result = "0";
                    break;
                }
            }

            if ((result != "0") && (minus % 2 != 0))
            {
                result = "-";
            }

            Console.WriteLine("Result: {0}\n", result);
        }
        else
        {
            Console.WriteLine("Error! Try with a Number!\n");
        }

        Main();
    }
}
