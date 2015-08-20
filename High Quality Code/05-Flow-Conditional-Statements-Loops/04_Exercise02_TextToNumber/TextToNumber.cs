namespace _04_Exercise02_TextToNumber
{
    using System;

    public class TextToNumber
    {
        private static int moduleNumber;

        public static void Main()
        {
            //Console.Write("Write a number: ");
            moduleNumber = int.Parse(Console.ReadLine());
            //Console.Write("Write a text ending with \"@\": ");
            string stringToFormat = Console.ReadLine();

            string[] cutString = stringToFormat.Split('@');
            string strText = cutString[0];

            if ((moduleNumber >= 2000 && moduleNumber <= 10000) && (strText.Length <= 100000))
            {
                int result = CountResult(strText);

                Console.WriteLine("{0}", result);
            }
        }

        private static int CountResult(string strText)
        {
            int result = 0;
            int numbers;

            for (int i = 0; i < strText.Length; i++)
            {
                if (int.TryParse(strText[i].ToString(), out numbers))
                {
                    int num = int.Parse(strText[i].ToString());
                    result *= num;
                }
                else if (strText[i] >= 'a' && strText[i] <= 'z' ||
                    strText[i] >= 'A' && strText[i] <= 'Z')
                {
                    result += CountGivenChar(strText[i]);
                }
                else
                {
                    result = result % moduleNumber;
                }
            }

            return result;
        }

        private static int CountGivenChar(char givenChar)
        {
            int number = 0;

            if (givenChar >= 'a' && givenChar <= 'z')
            {
                number = (int)givenChar - 97;
            }
            else
            {
                number = (int)givenChar - 65;
            }

            return number;
        }
    }
}
