namespace _23_SeriesOfLetters
{
    using System;

    class SeriesOfLetters
    {
        /*	Write a program that reads a string from the console and replaces all series of consecutive 
        identical letters with a single one.*/

        static void Main()
        {
            Console.Write("Write a string word: ");
            string str = Console.ReadLine();
            string[] check = str.Split(' ');

            if (check.Length == 1)
            {
                string result = str[0].ToString();

                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (str[i + 1] != str[i])
                    {
                        result += str[i + 1];
                    }
                }

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Error! Write only One word!");
            }

            Console.WriteLine();
            Main();
        }
    }
}
