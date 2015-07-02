namespace _05_WorkDays
{
    using System;
    using System.Linq;

    class WorkDays
    {
        /*	Write a method that calculates the number of workdays between today and given date, 
        passed as parameter.
        	Consider that workdays are all days from Monday to Friday except a fixed list of 
        public holidays specified preliminary as array.*/

        static readonly DateTime[] holidays = {
            new DateTime(2015, 1, 1), new DateTime(2015, 3, 2), new DateTime(2015, 3, 3), 
            new DateTime(2015, 4, 10), new DateTime(2015, 4, 13), new DateTime(2015, 5, 1), 
            new DateTime(2015, 5, 6), new DateTime(2015, 5, 24), new DateTime(2015, 9, 6), 
            new DateTime(2015, 9, 22), new DateTime(2015, 12, 24), new DateTime(2015, 12, 25)
        };

        static void Main()
        {
            Console.Write("Write month (this or after this one): ");
            string monthStr = Console.ReadLine();
            Console.Write("Write day (after today): ");
            string dayStr = Console.ReadLine();
            int numbers;

            DateTime now = DateTime.Now;

            if (int.TryParse(monthStr, out numbers) && 
                int.TryParse(dayStr, out numbers))
            {
                int month = int.Parse(monthStr);
                int day = int.Parse(dayStr);

                DateTime givenDate = new DateTime(2015, month, day);

                if ((givenDate.Day - now.Day) > 0 &&
                    (givenDate.Month - now.Month) == 0 ||
                    (givenDate.Month - now.Month) > 0)
                {
                    Console.WriteLine("The working days from {0:dd/MM/yyyy} to {1:dd/MM/yyyy} are {2}", 
                        now, givenDate, GetWorkingDays(now, givenDate));
                }
                else
                {
                    Console.WriteLine("Error! Write a Month and a Day After Today!");
                }
            }

            Console.WriteLine();
            Main();
        }

        private static int GetWorkingDays(DateTime now, DateTime givenDate)
        {
            int numberOfWorkingDays = 1;

            while (now <= givenDate)
            {
                if (!holidays.Contains(now)
                && now.DayOfWeek != DayOfWeek.Saturday
                && now.DayOfWeek != DayOfWeek.Sunday)
                {
                    numberOfWorkingDays++;
                }

                now = now.AddDays(1);
            }

            return numberOfWorkingDays;
        }
    }
}
