using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
namespace MazeSolver
{
    public partial class Form1 :MetroForm
    {
        private MazeDrawer _mazeDrawer;
        const int al_maxNum = 5;
        const int tableHeight = 40;
        private const int Delay = 6;
        private AlgorithmBase[] _algorithms;
        private Label[,] Labels;
        // private BFS test;
        private DFS test;
        bool noRoad = false;
        int al_id = 0;
        int al_num = 5;
        int currentLine = 0;
        int minClosed, minPathCost;
        bool pathFlag = false;
        int pathId = 0;
        
        Grid currentGrid;


        public Form1()
        {
            InitializeComponent();
            _mazeDrawer = new MazeDrawer(myPicBox);
            //_pathTimer = new System.Windows.Forms.Timer();
            //_pathTimer.Tick += PathTimer_Elapsed;
            _pathTimer.Enabled=false;
            test = new DFS(_mazeDrawer.Grid);
            _mazeDrawer.Draw();

            _algorithms = new AlgorithmBase[5];
            currentGrid = new Grid(_mazeDrawer.Grid);
            CheckForIllegalCrossThreadCalls = false;
        }

        private void PathTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            initLabels();
            initTable();

            m_tabControl.SelectedTab = alANDmap;
        }


        private void reset()
        {
            _mazeDrawer.Change(currentGrid);
        }

        private void reGenerate_Click(object sender, EventArgs e)
        {
            currentGrid.Randomize();
            _mazeDrawer.Change(currentGrid);
            _mazeDrawer.Draw();
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            infoLabel.Text = "很好，你已经开始乱搞了";
            reset();
            _mazeDrawer.Draw();
            bool Conti = true;
            noRoad = false;
            if (!isConnected())
            {
                var r = MessageBox.Show("不存在通路，是否继续", "请确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (r == DialogResult.Cancel)
                    Conti = false;
                noRoad = true;
            }
            if (Conti)
            {
                al_num = 0;
                if (BFSButton.Checked)
                    _algorithms[al_num++] = new BFS(_mazeDrawer.Grid);
                if (DFSButton.Checked)
                    _algorithms[al_num++] = new DFS(_mazeDrawer.Grid);
                if (DijkstrasButton.Checked)
                    _algorithms[al_num++] = new Dijkstras(_mazeDrawer.Grid);
                if (GreedyButton.Checked)
                    _algorithms[al_num++] = new greedy(_mazeDrawer.Grid);
                if (AstarButton.Checked)
                    _algorithms[al_num++] = new Astar(_mazeDrawer.Grid);
                if (al_num == 0)
                {
                    MessageBox.Show("请选择一个算法！", "请确认", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                reGenerate.Enabled = false;
                refresh.Enabled = false;
                start.Enabled = false;
                m_tabControl.SelectedTab = result;
                al_id = 0;
                infoLabel.Text = "正在执行" + _algorithms[al_id].AlgorithmName + "算法";
                minClosed = int.MaxValue;
                minPathCost = int.MaxValue;
                clearLabels();
                initTable();
                addLine(_algorithms[al_id].AlgorithmName);
                _pathTimer.Enabled=true;
            }

            
        }

        private void updateResult(Details d)
        {
            Labels[currentLine, 1].Text = d.OpenListSize.ToString();
            Labels[currentLine, 2].Text = d.ClosedListSize.ToString();
            Labels[currentLine, 3].Text = d.PathCost.ToString();
        }
        private void updateResult(Details d,bool flag)
        {
            Labels[currentLine, 1].Text = d.OpenListSize.ToString();
            Labels[currentLine, 2].Text = d.ClosedListSize.ToString();
            Labels[currentLine, 3].Text = "inf";
        }
        private void updateChampion()
        {
            try
            {
                int closed = Convert.ToInt32(Labels[currentLine, 2].Text);
                int PathCost = Convert.ToInt32(Labels[currentLine, 3].Text);
                if (closed <= minClosed)
                {
                    Labels[currentLine, 2].BackColor = System.Drawing.Color.SpringGreen;
                    minClosed = closed;
                    for (int j = 1; j <= currentLine; j++)
                    {
                        int closed2 = Convert.ToInt32(Labels[j, 2].Text);
                        if (closed2 > minClosed)
                        {
                            Labels[j, 2].BackColor = System.Drawing.Color.Transparent;
                        }
                    }
                }
                if (PathCost <= minPathCost)
                {
                    Labels[currentLine, 3].BackColor = System.Drawing.Color.SpringGreen;
                    minPathCost = PathCost;
                    for (int j = 1; j <= currentLine; j++)
                    {
                        try
                        {
                            int pathCost2 = Convert.ToInt32(Labels[j, 3].Text);
                            if (pathCost2 > minPathCost)
                            {
                                Labels[j, 3].BackColor = System.Drawing.Color.Transparent;
                            }
                        }
                        catch (Exception)
                        {
                        }

                    }
                }
            }
            catch (Exception)
            {

            }




        }
        private void addLine(String name)
        {
            table.RowCount++;
            table.Height = table.RowCount * tableHeight;
            table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, tableHeight));
            table.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            currentLine = table.RowCount-1;
            Labels[currentLine, 0].Text = name;
            this.Invoke(new EventHandler(delegate
            {
                table.Controls.Add(Labels[currentLine, 0], 0, currentLine);
                for (int j = 1; j < table.ColumnCount; j++)
                    table.Controls.Add(Labels[currentLine, j], j, currentLine);
            }));
            

        }
        private void initLabels()
        {
            Labels = new Label[al_maxNum+1, 4];
            for (int i = 0; i < al_maxNum+1;i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Labels[i, j] = new Label();
                    Labels[i, j].Text = "0";
                    Labels[i,j].Dock = System.Windows.Forms.DockStyle.Fill;
                    Labels[i, j].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    Labels[i, j].Anchor = AnchorStyles.Left | AnchorStyles.Right;
                    Labels[i,j].Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                }
            }
        }
        private void initTable()
        {
            table.Controls.Clear();
            table.RowCount = 1;
            table.ColumnCount = 4;
            table.Height = table.RowCount * tableHeight;
            float step = (float)100.0 / table.ColumnCount;
            for (int ii = 0; ii < table.ColumnCount; ii++)
            {
                table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, step));
            }
            for (int ii = 0; ii < table.RowCount; ii++)
            {
                table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, tableHeight));
            }
            table.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            Labels[0, 0].Text = "算法名称";
            table.Controls.Add(Labels[0, 0], 0, 0);

            Labels[0, 1].Text = "Open表";
            table.Controls.Add(Labels[0, 1], 1, 0);

            Labels[0, 2].Text = "Close表";
            table.Controls.Add(Labels[0, 2], 2, 0);

            Labels[0, 3].Text = "路径长度";
            table.Controls.Add(Labels[0, 3], 3, 0);
        }

        private void night_CheckedChanged(object sender, EventArgs e)
        {
            metroStyleManager.Theme = metroStyleManager.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            var m = new Random();
            int next = m.Next(0, 13);
            metroStyleManager.Style = (MetroColorStyle)next;
        }


        private void myPicBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseLoc = (MouseEventArgs)e;
            int _cellWidth = myPicBox.Width / currentGrid.hCells;
            int _cellHeight = myPicBox.Height / currentGrid.vCells;
            int x = mouseLoc.X / _cellWidth;
            int y = mouseLoc.Y / _cellHeight;
            if (addWall.Checked)
            {
                currentGrid.SetCell(x, y, CellType.Wall);
                _mazeDrawer.Change(currentGrid);
                _mazeDrawer.Draw();
            }
            if (decreaseWall.Checked)
            {
                currentGrid.SetCell(x, y, CellType.Empty);
                Random rand = new Random();
                int weight = rand.Next(1, 4);
                Cell C = new Cell();
                C.Coord = new Point(x, y);
                C.Type = CellType.Empty;
                C.Weight = weight;
                currentGrid.SetCell(x, y, C);
                _mazeDrawer.Change(currentGrid);
                _mazeDrawer.Draw();
            }
            if (changeStartButton.Checked)
            {
                currentGrid.changeStartPoint(new Point(x, y));
                _mazeDrawer.Change(currentGrid);
                _mazeDrawer.Draw();
            }
            if (changeEndButton.Checked)
            {
                currentGrid.changeEndPoint(new Point(x, y));
                _mazeDrawer.Change(currentGrid);
                _mazeDrawer.Draw();
            }
            

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            int width = 0, height = 0;
            try
            {
                width = Convert.ToInt32(WidthBox.Text);
                height = Convert.ToInt32(HeightBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("你输入了非法的字符！请重新输入");
                return;
            }
            if(width<5 || height<5)
            {
                MessageBox.Show("宽度不得小于5，高度不得小于5！");
                return;
            }
            if(width>30 || height > 20)
            {
                var r = MessageBox.Show("宽度建议不超过30，高度建议不超过20，否则难以看清（当然硬要大于也是可以运行的），是否继续？", "请确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (r == DialogResult.Cancel)
                    return;
            }
            currentGrid = new Grid(width, height);
            currentGrid.Randomize();
            _mazeDrawer.Change(currentGrid);
            _mazeDrawer.Draw();
        }

        private void clearLabels()
        {
            for (int i = 0; i < al_maxNum + 1; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Labels[i, j].Text = "0";
                    Labels[i, j].BackColor = System.Drawing.Color.Transparent;
                }
            }
        }

        private void _pathTimer_Tick(object sender, EventArgs e)
        {
            _pathTimer.Enabled = false;
            if (al_id < al_num)
            {

                var searchStatus = _algorithms[al_id].GetPathTick();
                updateResult(searchStatus);

                //searchStatus.print();
                
                if (!searchStatus.isDead)
                {
                    if (searchStatus.PathFound)
                    {
                        pathFlag = true;

                        for (int i = 1; i < searchStatus.Path.Length - 1; i++)
                        {
                            Point step = searchStatus.Path[i];
                            _mazeDrawer.Grid.SetCell(step, CellType.Path);
                            //Console.WriteLine(i);
                            _mazeDrawer.Draw();
                            Application.DoEvents();
                            System.Threading.Thread.Sleep(trackBar.Value/2);
                        }
                        
                        infoLabel.Text = _algorithms[al_id].AlgorithmName + "完成！";
                        updateChampion();
                        System.Threading.Thread.Sleep(1000);
                        al_id++;
                        if (al_id < al_num)
                        {
                            addLine(_algorithms[al_id].AlgorithmName);
                            infoLabel.Text = "正在执行" + _algorithms[al_id].AlgorithmName + "算法";
                            reset();

                        }
                    }
                    else
                    {
                        pathFlag = false;
                        System.Threading.Thread.Sleep(trackBar.Value);
                        _mazeDrawer.Draw();
                    }
                        
                }
                else
                {
                    if (noRoad)
                    {
                        updateResult(searchStatus, true);
                        infoLabel.Text = _algorithms[al_id].AlgorithmName + "没找到！";
                        // System.Threading.Thread.Sleep(1000);
                        al_id++;
                        if (al_id < al_num)
                        {
                            addLine(_algorithms[al_id].AlgorithmName);
                            infoLabel.Text = "正在执行" + _algorithms[al_id].AlgorithmName + "算法";
                            reset();
                        }
                    }
                    else
                    {
                        updateResult(searchStatus, true);
                        infoLabel.Text = _algorithms[al_id].AlgorithmName + "没找到！";
                        al_id += 1;
                        if (al_id < al_num)
                        {
                            addLine(_algorithms[al_id].AlgorithmName);
                            infoLabel.Text = "正在执行" + _algorithms[al_id].AlgorithmName + "算法";
                            reset();
                        }
                    }

                }



                _pathTimer.Enabled = true; 
            }
            else
            {
                _pathTimer.Enabled = false;
                infoLabel.Text = "执行结束";
                start.Enabled = true;
                refresh.Enabled = true;
                reGenerate.Enabled = true;
            }
        }

        private bool isConnected()
        {
            var testMazeDrawer = new MazeDrawer(myPicBox);
            testMazeDrawer.Change(currentGrid);
            var testPathFinder = new DFS(testMazeDrawer.Grid);
            var progress = testPathFinder.GetPathTick();
            while (!progress.isDead && !progress.PathFound)
            {
                progress = testPathFinder.GetPathTick();
            }
            if (progress.isDead) return false;
            return true;
        }

    }
}
