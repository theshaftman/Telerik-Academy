namespace _08_ExtractSentences
{
    using System;
    using System.Linq;

    class ExtractSentences
    {
        /*	Write a program that extracts from a given text all sentences containing given word.*/

        static void Main()
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string toFind = "in";
            char endSentence = '.';

            string[] sentences = text.Split(endSentence);
            string result = string.Empty;

            for (int i = 0; i < sentences.Length; i++)
            {
                if (sentences[i].ToLower().Contains(" " + toFind + " "))
                {
                    result += sentences[i] + endSentence;
                }
            }

            Console.WriteLine(result);
        }
    }
}
