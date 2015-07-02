namespace _01_SayHello
{
    using System;

    class SayHello
    {
        /*	Write a method that asks the user for his name and prints “Hello, <name>” 
        	Write a program to test this method.*/

        static void Main()
        {
            Console.Write("Write name: ");
            string str = Console.ReadLine();

            Console.WriteLine(CheckName(str));

            Main();
        }

        static string CheckName(string str)
        {
            string result = string.Empty;

            string hello = "Hello, ";
            string name = "<name>";
            string end = "!";

            if (str.Length > 0)
            {
                name = str;
            }

            result = hello + name + end;
            return result;
        }
    }
}
