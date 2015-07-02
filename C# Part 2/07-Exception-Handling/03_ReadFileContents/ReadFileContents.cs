namespace _03_ReadFileContents
{
    using System;
    using System.IO;
    using System.Text;

    class ReadFileContents
    {
        /*	Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
        reads its contents and prints it on the console.
        	Find in MSDN how to use System.IO.File.ReadAllText(…).
        	Be sure to catch all possible exceptions and print user-friendly error messages.*/

        static void Main()
        {
            string path = @"C:\WINDOWS\win.ini";

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

                Console.WriteLine(builder);
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("Can not find file {0}.", path);
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Invalid directory in the file path.");
            }
            catch (OutOfMemoryException)
            {
                Console.Error.WriteLine("There is insufficient memory to allocate a buffer for the returned string.");
            }
        }
    }
}
