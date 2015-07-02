namespace _01_SquareRoot
{
    using System;
    using System.Text;

    class SquareRoot
    {
        /*	Write a program that reads an integer number and calculates and prints its square root. 
                o	If the number is invalid or negative, print Invalid number.
                o	In all cases finally print Good bye.
        	Use try-catch-finally block.*/

        static void Main()
        {
            Console.Write("Write a positive INT number: ");
            string str = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            try
            {
                uint number = uint.Parse(str);
                double sqrt = Math.Sqrt(number);

                result.AppendLine("Sqrt of " + number + " = " + sqrt);
            }
            catch (Exception)
            {
                result.AppendLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine(result.ToString());
            }

            Main();
        }
    }
}
