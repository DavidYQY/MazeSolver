using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MazeSolver
{
    class MazeDrawer
    {
        private readonly PictureBox _pb;
        public Grid Grid { get; set; }
        public int Seed { get; }

        private int HorizontalCells = 15;
        private int VerticalCells = 10;

        private int _cellWidth;
        private int _cellHeight;

        public MazeDrawer(PictureBox pb, int seed = 0)
        {
            _pb = pb;
            Grid = new Grid(HorizontalCells, VerticalCells);
            if (seed == 0) seed = (int)DateTime.Now.Ticks;
            Seed = seed;
            Grid.Randomize(Seed);
        }

        public void Draw()
        {
            _cellWidth = _pb.Width / HorizontalCells;
            _cellHeight = _pb.Height / VerticalCells;

            var image = new Bitmap(_pb.Width, _pb.Height);

            using (var g = Graphics.FromImage(image))
            {
                var background = new Rectangle(0, 0, image.Width, image.Height);
                g.FillRectangle(new SolidBrush(Color.White), background);

                for (int x = 0; x < HorizontalCells; x++)
                {
                    for (int y = 0; y < VerticalCells; y++)
                    {
                        var cell = Grid.GetCell(x, y);
                        switch (cell.Type)
                        {
                            case CellType.Empty:
                                switch (cell.Weight)
                                {
                                    case 1: g.FillRectangle(Brushes.PapayaWhip, GetRectangle(x, y)); break;
                                    case 2: g.FillRectangle(Brushes.PeachPuff, GetRectangle(x, y)); break;
                                    case 3: g.FillRectangle(Brushes.Peru, GetRectangle(x, y)); break;
                                    default:
                                        g.DrawString("A", GetFont(), Brushes.Red, GetPoint(x, y)); break;//
                                }
                                break;
                            case CellType.Wall:
                                g.FillRectangle(Brushes.Black, GetRectangle(x, y));
                                break;
                            case CellType.Path:
                                //g.DrawImage(Properties.Resources.cat, GetRectangle(x, y));
                                g.FillRectangle(Brushes.Purple, GetRectangle(x, y));
                                break;
                            case CellType.Open:
                                g.FillRectangle(Brushes.LightSkyBlue, GetRectangle(x, y));
                                break;
                            case CellType.Closed:
                                g.FillRectangle(Brushes.LightSeaGreen, GetRectangle(x, y));
                                break;
                            case CellType.Current:
                                g.FillRectangle(Brushes.Crimson, GetRectangle(x, y));
                                break;
                            case CellType.Start:
                               // g.DrawString("A", GetFont(), Brushes.Red, GetPoint(x, y));
                                g.DrawImage(Properties.Resources.cat, GetRectangle(x, y));
                                break;
                            case CellType.End:
                                //g.DrawString("B", GetFont(), Brushes.Blue, GetPoint(x, y));
                                g.DrawImage(Properties.Resources.皮卡丘, GetRectangle(x, y));
                                break;
                            default:
                                throw new ArgumentOutOfRangeException("Unknown cell type: " + cell);
                        }

                        //g.DrawRectangle(Pens.Black, GetRectangle(x, y));
                    }
                }

                _pb.Image = image;
            }
        }


        private Rectangle GetRectangle(int x, int y)
        {
            return new Rectangle(x * _cellWidth, y * _cellHeight, _cellWidth, _cellHeight);
        }

        private PointF GetPoint(int x, int y)
        {
            return new PointF(x * _cellWidth, y * _cellHeight);
        }

        private Font GetFont()
        {
            return new Font(FontFamily.GenericMonospace, Math.Min(_cellWidth, _cellHeight) / 1.3f, FontStyle.Bold);
        }

        public void Change(Grid g)
        {

            if(g.hCells==HorizontalCells && g.vCells == VerticalCells)
            {
                Grid.changeStartPoint(g.GetStart().Coord);
                Grid.changeEndPoint(g.GetEnd().Coord);
                for (int x = 0; x < g.hCells; x++)
                    for (int y = 0; y < g.vCells; y++)
                        Grid.SetCell(x, y, g.GetCell(x, y));
            }
            else
            {
                HorizontalCells = g.hCells;
                VerticalCells = g.vCells;

                Grid = new Grid(HorizontalCells, VerticalCells);
                Grid.changeStartPoint(g.GetStart().Coord);
                Grid.changeEndPoint(g.GetEnd().Coord);
                for (int x = 0; x < g.hCells; x++)
                    for (int y = 0; y < g.vCells; y++)
                    {
                        Grid.SetCell(x, y, g.GetCell(x, y));    
                    }
                        
            }

        }
    }
}
