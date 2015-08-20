namespace _04_Exercise05_BtsToBits
{
    using System;

    public class BitsToBits
    {
        private static char[] bits;

        public static void Main()
        {
            //Console.Write("Enter N: ");
            string stringToCheck = Console.ReadLine();
            int number;

            if (int.TryParse(stringToCheck, out number))
            {
                number = int.Parse(stringToCheck);
            }

            if (number >= 1 && number <= 100)
            {
                int[] nums = new int[number];
                string result = string.Empty;
                bits = new char[number * 30];
                int charCount = 0;

                for (int i = 0; i < number; i++)
                {
                    stringToCheck = string.Empty;
                    stringToCheck = Console.ReadLine();
                    int numbers;

                    if (int.TryParse(stringToCheck, out numbers))
                    {
                        numbers = int.Parse(stringToCheck);

                        if (numbers >= 0 && numbers <= 1073741823)
                        {
                            nums[i] = numbers;
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }

                    result = Convert.ToString(nums[i], 2).PadLeft(30, '0');

                    for (int j = 0; j < 30; j++)
                    {
                        bits[charCount] = result[j];
                        charCount++;
                    }
                }

                int[] results = GetResult();

                Console.WriteLine(results[0]);
                Console.WriteLine(results[1]);
            }
        }

        private static int[] GetResult()
        {
            int[] result = new int[2];
            result[0] = MaxResult('0');
            result[1] = MaxResult('1');

            return result;
        }

        private static int MaxResult(char charToCheck)
        {
            int count = 0;
            int maximal = 0;

            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == charToCheck)
                {
                    count++;
                    maximal = (maximal >= count) ? maximal : count;
                }
                else
                {
                    count = 0;
                }
            }

            return maximal;
        }
    }
}
