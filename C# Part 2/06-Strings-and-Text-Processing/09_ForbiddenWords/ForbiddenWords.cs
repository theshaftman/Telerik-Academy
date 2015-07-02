namespace _09_ForbiddenWords
{
    using System;

    class ForbiddenWords
    {
        /*	We are given a string containing a list of forbidden words and a text containing some of these words.
        	Write a program that replaces the forbidden words with asterisks.*/

        static void Main()
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string forbidden = "PHP, CLR, Microsoft";
            char endSentence = '.';

            string[] sentences = text.Split(endSentence);
            string[] forbiddenWords = forbidden.Split(new char[]{',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            
            for (int i = 0; i < sentences.Length; i++)
            {
                for (int j = 0; j < forbiddenWords.Length; j++)
                {
                    if (sentences[i].Contains(forbiddenWords[j]))
                    {
                        text = text.Replace(forbiddenWords[j], new string('*', forbiddenWords[j].Length));
                    }
                }
            }

            Console.WriteLine(text);
        }
    }
}
