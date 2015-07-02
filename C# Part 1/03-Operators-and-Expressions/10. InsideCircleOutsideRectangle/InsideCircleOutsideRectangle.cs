using System;

class InsideCircleOutsideRectangle
{
    /*Write an expression that checks for given point (x, y) if it is within the circle 
     K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2)*/

    static void Main()
    {
        Console.WriteLine("{0,4} {1,4} {2,4}", "x", "y", "Inside K / outside R?");

        Check(1, 2);
        Check(2.5f, 2);
        Check(0, 1);
        Check(2.5f, 1);
        Check(2, 0);
        Check(4, 0);
        Check(2.5f, 1.5f);
        Check(2, 1.5f);
        Check(1, 2.5f);
        Check(-100, -100);
    }

    static void Check(float x, float y)
    {
        bool inThere = false;

        float r = 1.5f;
        float numX = x - 1f;
        float numY = y - 1f;

        bool inCircle = (numX * numX) + (numY * numY) <= (r * r);
        bool outRectangle = true;

        if ((y >= -1) && (y <= 1) && (x >= -1) && (x <= 5))
        {
            outRectangle = false;
        }

        if (inCircle && outRectangle)
        {
            inThere = true;
        }
        Console.WriteLine("{0,4} {1,4} {2,11}", x, y, inThere ? "yes" : "no");
    }
}
