namespace _19_PermutationsSet
{
    using System;

    class PermutationsSet
    {
        static void Main()
        {
            /*	Write a program that reads a number N and generates and 
            prints all the permutations of the numbers [1 … N].*/

            try
            {
                Console.Write("Write a number: ");
                int max = int.Parse(Console.ReadLine());
                string str = "";

                for (int i = 0; i < max; i++)
                {
                    str += (i + 1).ToString();
                }

                Console.WriteLine("Result:");
                Permutation(str.ToCharArray(), 0, str.Length - 1);
                
                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Error! Write a number!\n");
            }

            Main();
        }

        private static void Permutation(char[] str, int i, int n)
        {
            if (i == n)
            {                
                Console.WriteLine(string.Join(" ", str));
            }
            else
            {
                for (int j = i; j <= n; j++)
                {
                    char c = str[j];
                    str[j] = str[i];
                    str[i] = c;

                    Permutation(str, i + 1, n);

                    c = str[j];
                    str[j] = str[i];
                    str[i] = c;
                }
            }
        }
    }
}
