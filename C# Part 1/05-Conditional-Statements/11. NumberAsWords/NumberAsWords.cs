using System;

class NumberAsWords
{
    /*	Write a program that converts a number in the range 
    [0…999] to words, corresponding to the English pronunciation.*/

    static void Main()
    {
        Console.Write("Write a number [0-999]: ");
        string numberStr = Console.ReadLine();

        try
        {
            int number = int.Parse(numberStr);

            if (number >= 0 && number <= 999)
            {
                string result = "";

                if (numberStr.Length == 1)
                {
                    result = OneDigit(numberStr);
                }
                else if (numberStr.Length == 2)
                {
                    if (numberStr[0].ToString() == "1")
                    {
                        result = TwoDigitsTo20(numberStr[1].ToString());
                    }
                    else if (numberStr[1].ToString() == "0")
                    {
                        result = TwoDigits(numberStr[0].ToString());
                    }
                    else
                    {
                        result = TwoDigits(numberStr[0].ToString()) +
                            OneDigit(numberStr[1].ToString());
                    }
                }
                else
                {
                    if (numberStr[1].ToString() == "1")
                    {
                        result = ThreeDigits(numberStr[0].ToString()) +
                            TwoDigitsTo20(numberStr[2].ToString());
                    }
                    else if (numberStr[2].ToString() == "0" && 
                        numberStr[1].ToString() != "0")
                    {
                        result = ThreeDigits(numberStr[0].ToString()) + "and " +
                            TwoDigits(numberStr[1].ToString());
                    }
                    else if (numberStr[2].ToString() == "0" && 
                        numberStr[1].ToString() == "0")
                    {
                        result = ThreeDigits(numberStr[0].ToString());
                    }
                    else
                    {
                        result = ThreeDigits(numberStr[0].ToString()) + "and " +
                            TwoDigits(numberStr[1].ToString()) +
                            OneDigit(numberStr[2].ToString());
                    }
                }

                result = result[0].ToString().ToUpper() + result.Remove(0, 1);
                Console.WriteLine("{0}\n", result);
            }
            else
            {
                Console.WriteLine("Error! Try with a number between 0 and 999!\n");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Error!\n");
        }

        Main();
    }

    static string OneDigit(string number)
    {
        string result = "";

        switch (number)
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

    static string TwoDigitsTo20(string number)
    {
        string result = "";

        switch (number)
        {
            case "0": result = "ten"; break;
            case "1": result = "eleven"; break;
            case "2": result = "twelve"; break;
            case "3": result = "thirteen"; break;
            case "4": result = "fourteen"; break;
            case "5": result = "fiveteen"; break;
            case "6": result = "sixteen"; break;
            case "7": result = "seventeen"; break;
            case "8": result = "eighteen"; break;
            case "9": result = "nineteen"; break;
        }

        return result;
    }

    static string TwoDigits(string number)
    {
        string result = "";

        switch (number)
        {
            case "2": result = "twenty "; break;
            case "3": result = "thirty "; break;
            case "4": result = "fourty "; break;
            case "5": result = "fifty "; break;
            case "6": result = "sixty "; break;
            case "7": result = "seventy "; break;
            case "8": result = "eighty "; break;
            case "9": result = "ninety "; break;
        }

        return result;
    }

    static string ThreeDigits(string number)
    {
        string result = "";

        switch (number)
        {
            case "1": result = "one hundred "; break;
            case "2": result = "two hundred "; break;
            case "3": result = "three hundred "; break;
            case "4": result = "four hundred "; break;
            case "5": result = "five hundred "; break;
            case "6": result = "six hundred "; break;
            case "7": result = "seven hundred "; break;
            case "8": result = "eight hundred "; break;
            case "9": result = "nine hundred "; break;
        }

        return result;
    }
}
