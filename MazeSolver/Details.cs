using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MazeSolver
{
    class Details
    {
        public bool PathPossible => PathFound || OpenListSize > 0;
        public bool PathFound => Path != null;
        public Point[] Path { get; set; }
        public int PathCost { get; set; }
        public Node LastNode { get; set; }
        public int DistanceOfCurrentNode { get; set; }
        public int OpenListSize { get; set; }
        public int ClosedListSize { get; set; }
        public int UnexploredListSize { get; set; }
        public int Operations { get; set; }
        public bool isFound { get; set; }
        public bool isDead { get; set; }
        public void print()
        {
            string s = "";
            s += "PathCost:" + PathCost + "\n";
           // s += "LastNode:(" + LastNode.Coord.X + ","+LastNode.Coord.Y+")"+"\n";
            s += "DistanceOfCurrentNode:" + DistanceOfCurrentNode + "\n";
            s += "OpenListSize:" + OpenListSize + "\n";
            s += "ClosedListSize:" + ClosedListSize + "\n";
            s += "UnexploredListSize:" + UnexploredListSize + "\n";
            s += "Operations:" + Operations + "\n";
            s += "isFound" + isFound + "\n";
            Console.WriteLine(s);
        }
    }
}
