namespace _25_ExtractTextFromHTML
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    class ReplaceTags
    {
        /*	Write a program that extracts from given HTML file its title (if available), and its body text 
        without the HTML tags.*/

        static void Main()
        {
            string text = string.Empty;
            string result = string.Empty;
            StreamReader streamReader = new StreamReader("index.html");

            while ((text = streamReader.ReadLine()) != null)
            {
                if (text.Contains("<head>"))
                {
                    result += "Title: ";
                }
                else if (text.Contains("<p>"))
                {
                    result += "\nText: ";
                }

                result += RemoveAllTags(text).Trim();
            }

            streamReader.Close();
            Console.WriteLine(result);
        }

        private static string RemoveAllTags(string str)
        {
            string textWithoutTags = Regex.Replace(str, "<[^>]*>", " ");

            return textWithoutTags;
        }
    }
}
