using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MazeSolver
{
    abstract class AlgorithmBase
    {
        protected readonly Grid Grid;
        protected readonly List<Node> Closed;
        protected List<Point> Path;
        protected readonly Point Origin;
        protected readonly Point Destination;
        protected int Id;
        protected Node CurrentNode;
        protected int Operations;
        public string AlgorithmName;

        protected AlgorithmBase(Grid grid)
        {
            Grid = grid;
            Closed = new List<Node>();
            Origin = Grid.GetStart().Coord;
            Destination = Grid.GetEnd().Coord;
            Operations = 0;
            Id = 1;
        }

        public abstract Details getDetails();
        public abstract Details GetPathTick();
        protected List<Point> GetNeighbours(Node current)
        {
            int[] x=new int[4]{-1,0,1,0 };
            int[] y = new int[4] { 0, -1,0,1 };
            List<Point> neighbours = new List<Point>();
            for (int i = 0; i < 4; i++)
            {
                int posX = current.Coord.X + x[i];
                int posY = current.Coord.Y + y[i];
                Cell c = Grid.GetCell(posX, posY);
                if (c.Type == CellType.Invalid || c.Type == CellType.Wall)
                    continue;
                neighbours.Add(c.Coord);
            }
            return neighbours;
        }

        protected int getManhattenDistance(Point origin, Point destination)
        {
            return Math.Abs(origin.X - destination.X) + Math.Abs(origin.Y - destination.Y);
        }

        protected int GetPathCost()
        {
            if (Path == null) return 0;
            int cost = 0;
            foreach (var step in Path)
                cost += Grid.GetCell(step.X, step.Y).Weight;
            return cost;
        }
    }
}
