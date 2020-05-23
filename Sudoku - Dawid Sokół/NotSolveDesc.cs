using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku___Dawid_Sokół
{
    class NotSolveDesc :IDescription
    {
        public void DescNotSolvedSudoku()
        {
            Console.WriteLine("Not solved Sudoku:");
        }
        public void DescSolvedSudoku()
        {
            Console.WriteLine("Solved Sudoku:");
        }
    }
}
