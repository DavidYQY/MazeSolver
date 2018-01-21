using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MazeSolver
{
    class Astar:AlgorithmBase
    {
        private List<Node> _open;
        bool _destinationFound = false;
        bool _isDead = false;
        public Astar(Grid grid) : base(grid) {
            _open = new List<Node>();
            this.AlgorithmName = "Astar";
            CurrentNode = new Node(Id++, null, Origin, 0, getManhattenDistance(Origin, Destination));
            _open.Add(CurrentNode);
            Closed.Clear();
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
                    if (Grid.GetCell(neighbour).Type != CellType.Closed &&
                         Grid.GetCell(neighbour).Type != CellType.Start)
                    {
                        int GridWeight = Grid.GetCell(neighbour).Weight;
                        update(neighbour, CurrentNode.G, GridWeight);
                    }
                }
                


                if (CurrentNode.Coord.Equals(Destination))//end
                {
                    _destinationFound = true;
                    Closed.Add(CurrentNode);
                    Grid.SetCell(CurrentNode.Coord, CellType.Closed);

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

        private void update(Point p, int weight, int GridWeight)//update the weight of p,add to the openlist if needed
        {
            Node n = myFirstOrDefault(p);
            if (n == null)
            {
                _open.Add(new Node(Id++, CurrentNode.Id, p, weight + GridWeight, getManhattenDistance(p,Destination)));
                Grid.SetCell(p, CellType.Open);
            }
            else
            {
                if (n.G > weight + GridWeight)
                {
                    n.G = weight + GridWeight;
                    n.H= getManhattenDistance(n.Coord, Destination);
                    n.F = n.G + n.H;
                    n.ParentId = CurrentNode.Id;
                }
            }
        }
        private Node myFirstOrDefault(Point p)
        {
            for (int i = 0; i < _open.Count; i++)
            {
                if (_open.ElementAt(i).Coord.Equals(p))
                {
                    return _open.ElementAt(i);
                }
            }
            return null;
        }
    }
}
