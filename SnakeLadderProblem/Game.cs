using System;
using System.Collections.Generic;

namespace SnakeLadderProblem
{
    internal class Game
    {
        Board board;
        Dice dice;
        List<Player> playersList = new List<Player>();
        Player winner;

        public Game()
        {
            initializeGame();
        }

        private void initializeGame()
        {
            board = new Board(10, 5, 4);
            dice = new Dice(1);
            winner = null;
            addPlayers();
        }

        private void addPlayers()
        {
            Player player1 = new Player("p1", 0);
            Player player2 = new Player("p2", 0);
            playersList.Add(player1);
            playersList.Add(player2);
        }

        internal void startGame()
        {
            while (winner == null)
            {
                //check whose turn now
                Player playerTurn = findPlayerTurn();
                Console.WriteLine("player turn is:" + playerTurn.id + " current position is: " + playerTurn.currentPosition);

                //roll the dice
                int diceNumbers = dice.rollDice(); // 1 dice 1-6

                //get the new position// 0 => 3 => 3 => 8 =? 11
                int playerNewPosition = playerTurn.currentPosition + diceNumbers;

                // New position based on Snakes/Ladders
                playerNewPosition = jumpCheck(playerNewPosition);

                playerTurn.currentPosition = playerNewPosition;

                Console.WriteLine("player turn is:" + playerTurn.id + " new Position is: " + playerNewPosition);
                //check for winning condition
                if (playerNewPosition >= board.cells.GetLength(0) * board.cells.GetLength(1) - 1)
                {

                    winner = playerTurn;
                }

            }

            Console.WriteLine("WINNER IS:" + winner.id);
        }

        private int jumpCheck(int playerNewPosition)
        {
            // byond 100, player wins ==> 102 ==> 100
            if (playerNewPosition > board.cells.Length * board.cells.Length - 1)
            {
                return playerNewPosition;
            }

            Cell cell = board.getCell(playerNewPosition);
            if (cell.jump != null && cell.jump.start == playerNewPosition)
            {
                // Hash map key: start --- value: End
                String jumpBy = (cell.jump.start < cell.jump.end) ? "ladder" : "snake";
                Console.WriteLine("jump done by: " + jumpBy);
                return cell.jump.end;
            }
            return playerNewPosition;
        }

        private Player findPlayerTurn()
        {
            Player playerTurns = playersList[0];
            playersList.RemoveAt(0);
            playersList.Add(playerTurns);
            return playerTurns;
        }
    }
}