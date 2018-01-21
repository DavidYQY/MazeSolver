using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolver
{
    public enum CellType
    {
        Invalid,
        Empty,
        Wall,
        Path,
        Open,
        Closed,
        Current,
        Start,
        End
    }
}
