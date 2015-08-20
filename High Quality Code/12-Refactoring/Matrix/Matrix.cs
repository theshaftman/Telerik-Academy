namespace Matrix
{
    public class Matrix
    {
        private static int n;

        private static int[,] matrix;

        public static int[,] GiveMatrixValues(int length)
        {
            n = length;
            matrix = new int[n, n];

            return GiveMatrixValues();
        }

        private static int[,] GiveMatrixValues()
        {
            int value = 1;
            int row = 0;
            int col = 0;
            int directionX = 1;
            int directionY = 1;

            do
            {
                EmptyCell(matrix, out row, out col);

                directionX = 1;
                directionY = 1;

                while (true)
                {
                    matrix[row, col] = value;
                    value++;

                    if (!CheckPosition(matrix, row, col))
                    {
                        break;
                    }
                    
                    if (BoolA(n, row, col, directionX, directionY))
                    {
                        while (BoolB(n, row, col, directionX, directionY))
                        {
                            ChangeDirection(ref directionX, ref directionY);
                        }
                    }

                    row += directionX;
                    col += directionY;
                }

            } while (FindEmptyCell(matrix, out row, out col));

            return matrix;
        }

        private static bool BoolA(int n, int row, int col, int directionX, int directionY)
        {
            return row + directionX >= n || row + directionX < 0 ||
                col + directionY >= n || col + directionY < 0 ||
                matrix[row + directionX, col + directionY] != 0;
        }

        private static bool BoolB(int n, int row, int col, int directionX, int directionY)
        {
            return row + directionX >= n || row + directionX < 0 ||
                col + directionY >= n || col + directionY < 0 ||
                matrix[row + directionX, col + directionY] != 0;
        }

        static bool FindEmptyCell(int[,] arr, out int x, out int y)
        {
            x = 0;
            y = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        x = i;
                        y = j;

                        return true;
                    }
                }
            }

            return false;
        }

        static void EmptyCell(int[,] arr, out int x, out int y)
        {
            x = 0;
            y = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        x = i;
                        y = j;

                        return;
                    }
                }
            }
        }

        static bool CheckPosition(int[,] arr, int x, int y)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                if (x + dirX[i] >= arr.GetLength(0) || x + dirX[i] < 0)
                {
                    dirX[i] = 0;
                }

                if (y + dirY[i] >= arr.GetLength(0) || y + dirY[i] < 0)
                {
                    dirY[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (arr[x + dirX[i], y + dirY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        static void ChangeDirection(ref int dx, ref int dy)
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
    }
}