namespace _10_ExtractTextFromXML
{
    using System;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;

    class ExtractTextFromXML
    {
        /*	Write a program that extracts from given XML file all the text without the tags.*/

        static void Main()
        {
            string path = "input.xml";
            StringBuilder builder = new StringBuilder();

            try
            {
                StreamReader reader = new StreamReader(path);

                using (reader)
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        builder.AppendLine(line);
                        line = reader.ReadLine();
                    }

                    reader.Close();
                }

                string result = Regex.Replace(builder.ToString(), "<[^>]*>", " ").Replace("  ", " ").Trim();

                Console.WriteLine(result);
            }
            catch (Exception)
            {
                Console.WriteLine("Error! File \"input.xml\" can not be found!");
            }
        }
    }
}
