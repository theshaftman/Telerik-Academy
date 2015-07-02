namespace _07_ReplaceSubstring
{
    using System;
    using System.IO;
    using System.Text;

    class ReplaceSubstring
    {
        /*	Modify the solution of the previous problem to replace only whole words (not strings).*/

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
                                
                builder = builder.Replace(" start ", " finish ");
                builder = builder.Replace(" start.", " finish.");
                builder = builder.Replace(" start!", " finish!");
                builder = builder.Replace(" start,", " finish,");

                builder = builder.Replace(" Start ", " Finish ");

                WriteToFile(builder, path);

                Console.WriteLine("Operation completed successfully!");
            }
            catch (Exception)
            {
                Console.WriteLine("Error! File can not be found!");
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
