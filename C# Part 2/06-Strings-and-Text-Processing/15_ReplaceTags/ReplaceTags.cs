namespace _15_ReplaceTags
{
    using System;
    using System.IO;

    class ReplaceTags
    {
        /*	Write a program that replaces in a HTML document given as string all the tags 
        <a href="…">…</a> with corresponding tags [URL=…]…/URL].*/

        static void Main()
        {
            string text = string.Empty;
            string result = string.Empty;
            StreamReader streamReader = new StreamReader("index.html");

            while ((text = streamReader.ReadLine()) != null)
            {
                result += text.Trim();
            }

            streamReader.Close();

            result = result.Replace("<a href=", "[URL=").Replace("</a>", "[/URL]").Replace("\">", "\"]");
            Console.WriteLine(result);
        }
    }
}
