namespace Matrix
{
    using System;
    using System.Text;

    public class ConsoleOutput
    {
        public static string Print(int[,] matrix)
        {
            StringBuilder sb = new StringBuilder();

            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    sb.Append(String.Format("{0,4}", matrix[col, row]));
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
