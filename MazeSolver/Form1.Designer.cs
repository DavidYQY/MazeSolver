namespace MazeSolver
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.reGenerate = new System.Windows.Forms.Button();
            this.infoLabel = new MetroFramework.Controls.MetroLabel();
            this.m_tabControl = new MetroFramework.Controls.MetroTabControl();
            this.alANDmap = new MetroFramework.Controls.MetroTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.changeEndButton = new System.Windows.Forms.RadioButton();
            this.changeStartButton = new System.Windows.Forms.RadioButton();
            this.decreaseWall = new System.Windows.Forms.RadioButton();
            this.addWall = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.refresh = new System.Windows.Forms.Button();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.start = new MetroFramework.Controls.MetroButton();
            this.AlGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AstarButton = new MetroFramework.Controls.MetroCheckBox();
            this.DFSButton = new MetroFramework.Controls.MetroCheckBox();
            this.BFSButton = new MetroFramework.Controls.MetroCheckBox();
            this.GreedyButton = new MetroFramework.Controls.MetroCheckBox();
            this.DijkstrasButton = new MetroFramework.Controls.MetroCheckBox();
            this.Theme = new System.Windows.Forms.TabPage();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.result = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.trackBar = new MetroFramework.Controls.MetroTrackBar();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.myPicBox = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._pathTimer = new System.Windows.Forms.Timer(this.components);
            this.m_tabControl.SuspendLayout();
            this.alANDmap.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.AlGroup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Theme.SuspendLayout();
            this.result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reGenerate
            // 
            this.reGenerate.Location = new System.Drawing.Point(10, 392);
            this.reGenerate.Name = "reGenerate";
            this.reGenerate.Size = new System.Drawing.Size(203, 180);
            this.reGenerate.TabIndex = 4;
            this.reGenerate.Text = "自动随机生成地图";
            this.reGenerate.UseVisualStyleBackColor = true;
            this.reGenerate.Click += new System.EventHandler(this.reGenerate_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(1022, 698);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(107, 19);
            this.infoLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.infoLabel.TabIndex = 9;
            this.infoLabel.Text = "这是提示信息哦";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_tabControl
            // 
            this.m_tabControl.Controls.Add(this.alANDmap);
            this.m_tabControl.Controls.Add(this.Theme);
            this.m_tabControl.Controls.Add(this.result);
            this.m_tabControl.Location = new System.Drawing.Point(1022, 51);
            this.m_tabControl.Name = "m_tabControl";
            this.m_tabControl.SelectedIndex = 0;
            this.m_tabControl.Size = new System.Drawing.Size(608, 644);
            this.m_tabControl.TabIndex = 1;
            this.m_tabControl.UseSelectable = true;
            // 
            // alANDmap
            // 
            this.alANDmap.Controls.Add(this.reGenerate);
            this.alANDmap.Controls.Add(this.groupBox1);
            this.alANDmap.Controls.Add(this.start);
            this.alANDmap.Controls.Add(this.AlGroup);
            this.alANDmap.HorizontalScrollbarBarColor = true;
            this.alANDmap.HorizontalScrollbarHighlightOnWheel = false;
            this.alANDmap.HorizontalScrollbarSize = 10;
            this.alANDmap.Location = new System.Drawing.Point(4, 38);
            this.alANDmap.Name = "alANDmap";
            this.alANDmap.Size = new System.Drawing.Size(600, 602);
            this.alANDmap.TabIndex = 0;
            this.alANDmap.Text = "选择算法和设置地图";
            this.alANDmap.VerticalScrollbarBarColor = true;
            this.alANDmap.VerticalScrollbarHighlightOnWheel = false;
            this.alANDmap.VerticalScrollbarSize = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(0, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 160);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "绘制地图";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 86);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "手动绘制地图";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel3.Controls.Add(this.changeEndButton, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.changeStartButton, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.decreaseWall, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.addWall, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(585, 59);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // changeEndButton
            // 
            this.changeEndButton.AutoSize = true;
            this.changeEndButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeEndButton.Location = new System.Drawing.Point(441, 3);
            this.changeEndButton.Name = "changeEndButton";
            this.changeEndButton.Size = new System.Drawing.Size(141, 53);
            this.changeEndButton.TabIndex = 13;
            this.changeEndButton.TabStop = true;
            this.changeEndButton.Text = "改变目标点";
            this.changeEndButton.UseVisualStyleBackColor = true;
            // 
            // changeStartButton
            // 
            this.changeStartButton.AutoSize = true;
            this.changeStartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeStartButton.Location = new System.Drawing.Point(295, 3);
            this.changeStartButton.Name = "changeStartButton";
            this.changeStartButton.Size = new System.Drawing.Size(140, 53);
            this.changeStartButton.TabIndex = 2;
            this.changeStartButton.TabStop = true;
            this.changeStartButton.Text = "改变起始点";
            this.changeStartButton.UseVisualStyleBackColor = true;
            // 
            // decreaseWall
            // 
            this.decreaseWall.AutoSize = true;
            this.decreaseWall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decreaseWall.Location = new System.Drawing.Point(149, 3);
            this.decreaseWall.Name = "decreaseWall";
            this.decreaseWall.Size = new System.Drawing.Size(140, 53);
            this.decreaseWall.TabIndex = 1;
            this.decreaseWall.TabStop = true;
            this.decreaseWall.Text = "减少墙壁";
            this.decreaseWall.UseVisualStyleBackColor = true;
            // 
            // addWall
            // 
            this.addWall.AutoSize = true;
            this.addWall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addWall.Location = new System.Drawing.Point(3, 3);
            this.addWall.Name = "addWall";
            this.addWall.Size = new System.Drawing.Size(140, 53);
            this.addWall.TabIndex = 0;
            this.addWall.TabStop = true;
            this.addWall.Text = "增加墙壁";
            this.addWall.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.refresh, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.HeightBox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.WidthBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(591, 37);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // refresh
            // 
            this.refresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refresh.Location = new System.Drawing.Point(475, 3);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(113, 31);
            this.refresh.TabIndex = 12;
            this.refresh.Text = "确认更改";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // HeightBox
            // 
            this.HeightBox.AcceptsReturn = true;
            this.HeightBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeightBox.Location = new System.Drawing.Point(357, 3);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(112, 28);
            this.HeightBox.TabIndex = 3;
            this.HeightBox.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(239, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "地图高度";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "地图宽度";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WidthBox
            // 
            this.WidthBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WidthBox.Location = new System.Drawing.Point(121, 3);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(112, 28);
            this.WidthBox.TabIndex = 1;
            this.WidthBox.Text = "15";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(280, 392);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(299, 169);
            this.start.TabIndex = 11;
            this.start.Text = "开始";
            this.start.UseSelectable = true;
            this.start.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // AlGroup
            // 
            this.AlGroup.BackColor = System.Drawing.Color.Transparent;
            this.AlGroup.Controls.Add(this.tableLayoutPanel1);
            this.AlGroup.Location = new System.Drawing.Point(3, 20);
            this.AlGroup.Name = "AlGroup";
            this.AlGroup.Size = new System.Drawing.Size(594, 154);
            this.AlGroup.TabIndex = 10;
            this.AlGroup.TabStop = false;
            this.AlGroup.Text = "选择算法";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.AstarButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DFSButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BFSButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GreedyButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DijkstrasButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(588, 127);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // AstarButton
            // 
            this.AstarButton.AutoSize = true;
            this.AstarButton.Checked = true;
            this.AstarButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AstarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AstarButton.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.AstarButton.Location = new System.Drawing.Point(3, 87);
            this.AstarButton.Name = "AstarButton";
            this.AstarButton.Size = new System.Drawing.Size(288, 37);
            this.AstarButton.TabIndex = 4;
            this.AstarButton.Text = "AStar";
            this.AstarButton.UseSelectable = true;
            // 
            // DFSButton
            // 
            this.DFSButton.AutoSize = true;
            this.DFSButton.Checked = true;
            this.DFSButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DFSButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DFSButton.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.DFSButton.Location = new System.Drawing.Point(297, 3);
            this.DFSButton.Name = "DFSButton";
            this.DFSButton.Size = new System.Drawing.Size(288, 36);
            this.DFSButton.TabIndex = 1;
            this.DFSButton.Text = "DFS";
            this.DFSButton.UseSelectable = true;
            // 
            // BFSButton
            // 
            this.BFSButton.AutoSize = true;
            this.BFSButton.Checked = true;
            this.BFSButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BFSButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BFSButton.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.BFSButton.Location = new System.Drawing.Point(3, 3);
            this.BFSButton.Name = "BFSButton";
            this.BFSButton.Size = new System.Drawing.Size(288, 36);
            this.BFSButton.TabIndex = 0;
            this.BFSButton.Text = "BFS";
            this.BFSButton.UseSelectable = true;
            // 
            // GreedyButton
            // 
            this.GreedyButton.AutoSize = true;
            this.GreedyButton.Checked = true;
            this.GreedyButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GreedyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GreedyButton.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.GreedyButton.Location = new System.Drawing.Point(297, 45);
            this.GreedyButton.Name = "GreedyButton";
            this.GreedyButton.Size = new System.Drawing.Size(288, 36);
            this.GreedyButton.TabIndex = 3;
            this.GreedyButton.Text = "Greedy";
            this.GreedyButton.UseSelectable = true;
            // 
            // DijkstrasButton
            // 
            this.DijkstrasButton.AutoSize = true;
            this.DijkstrasButton.Checked = true;
            this.DijkstrasButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DijkstrasButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DijkstrasButton.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.DijkstrasButton.Location = new System.Drawing.Point(3, 45);
            this.DijkstrasButton.Name = "DijkstrasButton";
            this.DijkstrasButton.Size = new System.Drawing.Size(288, 36);
            this.DijkstrasButton.TabIndex = 2;
            this.DijkstrasButton.Text = "Dijstras";
            this.DijkstrasButton.UseSelectable = true;
            // 
            // Theme
            // 
            this.Theme.Controls.Add(this.metroTile1);
            this.Theme.Location = new System.Drawing.Point(4, 38);
            this.Theme.Name = "Theme";
            this.Theme.Size = new System.Drawing.Size(600, 602);
            this.Theme.TabIndex = 3;
            this.Theme.Text = "界面风格";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTile1.Location = new System.Drawing.Point(0, 0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(600, 602);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "点击切换颜色风格";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // result
            // 
            this.result.Controls.Add(this.metroLabel1);
            this.result.Controls.Add(this.trackBar);
            this.result.Controls.Add(this.table);
            this.result.HorizontalScrollbarBarColor = true;
            this.result.HorizontalScrollbarHighlightOnWheel = false;
            this.result.HorizontalScrollbarSize = 10;
            this.result.Location = new System.Drawing.Point(4, 38);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(600, 602);
            this.result.TabIndex = 1;
            this.result.Text = "结果展示";
            this.result.VerticalScrollbarBarColor = true;
            this.result.VerticalScrollbarHighlightOnWheel = false;
            this.result.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroLabel1.Location = new System.Drawing.Point(0, 481);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(219, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "调整程序运行快慢（越左边越快）";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.Color.Transparent;
            this.trackBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBar.Location = new System.Drawing.Point(0, 500);
            this.trackBar.Maximum = 50;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(600, 102);
            this.trackBar.TabIndex = 3;
            this.trackBar.Text = "程序运行快慢";
            this.trackBar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.trackBar.Value = 25;
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.Transparent;
            this.table.ColumnCount = 3;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table.Dock = System.Windows.Forms.DockStyle.Top;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 2;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.Size = new System.Drawing.Size(600, 114);
            this.table.TabIndex = 2;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // myPicBox
            // 
            this.myPicBox.Location = new System.Drawing.Point(23, 51);
            this.myPicBox.Name = "myPicBox";
            this.myPicBox.Size = new System.Drawing.Size(970, 661);
            this.myPicBox.TabIndex = 0;
            this.myPicBox.TabStop = false;
            this.myPicBox.Click += new System.EventHandler(this.myPicBox_Click);
            // 
            // _pathTimer
            // 
            this._pathTimer.Enabled = true;
            this._pathTimer.Interval = 5;
            this._pathTimer.Tick += new System.EventHandler(this._pathTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1653, 754);
            this.Controls.Add(this.myPicBox);
            this.Controls.Add(this.m_tabControl);
            this.Controls.Add(this.infoLabel);
            this.Name = "Form1";
            this.StyleManager = this.metroStyleManager;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.m_tabControl.ResumeLayout(false);
            this.alANDmap.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.AlGroup.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Theme.ResumeLayout(false);
            this.result.ResumeLayout(false);
            this.result.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button reGenerate;
        private MetroFramework.Controls.MetroLabel infoLabel;
        private MetroFramework.Controls.MetroTabControl m_tabControl;
        private MetroFramework.Controls.MetroTabPage alANDmap;
        private MetroFramework.Controls.MetroTabPage result;
        private System.Windows.Forms.PictureBox myPicBox;
        private System.Windows.Forms.GroupBox AlGroup;
        private MetroFramework.Controls.MetroCheckBox BFSButton;
        private MetroFramework.Controls.MetroCheckBox GreedyButton;
        private MetroFramework.Controls.MetroCheckBox DijkstrasButton;
        private MetroFramework.Controls.MetroCheckBox DFSButton;
        private MetroFramework.Controls.MetroButton start;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroCheckBox AstarButton;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.TabPage Theme;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton addWall;
        private System.Windows.Forms.RadioButton decreaseWall;
        private System.Windows.Forms.RadioButton changeStartButton;
        private System.Windows.Forms.RadioButton changeEndButton;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.BindingSource bindingSource1;
        private MetroFramework.Controls.MetroTrackBar trackBar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Timer _pathTimer;
    }
}

