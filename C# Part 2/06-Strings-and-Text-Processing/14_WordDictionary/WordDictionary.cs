namespace _14_WordDictionary
{
    using System;
    using System.Collections.Generic;

    class WordDictionary
    {
        /*	A dictionary is stored as a sequence of text lines containing words and their explanations.
        	Write a program that enters a word and translates it by using the dictionary.*/

        static void Main()
        {
            Dictionary<string, string> dict = new Dictionary<string, string> 
            {
                {".NET", "platform for applications from Microsoft"},
                {"CLR", "managed execution environment for .NET"},
                {"NAMESPACE", "hierarchical organization of classes"}
            };

            Console.Write("Write a word: ");
            string str = Console.ReadLine().ToUpper();

            if (dict.ContainsKey(str))
            {
                Console.WriteLine("{0} - {1}\n", str, dict[str]);
            }
            else
            {
                Console.WriteLine("Error! Doesn`t have this word!\n");
            }

            Main();
        }
    }
}
