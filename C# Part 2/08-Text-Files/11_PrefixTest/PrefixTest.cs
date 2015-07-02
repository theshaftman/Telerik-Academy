namespace _11_PrefixTest
{
    using System;
    using System.IO;
    using System.Text;

    class PrefixTest
    {
        /*	Write a program that deletes from a text file all words that start with the prefix test.*/

        static void Main()
        {
            string path = "test.txt";
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

                string[] words = builder.ToString().Split(' ', ',', '.', '!', '?', '\n', '\r');

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].StartsWith("test") || 
                        words[i].StartsWith("Test"))
                    {
                        builder = builder.Replace(words[i], string.Empty);
                    }
                }

                WriteToFile(builder, path);
                Console.WriteLine("Operation completed successfully!");
            }
            catch (Exception)
            {
                Console.WriteLine("Error! \"test.txt\" can not be found!");
            }
        }

        private static void WriteToFile(StringBuilder builder, string path)
        {
            StreamWriter writer = new StreamWriter(path);

            using (writer)
            {
                writer.WriteLine(builder);
                writer.Close();
            }
        }
    }
}
