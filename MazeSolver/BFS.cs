using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Collections.Concurrent;

namespace MazeSolver
{
    class BFS:AlgorithmBase
    {
        private ConcurrentQueue<Node> _q ;
        bool _destinationFound = false;
        bool _isDead = false;
        public BFS(Grid grid) : base(grid)
        {
            AlgorithmName = "Broad-First Search";
            _q = new ConcurrentQueue<Node>();
            _q.Enqueue(new Node(Id++,null,Origin,0,0)); Closed.Clear();
        }

        public override Details GetPathTick()
        {
            
            if (_q.Count > 0 && !_destinationFound)
            {
                if(_q.TryDequeue(out CurrentNode))
                {
                    //if (AlreadyVisted(CurrentNode.Coord)) return getDetails();
                    Closed.Add(CurrentNode);
                    //Console.WriteLine(CurrentNode.Coord.X + " " + CurrentNode.Coord.Y);
                    //Console.WriteLine(Destination.X + "," + Destination.Y);
                    if (CurrentNode.Coord.Equals(Destination))
                    {
                        _destinationFound = true;
                        return getDetails();
                    }

                    Grid.SetCell(CurrentNode.Coord, CellType.Closed);
                    List<Point> neighbours = GetNeighbours(CurrentNode);
                    foreach (Point neighbour in neighbours)
                    {
                        if (AlreadyVisted2(neighbour)) continue;
                        Node neighbourNode = new Node(Id++, CurrentNode.Id, neighbour, 0, 0);

                        _q.Enqueue(neighbourNode);
                        Grid.SetCell(neighbour, CellType.Open);
                    }
                }
            }
            else if(_destinationFound)
            {
               // Console.WriteLine("?"+_q.Count+","+_destinationFound);
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
                catch(Exception)
                {
                    Console.WriteLine("未知错误");
                }

            }
            else if(_q.Count==0)
            {
                Console.WriteLine(_q.Count);
                _isDead = true;
            }
            else
            {
                Console.WriteLine("未知错误");
            }
          
            
            return getDetails();
            
        }


        private bool AlreadyVisted(Point p)
        {
            foreach(Node p2 in Closed)
            {
                if (p2.Coord.Equals(p))
                    return true;
            }
            return false;
        }

        private bool AlreadyVisted2(Point p)
        {
            foreach (Node p2 in _q)
            {
                if (p2.Coord.Equals(p))
                    return true;
            }
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
                OpenListSize = _q.Count,
                ClosedListSize = Closed.Count,
                UnexploredListSize = Grid.GetCountOfType(CellType.Empty),
                Operations = Operations++,
                isFound = _destinationFound,
                isDead = _isDead
            };
        }
    }
}
