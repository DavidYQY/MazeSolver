﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MazeSolver
{
    class Node
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public Point Coord { get; set; }
        public int F { get; set; }
        public int G { get; set; }
        public int H { get; set; }
        public Node(int id, int? parentId, int x, int y, int g, int h)
        {
            Id = id;
            ParentId = parentId;
            Coord = new Point(x, y);
            G = g;
            H = h;
            F = G + H;
        }

        public Node(int id, int? parentId, Point coord, int g, int h)
        {
            Id = id;
            ParentId = parentId;
            Coord = coord;
            G = g;
            H = h;
            F = G + H;
        }
    }


}
