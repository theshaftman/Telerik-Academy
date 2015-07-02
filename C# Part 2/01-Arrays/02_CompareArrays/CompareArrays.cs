namespace _02_CompareArrays
{
    using System;

    class CompareArrays
    {
        /*	Write a program that reads two integer arrays from the console 
        and compares them element by element.*/

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
                    int[] intA = new int[strArrA.Length];
                    int[] intB = new int[strArrB.Length];

                    for (int i = 0; i < strArrA.Length; i++)
                    {
                        intA[i] = int.Parse(strArrA[i]);
                    }

                    for (int j = 0; j < strArrB.Length; j++)
                    {
                        intB[j] = int.Parse(strArrB[j]);
                    }
                    
                    if (intA.Length == intB.Length)
                    {
                        for (int k = 0; k < intA.Length; k++)
                        {
                            if (intA[k] != intB[k])
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
                Console.WriteLine("Write INT numbers!\n");
            }

            Main();
        }
    }
}
