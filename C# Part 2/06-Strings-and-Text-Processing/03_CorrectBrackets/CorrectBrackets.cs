namespace _03_CorrectBrackets
{
    using System;

    class CorrectBrackets
    {
        /*	Write a program to check if in a given expression the brackets are put correctly.*/

        static void Main()
        {
            Console.Write("Write an expression: ");
            string str = Console.ReadLine();

            int openBrackets = 0;
            int closeBrackets = 0;
            bool ifCorrect = false;
            int index = 0;
            int endIndex = 1;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    openBrackets++;
                    index = i;
                }
                else if (str[i] == ')' && i > index)
                {
                    closeBrackets++;
                    endIndex = i;
                }
            }

            if (openBrackets == closeBrackets && index < endIndex)
            {
                ifCorrect = true;
            }

            Console.WriteLine("Correct brackets? {0}\n", ifCorrect);

            Main();
        }
    }
}
