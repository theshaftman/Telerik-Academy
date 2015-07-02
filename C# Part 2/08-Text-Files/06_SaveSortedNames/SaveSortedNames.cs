namespace _06_SaveSortedNames
{
    using System;
    using System.IO;
    using System.Text;

    class SaveSortedNames
    {
        /*	Write a program that reads a text file containing a list of strings, sorts them and saves them 
        to another text file.*/

        static void Main()
        {
            string path = "input.txt";
            string pathResult = "output.txt";
            StreamReader reader = new StreamReader(path);
            StringBuilder builder = new StringBuilder();
            StreamWriter writer = new StreamWriter(pathResult);

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

            string[] result = builder.ToString().Split('\n');
            Array.Sort(result);
            
            using (writer)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine(result[i]);
                    writer.WriteLine(result[i]);
                }

                writer.Close();
            }
        }
    }
}
