namespace Matrix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int matrixLength = ConsoleInput.FindInt();
            int[,] matrix = Matrix.GiveMatrixValues(matrixLength);

            System.Console.WriteLine(ConsoleOutput.Print(matrix));
        }
    }
}
