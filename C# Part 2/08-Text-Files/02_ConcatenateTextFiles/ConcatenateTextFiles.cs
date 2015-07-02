namespace _02_ConcatenateTextFiles
{
    using System;
    using System.IO;
    using System.Text;

    class ConcatenateTextFiles
    {
        /*	Write a program that concatenates two text files into another text file.*/

        private static StringBuilder stringBuilder = new StringBuilder(); 

        static void Main()
        {
            string pathA = "test1.txt";
            string pathB = "test2.txt";
            string pathResult = "result.txt";
            
            try
            {
                StreamReader streamReaderA = new StreamReader(pathA);
                StreamReader streamReaderB = new StreamReader(pathB);
                StreamWriter streamWriter = new StreamWriter(pathResult);

                Concatenate(streamReaderA);
                Concatenate(streamReaderB);

                using (streamWriter)
                {
                    streamWriter.WriteLine(stringBuilder.ToString());
                    streamWriter.Close();
                }

                Console.WriteLine(stringBuilder);
            }
            catch (Exception)
            {
                Console.WriteLine("Error! File can not be found!");
            }
        }

        private static void Concatenate(StreamReader streamReader)
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
        }
    }
}
