namespace _13_CountWords
{
    using System;
    using System.IO;
    using System.Text;
    using System.Collections.Generic;

    class CountWords
    {
        /*	Write a program that reads a list of words from the file words.txt and finds how many times 
        each of the words is contained in another file test.txt.
        	The result should be written in the file result.txt and the words should be sorted by the 
        number of their occurrences in descending order.
        	Handle all possible exceptions in your methods.*/

        static void Main()
        {
            string pathFile = "words.txt";
            string pathToTest = "test.txt";
            string pathToResult = "result.txt";
            StringBuilder builderFile = new StringBuilder();
            StringBuilder builderToTest = new StringBuilder();
            List<string> occurences = new List<string>();

            try
            {
                builderFile = BuildFile(builderFile, pathFile);
                builderToTest = BuildFile(builderToTest, pathToTest);

                string[] toTest = builderToTest.ToString().Split(' ', '\n', '\r');

                WriteToFile(builderFile, toTest, pathToResult, occurences);

                Console.WriteLine("Operation completed successfully!");
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

        private static void WriteToFile(StringBuilder builder, string[] toTest, string path, List<string> occurences)
        {
            string[] words = builder.ToString().Split(' ', ',', '!', '?', '\n', '\r');
            
            for (int i = 0; i < toTest.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < words.Length; j++)
                {
                    if (toTest[i] == words[j])
                    {
                        count++;
                    }
                }

                string check = count + " time(s) \"" + toTest[i] + "\" appears";

                if (!occurences.Contains(check) && toTest[i] != "")
                {
                    occurences.Add(check);
                }
            }

            occurences.Sort();
            occurences.Reverse();

            StreamWriter writer = new StreamWriter(path);

            using (writer)
            {
                for (int i = 0; i < occurences.Count; i++)
                {
                    writer.WriteLine(occurences[i]);
                }
                writer.Close();
            }
        }
    }
}
