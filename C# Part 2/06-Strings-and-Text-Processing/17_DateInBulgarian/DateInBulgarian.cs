namespace _17_DateInBulgarian
{
    using System;

    class DateInBulgarian
    {
        /*	Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
        and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of 
        week in Bulgarian.*/

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Enter date: ");
            string dateStr = Console.ReadLine();
            Console.Write("Enter time: ");
            string timeStr = Console.ReadLine();

            if (dateStr.Contains(".") && timeStr.Contains(":"))
            {
                string[] dateArr = dateStr.Split('.');
                string[] timeArr = timeStr.Split(':');

                if (dateArr.Length == 3 && timeArr.Length == 3)
                {
                    int[] date = new int[3];
                    int[] time = new int[3];
                    date = ConvertToInt(dateArr);
                    time = ConvertToInt(timeArr);

                    DateTime givenDate = new DateTime(date[2], date[1], date[0], time[0], time[1], time[2]);
                    givenDate = givenDate.AddHours(6).AddMinutes(30);

                    string addition = string.Empty;

                    switch (date[0])
                    {
                        case 2: addition = "Понеделник"; break;
                        case 3: addition = "Вторник"; break;
                        case 4: addition = "Сряда"; break;
                        case 5: addition = "Четвъртък"; break;
                        case 6: addition = "Петък"; break;
                        case 7: addition = "Събота"; break;
                        case 1: addition = "Неделя"; break;
                        default:
                            break;
                    }

                    string result = givenDate.ToString("dd.MM.yyyy hh:mm:ss") + " " + addition;

                    Console.WriteLine(result);
                }
            }

            Console.WriteLine();
            Main();
        }

        private static int[] ConvertToInt(string[] arrStr)
        {
            int[] result = new int[3];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = int.Parse(arrStr[i]);
            }

            return result;
        }
    }
}
