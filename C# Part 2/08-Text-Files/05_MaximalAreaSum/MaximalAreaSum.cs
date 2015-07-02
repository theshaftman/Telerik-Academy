namespace _05_MaximalAreaSum
{
    using System;
    using System.IO;
    using System.Text;

    class MaximalAreaSum
    {
        /*	Write a program that reads a text file containing a square matrix of numbers.
        	Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements. 
                o	The first line in the input file contains the size of matrix N.
                o	Each of the next N lines contain N numbers separated by space.
                o	The output should be a single number in a separate text file.*/

        private static StringBuilder builder = new StringBuilder();

        static void Main()
        {
            string path = "input.txt";

            try
            {
                Read(path);
                
                //Console.WriteLine(builder.ToString());
                string[] check = builder.ToString().Split('\n');

                try
                {
                    int n = Convert.ToInt32(check[0]);
                    int[,] matrix = new int[n, n];

                    if (CheckCreatingMatrix(matrix, check))
                    {
                        int maxSum = matrix[0, 0] + matrix[0, 1] + matrix[1, 0] + matrix[1, 1];
                        int startRow = 0;
                        int startCol = 0;

                        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                        {
                            int sum = 0;

                            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                            {
                                sum = matrix[row, col] + matrix[row, col + 1] + 
                                    matrix[row + 1, col] + matrix[row + 1, col + 1];

                                if (sum > maxSum)
                                {
                                    maxSum = sum;
                                    startRow = row;
                                    startCol = col;
                                }
                            }
                        }

                        Console.WriteLine("Maximal sum = {0}", maxSum);
                        PrintMax(matrix, startRow, startCol);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error! Write a number in the beginning of the document!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error! File can not be found!");
            }
        }

        private static void Read(string path)
        {
            StreamReader reader = new StreamReader(path);

            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    builder.AppendLine(line);
                    line = reader.ReadLine();
                }

                reader.Close();
            }
        }

        private static bool CheckCreatingMatrix(int[,] matrix, string[] matrixString)
        {
            bool correct = true;
            int n = matrix.GetLength(0);

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] matrixCheck = matrixString[row + 1].Split(' ');

                if (matrixCheck.Length == n)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = Convert.ToInt32(matrixCheck[col]);
                    }
                }
                else
                {
                    correct = false;
                    Console.WriteLine("Error! Write your matrix more correctly!");
                    
                    break;
                }
            }

            return correct;
        }

        private static void PrintMax(int[,] matrix, int startRow, int startCol)
        {
            for (int row = startRow; row < startRow + 2; row++)
            {
                for (int col = startCol; col < startCol + 2; col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
