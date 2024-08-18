using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBoardProject
{
    class Program
    {
        // Entry point of the console application.
        static void Main(string[] args)
        {
            // Initializes the size of the board.
            int boardSize = 10;  // Set the size of the board

            // Sets the difficulty which determines the percentage of cells that are "live".
            int difficulty = 20; // Set difficulty (percentage of live cells)

            // Creates a new Board object with specified size and difficulty.
            Board board = new Board(boardSize, difficulty);

            // Randomly sets cells to live based on the difficulty level.
            board.SetupLiveNeighbors();

            // Calculates and updates the number of live neighbors for each cell.
            board.CalculateLiveNeighbors();

            // Outputs the current state of the board to the console.
            PrintBoard(board);

            // Waits for the user to press a key before closing the console window.
            Console.ReadKey();
        }

        // A utility method that prints the board's cells and their number of live neighbors.
        static void PrintBoard(Board board)
        {
            // Iterates through each row of the board.
            for (int i = 0; i < board.Size; i++)
            {
                // Iterates through each column of the row.
                for (int j = 0; j < board.Size; j++)
                {
                    // Prints the number of live neighbors for each cell, followed by a space.
                    Console.Write(board.Grid[i, j].LiveNeighbors + " ");
                }
                // Moves to the next line after printing all columns in a row.
                Console.WriteLine();
            }
        }
    }
}