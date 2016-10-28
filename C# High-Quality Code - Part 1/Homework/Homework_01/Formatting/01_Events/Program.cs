namespace _01_Events
{
    using System;
    using System.Text;
    using Model;

    public class Program
    {
        private static StringBuilder output = new StringBuilder();

        public static void Main(string[] args)
        {
            while (Command.ExecuteNextCommand())
            {
            }

            Console.WriteLine(output);
        }
    }
}
