using System;

class Rectangles
{
    //Write an expression that calculates rectangle’s perimeter and area by given width and height.

    static void Main()
    {
        Console.WriteLine("width height perimeter area");
        Rectangle(3f, 4f);
        Rectangle(2.5f, 3f);
        Rectangle(5f, 5f);
    }

    static void Rectangle(float width, float height)
    {
        float area = width * height;
        float perimeter = 2 * (width + height);

        Console.WriteLine("{0,5}{1,4}{2,10:0.##}{3,8:0.##}", 
            width, height, perimeter, area);
    }
}

