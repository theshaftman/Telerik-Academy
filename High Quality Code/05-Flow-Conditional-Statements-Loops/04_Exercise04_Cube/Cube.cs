namespace _04_Exercise04_Cube
{
    using System;

    public class Cube
    {
        public static void Main()
        {
            //Console.Write("Write INT: ");
            int inputNumber = GetInt();

            if (inputNumber >= 4 && inputNumber <= 100)
            {
                int width = inputNumber;
                int height = (inputNumber * 2) - 1;
                int differenceA = inputNumber;
                int differenceB = 0;

                for (int row = 0; row < height; row++)
                {
                    string result = string.Empty;

                    if (row > 0 && row < inputNumber - 1)
                    {
                        result = GetResult(row, differenceA, differenceB, inputNumber, height);
                        
                        differenceA--;
                        differenceB++;
                    }
                    else if (row >= inputNumber && row < height - 1)
                    {
                        result = GetResult(row, differenceA, differenceB, inputNumber, height);
                        differenceB--;
                    }
                    else if (row == inputNumber - 1)
                    {
                        differenceA--;
                        result = GetResult(row, differenceA, differenceB, inputNumber, height);
                        differenceB--;
                    }
                    else
                    {
                        result = GetResult(row, differenceA, differenceB, inputNumber, height);
                    }

                    Console.WriteLine(result);
                }
            }
        }

        private static int GetInt()
        {
            string stringNumber = Console.ReadLine();
            int numbers;

            if (int.TryParse(stringNumber, out numbers))
            {
                return int.Parse(stringNumber);
            }

            return -1;
        }

        private static string GetResult(int row, int differenceA, int differenceB, int inputNumber, int height)
        {
            string result = string.Empty;

            if (row == 0 || row == height - 1)
            {
                string outStr = new String(' ', differenceA);
                string inStr = new String(':', inputNumber);

                result = outStr + inStr;
            }
            else if (row > 0 && row < inputNumber - 1)
            {
                int widthIn = inputNumber - 2;
                string outStr = new String(' ', differenceA - 1);
                string inStrFree = new String('/', widthIn);
                string outStrFree = new String('X', differenceB);
                string inStr = new String(':', 1);

                result = outStr + inStr + inStrFree + inStr + outStrFree + inStr;
            }
            else if (row >= inputNumber && row < height - 1)
            {
                int widthIn = inputNumber - 2;
                string outStr = new String(' ', 1);
                string inStrFree = new String(' ', widthIn);
                string outStrFree = new String('X', differenceB);
                string inStr = new String(':', 1);

                result = outStr + inStr + inStrFree + inStr + outStrFree + inStr;
            }
            else if (row == inputNumber - 1)
            {
                string outStr = new String(' ', differenceA);
                string inStr = new String(':', inputNumber);
                string endInStr = new String(':', 1);
                string outStrFree = new String('X', differenceB);

                result = outStr + inStr + outStrFree + endInStr;
            }

            return result;
        }
    }
}
