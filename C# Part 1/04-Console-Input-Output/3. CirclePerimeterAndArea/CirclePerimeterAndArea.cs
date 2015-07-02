using System;

class CirclePerimeterAndArea
{
    /*	Write a program that reads the radius r of a circle and prints its perimeter 
    and area formatted with 2 digits after the decimal point*/

    static void Main()
    {
        Console.Write("Write \"R\": ");
        string strR = Console.ReadLine();
        double numbers;

        if (double.TryParse(strR, out numbers))
        {
            double r = double.Parse(strR);
            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * (r * r);

            Console.WriteLine("Perimeter: {0:0.##}\nArea: {1:0.##}\n", perimeter, area);

            Main();
        }
        else
        {
            Console.WriteLine("Error! Try to write INT!");

            Main();
        }
    }
}
