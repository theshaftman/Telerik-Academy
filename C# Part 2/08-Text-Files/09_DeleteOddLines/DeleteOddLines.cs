namespace _09_DeleteOddLines
{
    using System;
    using System.IO;
    using System.Text;

    class DeleteOddLines
    {
        /*	Write a program that deletes from given text file all odd lines.
        	The result should be in the same file.*/

        static void Main()
        {
            string path = "test.txt";

            try
            {
                StreamReader reader = new StreamReader(path);
                StringBuilder builder = new StringBuilder();

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

                string[] lines = builder.ToString().Split('\n');
                StringBuilder endResult = new StringBuilder();

                for (int i = 0; i < lines.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        endResult.AppendLine(lines[i]);
                    }
                }

                WriteToFile(endResult, path);
            }
            catch (Exception)
            {
                Console.WriteLine("Error! File can not be found!");
            }
        }

        private static void WriteToFile(StringBuilder result, string path)
        {
            StreamWriter writer = new StreamWriter(path);
            
            using (writer)
            {
                writer.WriteLine(result);
                writer.Close();
            }

            Console.WriteLine("Operation finished successfully!");
        }
    }
}
