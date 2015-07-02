namespace _02_EnterNumbers
{
    using System;

    class EnterNumbers
    {
        /*	Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end]. 
                o	If an invalid number or non-number text is entered, the method should throw an exception.
        	Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100 */

        static void Main()
        {
            Console.WriteLine("Repeat 10 times:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} time: ", i + 1);
                ReadNumber(0, 100);
            }
        }

        private static void ReadNumber(int start, int end)
        {
            string str = Console.ReadLine();

            try
            {
                int number = int.Parse(str);

                if (number > start && number < end)
                {
                    Console.WriteLine("{0} is in range", number);
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Wrong input!\n{0}", ex.Message);
            }
            finally
            {
                Console.WriteLine();
            }
        }
    }
}
