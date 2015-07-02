namespace _18_ExtractEmails
{
    using System;

    class ExtractEmails
    {
        /*	Write a program for extracting all email addresses from given text.
        	All sub-strings that match the format @… should be recognized as emails.*/

        static void Main()
        {
            Console.Write("Write a text to check E-mails: ");
            string str = Console.ReadLine();

            string[] words = str.Split(' ');
            string result = string.Empty;

            int cliombIndex = 0;
            int dotIndex = 0;

            for (int i = 0; i < words.Length; i++)
            {
                cliombIndex = words[i].LastIndexOf("@");
                dotIndex = words[i].LastIndexOf(".");

                if (words[i].Contains("@") &&
                    words[i].Contains(".") &&
                    cliombIndex + 1 < dotIndex &&
                    cliombIndex > 0 && dotIndex > 0)
                {
                    result += words[i] + Environment.NewLine;
                }
            }

            Console.WriteLine("E-mails result:\n{0}", result);

            Main();
        }
    }
}
