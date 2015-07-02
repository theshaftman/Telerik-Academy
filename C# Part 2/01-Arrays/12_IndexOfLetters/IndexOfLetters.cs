namespace _12_IndexOfLetters
{
    using System;

    class IndexOfLetters
    {
        /*	Write a program that creates an array containing all letters 
        from the alphabet (A-Z).
        	Read a word from the console and print the index of each of 
        its letters in the array.*/

        static void Main()
        {
            char[] chars = new char[26];

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)(i + 65);
            }
                        
            var enumerator = chars.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.Write("{0} ", enumerator.Current);
            }

            Console.WriteLine();

            Console.Write("Write a word: ");
            string str = Console.ReadLine();
            string[] check = str.Split(' ');

            if (check.Length == 1)
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    for (int k = 0; k < str.Length; k++)
                    {
                        if (str[k].ToString().ToUpper() == chars[j].ToString())
                        {
                            Console.WriteLine("[{0}] {1}", j, chars[j]);
                        }
                    }
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Error! Write a Word!\n");
            }

            Main();
        }
    }
}
