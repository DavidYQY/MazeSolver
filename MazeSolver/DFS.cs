using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MazeSolver
{
    class DFS:AlgorithmBase
    {
        Stack<Node> _stack;
        bool _destinationFound = false;
        bool _isDead = false;
        public DFS(Grid grid) : base(grid)
        {
            AlgorithmName = "Depth-First Search";
            _stack = new Stack<Node>();
            _stack.Push(new Node(Id++, null, Origin, 0, 0)); Closed.Clear();
        }
        public override Details GetPathTick()
        {
            if(_stack.Count>0 && !_destinationFound)
            {
                CurrentNode = _stack.Pop();
                if (AlreadyVisted(CurrentNode.Coord)) return getDetails();
                Closed.Add(CurrentNode);
                Grid.SetCell(CurrentNode.Coord, CellType.Closed);
                if (CurrentNode.Coord.Equals(Destination))
                {
                    _destinationFound = true;

                }
                List<Point> neighbours = GetNeighbours(CurrentNode);
                foreach (Point neighbour in neighbours)
                {
                     
                    if (!AlreadyVisted(neighbour))
                    {
                        _stack.Push(new Node(Id++, CurrentNode.Id, neighbour, 0, 0));
                        Grid.SetCell(neighbour, CellType.Open);
                    }
                        
                }
                
            }
            else if (_destinationFound)
            {
                Console.WriteLine("?" + _stack.Count + "," + _destinationFound);
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

        private bool AlreadyVisted(Point p)
        {
            foreach (Node p2 in Closed)
            {
                if (p2.Coord.Equals(p))
                    return true;
            }
            return false;
        }

        public override Details getDetails()
        {
            return new Details
            {
                Path = Path?.ToArray(),
                PathCost = GetPathCost(),
                LastNode = CurrentNode,
                DistanceOfCurrentNode = CurrentNode == null ? 0 : getManhattenDistance(CurrentNode.Coord, Destination),
                OpenListSize = _stack.Count,
                ClosedListSize = Closed.Count,
                UnexploredListSize = Grid.GetCountOfType(CellType.Empty),
                Operations = Operations++,
                isFound = _destinationFound,
                isDead = _isDead
            };
        }
    }
}
