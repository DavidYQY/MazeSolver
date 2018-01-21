using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MazeSolver
{
    class greedy:AlgorithmBase
    {
        private List<Node> _open;
        bool _destinationFound = false;
        bool _isDead = false;
        public greedy(Grid grid) : base(grid) {
            _open = new List<Node>();
            CurrentNode = new Node(Id++, null, Origin, 0, getManhattenDistance(Origin, Destination));
            _open.Add(CurrentNode);
            Closed.Clear();
            this.AlgorithmName = "Greedy";

        }
        public override Details getDetails()
        {
            return new Details
            {
                Path = Path?.ToArray(),
                PathCost = GetPathCost(),
                LastNode = CurrentNode,
                DistanceOfCurrentNode = CurrentNode == null ? 0 : getManhattenDistance(CurrentNode.Coord, Destination),
                OpenListSize = _open.Count,
                ClosedListSize = Closed.Count,
                UnexploredListSize = Grid.GetCountOfType(CellType.Empty),
                Operations = Operations++,
                isFound = _destinationFound,
                isDead = _isDead
            };
        }

        public override Details GetPathTick()
        {
            if (_open.Count > 0 && !_destinationFound)
            {
                CurrentNode = _open.OrderBy(x => x.F).First();
                _open.Remove(CurrentNode);
                List<Point> neighbours = GetNeighbours(CurrentNode);
                foreach (Point neighbour in neighbours)
                {
                    if (Grid.GetCell(neighbour).Type != CellType.Start &&
                        Grid.GetCell(neighbour).Type != CellType.Closed) 
                    {
                        update(neighbour);
                    }
                }


                if (CurrentNode.Coord.Equals(Destination))//end
                {
                    _destinationFound = true;
                    Closed.Add(CurrentNode);
                }
                else
                {
                    Closed.Add(CurrentNode);
                    Grid.SetCell(CurrentNode.Coord, CellType.Closed);
                }

            }
            else if (_destinationFound)
            {
                Path = new List<Point>();
                try
                {
                    Node step = Closed.First(x => x.Coord.Equals(Destination));
                    while (!step.Coord.Equals(Origin))
                    {
                        Path.Add(step.Coord);
                        step = Closed.First(x => x.Id == step.ParentId);
                    }
                    Path.Add(Origin);
                    Path.Reverse();
                }
                catch (Exception)
                {
                    Console.WriteLine("未知错误");
                }
            }
            else
            {
                _isDead = true;
            }
            return getDetails();
        }

        private void update(Point p)//update the weight of p,add to the openlist if needed
        {
            Node n = _open.FirstOrDefault(x => x.Coord.Equals(p));
            if (n == null)
            {
                _open.Add(new Node(Id++, CurrentNode.Id, p, 0, getManhattenDistance(p, Destination)));
                Grid.SetCell(p, CellType.Open);
            }
        }


       

    }
}
