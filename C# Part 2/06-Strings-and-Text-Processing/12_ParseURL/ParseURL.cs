namespace _12_ParseURL
{
    using System;
    //using System.IO;

    class ParseURL
    {
        /*	Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] 
        and extracts from it the [protocol], [server] and [resource] elements.*/

        static void Main()
        {
            string text = "http://telerikacademy.com/Courses/Courses/Details/212";

            Console.WriteLine("[protocol] = {0}\n[server] = {1}\n[resource] = {2}", 
                GetInformation(text)[0], GetInformation(text)[1], GetInformation(text)[2]);
        }

        private static string[] GetInformation(string text)
        {
            string[] result = new string[3];

            // Getting a protocol
            //char separator = Path.DirectorySeparatorChar;
            char separator = '/';
            int index = text.IndexOf(separator);
            result[0] = text.Substring(0, index - 1);

            //Getting a server
            int endIndex = text.IndexOf(separator, index + 2);
            result[1] = text.Substring(index + 2, endIndex - index - 2);

            //Getting a resource
            result[2] = text.Substring(endIndex);
            
            return result;
        }
    }
}
