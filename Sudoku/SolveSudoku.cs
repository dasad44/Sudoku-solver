using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class SolveSudoku
    {
        public int[,] sudoku = new int[9, 9];
        public int[,] currentsudoku = new int[9, 9];
        bool can_insert(int x, int y, int value)
        {
            for (int i = 0; i < 9; i++)
            {
                if (value == currentsudoku[x, i] || value == currentsudoku[i, y] || value == currentsudoku[x / 3 * 3 + i % 3, y / 3 * 3 + i / 3])
                {
                    return false;
                }
            }
            return true;
        }

        bool next(int x, int y)
        {
            if (x == 8 && y == 8)
            {
                return true;
            }
            else if (x == 8)
            {
                return solve(0, y + 1);
            }
            else
            {
                return solve(x + 1, y);
            }
        }

        public bool solve(int x, int y)
        {
            if (sudoku[x, y] == 0)
            {
                for (int i = 1; i <= 9; i++)
                {
                    if (can_insert(x, y, i))
                    {
                        currentsudoku[x, y] = i;
                        if (next(x, y)) return true;
                    }
                }
                currentsudoku[x, y] = 0; return false;
            }
            return next(x, y);
        }
    }
}

