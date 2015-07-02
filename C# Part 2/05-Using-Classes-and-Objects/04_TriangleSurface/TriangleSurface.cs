namespace _04_TriangleSurface
{
    using System;

    class TriangleSurface
    {
        /*	Write methods that calculate the surface of a triangle by given: 
                o	Side and an altitude to it;
                o	Three sides;
                o	Two sides and an angle between them;
        	Use System.Math.*/

        static void Main()
        {
            Console.WriteLine(@"Calculate triangle surface by given:
1) Side and altitude to it
2) Three sides
3) Two sides and an angle between them");
            string choose = Console.ReadLine();

            switch (choose)
            {
                case "1": Console.WriteLine("Surface = {0:0.###}", SideAltitudeResult()); 
                    break;
                case "2": Console.WriteLine("Surface = {0:0.###}", ThreeSidesResult()); 
                    break;
                case "3": Console.WriteLine("Surface = {0:0.###}", TwoSidesAndAngleResult()); 
                    break;
                default: Console.WriteLine("Error! Write a number between 1 and 3!");
                    break;
            }

            Console.WriteLine();
            Main();
        }

        private static double SideAltitudeResult()
        {
            Console.Write("Base \"b\": ");
            string strB = Console.ReadLine();
            Console.Write("Altitude \"h\": ");
            string strH = Console.ReadLine();
            double result = 0.0;
            double numbers;

            if (double.TryParse(strB, out numbers) && double.TryParse(strH, out numbers))
            {
                double b = double.Parse(strB);
                double h = double.Parse(strH);

                result = (b * h) / 2;
            }

            return result;
        }

        private static double ThreeSidesResult()
        {
            Console.Write("Side \"a\": ");
            string strA = Console.ReadLine();
            Console.Write("Side \"b\": ");
            string strB = Console.ReadLine();
            Console.Write("Side \"c\": ");
            string strC = Console.ReadLine();
            double result = 0.0;
            double numbers;

            if (double.TryParse(strA, out numbers) && 
                double.TryParse(strB, out numbers) &&
                double.TryParse(strC, out numbers))
            {
                double a = double.Parse(strA);
                double b = double.Parse(strB);
                double c = double.Parse(strC);

                double s = (a + b + c) / 2;
                double inSquare = s * (s - a) * (s - b) * (s - c);
                result = Math.Sqrt(inSquare);
            }

            return result;
        }

        private static double TwoSidesAndAngleResult()
        {
            Console.Write("Side \"b\": ");
            string strB = Console.ReadLine();
            Console.Write("Side \"c\": ");
            string strC = Console.ReadLine();
            Console.Write("Angle \"a\": ");
            string strAngle = Console.ReadLine();
            double result = 0.0;
            double numbers;

            if (double.TryParse(strB, out numbers) &&
                double.TryParse(strC, out numbers) &&
                double.TryParse(strAngle, out numbers))
            {
                double b = double.Parse(strB);
                double c = double.Parse(strC);
                double angle = double.Parse(strAngle);

                double angleWork = angle * Math.PI / 180.0;
                result = ((b * c) / 2) * Math.Sin((double)angleWork);
            }

            return result;
        }
    }
}
