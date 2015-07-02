namespace _03_EnglishDigit
{
    using System;

    class EnglishDigit
    {
        /*	Write a method that returns the last digit of given integer as an English word.*/

        static void Main()
        {
            Console.Write("Write INT digit: ");
            string str = Console.ReadLine();
            int numbers;

            if (int.TryParse(str, out numbers))
            {
                int number = int.Parse(str);

                Console.WriteLine("{0}\n", LastDigit(str));
            }
            else
            {
                Console.WriteLine("Error! Write an INT!\n");
            }

            Main();
        }

        static string LastDigit(string str)
        {
            string digit = str[str.Length - 1].ToString();
            string result = string.Empty;

            switch (digit)
            {
                case "0": result = "zero"; break;
                case "1": result = "one"; break;
                case "2": result = "two"; break;
                case "3": result = "three"; break;
                case "4": result = "four"; break;
                case "5": result = "five"; break;
                case "6": result = "six"; break;
                case "7": result = "seven"; break;
                case "8": result = "eight"; break;
                case "9": result = "nine"; break;
            }
            
            return result;
        }
    }
}
