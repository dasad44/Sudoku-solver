using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    interface ISolveSudoku
    {
        bool can_insert(int x, int y, int value);
        bool next(int x, int y);
        bool solve(int x, int y);
    }
}
