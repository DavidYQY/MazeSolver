using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MazeSolver
{
    public class Grid
    {
        private Cell[,] _grid;
        public int hCells, vCells;
        Point startPoint;
        Point endPoint;
        public Grid(int _hcells,int _vcells)
        {
            _grid = new Cell[_hcells, _vcells];
            hCells = _hcells;
            vCells = _vcells;
            startPoint = new Point(2,4);
            endPoint = new Point(_hcells - 2, _vcells - 3);

            reset();
        }
        public Grid(Grid g)
        {
            this.hCells = g.hCells;
            this.vCells = g.vCells;
            _grid = new Cell[hCells, vCells];
            for (int x = 0; x < g.hCells; x++)
                for (int y = 0; y < g.vCells; y++)
                    _grid[x, y] = new Cell(g._grid[x,y]);

            startPoint = new Point(g.startPoint.X, g.startPoint.Y);
            endPoint = new Point(g.endPoint.X, g.endPoint.Y);
        }
        public void reset()
        {
            for (int x = 0; x < _grid.GetLength(0); x++)
                for (int y = 0; y < _grid.GetLength(1); y++)
                    SetCell(x, y, CellType.Empty);
            SetStartAndEnd();
        }
        public void SetCell(int x, int y, CellType type)
        {
            _grid[x, y] = new Cell
            {
                Coord = new Point(x, y),
                Type = type,
                Weight = GetCell(x, y)?.Weight ?? 0
            };
            SetStartAndEnd();
        }
        public void SetCell(int x,int y,Cell C)
        {
            Cell temp = new Cell();
            temp.Coord = C.Coord;
            temp.Weight = C.Weight;
            temp.Type = C.Type;
            _grid[x, y] = C;
            SetStartAndEnd();
        }
        public void SetCell(Point p,Cell C)
        {
            SetCell(p.X, p.Y, C);
        }
        public void SetCell(Point p, CellType type)
        {
            SetCell(p.X, p.Y, type);
        }

        private void SetStartAndEnd()
        {
            
            _grid[startPoint.X,startPoint.Y] = new Cell
            {
                Coord = new Point(startPoint.X, startPoint.Y),
                Type = CellType.Start
            };
            _grid[endPoint.X, endPoint.Y] = new Cell
            {
                Coord = new Point(endPoint.X,endPoint.Y),
                Type = CellType.End
            };
        }

        public Cell GetCell(int x, int y)
        {
            if (x > hCells - 1 || x < 0 || y > vCells - 1 || y < 0)
                return new Cell { Coord = new Point(-1, -1), Type = CellType.Invalid };
            return _grid[x, y];
        }
        public Cell GetCell(Point p)
        {
            return GetCell(p.X, p.Y);
        }

        public Cell GetStart()
        {
            return GetCell(startPoint);
        }

        public Cell GetEnd()
        {
            return GetCell(endPoint);
        }

        public int GetCountOfType(CellType type)
        {
            int total = 0;
            foreach (var cell in _grid)
            {
                if (cell.Type == type)
                    total += 1;
            }

            return total;
        }

        public void Randomize(int seed)
        {
            Random rand = new Random(seed);
            for (int x = 0; x < hCells; x++)
            {
                for (int y=0;y<vCells;y++)
                {
                    if (rand.Next(0, 20) >= 16)
                        _grid[x, y].Type = CellType.Wall;
                    else
                        _grid[x, y].Type = CellType.Empty;

                    int weight = rand.Next(1, 4);
                    _grid[x, y].Weight = weight;
                }
            }

            SetStartAndEnd();
        }
        public void Randomize()
        {
            Randomize((int)DateTime.Now.Ticks);
        }
        public void changeStartPoint(Point p)
        {
            Point temp = new Point(startPoint.X,startPoint.Y);
            startPoint = new Point(p.X, p.Y);
            Random rand = new Random();
            int weight = rand.Next(1, 4);
            _grid[temp.X,temp.Y].Weight = weight;
            _grid[temp.X, temp.Y].Type = CellType.Empty;
            _grid[temp.X, temp.Y].Coord = new Point(temp.X, temp.Y);

            SetStartAndEnd();
        }
        public void changeEndPoint(Point p)
        {
            Point temp = new Point(endPoint.X, endPoint.Y);
            endPoint = new Point(p.X, p.Y);
            Random rand = new Random();
            int weight = rand.Next(1, 4);
            _grid[temp.X, temp.Y].Weight = weight;
            _grid[temp.X, temp.Y].Type = CellType.Empty;
            _grid[temp.X, temp.Y].Coord = new Point(temp.X, temp.Y);

            SetStartAndEnd();
        }
    }
}
