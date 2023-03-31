using System;

namespace SnakeLadderProblem
{
    internal class Board
    {
        public Cell[,] cells;

        public Board(int boardSize, int numberOfSnakes, int numberOfLadders)
        {
            initializeCells(boardSize);
            addSnakesLadders(cells, numberOfSnakes, numberOfLadders);
        }

        private void initializeCells(int boardSize)
        {
            cells = new Cell[boardSize, boardSize];

            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    Cell cellObj = new Cell();
                    cells[i, j] = cellObj;
                }
            }
        }
        private static readonly Random getrandom = new Random();

        private void addSnakesLadders(Cell[,] cells, int numberOfSnakes, int numberOfLadders)
        {
            // 3
            while (numberOfSnakes > 0)
            {
                int snakeHead = getrandom.Next(1, cells.GetLength(0) * cells.GetLength(1) - 1);
                int snakeTail = getrandom.Next(1, cells.GetLength(0) * cells.GetLength(1) - 1);
                if (snakeTail >= snakeHead)
                {
                    continue;
                }

                Jump snakeObj = new Jump();
                snakeObj.start = snakeHead;
                snakeObj.end = snakeTail;
                // Console.WriteLine($"SNAKE from postion starts at {snakeObj.start} to {snakeObj.end}");
                Cell cell = getCell(snakeHead);
                cell.jump = snakeObj;

                numberOfSnakes--;
            }

            while (numberOfLadders > 0)
            {
                int ladderStart = getrandom.Next(1, cells.GetLength(0) * cells.GetLength(1) - 1);
                int ladderEnd = getrandom.Next(1, cells.GetLength(0) * cells.GetLength(1) - 1);
                if (ladderStart >= ladderEnd)
                {
                    continue;
                }

                Jump ladderObj = new Jump();
                ladderObj.start = ladderStart;
                ladderObj.end = ladderEnd;
                // Console.WriteLine($"LADDER from postion starts at {ladderObj.start} to {ladderObj.end}");

                Cell cell = getCell(ladderStart);
                cell.jump = ladderObj;

                numberOfLadders--;
            }

        }

        internal Cell getCell(int playerPosition)
        {
            try
            {
                int boardRow = playerPosition / cells.GetLength(0);
                int boardColumn = (playerPosition % cells.GetLength(1));
                return cells[boardRow, boardColumn];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Player Position: {playerPosition} ERROR: {e.Message}");
                return cells[cells.GetLength(0) - 1, cells.GetLength(1) - 1];
            }
        }
    }
}