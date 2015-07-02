namespace _03_CompareCharArrays
{
    using System;

    class CompareCharArrays
    {
        /*	Write a program that compares two char arrays lexicographically 
        (letter by letter).*/

        static void Main()
        {
            Console.Write("Write First Array(decided by space): ");
            string strA = Console.ReadLine();
            Console.Write("Write Second Array(devided by space): ");
            string strB = Console.ReadLine();

            string[] strArrA = strA.Split(' ');
            string[] strArrB = strB.Split(' ');

            try
            {
                bool equal = true;
                
                if (strArrA.Length == strArrB.Length)
                {
                    char[] charA = new char[strArrA.Length];
                    char[] charB = new char[strArrB.Length];
                    int numbers;

                    for (int i = 0; i < strArrA.Length; i++)
                    {
                        if (!int.TryParse(strArrA[i], out numbers))
                        {
                            charA[i] = char.Parse(strArrA[i]);
                        }
                        else
                        {
                            Console.WriteLine("Not Numbers!\n");

                            Main();
                        }
                    }

                    for (int j = 0; j < strArrB.Length; j++)
                    {
                        if (!int.TryParse(strArrB[j], out numbers))
                        {
                            charB[j] = char.Parse(strArrB[j]);
                        }
                        else
                        {
                            Console.WriteLine("Not Numbers!\n");

                            Main();
                        }
                    }

                    if (charA.Length == charB.Length)
                    {
                        for (int k = 0; k < charA.Length; k++)
                        {
                            if (charA[k] != charB[k])
                            {
                                equal = false;

                                break;
                            }
                        }
                    }
                }
                else
                {
                    equal = false;
                }
                
                Console.WriteLine("Are the two arrays equal? {0}\n", equal);
            }
            catch (Exception)
            {
                Console.WriteLine("Write Chars!\n");
            }

            Main();
        }
    }
}
