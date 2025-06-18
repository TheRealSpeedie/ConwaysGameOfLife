using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
    public class GameOfLife
    {
        public bool[,] cells { get; private set; }
        public readonly int numOfCells = 40;
        public readonly int cellSize = 20;
        public GameOfLife()
        {
            cells = new bool[numOfCells, numOfCells];
        }
        public void ResetField()
        {
            for (int row = 0; row < numOfCells; row++)
            {
                for (int col = 0; col < numOfCells; col++)
                {
                    cells[row, col] = false;
                }
            }
        }
        public void SetAlive(int row, int col)
        {
            if (row < 0 || col < 0 || row >= numOfCells || col >= numOfCells) return;
            cells[row, col] = true;
        }
        public void SetDead(int row, int col)
        {
            cells[row, col] = false;
        }
        public bool IsAlive(int row, int col)
        {
            if (row < 0 || col < 0 || row >= numOfCells || col >= numOfCells) return false;
            return cells[row, col];
        }
        public int NextGeneration()
        {
            int changedCells = 0;
            var nextGen = new bool[numOfCells, numOfCells];
            for (int row = 0; row < numOfCells; row++)
            {
                for (int col = 0; col < numOfCells; col++)
                {
                    var neighbours = CountAliveNeighbours(row, col);
                    var isCellAlive = IsAlive(row, col);
                    if (neighbours == 3 && !isCellAlive)
                    {
                        nextGen[row, col] = true;
                        changedCells++;
                    }
                    else if (neighbours < 2 && isCellAlive)
                    {
                        nextGen[row, col] = false;
                        changedCells++;
                    }
                    else if (neighbours == 3 && isCellAlive || neighbours == 2 && isCellAlive)
                    {
                        nextGen[row, col] = true;
                    }
                    else if (neighbours > 3 && isCellAlive)
                    {
                        nextGen[row, col] = false;
                        changedCells++;
                    }
                }
            }
            cells = nextGen;
            return changedCells;
        }
        public int CountAliveNeighbours(int row, int col)
        {
            var amount = 0;

            if (IsAlive(row - 1, col - 1)) amount++;
            if (IsAlive(row - 1, col)) amount++;
            if (IsAlive(row - 1, col + 1)) amount++;

            if (IsAlive(row, col - 1)) amount++;
            if (IsAlive(row, col + 1)) amount++;

            if (IsAlive(row + 1, col - 1)) amount++;
            if (IsAlive(row + 1, col)) amount++;
            if (IsAlive(row + 1, col + 1)) amount++;

            return amount;
        }
    }
}

