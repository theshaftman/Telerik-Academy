using System;

class BiggestOf3Numbers
{
    //	Write a program that finds the biggest of three numbers.

    static void Main()
    {
        Console.Write("Write 3 numbers (devided by space): ");
        string str = Console.ReadLine();
        string[] strNumbers = str.Split(' ');
        double numberCheck;

        if (strNumbers.Length == 3)
        {
            if (double.TryParse(strNumbers[0], out numberCheck) &&
                double.TryParse(strNumbers[1], out numberCheck) &&
                double.TryParse(strNumbers[2], out numberCheck))
            {
                //double biggest = double.Parse(strNumbers[0]);

                //for (int i = 0; i < strNumbers.Length; i++)
                //{
                //    if (double.Parse(strNumbers[i]) > biggest)
                //    {
                //        biggest = double.Parse(strNumbers[i]);
                //    }
                //}

                double biggest = 0d;

                double numA = double.Parse(strNumbers[0]);
                double numB = double.Parse(strNumbers[1]);
                double numC = double.Parse(strNumbers[2]);

                if (numA > numB)
                {
                    if (numA > numC)
                    {
                        biggest = numA;
                    }
                    else
                    {
                        biggest = numC;
                    }
                }
                else
                {
                    if (numB > numC)
                    {
                        biggest = numB;
                    }
                    else
                    {
                        biggest = numC;
                    }
                }

                Console.WriteLine("Biggest: {0}\n", biggest);
            }
            else
            {
                Console.WriteLine("Error! Write numbers!\n");
            }
        }
        else
        {
            Console.WriteLine("Error! Try with 3 Numbers!!!\n");
        }

        Main();
    }
}
