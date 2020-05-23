using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    interface IFileHandler
    {
        void ConvertToInt();
        void ShowNumbers();
        void CloseFile();
    }
}
