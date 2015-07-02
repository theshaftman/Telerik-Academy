namespace _21_LettersCount
{
    using System;
    using System.Collections.Generic;

    class LettersCount
    {
        /*	Write a program that reads a string from the console and prints all different letters 
        in the string along with information how many times each letter is found. */

        static void Main()
        {
            Console.Write("Write a string: ");
            string str = Console.ReadLine();
            List<string> letters = new List<string>();

            for (int i = 0; i < str.Length - 1; i++)
            {
                int count = 0;
                string letterCount = string.Empty;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        count++;
                    }
                }

                letterCount = str[i] + " -> " + count + " time(s)";

                if (!letters.Contains(letterCount))
                {
                    letters.Add(letterCount);
                }

                count = 0;
            }

            Console.WriteLine("Letters count: ");

            for (int j = 0; j < letters.Count; j++)
            {
                Console.WriteLine(letters[j]);
            }

            Console.WriteLine();
            Main();
        }
    }
}
