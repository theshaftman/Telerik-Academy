namespace _04_Exercise01_Printing
{
    using System;

    public class Printing
    {
        public static void Main()
        {
            //Console.Write("Write \"N students\": ");
            int students = GetInt();
            //Console.Write("Write \"S sheets\": ");
            int sheets = GetInt();
            //Console.Write("Write \"P price on one realm\": ");
            double price = GetDouble();

            if (CheckValue(students, 0, 10000) && CheckValue(sheets, 0, 500) &&
                CheckPriceValue(price, 0.01, 100))
            {
                int sheetsValue = students * sheets;
                double realmsValue = (double)(sheetsValue) / 500;
                double result = realmsValue * price;

                Console.WriteLine("{0:F2}", result);
            }
        }

        private static int GetInt()
        {
            string str = Console.ReadLine();
            int number;

            if (int.TryParse(str, out number))
            {
                return int.Parse(str);
            }

            return Int32.MinValue;
        }

        private static double GetDouble()
        {
            string str = Console.ReadLine();
            double number;

            if (double.TryParse(str, out number))
            {
                return double.Parse(str);
            }

            return Double.MinValue;
        }

        private static bool CheckValue(int value, int minValue, int maxValue)
        {
            if (value > minValue && value <= maxValue)
            {
                return true;
            }

            return false;
        }

        private static bool CheckPriceValue(double price, double minValue, double maxValue)
        {
            if (price >= minValue && price <= maxValue)
            {
                return true;
            }

            return false;
        }
    }
}
