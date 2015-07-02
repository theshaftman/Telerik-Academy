namespace _16_DateDifference
{
    using System;

    class DateDifference
    {
        /*	Write a program that reads two dates in the format: day.month.year and calculates 
        the number of days between them.*/

        static void Main()
        {
            Console.Write("Enter first date: ");
            string firstStr = Console.ReadLine();
            Console.Write("Enter second date: ");
            string secondStr = Console.ReadLine();

            if (firstStr.Contains(".") && secondStr.Contains("."))
	        {
                string[] firstArr = firstStr.Split('.');
                string[] secondArr = secondStr.Split('.');

                if (firstArr.Length == 3 && secondArr.Length == 3)
                {
                    int[] first = new int[3];
                    int[] second = new int[3];
                    first = ConvertToInt(firstArr);
                    second = ConvertToInt(secondArr);

                    DateTime firstDate = new DateTime(first[2], first[1], first[0]);
                    DateTime secondDate = new DateTime(second[2], second[1], second[0]);

                    TimeSpan numberOfDays = secondDate - firstDate;
                    int dateDifference = numberOfDays.Days;

                    Console.WriteLine("Distance: {0} days", dateDifference);
                }
	        }

            Console.WriteLine();
            Main();
        }

        private static int[] ConvertToInt(string[] arrStr)
        {
            int[] arr = new int[3];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(arrStr[i]);
            }

            return arr;
        }
    }
}
