namespace _01_OddLines
{
    using System;
    using System.IO;
    using System.Text;

    class OddLines
    {
        /*	Write a program that reads a text file and prints on the console its odd lines.*/

        static void Main()
        {
            string path = "Something.txt";
            StreamReader streamReader = new StreamReader(path);
            StringBuilder stringBuilder = new StringBuilder();

            try
            {
                using (streamReader)
                {
                    string line = streamReader.ReadLine();

                    while (line != null)
                    {
                        stringBuilder.AppendLine(line);
                        line = streamReader.ReadLine();
                    }

                    streamReader.Close();
                }

                string result = stringBuilder.ToString();
                string[] endResult = result.Split('\n');

                for (int i = 0; i < endResult.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(endResult[i]);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("File can not be read!");
            }            
        }
    }
}
