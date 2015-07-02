namespace _11_AddingPolynomials
{
    using System;

    class AddingPolynomials
    {
        /*	Write a method that adds two polynomials.
        	Represent them as arrays of their coefficients.*/

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
                Console.WriteLine("Add polynomials:");
                Print(AddPolynomials(arr1, arr2));
            }

            Console.WriteLine();

            Main();
        }

        private static int[] AddPolynomials(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = arr1[i] + arr2[i];
            }

            return result;
        }

        private static void Print(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
