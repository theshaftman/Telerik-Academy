namespace _12_RemoveWords
{
    using System;
    using System.IO;
    using System.Text;

    class RemoveWords
    {
        /*	Write a program that removes from a text file all words listed in given another text file.
        	Handle all possible exceptions in your methods.*/

        static void Main()
        {
            string pathFile = "text.txt";
            string pathToRemove = "remove.txt";
            StringBuilder builderFile = new StringBuilder();
            StringBuilder builderToRemove = new StringBuilder();

            try
            {
                builderFile = BuildFile(builderFile, pathFile);
                builderToRemove = BuildFile(builderToRemove, pathToRemove);

                string[] toRemove = builderToRemove.ToString().Split(' ', '\n', '\r');

                WriteToFile(builderFile, toRemove, pathFile);
            }
            catch (Exception)
            {
                Console.WriteLine("Error! File or files can not be found!");
            }
        }

        private static StringBuilder BuildFile(StringBuilder builder, string path)
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

            return builder;
        }

        private static void WriteToFile(StringBuilder builder, string[] toRemove, string path)
        {
            string[] words = builder.ToString().Split(' ', ',', '!', '?', '\n', '\r');

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < toRemove.Length; j++)
                {
                    if (words[i] == toRemove[j])
                    {
                        builder = builder.Replace(toRemove[j] + " ", " ");
                    }
                }
            }
            
            StreamWriter writer = new StreamWriter(path);

            using (writer)
            {
                writer.WriteLine(builder);
                writer.Close();
            }
        }
    }
}
