namespace _02_MaximalSum
{
    using System;

    class MaximalSum
    {
        /*	Write a program that reads a rectangular matrix of size N x M and finds in it the square 
        3 x 3 that has maximal sum of its elements.*/

        static void Main()
        {
            int[,] matrix = {
                    {1, 2, 1, 4, 0, 1},
                    {0, 1, 2, 1, 0, 0},
                    {0, 9, 0, 1, 1, 2},
                    {1, 1, 2, 2, 1, 1},
                    {3, 2, 1, 9, 1, 0}
                };

            int n = 3;
            int sum = 0;
            int firstIndexRow = 0;
            int firstIndexCol = 0;
            int bestSum = matrix[0, 0] + matrix[0, 1] + matrix[0, 0] + 
                matrix[1, 0] + matrix[1, 1] + matrix[1, 2] +
                matrix[2, 0] + matrix[2, 1] + matrix[2, 2];
            

            for (int row = 0; row < matrix.GetLength(0) - (n - 1); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - (n - 1); col++)
                {
                    for (int i = col; i < (col + n); i++)
                    {
                        sum = matrix[row, col] + matrix[row, col + 1] + 
                            matrix[row, col + 2] + matrix[row + 1, col] + 
                            matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                            matrix[row + 2, col] + matrix[row + 2, col + 1] +
                            matrix[row + 2, col + 2];

                        if (sum > bestSum)
                        {
                            bestSum = sum;
                            firstIndexRow = row;
                            firstIndexCol = col;
                        }

                        sum = 0;
                    }
                }
            }

            Console.WriteLine("Best sum = {0}", bestSum);
            Console.WriteLine("Result in aray:");

            for (int row = firstIndexRow; row < firstIndexRow + n; row++)
            {
                for (int col = firstIndexCol; col < firstIndexCol + n; col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
