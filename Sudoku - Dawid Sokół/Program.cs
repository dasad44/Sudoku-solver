using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku___Dawid_Sokół
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            Description desc = new Description();
            desc.DescNotSolvedSudoku();
            board.CreateBoard();
            FileHandler filehandler = new FileHandler();

            Console.WriteLine();
            SolveSudoku solvesudoku = new SolveSudoku();
            filehandler.ConvertToInt();
            filehandler.ShowNumbers();

            solvesudoku.sudoku = filehandler.boardintarray;
            solvesudoku.currentsudoku = solvesudoku.sudoku;
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            desc.DescSolvedSudoku();
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
                Console.WriteLine("Sudoku Can't be solved!");
            }
            filehandler.FileCloser();

            Console.ReadKey();
        }
    }
}
