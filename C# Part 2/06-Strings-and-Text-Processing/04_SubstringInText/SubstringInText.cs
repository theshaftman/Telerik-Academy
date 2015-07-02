namespace _04_SubstringInText
{
    using System;

    class SubstringInText
    {
        /*	Write a program that finds how many times a sub-string is contained in a given text 
        (perform case insensitive search).*/

        static void Main()
        {
            string str = "The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string text = str.ToLower();
            string toFind = "in";

            int index = str.IndexOf(toFind);
            int count = 0;

            while (index > -1)
            {
                count++;
                index = str.IndexOf(toFind, index + 1);
            }

            Console.WriteLine("Found \"{0}\": {1}", toFind, count);
        }
    }
}
