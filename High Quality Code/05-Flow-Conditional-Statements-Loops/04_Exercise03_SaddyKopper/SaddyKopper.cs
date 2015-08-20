namespace _04_Exercise03_SaddyKopper
{
    using System;
    using System.Numerics;

    public class SaddyKopper
    {
        private const int MaxNumberOfTransformation = 10;

        public static void Main()
        {
            ulong inputNumber = UlongCheck();

            PerformNumberTransformations(inputNumber);
        }

        private static ulong UlongCheck()
        {
            string stringToCheck = Console.ReadLine();
            ulong numbers;

            if (ulong.TryParse(stringToCheck, out numbers))
            {
                return ulong.Parse(stringToCheck);
            }

            return 0;
        }

        private static void PerformNumberTransformations(ulong inputNumber)
        {
            int transformationsCount = 0;
            ulong sumOfDigits = 0;
            BigInteger result = 1;
            BigInteger sumNumber = inputNumber / 10;
            bool isTransformationFinished = false;

            while (transformationsCount < 11 && !isTransformationFinished)
            {
                while (sumNumber > 0)
                {
                    sumOfDigits = SumDigits(sumNumber);
                    result *= sumOfDigits;
                    sumNumber /= 10;
                }

                transformationsCount++;

                if (result < 10 && transformationsCount <= MaxNumberOfTransformation)
                {
                    Console.WriteLine(transformationsCount);
                    Console.WriteLine(result);
                    isTransformationFinished = true;
                }
                else if (transformationsCount == 9)
                {
                    Console.WriteLine(result);
                    isTransformationFinished = true;
                }
                else
                {
                    sumNumber = result / 10;
                    result = 1;
                }
            }
        }

        private static ulong SumDigits(BigInteger sumNumber)
        {
            ulong sumOfDigits = 0;

            string operate = Convert.ToString(sumNumber);

            for (int i = 0; i < operate.Length; i += 2)
            {
                if (char.IsDigit(operate[i]))
                {
                    sumOfDigits += (ulong)(operate[i] - '0');
                }
            }

            return sumOfDigits;
        }
    }
}
