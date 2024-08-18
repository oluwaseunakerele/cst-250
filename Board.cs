using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBoardProject
{
    public class Board
    {
        // Properties
        // Size: The dimension of the board (e.g., a 10x10 grid would have Size set to 10).
        public int Size { get; set; }

        // Grid: A 2D array of Cell objects representing each cell on the board.
        public Cell[,] Grid { get; set; }

        // Difficulty: Affects the probability of a cell being 'live'. It's used as a percentage.
        public int Difficulty { get; set; }

        // Constructor
        // Initializes a new instance of the Board with a given size and difficulty level.
        public Board(int size, int difficulty)
        {
            Size = size;
            Difficulty = difficulty;
            Grid = new Cell[size, size]; // Allocates memory for the grid of cells.
            InitializeGrid(); // Initializes each cell in the grid.
        }

        // Methods
        // InitializeGrid: Populates the grid with new cells, each initialized with its position.
        private void InitializeGrid()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Grid[i, j] = new Cell(i, j);
                }
            }
        }

        // SetupLiveNeighbors: Randomly assigns 'live' status to cells based on the difficulty.
        public void SetupLiveNeighbors()
        {
            Random random = new Random();
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    // Each cell has a probability (based on 'Difficulty') of being live.
                    Grid[i, j].IsLive = random.Next(100) < Difficulty;
                }
            }
        }

        // CalculateLiveNeighbors: Calculates and updates the count of live neighbors for each cell.
        public void CalculateLiveNeighbors()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    int liveNeighbors = 0;
                    // Check all adjacent cells (including diagonally adjacent ones).
                    for (int x = -1; x <= 1; x++)
                    {
                        for (int y = -1; y <= 1; y++)
                        {
                            int ni = i + x;
                            int nj = j + y;
                            // Skip the current cell itself.
                            if (x == 0 && y == 0) continue;
                            // Ensure indices are within grid boundaries.
                            if (ni >= 0 && nj >= 0 && ni < Size && nj < Size && Grid[ni, nj].IsLive)
                            {
                                liveNeighbors++;
                            }
                        }
                    }
                    // Update the live neighbors count for the current cell.
                    Grid[i, j].LiveNeighbors = liveNeighbors;
                }
            }
        }
    }

}
