using System;

class OddEvenProduct
{
    /*	Write a program that checks whether the product 
    of the odd elements is equal to the product of the 
    even elements.
	    Elements are counted from 1 to n, so the first 
    element is odd, the second is even, etc.*/

    static void Main()
    {
        Console.Write("Write numbers (separated by space): ");
        string str = Console.ReadLine();
        string[] strNumbers = str.Split(' ');

        try
        {
            int[] numbers = new int[strNumbers.Length];
            int evenProd = 1;
            int oddProd = 1;

            for (int i = 0; i < strNumbers.Length; i++)
            {
                numbers[i] = int.Parse(strNumbers[i]);
            }

            for (int j = 0; j < numbers.Length; j++)
            {
                if (j % 2 == 0)
                {
                    oddProd *= numbers[j];
                }
                else
                {
                    evenProd *= numbers[j];
                }
            }

            if (oddProd == evenProd)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}\n", oddProd);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product: {0}\neven_product: {1}\n", 
                    oddProd, evenProd);
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Error! Write INT numbers!\n");
        }

        Main();
    }
}
