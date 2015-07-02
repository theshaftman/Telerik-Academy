using System;

class Trapezoids
{
    //Write an expression that calculates trapezoid's area by given sides a and b and height h

    static void Main()
    {
        Console.WriteLine("{0,6} {1,6} {2,6} {3,10}", "a", "b", "h", "area");

        CheckArea(5, 7, 12);
        CheckArea(2, 1, 33);
        CheckArea(8.5f, 4.3f, 2.7f);
        CheckArea(100, 200, 300);
        CheckArea(0.222f, 0.333f, 0.555f);
    }

    static void CheckArea(float a, float b, float h)
    {
        float area = ((a + b) / 2f) * h;

        Console.WriteLine("{0,6} {1,6} {2,6} {3,10}", a, b, h, area);
    }
}
