using System;

class PlayWithIntDoubleString
{
    /*	Write a program that, depending on the user’s choice, 
    inputs an int, double or string variable. 
        o	If the variable is int or double, the program increases it by one.
        o	If the variable is a string, the program appends * at the end.*/

    static void Main()
    {
        Console.WriteLine(@"Please choose a type:
1 --> int
2 --> double
3 --> string");
        string str = Console.ReadLine();

        switch (str)
        {
            case "1": ChooseInt(); break;
            case "2": ChooseDouble(); break;
            case "3": ChooseString(); break;
            default: Console.WriteLine("Error! Write [1-3]!"); break;
        }

        Main();
    }

    static void ChooseInt()
    {
        Console.Write("Please enter a Int: ");

        try
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Result: {0}\n", number + 1);
        }
        catch (Exception)
        {
            Console.WriteLine("Error!\n");
        }
    }

    static void ChooseDouble()
    {
        Console.Write("Please enter a Double: ");

        try
        {
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine("Result: {0}\n", number + 1d);
        }
        catch (Exception)
        {
            Console.WriteLine("Error!\n");
        }
    }

    static void ChooseString()
    {
        Console.Write("Please enter a String: ");
        string str = Console.ReadLine();

        Console.WriteLine("Result: {0}\n", str + "*");
    }
}
