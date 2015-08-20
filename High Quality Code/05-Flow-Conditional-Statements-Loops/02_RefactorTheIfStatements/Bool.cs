namespace _02_RefactorTheIfStatements
{
    using System;

    public class Bool
    {
        public const int MIN_X = 1;
        public const int MAX_X = 3;
        public const int MIN_Y = 2;
        public const int MAX_Y = 5;

        public static bool IsVisitedCell = true;
        static int x = 2;
        static int y = 3;

        public static void VisitCell()
        {
            Console.WriteLine("Let's pay that cell a visit.");
        }

        public static void CheckIfShouldVisitCell()
        {
            bool truthyY = (MIN_Y <= y && y <= MAX_Y);
            bool truthyX = (MIN_X <= x && x <= MAX_X);

            if (truthyX && truthyY && IsVisitedCell)
            {
                VisitCell();
            }
        }
    }
}
