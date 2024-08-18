using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBoardProject
{
    // Defines the Cell class which represents each cell on the game board.
    public class Cell
    {
        // Properties
        // Row and Column properties indicate the position of the cell on the board.
        public int Row { get; set; }
        public int Column { get; set; }

        // IsVisited property tracks if the cell has been checked or used in game logic.
        public bool IsVisited { get; set; }

        // IsLive property indicates if the cell is "active" or "live" in the game context.
        public bool IsLive { get; set; }

        // LiveNeighbors property stores the count of live adjacent cells.
        public int LiveNeighbors { get; set; }

        // Constructor to initialize a new instance of the Cell class.
        // The cell starts with default settings of not visited, not live, and zero live neighbors.
        public Cell(int row, int column)
        {
            Row = row;
            Column = column;
            IsVisited = false;
            IsLive = false;
            LiveNeighbors = 0;
        }
    }
}


