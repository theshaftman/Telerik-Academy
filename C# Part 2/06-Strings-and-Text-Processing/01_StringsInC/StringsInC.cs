namespace _01_StringsInC
{
    using System;
    using System.Text;

    class StringsInC
    {
        /*	Describe the strings in C#.
        	What is typical for the string data type?
        	Describe the most important methods of the String class.*/

        static void Main()
        {
            Console.WriteLine("Describe the strings in C#:");
            Console.WriteLine(StringDescription());
            Console.WriteLine();

            Console.WriteLine("What is typical for the string data type?");
            Console.WriteLine(WhatIsTypicalForStringData());
            Console.WriteLine();

            Console.WriteLine("Describe the most important methods of the String class:");
            Console.WriteLine(MostImportantMethods());
            Console.WriteLine();
        }

        private static string StringDescription()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("In strings, we find characters, words and textual data.");
            result.AppendLine("The string type allows us to test and manipulate character data.");
            result.AppendLine("The string is declared by the keyword \"string\" in C#.");
            result.AppendLine("Use Unicode to support multiple languages and alphabets");

            return result.ToString();
        }

        private static string WhatIsTypicalForStringData()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("The class System.String is a reference type.");
            result.AppendLine("String objects are like arrays of characters (char[]).");
            result.AppendLine("They have fixed length (String.Length).");
            result.AppendLine("Their elements can be accessed directly by index (the index is in the range [0..Length-1]).");

            return result.ToString();
        }

        private static string MostImportantMethods()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("The most important string processing members are:");
            result.AppendLine("Length, Compare(str1, str2), IndexOf(str), LastIndexOf(str), Substring(startIndex, length), Replace(oldStr, newStr), Remove(startIndex, length), ToLower(), ToUpper(), Trim()");

            return result.ToString();
        }
    }
}
