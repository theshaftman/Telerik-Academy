using System;

class DivideBy7And5
{
    /*Write a Boolean expression that checks for given integer if it can be divided 
     (without remainder) by 7 and 5 at the same time.*/

    static void Main()
    {
        Console.WriteLine("   n   Divided by 7 and 5");
        Divided7And5(3);
        Divided7And5(0);
        Divided7And5(5);
        Divided7And5(7);
        Divided7And5(35);
        Divided7And5(140);
        
    }

    static void Divided7And5(int number)
    {
        bool divided = false;

        if ((number % 5 == 0) && (number % 7 == 0) && (number != 0))
        {
            divided = true;
        }

        Console.WriteLine("{0,4}{1,14}", number, divided);
    }
}
