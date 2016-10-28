namespace _04_MineSweeper
{
    using Model;

    public class MineSweeperProgram
    {
        public static void Main(string[] arguments)
        {
            int rows = 5;
            int columns = 15;
            int bombsCount = 15;
            int maximumAllowedTurns = 35;

            MineSweeper.Run(rows, columns, bombsCount, maximumAllowedTurns);
        }
    }
}