namespace _06_FirstLargerThanNeighbours
{
    using System;

    class FirstLarger
    {
        /*	Write a method that returns the index of the first element in array that is larger than 
        its neighbours, or -1, if there’s no such element.
        	Use the method from the previous exercise.*/

        static void Main()
        {
            Console.Write("Write array(divided by space): ");
            string str = Console.ReadLine();

            string[] arrayStr = str.Split(' ');
            int[] array = new int[arrayStr.Length];
            int numbers;

            for (int i = 0; i < array.Length; i++)
            {
                if (int.TryParse(arrayStr[i], out numbers))
                {
                    array[i] = int.Parse(arrayStr[i]);
                }
                else
                {
                    Console.WriteLine("Error! Write INTS!\n");

                    Main();
                }
            }

            int index = CheckIfLarger(array);

            if (index != -1)
            {
                Console.WriteLine("Index of first large numebr in array [{0}] = {1}\n", index, array[index]);
            }
            else
            {
                Console.WriteLine("There isn`t a larger number [{0}]\n", index);
            }

            Main();
        }

        static int CheckIfLarger(int[] array)
        {
            int isLarger = -1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    isLarger = i;

                    break;
                }
            }

            return isLarger;
        }
    }
}
