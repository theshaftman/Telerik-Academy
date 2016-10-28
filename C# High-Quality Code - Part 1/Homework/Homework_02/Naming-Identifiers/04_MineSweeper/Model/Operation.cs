namespace _04_MineSweeper.Model
{
    using System;
    using System.Collections.Generic;

    internal static class Operation
    {
        internal static char[,] CreateArea(int rowsCount, int columnsCount, char emptyChar)
        {
            char[,] area = new char[rowsCount, columnsCount];

            for (int rows = 0; rows < rowsCount; rows++)
            {
                for (int columns = 0; columns < columnsCount; columns++)
                {
                    area[rows, columns] = emptyChar;
                }
            }

            return area;
        }

        internal static char[,] IncludeBombs(int rowsCount, int columnsCount, int maxBombsCount, char isNotBomb, char isBomb)
        {
            char[,] area = CreateArea(rowsCount, columnsCount, isNotBomb);
            List<int> bombPositionsList = CreateBombPositionList(maxBombsCount);

            foreach (int bombPosition in bombPositionsList)
            {
                int column = bombPosition / columnsCount;
                int row = bombPosition % columnsCount;

                if (row == 0 && bombPosition != 0)
                {
                    row = columnsCount;
                    column--;
                }
                else
                {
                    row++;
                }

                area[column, row - 1] = isBomb;
            }

            return area;
        }
        
        internal static int BombsCount(char[,] area, int row, int column, char bombType)
        {
            int count = 0;
            int rows = area.GetLength(0);
            int columns = area.GetLength(1);

            if (row - 1 >= 0)
            {
                if (area[row - 1, column] == bombType)
                {
                    count++;
                }
            }

            if (row + 1 < rows)
            {
                if (area[row + 1, column] == bombType)
                {
                    count++;
                }
            }

            if (column - 1 >= 0)
            {
                if (area[row, column - 1] == bombType)
                {
                    count++;
                }
            }

            if (column + 1 < columns)
            {
                if (area[row, column + 1] == bombType)
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (area[row - 1, column - 1] == bombType)
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (column + 1 < columns))
            {
                if (area[row - 1, column + 1] == bombType)
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (column - 1 >= 0))
            {
                if (area[row + 1, column - 1] == bombType)
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (column + 1 < columns))
            {
                if (area[row + 1, column + 1] == bombType)
                {
                    count++;
                }
            }

            return count;
        }
        
        private static List<int> CreateBombPositionList(int maxBombsCount)
        {
            Random random = new Random();
            List<int> bombPositionsList = new List<int>();

            while (bombPositionsList.Count < maxBombsCount)
            {
                int bombPosition = random.Next(50);

                if (!bombPositionsList.Contains(bombPosition))
                {
                    bombPositionsList.Add(bombPosition);
                }
            }

            return bombPositionsList;
        }
    }
}
