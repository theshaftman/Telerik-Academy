namespace _07_LargestAreaInMatrix
{
    using System;

    class LargestAreaInMatrix
    {
        /*	Write a program that finds the largest area of equal neighbour elements 
        in a rectangular matrix and prints its size.*/

        static bool[,] visited = new bool[1000, 1000];
        static int[] dx = { -1, 1, 0, 0 };
        static int[] dy = { 0, 0, -1, 1 };
        
        static void Main(string[] args)
        {
            int[,] matrix = {
                {1, 3, 2, 2, 2, 4},
                {3, 3, 3, 2, 4, 4},
                {4, 3, 1, 2, 3, 3},
                {4, 3, 1, 3, 3, 1},
                {4, 3, 3, 3, 1, 1}
            };

            int current = 0;
            int maxNumber = 0;
            int max = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    current = LargestArea(matrix, row, col, matrix[row, col]);
                        
                    if (current > max)
                    {
                        max = current;
                        maxNumber = matrix[row, col];
                    }
                }
            }

            Console.WriteLine("{0} -> {1} times", maxNumber, max);
        }

        static int LargestArea(int[,] matrix, int x, int y, int value)
        {
            if (visited[x, y])
            {
                return 0;
            }
            else
            {
                visited[x, y] = true;
                int best = 0;
                
                for (int i = 0; i < 4; i++)
                {
                    int modx = dx[i] + x;
                    int mody = dy[i] + y;
                    
                    if (modx < 0 || modx >= matrix.GetLength(0) ||
                        mody < 0 || mody >= matrix.GetLength(1))
                    {
                        continue;
                    }
                   
                    if (matrix[modx, mody] == value)
                    {
                        int v = LargestArea(matrix, modx, mody, value);
                        best += v;
                    }
                }
                
                return best + 1;
            }
        }
    }
}
