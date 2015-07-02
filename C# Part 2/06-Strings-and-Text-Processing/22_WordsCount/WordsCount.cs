namespace _22_WordsCount
{
    using System;
    using System.Collections.Generic;

    class WordsCount
    {
        /*	Write a program that reads a string from the console and lists all different words in the string 
        along with information how many times each word is found.*/

        static void Main()
        {
            Console.Write("Write a string of words: ");
            string str = Console.ReadLine();
            string[] words = str.Split(' ');
            List<string> wordsCount = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                int count = 0;
                string result = string.Empty;

                for (int j = 0; j < words.Length; j++)
                {
                    if (words[i].ToLower() == words[j].ToLower())
                    {
                        count++;
                    }
                }

                result = words[i].ToLower() + " -> " + count + " time(s)";

                if (!wordsCount.Contains(result))
                {
                    wordsCount.Add(result);
                }

                count = 0;
            }

            Console.WriteLine("Words count:");
            for (int j = 0; j < wordsCount.Count; j++)
            {
                Console.WriteLine(wordsCount[j]);
            }

            Console.WriteLine();
            Main();
        }
    }
}
