namespace _03_SequnceMatrix
{
    using System;

    class SequenceMatrix
    {
        /*	We are given a matrix of strings of size N x M. Sequences in the matrix we define 
        as sets of several neighbour elements located on the same line, column or diagonal.
        	Write a program that finds the longest sequence of equal strings in the matrix.*/

        static void Main()
        {
            string[,] matrix = {
                {"ha", "fifi", "ho", "hi"},
                {"fo", "ha", "hi", "xx"},
                {"xxx", "ho", "ha", "xx"}
            };

            int count = 1;
            int maxCount = 1;
            string maxValue = string.Empty;

            //Searching horizontally
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if ((matrix[row, col] == matrix[row, col + 1]))
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxValue = matrix[row, col];
                    }
                }
                
                count = 1;
            }
            
            //Searching vertically
            for (int col = 0; col < matrix.GetLength(1); col++) 
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    if ((matrix[row, col] == matrix[row + 1, col]))
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxValue = matrix[row, col];
                    }
                }
            
                count = 1;
            }

            //Searching diagonally from left to right
            for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
            {
                if ((matrix[row, col] == matrix[row + 1, col + 1]))
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxValue = matrix[row, col];
                }
            }

            count = 1;

            //Searching diagonally from right to left
            for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col > 0; row++, col--)
            {
                if ((matrix[row, col] == matrix[row + 1, col + 1]))
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxValue = matrix[row, col];
                }
            }

            count = 1;

            Console.Write("Result: ");

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write("{0}", maxValue);

                if (i < maxCount - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
    }
}
