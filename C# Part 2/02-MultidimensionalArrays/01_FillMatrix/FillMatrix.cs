using System.Collections.Generic;

namespace _01_FillMatrix
{
    using System;
    using System.Linq;

    class FillMatrix
    {
        /*	Write a program that fills and prints a matrix of size (n, n) as shown below:*/

        static int n = 4;
        static int[,] matrix = new int[n, n];

        static void Main()
        {
            Console.WriteLine("First variant:");
            FirstVariant();
            Print();
            
            Console.WriteLine("\nSecond variant:");
            SecondVariant();
            Print();

            Console.WriteLine("\nThird variant:");
            ThirdVariant();
            Print();

            Console.WriteLine("\nFourth variant:");
            FourthVariant();
            Print();
        }

        private static void FirstVariant()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col > 0)
                    {
                        matrix[row, col] = matrix[row, col - 1] + n;
                    }
                    else
                    {
                        matrix[row, col] = row + 1;
                    }
                }
            }
        }

        private static void SecondVariant()
        {
            int counter = 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col % 2 == 0)
                    {
                        matrix[row, col] = counter + (n * col);
                    }
                    else
                    {
                        matrix[row, col] = (n * (col + 1)) - row;
                    }
                }

                counter++;
            }
        }

        private static void ThirdVariant()
        {
            int number = 1;
            int currentRow;

            for (int row = n - 1; row >= 0; row--)
            {
                currentRow = row;

                for (int col = 0; col < n - row; col++)
                {
                    matrix[currentRow++, col] = number++;
                }
            }

            number = n * n;

            for (int row = 0; row < n - 1; row++)
            {
                currentRow = row;
                for (int col = n - 1; currentRow >= 0; col--)
                {
                    matrix[currentRow--, col] = number--;
                }
            }
        }

        private static void FourthVariant()
        {
            List<Tuple<int, int>> directions = new List<Tuple<int, int>>();
            directions.Add(new Tuple<int, int>(1, 0));
            directions.Add(new Tuple<int, int>(0, 1));
            directions.Add(new Tuple<int, int>(-1, 0));
            directions.Add(new Tuple<int, int>(0, -1));

            int[,] used = new int[n, n];

            //Console.WriteLine(inRange(matrix, 3, 3));
            
            int num = 1;
            int doneCount = 0;
            int i = 0;
            int j = 0;
            int currentDirection = 0;

            while (doneCount < n * n)
            {
                int nextI = i + directions[currentDirection].Item1;
                int nextJ = j + directions[currentDirection].Item2;

                if (!inRange(matrix, nextI, nextJ) || used[nextI, nextJ] == 1)
                {
                    currentDirection = getNextDir(directions, currentDirection);
                }

                matrix[i, j] = num++;
                used[i, j] = 1;
                doneCount += 1;

                i += directions[currentDirection].Item1;
                j += directions[currentDirection].Item2;
            }
        }

        private static bool inRange(int[,] matrix, int x, int y)
        {
            return (x >= 0 && x < matrix.GetLength(0)) && (y >= 0 && y < matrix.GetLength(1));
        }
    
        private static int getNextDir(List<Tuple<int, int>> directions, int currentDirection)
        {
            if (currentDirection + 1 == directions.Count())
            {
                return 0;
            }
            else
            {
                return currentDirection + 1;
            }
        }

        private static void Print()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
