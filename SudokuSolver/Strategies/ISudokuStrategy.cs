using System;

namespace SudokuSolver.Strategies
{
    interface ISudokuStrategy
    {
        int[,] Solve(int[,] sudokuBoard);
    }
}

