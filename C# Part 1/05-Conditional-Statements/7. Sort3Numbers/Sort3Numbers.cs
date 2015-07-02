using System;

class Sort3Numbers
{
    /*	Write a program that enters 3 real numbers and prints 
    them sorted in descending order. 
        o	Use nested if statements.*/

    static void Main()
    {
        Console.Write("Write 3 numbers (devided by space): ");
        string str = Console.ReadLine();
        string[] strNumbers = str.Split(' ');

        if (strNumbers.Length == 3)
        {
            double numbers;

            if (double.TryParse(strNumbers[0], out numbers) &&
                double.TryParse(strNumbers[1], out numbers) &&
                double.TryParse(strNumbers[2], out numbers))
            {
                double numA = double.Parse(strNumbers[0]);
                double numB = double.Parse(strNumbers[1]);
                double numC = double.Parse(strNumbers[2]);
                double biggest = 0d;
                double bigger = 0d;
                double big = 0d;

                if (numA > numB)
                {
                    if (numA > numC)
                    {
                        biggest = numA; //1

                        if (numB > numC)
                        {
                            bigger = numB; //2
                            big = numC;
                        }
                        else
                        {
                            bigger = numC; //2
                            big = numB;
                        }
                    }
                    else
                    {
                        biggest = numC; //1

                        if (numA > numB)
                        {
                            bigger = numA; //2
                            big = numB;
                        }
                        else
                        {
                            bigger = numB; //2
                            big = numA;
                        }
                    }
                }
                else
                {
                    if (numB > numC)
                    {
                        biggest = numB; //1

                        if (numA > numC)
                        {
                            bigger = numA; //2
                            big = numC;
                        }
                        else
                        {
                            bigger = numC; //2
                            big = numA;
                        }
                    }
                    else
                    {
                        biggest = numC; //1

                        if (numA > numB)
                        {
                            bigger = numA; //2
                            big = numB;
                        }
                        else
                        {
                            bigger = numB; //2
                            big = numA;
                        }
                    }
                }

                Console.WriteLine("Result: {0} {1} {2}\n", biggest, bigger, big);
            }
            else
            {
                Console.WriteLine("Write Numbers!\n");
            }
        }
        else
        {
            Console.WriteLine("Error! Write 3 numbers!\n");
        }

        Main();
    }
}
