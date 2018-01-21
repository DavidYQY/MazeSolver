using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MazeSolver
{
    public class Cell
    {
        public Point Coord { get; set; }
        public CellType Type { get; set; }
        public int Weight { get; set; }
        public Cell(Cell c2)
        {
            Coord = new Point(c2.Coord.X,c2.Coord.Y);
            Type = c2.Type;
            Weight = c2.Weight;
        }
        public Cell() { }
    }
}
