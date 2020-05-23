using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            NotSolveDesc desc = new NotSolveDesc();
            SolveDesc solvedesc = new SolveDesc();
            desc.DescNotSolvedSudoku();
            FileHandler filehandler = new FileHandler();

            SolveSudoku solvesudoku = new SolveSudoku();
            filehandler.ConvertToInt();
            filehandler.ShowNumbers();

            solvesudoku.sudoku = filehandler.boardintarray;
            solvesudoku.currentsudoku = solvesudoku.sudoku;
            Console.WriteLine();
            solvedesc.DescSolvedSudoku();
            if (solvesudoku.solve(0, 0))
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        Console.Write(solvesudoku.currentsudoku[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Sudoku can not be solved!");
            }
            filehandler.CloseFile();

            Console.ReadKey();
        }
    }
}
