using System;

class BonusScore
{
    /*	Write a program that applies bonus score to given score in the range [1…9] by the following rules: 
        o	If the score is between 1 and 3, the program multiplies it by 10.
        o	If the score is between 4 and 6, the program multiplies it by 100.
        o	If the score is between 7 and 9, the program multiplies it by 1000.
        o	If the score is 0 or more than 9, the program prints “invalid score”.*/

    static void Main()
    {
        Console.Write("Score: ");
        string str = Console.ReadLine();

        try
        {
            int number = int.Parse(str);
            int result = 0;

            switch (number)
            {
                case 1:
                case 2:
                case 3: result = number * 10;
                    break;
                case 4:
                case 5:
                case 6: result = number * 100;
                    break;
                case 7:
                case 8:
                case 9: result = number * 1000;
                    break;
                default: Console.WriteLine("invalid score\n");
                    Main();
                    break;
            }

            Console.WriteLine("Result: {0}\n", result);
        }
        catch (Exception)
        {
            Console.WriteLine("Error! Write a INT Number!\n");
        }

        Main();
    }
}
