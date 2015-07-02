namespace _12_SubstractingPolynomials
{
    using System;

    class SubstractingPolynomials
    {
        /*	Extend the previous program to support also subtraction and multiplication of polynomials.*/

        enum Operation
        {
            Add,
            Substract,
            Multiply
        }

        static void Main()
        {
            Console.Write("Write size of polynomials: ");
            string str = Console.ReadLine();
            int numbers;

            if (int.TryParse(str, out numbers))
            {
                int n = int.Parse(str);
                int[] arr1 = new int[n];
                int[] arr2 = new int[n];

                for (int i = 0; i < n; i++)
                {
                    int grate = n - (i + 1);
                    char ch = (char)(i + 97);
                    string use = ch.ToString();

                    if (grate > 1)
                    {
                        use += "x^" + grate;
                    }
                    else if (grate == 1)
                    {
                        use += "x";
                    }

                    Console.Write("Write polynom A [{0}] = ", use);
                    arr1[i] = int.Parse(Console.ReadLine());
                    Console.Write("Write polynom B [{0}] = ", use);
                    arr2[i] = int.Parse(Console.ReadLine());
                }

                Array.Reverse(arr1);
                Array.Reverse(arr2);

                Console.Write("Polynom A: ");
                Print(arr1);
                Console.Write("Polynom B: ");
                Print(arr2);
                Console.WriteLine("\nAdd polynomials:");
                Print(OperatePolynomials(arr1, arr2, Operation.Add));
                Console.WriteLine("Substract polynomials:");
                Print(OperatePolynomials(arr1, arr2, Operation.Substract));
                Console.WriteLine("Multiply polynomials:");
                Print(OperatePolynomials(arr1, arr2, Operation.Multiply));
            }

            Console.WriteLine();

            Main();
        }

        private static int[] OperatePolynomials(int[] arr1, int[] arr2, Operation op)
        {
            int[] result = new int[arr1.Length];

            for (int i = 0; i < result.Length; i++)
            {
                switch (op)
                {
                    case Operation.Add:
                        result[i] = arr1[i] + arr2[i];
                        break;
                    case Operation.Substract:
                        result[i] = arr1[i] - arr2[i];
                        break;
                    case Operation.Multiply:
                        result[i] = arr1[i] * arr2[i];
                        break;
                }
            }

            return result;
        }

        private static void Print(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
