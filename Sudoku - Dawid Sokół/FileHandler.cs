using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sudoku___Dawid_Sokół
{
    class FileHandler :IFileHandler
    {
        public string[] numbers = File.ReadAllLines(@"sudoku.txt");
        public StreamReader file = new StreamReader("sudoku.txt");
        public int[,] boardstringarray = new int[9, 9];
        public int columns = 0;
        public int[,] boardintarray = new int[9, 9];
        public bool fileexists = false;

        public void ConvertToInt()
        {
            //numberstoint = Array.ConvertAll<string, int>(numbers, int.Parse);
            for (int i = 0; i < numbers.Length; i++)
            {
                string[] tmp = numbers[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < tmp.Length; j++)
                {
                    boardintarray[i, j] = int.Parse(tmp[j]);
                }
            }
        }
        public void ShowNumbers()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(boardintarray[i,j]);
                }
                Console.WriteLine();
            }
        }

        public void FileCloser()
        {
            file.Close();
        }
    }
}
