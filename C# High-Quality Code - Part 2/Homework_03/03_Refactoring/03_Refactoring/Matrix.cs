namespace _03_Refactoring
{
    using System;

    public class Matrix
    {
        private static int[,] matrix;
        private static int n;
        private static int k = 1;
        private static int i = 0;
        private static int j = 0;
        private static int dx = 1;
        private static int dy = 1;
        private static int addition = 0;

        internal static void GetInput()
        {
            Console.WriteLine("Enter a positive number ");
            string input = Console.ReadLine();
            n = 0;

            while (!int.TryParse(input, out n) || n < 0 || n > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }
        }

        internal static void GetMatrix()
        {
            matrix = new int[n, n];
            int step = n;

            Modify();
            FindCell(out i, out j);
            Modify();
        }

        internal static void PrintMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0, 3}", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static void Change(ref int dx, ref int dy)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int cd = 0;

            for (int count = 0; count < 8; count++)
            {
                if (dirX[count] == dx && dirY[count] == dy)
                {
                    cd = count;
                    break;
                }
            }

            if (cd == 7)
            {
                dx = dirX[0];
                dy = dirY[0];

                return;
            }

            dx = dirX[cd + 1];
            dy = dirY[cd + 1];
        }

        private static bool Check(int[,] matrix, int x, int y)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                if (x + dirX[i] >= matrix.GetLength(0) || x + dirX[i] < 0)
                {
                    dirX[i] = 0;
                }

                if (y + dirY[i] >= matrix.GetLength(1) || y + dirY[i] < 0)
                {
                    dirY[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (matrix[x + dirX[i], y + dirY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool FindCell(out int x, out int y)
        {
            x = 0;
            y = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        x = i;
                        y = j;

                        return true;
                    }
                }
            }

            return false;
        }
        
        private static void Modify()
        {
            while (true)
            {
                matrix[i, j] = k + addition;

                if (!Check(matrix, i, j))
                {
                    break;
                }

                if (InRange())
                {
                    while (InRange())
                    {
                        Change(ref dx, ref dy);
                    }
                }

                i += dx;
                j += dy;
                k++;
            }

            addition += 1;
        }

        private static bool InRange()
        {
            bool inRange = (i + dx >= n || i + dx < 0 ||
                j + dy >= n || j + dy < 0 ||
                matrix[i + dx, j + dy] != 0);

            return inRange;
        }
    }
}
