namespace _03_LineNumbers
{
    using System;
    using System.IO;
    using System.Text;

    class LineNumbers
    {
        /*	Write a program that reads a text file and inserts line numbers in front of each of its lines.
        	The result should be written to another text file.*/

        static void Main()
        {
            string fromPath = "test.txt";
            string toPath = "result.txt";

            try
            {
                StreamReader streamReader = new StreamReader(fromPath);
                StreamWriter streamWriter = new StreamWriter(toPath);
                StringBuilder stringBuilder = new StringBuilder();

                using (streamReader)
                {
                    string line = streamReader.ReadLine();
                    int count = 1;

                    while (line != null)
                    {
                        stringBuilder.Append(count + " line: ");
                        stringBuilder.AppendLine(line);
                        line = streamReader.ReadLine();

                        count++;
                    }

                    streamReader.Close();
                }
                
                using (streamWriter)
                {
                    streamWriter.WriteLine(stringBuilder.ToString());
                    streamWriter.Close();
                }

                Console.WriteLine(stringBuilder.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error! File can not be found!");
            }
        }
    }
}
