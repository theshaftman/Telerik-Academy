namespace _13_ReverseSentence
{
    using System;

    class ReverseSentence
    {
        /*	Write a program that reverses the words in given sentence.*/

        static void Main()
        {
            string text = "C# is not C++, not PHP and not Delphi!";

            char comma = ',';
            char endSign = '!';

            string[] arrSearch = text.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
            int indexComma = 0;
            int indexSign = 0;

            for (int i = 0; i < arrSearch.Length; i++)
            {
                if (arrSearch[i].Contains(comma.ToString()))
                {
                    indexComma = i;
                }
                else if (arrSearch[i].Contains(endSign.ToString()))
                {
                    indexSign = i;
                }
            }

            string[] arr = text.Split(new char[]{' ', comma, endSign}, StringSplitOptions.RemoveEmptyEntries);
            string result = string.Empty;

            for (int j = arr.Length - 1; j >= 0; j--)
            {
                result += arr[j];

                if ((arr.Length - j - 1) == indexComma)
                {
                    result += comma.ToString();
                }
                else if ((arr.Length - j - 1) == indexSign)
                {
                    result += endSign.ToString();
                }

                result += " ";
            }

            Console.WriteLine(result);
        }
    }
}
