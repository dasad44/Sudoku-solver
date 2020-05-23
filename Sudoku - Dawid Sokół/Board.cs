using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sudoku___Dawid_Sokół
{
    class Board :IBoard
    {
        public int[,] boardarray = new int[9, 9];

        public void CreateBoard()
        {
            for(int i = 0; i < 10; i ++)
            {
                for(int j = 0; j < 11; j++)
                {
                }
            }
        }
    }
}
