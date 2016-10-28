namespace _04_MineSweeper.Model
{
    using System;
    using System.Collections.Generic;

    internal static class MineSweeper
    {
        private const char NOT_FOUND_CHARACTER = '?';
        private const char NO_BOMB_CHARACTER = '-';
        private const char BOMB_CHARACTER = '*';

        private static bool isFirstLine;
        private static bool isLastLine;
        private static bool isBombFound;
        private static char[,] area;
        private static char[,] bombArea;
        private static List<Highscore> highscoreList;
        private static int counter;
        private static int givenRows;
        private static int givenColumns;
        private static int givenBombsCount;
        private static int givenMaximumAllowedTurns;

        internal static void Run(int rows, int columns, int bombsCount, int maximumAllowedTurns)
        {
            highscoreList = new List<Highscore>(6);
            givenRows = rows;
            givenColumns = columns;
            givenBombsCount = bombsCount;
            givenMaximumAllowedTurns = maximumAllowedTurns;

            InputValues();

            int row = 0;
            int column = 0;
            string line = string.Empty;

            do
            {
                if (isFirstLine)
                {
                    PrintFirstLine();
                }

                ConsoleOutput.Print("Please write \"row\" and \"column\": ");
                line = Console.ReadLine();
                
                string[] entryLine = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (entryLine.Length == 2 &&
                    int.TryParse(entryLine[0], out row) &&
                    int.TryParse(entryLine[1], out column) &&
                    row <= area.GetLength(0) - 1 && column <= area.GetLength(1) - 1)
                {
                    line = "turn";
                }

                ExecuteLine(line, row, column);

                if (isBombFound)
                {
                    EndCurrentGame();
                }

                if (isLastLine)
                {
                    PrintLastLine();
                }
            }
            while (line != "exit");

            ConsoleOutput.PrintLine("Game Over!");
            Console.Read();
        }

        private static void InputValues()
        {
            area = Operation.CreateArea(givenRows, givenColumns, NOT_FOUND_CHARACTER);
            bombArea = Operation.IncludeBombs(givenRows, givenColumns, givenBombsCount, NO_BOMB_CHARACTER, BOMB_CHARACTER);

            isFirstLine = true;
            isLastLine = false;
            isBombFound = false;

            counter = 0;
        }

        private static void ExecuteLine(string line, int row, int column)
        {
            switch (line)
            {
                case "top":
                    HighscoresList(highscoreList);
                    break;
                case "restart":
                    InputValues();
                    ConsoleOutput.PrintField(area);
                    break;
                case "turn":
                    ClassicTurn(row, column);
                    break;
                case "exit":
                    break;
                default:
                    ConsoleOutput.PrintLine("\nInvalid line\n");
                    break;
            }
        }
        
        private static void PrintFirstLine()
        {
            ConsoleOutput.PrintLine("Lets play \"Minesweeper\". Try to find the fields without any mines.");
            ConsoleOutput.PrintLine("   Help:");
            ConsoleOutput.PrintLine("\t'top' - shows leader board");
            ConsoleOutput.PrintLine("\t'restart' - starts a new game");
            ConsoleOutput.PrintLine("\t'exit' exits the game");

            ConsoleOutput.PrintField(area);

            isFirstLine = false;
        }

        private static void EndCurrentGame()
        {
            ConsoleOutput.PrintField(bombArea);
            ConsoleOutput.Print(string.Format(
                "\nYou ended the game with {0} points. Please give your nickname: ",
                counter));

            string inputName = Console.ReadLine();

            Highscore currentPlayer = new Highscore(inputName, counter);

            if (highscoreList.Count < 5)
            {
                highscoreList.Add(currentPlayer);
            }
            else
            {
                for (int i = 0; i < highscoreList.Count; i++)
                {
                    if (highscoreList[i].Points < currentPlayer.Points)
                    {
                        highscoreList.Insert(i, currentPlayer);
                        highscoreList.RemoveAt(highscoreList.Count - 1);

                        break;
                    }
                }
            }

            highscoreList.Sort((Highscore r1, Highscore r2) => r2.Name.CompareTo(r1.Name));
            highscoreList.Sort((Highscore r1, Highscore r2) => r2.Points.CompareTo(r1.Points));

            HighscoresList(highscoreList);

            InputValues();
        }

        private static void PrintLastLine()
        {
            ConsoleOutput.PrintLine(string.Format(
                "\nExcellent! You suceeded to end your game for the given {0} moves.",
                givenMaximumAllowedTurns));
            ConsoleOutput.PrintField(bombArea);
            ConsoleOutput.PrintLine("Please write your nickname: ");

            string imeee = Console.ReadLine();
            Highscore highscoresList = new Highscore(imeee, counter);
            highscoreList.Add(highscoresList);
            HighscoresList(highscoreList);

            InputValues();
        }

        private static void Turn(
            char[,] area,
            char[,] bombList,
            int row,
            int column)
        {
            int bombsCount = Operation.BombsCount(bombList, row, column, BOMB_CHARACTER);

            bombList[row, column] = char.Parse(bombsCount.ToString());
            area[row, column] = char.Parse(bombsCount.ToString());
        }

        private static void ClassicTurn(int row, int column)
        {
            if (bombArea[row, column] != BOMB_CHARACTER)
            {
                if (bombArea[row, column] == NO_BOMB_CHARACTER)
                {
                    Turn(area, bombArea, row, column);
                    counter++;
                }

                if (givenMaximumAllowedTurns == counter)
                {
                    isLastLine = true;
                }
                else
                {
                    ConsoleOutput.PrintField(area);
                }
            }
            else
            {
                isBombFound = true;
            }
        }

        private static void HighscoresList(List<Highscore> highscoresList)
        {
            ConsoleOutput.PrintLine("\nPoints:");

            if (highscoresList.Count > 0)
            {
                for (int i = 0; i < highscoresList.Count; i++)
                {
                    ConsoleOutput.PrintLine(string.Format(
                        "{0}. {1} --> {2} boxes",
                        i + 1,
                        highscoresList[i].Name,
                        highscoresList[i].Points));
                }

                ConsoleOutput.PrintLine();
            }
            else
            {
                ConsoleOutput.PrintLine("Missing classation!\n");
            }
        }
    }
}
