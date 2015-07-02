namespace _04_CompareTextFiles
{
    using System;
    using System.IO;
    using System.Text;

    class CompareTextFiles
    {
        /*	Write a program that compares two text files line by line and prints the number of lines 
        that are the same and the number of lines that are different.
        	Assume the files have equal number of lines.*/

        static void Main()
        {
            string pathA = "testA.txt";
            string pathB = "testB.txt";

            StringBuilder builderA = new StringBuilder();
            StringBuilder builderB = new StringBuilder();

            try
            {
                StreamReader readerA = new StreamReader(pathA);
                StreamReader readerB = new StreamReader(pathB);

                Read(readerA, builderA);
                Read(readerB, builderB);

                readerA.Close();
                readerB.Close();

                string[] resultA = builderA.ToString().Split('\n');
                string[] resultB = builderB.ToString().Split('\n');

                if (resultA.Length == resultB.Length)
                {
                    int equal = 0;
                    int notEqual = 0;

                    for (int i = 0; i < resultA.Length; i++)
                    {
                        if (resultA[i] == resultB[i])
                        {
                            equal++;
                        }
                        else
                        {
                            notEqual++;
                        }
                    }

                    Console.WriteLine("Equal lines: {0}\nNot equal lines: {1}", equal, notEqual);

                    //Console.WriteLine(builderA.ToString());
                    //Console.WriteLine(builderB.ToString());
                }
                else
                {
                    Console.WriteLine("Lines in the documents must be equal!");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Error! File can not be found!");
            }
        }

        private static void Read(StreamReader reader, StringBuilder builder)
        {
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
        }
    }
}
