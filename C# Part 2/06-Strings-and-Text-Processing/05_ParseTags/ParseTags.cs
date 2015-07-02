namespace _05_ParseTags
{
    using System;

    class ParseTags
    {
        /*	You are given a text. Write a program that changes the text in all regions surrounded by 
        the tags <upcase> and </upcase> to upper-case.*/

        static void Main()
        {
            string text = "We are living in a <upcase>yellow submarine.</upcase> We don't have <upcase>anything</upcase> else.";
        
            string[] str = text.Split('<');

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i][0] != '/' && str[i][0] == 'u')
                {
                    string check = str[i];
                    string upper = str[i].Remove(0, 7).ToUpper();

                    text = text.Replace(check, upper);
                }
                else if (str[i][0] == '/')
                {
                    string check = str[i];
                    string upper = str[i].Remove(0, 8);

                    text = text.Replace(check, upper);
                }
            }

            text = text.Replace("<", "");

            Console.WriteLine(text);
        }
    }
}
