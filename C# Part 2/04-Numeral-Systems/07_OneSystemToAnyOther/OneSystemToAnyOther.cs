using System;
using System.Text;

namespace _07_OneSystemToAnyOther
{
    class OneSystemToAnyOther
    {
        static void Main()
        {
            Console.Write("Write a numeral system you want to convert from (2 <= s <= 16): ");
            int fromSystem = int.Parse(Console.ReadLine());
            Console.Write("Please, enter number: ");
            string number = Console.ReadLine();
            Console.Write("Write a numeral system you to convert to (2 <= d <= 16): ");
            int toSystem = int.Parse(Console.ReadLine());
            long decimalRepresantation = Convert.ToInt64(number, fromSystem);
            
            if (toSystem == 10)
            {
                Console.WriteLine(decimalRepresantation);
            }
            else
            {
                string converted = ConvertNumber(decimalRepresantation, toSystem);
                Console.WriteLine(converted);
            }
        }

        private static string ConvertNumber(long number, int toSystem)
        {
            StringBuilder result = new StringBuilder();
            long remainder = 0;
            
            while (number > 0)
            {
                remainder = number % toSystem;
                result.Insert(0, SwitchRemainder(remainder));
                number /= toSystem;
            }

            return result.ToString();
        }

        private static string SwitchRemainder(long remainder)
        {
            switch (remainder)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                return remainder.ToString();
                case 10: return "A";
                case 11: return "B";
                case 12: return "C";
                case 13: return "D";
                case 14: return "E";
                case 15: return "F";
                default: throw new ArgumentOutOfRangeException("Invalid numeral system!");
            }
        }
    }
}
