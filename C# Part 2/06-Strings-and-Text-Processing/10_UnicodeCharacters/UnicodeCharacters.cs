namespace _10_UnicodeCharacters
{
    using System;
    using System.Text;

    class UnicodeCharacters
    {
        /*	Write a program that converts a string to a sequence of C# Unicode character literals.
        	Use format strings.*/

        static void Main()
        {
            Console.Write("Write a string: ");
            string str = Console.ReadLine();

            Console.WriteLine("{0}\n", ConvertToUnicode(str));

            Main();
        }

        private static string ConvertToUnicode(string text)
        {
            StringBuilder result = new StringBuilder();

            foreach (var letter in text)
            {
                result.Append(String.Format("\\u{0:X4}", (int)letter));
            }

            return result.ToString();
        }
    }
}
