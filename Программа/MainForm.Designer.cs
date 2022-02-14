namespace Visualizer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьСценуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьСценуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видМоделиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каркаснаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.твердотельнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проецированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параллельноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.центральноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьПараметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.upleft = new System.Windows.Forms.Label();
            this.upright = new System.Windows.Forms.Label();
            this.downleft = new System.Windows.Forms.Label();
            this.downright = new System.Windows.Forms.Label();
            this.down = new System.Windows.Forms.Label();
            this.right = new System.Windows.Forms.Label();
            this.up = new System.Windows.Forms.Label();
            this.left = new System.Windows.Forms.Label();
            this.drawContainer1 = new Visualizer.DrawContainer();
            this.ObjectList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TransferZ = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.TransferY = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.TransferX = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ScaleZ = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.ScaleY = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.ScaleX = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.CameraZ = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.CameraY = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.CameraX = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.EyeZ = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.EyeY = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.EyeX = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectButton = new System.Windows.Forms.Button();
            this.rotateButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.transferButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransferZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferX)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleX)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CameraZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraX)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EyeZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EyeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EyeX)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.видМоделиToolStripMenuItem,
            this.проецированиеToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(333, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьСценуToolStripMenuItem,
            this.сохранитьСценуToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fileToolStripMenuItem.Text = "Сцена";
            // 
            // открытьСценуToolStripMenuItem
            // 
            this.открытьСценуToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.открытьСценуToolStripMenuItem.Name = "открытьСценуToolStripMenuItem";
            this.открытьСценуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.открытьСценуToolStripMenuItem.Text = "Открыть";
            this.открытьСценуToolStripMenuItem.Click += new System.EventHandler(this.открытьСценуToolStripMenuItem_Click);
            // 
            // сохранитьСценуToolStripMenuItem
            // 
            this.сохранитьСценуToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.сохранитьСценуToolStripMenuItem.Name = "сохранитьСценуToolStripMenuItem";
            this.сохранитьСценуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьСценуToolStripMenuItem.Text = "Сохранить";
            this.сохранитьСценуToolStripMenuItem.Click += new System.EventHandler(this.сохранитьСценуToolStripMenuItem_Click);
            // 
            // видМоделиToolStripMenuItem
            // 
            this.видМоделиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каркаснаяToolStripMenuItem,
            this.твердотельнаяToolStripMenuItem});
            this.видМоделиToolStripMenuItem.Name = "видМоделиToolStripMenuItem";
            this.видМоделиToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.видМоделиToolStripMenuItem.Text = "Вид";
            // 
            // каркаснаяToolStripMenuItem
            // 
            this.каркаснаяToolStripMenuItem.Name = "каркаснаяToolStripMenuItem";
            this.каркаснаяToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.каркаснаяToolStripMenuItem.Text = "Каркасная";
            this.каркаснаяToolStripMenuItem.Click += new System.EventHandler(this.каркаснаяToolStripMenuItem_Click);
            // 
            // твердотельнаяToolStripMenuItem
            // 
            this.твердотельнаяToolStripMenuItem.Name = "твердотельнаяToolStripMenuItem";
            this.твердотельнаяToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.твердотельнаяToolStripMenuItem.Text = "Твердотельная";
            this.твердотельнаяToolStripMenuItem.Click += new System.EventHandler(this.твердотельнаяToolStripMenuItem_Click);
            // 
            // проецированиеToolStripMenuItem
            // 
            this.проецированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параллельноеToolStripMenuItem,
            this.центральноеToolStripMenuItem});
            this.проецированиеToolStripMenuItem.Name = "проецированиеToolStripMenuItem";
            this.проецированиеToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.проецированиеToolStripMenuItem.Text = "Проецирование";
            // 
            // параллельноеToolStripMenuItem
            // 
            this.параллельноеToolStripMenuItem.Name = "параллельноеToolStripMenuItem";
            this.параллельноеToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.параллельноеToolStripMenuItem.Text = "Параллельное";
            this.параллельноеToolStripMenuItem.Click += new System.EventHandler(this.параллельноеToolStripMenuItem_Click);
            // 
            // центральноеToolStripMenuItem
            // 
            this.центральноеToolStripMenuItem.Name = "центральноеToolStripMenuItem";
            this.центральноеToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.центральноеToolStripMenuItem.Text = "Центральное";
            this.центральноеToolStripMenuItem.Click += new System.EventHandler(this.центральноеToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьПараметрыToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.editToolStripMenuItem.Text = "Объект";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.добавитьToolStripMenuItem.Text = "Создать";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьПараметрыToolStripMenuItem
            // 
            this.изменитьПараметрыToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.изменитьПараметрыToolStripMenuItem.Name = "изменитьПараметрыToolStripMenuItem";
            this.изменитьПараметрыToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.изменитьПараметрыToolStripMenuItem.Text = "Изменить";
            this.изменитьПараметрыToolStripMenuItem.Click += new System.EventHandler(this.изменитьПараметрыToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.upleft);
            this.panel2.Controls.Add(this.upright);
            this.panel2.Controls.Add(this.downleft);
            this.panel2.Controls.Add(this.downright);
            this.panel2.Controls.Add(this.down);
            this.panel2.Controls.Add(this.right);
            this.panel2.Controls.Add(this.up);
            this.panel2.Controls.Add(this.left);
            this.panel2.Controls.Add(this.drawContainer1);
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1654, 1048);
            this.panel2.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label18.Image = ((System.Drawing.Image)(resources.GetObject("label18.Image")));
            this.label18.Location = new System.Drawing.Point(1535, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 48);
            this.label18.TabIndex = 9;
            // 
            // upleft
            // 
            this.upleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.upleft.Image = ((System.Drawing.Image)(resources.GetObject("upleft.Image")));
            this.upleft.Location = new System.Drawing.Point(1491, 8);
            this.upleft.Name = "upleft";
            this.upleft.Size = new System.Drawing.Size(45, 45);
            this.upleft.TabIndex = 8;
            this.upleft.Click += new System.EventHandler(this.upleft_Click);
            // 
            // upright
            // 
            this.upright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.upright.Image = ((System.Drawing.Image)(resources.GetObject("upright.Image")));
            this.upright.Location = new System.Drawing.Point(1581, 8);
            this.upright.Name = "upright";
            this.upright.Size = new System.Drawing.Size(45, 45);
            this.upright.TabIndex = 7;
            this.upright.Click += new System.EventHandler(this.upright_Click);
            // 
            // downleft
            // 
            this.downleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.downleft.Image = ((System.Drawing.Image)(resources.GetObject("downleft.Image")));
            this.downleft.Location = new System.Drawing.Point(1491, 97);
            this.downleft.Name = "downleft";
            this.downleft.Size = new System.Drawing.Size(45, 45);
            this.downleft.TabIndex = 6;
            this.downleft.Click += new System.EventHandler(this.downleft_Click);
            // 
            // downright
            // 
            this.downright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.downright.Image = ((System.Drawing.Image)(resources.GetObject("downright.Image")));
            this.downright.Location = new System.Drawing.Point(1581, 97);
            this.downright.Name = "downright";
            this.downright.Size = new System.Drawing.Size(45, 45);
            this.downright.TabIndex = 5;
            this.downright.Click += new System.EventHandler(this.downright_Click);
            // 
            // down
            // 
            this.down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.down.Image = ((System.Drawing.Image)(resources.GetObject("down.Image")));
            this.down.Location = new System.Drawing.Point(1536, 97);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(45, 45);
            this.down.TabIndex = 4;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.right.Image = ((System.Drawing.Image)(resources.GetObject("right.Image")));
            this.right.Location = new System.Drawing.Point(1581, 53);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(45, 45);
            this.right.TabIndex = 3;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // up
            // 
            this.up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.up.Image = ((System.Drawing.Image)(resources.GetObject("up.Image")));
            this.up.Location = new System.Drawing.Point(1536, 8);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(45, 45);
            this.up.TabIndex = 2;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.left.Image = ((System.Drawing.Image)(resources.GetObject("left.Image")));
            this.left.Location = new System.Drawing.Point(1491, 52);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(45, 45);
            this.left.TabIndex = 1;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // drawContainer1
            // 
            this.drawContainer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.drawContainer1.Location = new System.Drawing.Point(-83, 0);
            this.drawContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.drawContainer1.Name = "drawContainer1";
            this.drawContainer1.Size = new System.Drawing.Size(1745, 1215);
            this.drawContainer1.TabIndex = 0;
            this.drawContainer1.Text = "drawContainer1";
            this.drawContainer1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawContainer1_MouseUp);
            // 
            // ObjectList
            // 
            this.ObjectList.FormattingEnabled = true;
            this.ObjectList.ItemHeight = 16;
            this.ObjectList.Location = new System.Drawing.Point(8, 70);
            this.ObjectList.Margin = new System.Windows.Forms.Padding(4);
            this.ObjectList.Name = "ObjectList";
            this.ObjectList.Size = new System.Drawing.Size(252, 180);
            this.ObjectList.TabIndex = 1;
            this.ObjectList.SelectedIndexChanged += new System.EventHandler(this.ObjectList_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TransferZ);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TransferY);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TransferX);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(56, 311);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(169, 130);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Перенос";
            // 
            // TransferZ
            // 
            this.TransferZ.DecimalPlaces = 3;
            this.TransferZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TransferZ.Location = new System.Drawing.Point(56, 89);
            this.TransferZ.Margin = new System.Windows.Forms.Padding(4);
            this.TransferZ.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TransferZ.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.TransferZ.Name = "TransferZ";
            this.TransferZ.Size = new System.Drawing.Size(97, 22);
            this.TransferZ.TabIndex = 5;
            this.TransferZ.ValueChanged += new System.EventHandler(this.TransferZ_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Z:";
            // 
            // TransferY
            // 
            this.TransferY.DecimalPlaces = 3;
            this.TransferY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TransferY.Location = new System.Drawing.Point(56, 57);
            this.TransferY.Margin = new System.Windows.Forms.Padding(4);
            this.TransferY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TransferY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.TransferY.Name = "TransferY";
            this.TransferY.Size = new System.Drawing.Size(97, 22);
            this.TransferY.TabIndex = 3;
            this.TransferY.ValueChanged += new System.EventHandler(this.TransferY_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Y:";
            // 
            // TransferX
            // 
            this.TransferX.DecimalPlaces = 3;
            this.TransferX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TransferX.Location = new System.Drawing.Point(56, 25);
            this.TransferX.Margin = new System.Windows.Forms.Padding(4);
            this.TransferX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TransferX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.TransferX.Name = "TransferX";
            this.TransferX.Size = new System.Drawing.Size(97, 22);
            this.TransferX.TabIndex = 1;
            this.TransferX.ValueChanged += new System.EventHandler(this.TransferX_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "X:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ScaleZ);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.ScaleY);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.ScaleX);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(56, 481);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(169, 134);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Масштабирование";
            // 
            // ScaleZ
            // 
            this.ScaleZ.DecimalPlaces = 3;
            this.ScaleZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ScaleZ.Location = new System.Drawing.Point(55, 87);
            this.ScaleZ.Margin = new System.Windows.Forms.Padding(4);
            this.ScaleZ.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ScaleZ.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.ScaleZ.Name = "ScaleZ";
            this.ScaleZ.Size = new System.Drawing.Size(97, 22);
            this.ScaleZ.TabIndex = 5;
            this.ScaleZ.ValueChanged += new System.EventHandler(this.ScaleZ_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 90);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Z:";
            // 
            // ScaleY
            // 
            this.ScaleY.DecimalPlaces = 3;
            this.ScaleY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ScaleY.Location = new System.Drawing.Point(55, 55);
            this.ScaleY.Margin = new System.Windows.Forms.Padding(4);
            this.ScaleY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ScaleY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.ScaleY.Name = "ScaleY";
            this.ScaleY.Size = new System.Drawing.Size(97, 22);
            this.ScaleY.TabIndex = 3;
            this.ScaleY.ValueChanged += new System.EventHandler(this.ScaleY_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 58);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Y:";
            // 
            // ScaleX
            // 
            this.ScaleX.DecimalPlaces = 3;
            this.ScaleX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ScaleX.Location = new System.Drawing.Point(55, 23);
            this.ScaleX.Margin = new System.Windows.Forms.Padding(4);
            this.ScaleX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ScaleX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.ScaleX.Name = "ScaleX";
            this.ScaleX.Size = new System.Drawing.Size(97, 22);
            this.ScaleX.TabIndex = 1;
            this.ScaleX.ValueChanged += new System.EventHandler(this.ScaleX_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 26);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "X:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.CameraZ);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.CameraY);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.CameraX);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Location = new System.Drawing.Point(56, 668);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(169, 131);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Точка центра";
            // 
            // CameraZ
            // 
            this.CameraZ.DecimalPlaces = 3;
            this.CameraZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CameraZ.Location = new System.Drawing.Point(55, 83);
            this.CameraZ.Margin = new System.Windows.Forms.Padding(4);
            this.CameraZ.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.CameraZ.Name = "CameraZ";
            this.CameraZ.Size = new System.Drawing.Size(97, 22);
            this.CameraZ.TabIndex = 5;
            this.CameraZ.ValueChanged += new System.EventHandler(this.CameraZ_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Z:";
            // 
            // CameraY
            // 
            this.CameraY.DecimalPlaces = 3;
            this.CameraY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CameraY.Location = new System.Drawing.Point(55, 53);
            this.CameraY.Margin = new System.Windows.Forms.Padding(4);
            this.CameraY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.CameraY.Name = "CameraY";
            this.CameraY.Size = new System.Drawing.Size(97, 22);
            this.CameraY.TabIndex = 3;
            this.CameraY.ValueChanged += new System.EventHandler(this.CameraY_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Y:";
            // 
            // CameraX
            // 
            this.CameraX.DecimalPlaces = 3;
            this.CameraX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CameraX.Location = new System.Drawing.Point(55, 23);
            this.CameraX.Margin = new System.Windows.Forms.Padding(4);
            this.CameraX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.CameraX.Name = "CameraX";
            this.CameraX.Size = new System.Drawing.Size(97, 22);
            this.CameraX.TabIndex = 1;
            this.CameraX.ValueChanged += new System.EventHandler(this.CameraX_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 26);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "X:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.EyeZ);
            this.groupBox8.Controls.Add(this.label21);
            this.groupBox8.Controls.Add(this.EyeY);
            this.groupBox8.Controls.Add(this.label22);
            this.groupBox8.Controls.Add(this.EyeX);
            this.groupBox8.Controls.Add(this.label23);
            this.groupBox8.Location = new System.Drawing.Point(56, 848);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox8.Size = new System.Drawing.Size(169, 125);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Точка зрения";
            // 
            // EyeZ
            // 
            this.EyeZ.DecimalPlaces = 3;
            this.EyeZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.EyeZ.Location = new System.Drawing.Point(55, 83);
            this.EyeZ.Margin = new System.Windows.Forms.Padding(4);
            this.EyeZ.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.EyeZ.Name = "EyeZ";
            this.EyeZ.Size = new System.Drawing.Size(97, 22);
            this.EyeZ.TabIndex = 5;
            this.EyeZ.ValueChanged += new System.EventHandler(this.EyeZ_ValueChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(32, 86);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(21, 17);
            this.label21.TabIndex = 4;
            this.label21.Text = "Z:";
            // 
            // EyeY
            // 
            this.EyeY.DecimalPlaces = 3;
            this.EyeY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.EyeY.Location = new System.Drawing.Point(55, 53);
            this.EyeY.Margin = new System.Windows.Forms.Padding(4);
            this.EyeY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.EyeY.Name = "EyeY";
            this.EyeY.Size = new System.Drawing.Size(97, 22);
            this.EyeY.TabIndex = 3;
            this.EyeY.ValueChanged += new System.EventHandler(this.EyeY_ValueChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(33, 55);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(21, 17);
            this.label22.TabIndex = 2;
            this.label22.Text = "Y:";
            // 
            // EyeX
            // 
            this.EyeX.DecimalPlaces = 3;
            this.EyeX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.EyeX.Location = new System.Drawing.Point(55, 23);
            this.EyeX.Margin = new System.Windows.Forms.Padding(4);
            this.EyeX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.EyeX.Name = "EyeX";
            this.EyeX.Size = new System.Drawing.Size(97, 22);
            this.EyeX.TabIndex = 1;
            this.EyeX.ValueChanged += new System.EventHandler(this.EyeX_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(32, 26);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(21, 17);
            this.label23.TabIndex = 0;
            this.label23.Text = "X:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.selectButton);
            this.panel1.Controls.Add(this.rotateButton);
            this.panel1.Controls.Add(this.changeButton);
            this.panel1.Controls.Add(this.transferButton);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.createButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox8);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.ObjectList);
            this.panel1.Location = new System.Drawing.Point(1662, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 1078);
            this.panel1.TabIndex = 1;
            // 
            // selectButton
            // 
            this.selectButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectButton.BackgroundImage")));
            this.selectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectButton.Location = new System.Drawing.Point(20, 257);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(30, 30);
            this.selectButton.TabIndex = 16;
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // rotateButton
            // 
            this.rotateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rotateButton.BackgroundImage")));
            this.rotateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rotateButton.Location = new System.Drawing.Point(220, 257);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(35, 30);
            this.rotateButton.TabIndex = 15;
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("changeButton.BackgroundImage")));
            this.changeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changeButton.Location = new System.Drawing.Point(179, 257);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(35, 30);
            this.changeButton.TabIndex = 14;
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // transferButton
            // 
            this.transferButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("transferButton.BackgroundImage")));
            this.transferButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transferButton.Location = new System.Drawing.Point(138, 257);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(35, 30);
            this.transferButton.TabIndex = 13;
            this.transferButton.UseVisualStyleBackColor = true;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(97, 257);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(35, 30);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "-";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.BackColor = System.Drawing.Color.Transparent;
            this.createButton.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createButton.Location = new System.Drawing.Point(56, 257);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(35, 30);
            this.createButton.TabIndex = 11;
            this.createButton.Text = "+";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(208, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 60);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1942, 1080);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Queen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransferZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferX)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleX)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CameraZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraX)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EyeZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EyeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EyeX)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem открытьСценуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьСценуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьПараметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private DrawContainer drawContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.NumericUpDown EyeZ;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown EyeY;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown EyeX;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown CameraZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown CameraY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown CameraX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown TransferZ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox ObjectList;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown ScaleZ;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown ScaleY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown ScaleX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem видМоделиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каркаснаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem твердотельнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проецированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параллельноеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem центральноеToolStripMenuItem;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button rotateButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.NumericUpDown TransferY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown TransferX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label right;
        private System.Windows.Forms.Label up;
        private System.Windows.Forms.Label left;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label upleft;
        private System.Windows.Forms.Label upright;
        private System.Windows.Forms.Label downleft;
        private System.Windows.Forms.Label downright;
        private System.Windows.Forms.Label down;
    }
}

