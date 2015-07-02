using System;

class QuadraticEquation
{
    /*	Write a program that reads the coefficients a, b and c of a quadratic equation 
    ax2 + bx + c = 0 and solves it (prints its real roots).*/

    static void Main()
    {
        Console.WriteLine("\nax2 + bx + c = 0");
        Console.Write("Write \"a\": ");
        string strA = Console.ReadLine();
        Console.Write("Write \"b\": ");
        string strB = Console.ReadLine();
        Console.Write("Write \"c\": ");
        string strC = Console.ReadLine();

        try
        {
            double a = double.Parse(strA);
            double b = double.Parse(strB);
            double c = double.Parse(strC);

            double d = (b * b) - (4 * a * c);
            double root1;
            double root2;

            if (d > 0)
            {
                double num = 2 * a;
                double num1 = -b - Math.Sqrt(d);
                double num2 = -b + Math.Sqrt(d);
                root1 = num1 / num;
                root2 = num2 / num;
                Console.WriteLine("Two roots: x1 = {0:0.###}, x2 = {1:0.###}", root1, root2);
            }
            else if (d == 0)
            {
                root1 = -b / (2 * a);

                Console.WriteLine("One root: x1 = x2 = {0:0.###}", root1);
            }
            else
            {
                Console.WriteLine("The quadratic DOESN`T have any roots!");
            }

            Main();
        }
        catch (Exception)
        {
            Console.WriteLine("Error! Try again!");

            Main();
        }
    }
}
