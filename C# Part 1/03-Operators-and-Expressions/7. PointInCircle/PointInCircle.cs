using System;

class PointInCircle
{
    //Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2

    static void Main()
    {
        Console.WriteLine("{0,4} {1,5} {2}", "x", "y", "inside");

        InCircle(0, 1);
        InCircle(-2, 0);
        InCircle(-1, 2);
        InCircle(1.5f, -1);
        InCircle(-1.5f, -1.5f);
        InCircle(100, -30);
        InCircle(0, 0);
        InCircle(0.2f, -0.8f);
        InCircle(0.9f, -1.93f);
        InCircle(1, 1.655f);
    }

    static void InCircle(float x, float y)
    {
        bool inside = false;
        float r = 2f;
        float inCirc = (x * x) + (y * y);

        if (inCirc <= (r * r))
        {
            inside = true;
        }

        Console.WriteLine("{0,4} {1,5} {2,6}", x, y, inside);
    }
}
