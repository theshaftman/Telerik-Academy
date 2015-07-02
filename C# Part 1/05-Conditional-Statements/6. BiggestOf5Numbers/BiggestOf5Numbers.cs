using System;

class BiggestOf5Numbers
{
    /*	Write a program that finds the biggest of five numbers 
    by using only five if statements.*/

    static void Main()
    {
        Console.Write("Write number A: ");
        string strNumA = Console.ReadLine();
        Console.Write("Write number B: ");
        string strNumB = Console.ReadLine();
        Console.Write("Write number C: ");
        string strNumC = Console.ReadLine();
        Console.Write("Write number D: ");
        string strNumD = Console.ReadLine();
        Console.Write("Write number E: ");
        string strNumE = Console.ReadLine();

        try
        {
            double numA = double.Parse(strNumA);
            double numB = double.Parse(strNumB);
            double numC = double.Parse(strNumC);
            double numD = double.Parse(strNumD);
            double numE = double.Parse(strNumE);
            double biggest = 0d;

            if (numA > numB && numA > numC && 
                numA > numD && numA > numE)
            {
                biggest = numA;
            }
            else if (numB > numA && numB > numC &&
                numB > numD && numB > numE)
            {
                biggest = numB;
            } 
            else if (numC > numA && numC > numB &&
                 numC > numD && numC > numE)
            {
                biggest = numC;
            }
            else if (numD > numA && numD > numB &&
                numD > numC && numD > numE)
            {
                biggest = numD;
            }
            else
            {
                biggest = numE;
            }

            Console.WriteLine("Biggest: {0}\n", biggest);
        }
        catch (Exception)
        {
            Console.WriteLine("Error! Write numbers!\n");
        }

        Main();
    }
}
