namespace _19_DatesFromTextInCanada
{
    using System;

    class DatesFromText
    {
        /*	Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
        	Display them in the standard date format for Canada.*/

        static void Main()
        {
            Console.Write("Write a text to check dates: ");
            string str = Console.ReadLine();

            string[] words = str.Split(' ');
            string result = string.Empty;

            for (int i = 0; i < words.Length; i++)
            {
                string[] check = words[i].Split('.');

                if (check.Length == 3)
                {
                    if (check[0].Length == 2 && check[1].Length == 2 && check[2].Length == 4)
                    {
                        result += words[i] + Environment.NewLine;
                    }
                }
            }

            result = result.Replace(".", "/");

            Console.WriteLine("Dates result:\n{0}", result);
            
            Main();
        }
    }
}
