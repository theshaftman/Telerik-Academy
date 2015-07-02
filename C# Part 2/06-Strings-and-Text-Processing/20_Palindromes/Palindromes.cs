namespace _20_Palindromes
{
    using System;

    class Palindromes
    {
        /*	Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.*/

        static void Main()
        {
            Console.Write("Write a text to check for palindromes: ");
            string str = Console.ReadLine();

            string[] words = str.Split(new char[]{' ', '.'}, StringSplitOptions.RemoveEmptyEntries);
            string result = string.Empty;

            for (int i = 0; i < words.Length; i++)
            {
                bool palindromeCheck = true;

                for (int j = 0; j < words[i].Length; j++)
                {
                    if (words[i][j] != words[i][words[i].Length - j - 1])
                    {
                        palindromeCheck = false;
                        break;
                    }
                }

                if (palindromeCheck)
                {
                    result += words[i] + Environment.NewLine;
                }
            }

            Console.WriteLine("Palindromes:\n{0}", result);

            Main();
        }
    }
}
