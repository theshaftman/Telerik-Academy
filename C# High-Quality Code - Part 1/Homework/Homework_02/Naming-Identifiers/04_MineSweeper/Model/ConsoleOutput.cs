namespace _04_MineSweeper.Model
{
    using System;

    internal static class ConsoleOutput
    {
        internal static void PrintField(char[,] area)
        {
            int rowsCount = area.GetLength(0);
            int columnsCount = area.GetLength(1);

            PrintLine("\n");
            Print("    ");

            for (int index = 0; index < columnsCount; index++)
            {
                Print(string.Format("{0, 2} ", index));
            }

            PrintLine();

            for (int rows = 0; rows < rowsCount; rows++)
            {
                Print(string.Format("{0} | ", rows));

                for (int columns = 0; columns < columnsCount; columns++)
                {
                    Print(string.Format("{0, 2} ", area[rows, columns]));
                }
                
                PrintLine("|");
            }

            Print("    ");
            
            for (int index = 0; index < columnsCount; index++)
            {
                Print(string.Format("{0, 2} ", '-'));
            }

            PrintLine("\n");
        }

        internal static void Print(object output = null)
        {
            Console.Write(output);
        }

        internal static void PrintLine(object output = null)
        {
            Console.WriteLine(output);
        }
    }
}
