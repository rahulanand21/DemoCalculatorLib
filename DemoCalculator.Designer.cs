namespace DemoCalculatorLib
{
    partial class DemoCalculator
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.clearButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.sevenButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.signchangeButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.additionButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonpower = new System.Windows.Forms.Button();
            this.sinebutton = new System.Windows.Forms.Button();
            this.cosinebutton = new System.Windows.Forms.Button();
            this.tangentbutton = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonroot = new System.Windows.Forms.Button();
            this.buttoncube = new System.Windows.Forms.Button();
            this.buttoncuberoot = new System.Windows.Forms.Button();
            this.factorial = new System.Windows.Forms.Button();
            this.buttonOct = new System.Windows.Forms.Button();
            this.buttonHex = new System.Windows.Forms.Button();
            this.buttonBoolean = new System.Windows.Forms.Button();
            this.buttonPermutation = new System.Windows.Forms.Button();
            this.buttoncombination = new System.Windows.Forms.Button();
            this.buttoninverse = new System.Windows.Forms.Button();
            this.buttonlog = new System.Windows.Forms.Button();
            this.buttonln = new System.Windows.Forms.Button();
            this.buttonisin = new System.Windows.Forms.Button();
            this.buttoniCos = new System.Windows.Forms.Button();
            this.buttoniTan = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 43);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel2.Click += new System.EventHandler(this.Operator_Click);
            this.splitContainer1.Size = new System.Drawing.Size(551, 318);
            this.splitContainer1.SplitterDistance = 276;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.clearButton, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.divisionButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.nineButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.eightButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDisplay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sevenButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.fourButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.fiveButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.sixButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.multiplicationButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.oneButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.twoButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.threeButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.subtractButton, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.equalsButton, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.zeroButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.signchangeButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.decimalButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.additionButton, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(272, 314);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.Value_Click);
            // 
            // clearButton
            // 
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(221, 67);
            this.clearButton.Margin = new System.Windows.Forms.Padding(5);
            this.clearButton.Name = "clearButton";
            this.tableLayoutPanel1.SetRowSpan(this.clearButton, 2);
            this.clearButton.Size = new System.Drawing.Size(46, 114);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "R";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionButton.Location = new System.Drawing.Point(167, 67);
            this.divisionButton.Margin = new System.Windows.Forms.Padding(5);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(44, 52);
            this.divisionButton.TabIndex = 4;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.Operator_Click);
            // 
            // nineButton
            // 
            this.nineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineButton.Location = new System.Drawing.Point(113, 67);
            this.nineButton.Margin = new System.Windows.Forms.Padding(5);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(44, 52);
            this.nineButton.TabIndex = 3;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.Value_Click);
            // 
            // eightButton
            // 
            this.eightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightButton.Location = new System.Drawing.Point(59, 67);
            this.eightButton.Margin = new System.Windows.Forms.Padding(5);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(44, 52);
            this.eightButton.TabIndex = 2;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.Value_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtDisplay, 5);
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(3, 16);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(266, 29);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sevenButton
            // 
            this.sevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenButton.Location = new System.Drawing.Point(5, 67);
            this.sevenButton.Margin = new System.Windows.Forms.Padding(5);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(44, 52);
            this.sevenButton.TabIndex = 1;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.Value_Click);
            // 
            // fourButton
            // 
            this.fourButton.BackColor = System.Drawing.SystemColors.Control;
            this.fourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourButton.Location = new System.Drawing.Point(5, 129);
            this.fourButton.Margin = new System.Windows.Forms.Padding(5);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(44, 52);
            this.fourButton.TabIndex = 6;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.Value_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveButton.Location = new System.Drawing.Point(59, 129);
            this.fiveButton.Margin = new System.Windows.Forms.Padding(5);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(44, 52);
            this.fiveButton.TabIndex = 7;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.Value_Click);
            // 
            // sixButton
            // 
            this.sixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixButton.Location = new System.Drawing.Point(113, 129);
            this.sixButton.Margin = new System.Windows.Forms.Padding(5);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(44, 52);
            this.sixButton.TabIndex = 8;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.Value_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicationButton.Location = new System.Drawing.Point(167, 129);
            this.multiplicationButton.Margin = new System.Windows.Forms.Padding(5);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(44, 52);
            this.multiplicationButton.TabIndex = 9;
            this.multiplicationButton.Text = "*";
            this.multiplicationButton.UseVisualStyleBackColor = true;
            this.multiplicationButton.Click += new System.EventHandler(this.Operator_Click);
            // 
            // oneButton
            // 
            this.oneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneButton.Location = new System.Drawing.Point(5, 191);
            this.oneButton.Margin = new System.Windows.Forms.Padding(5);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(44, 52);
            this.oneButton.TabIndex = 11;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.Value_Click);
            // 
            // twoButton
            // 
            this.twoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoButton.Location = new System.Drawing.Point(59, 191);
            this.twoButton.Margin = new System.Windows.Forms.Padding(5);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(44, 52);
            this.twoButton.TabIndex = 12;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.Value_Click);
            // 
            // threeButton
            // 
            this.threeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeButton.Location = new System.Drawing.Point(113, 191);
            this.threeButton.Margin = new System.Windows.Forms.Padding(5);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(44, 52);
            this.threeButton.TabIndex = 13;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.Value_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractButton.Location = new System.Drawing.Point(167, 191);
            this.subtractButton.Margin = new System.Windows.Forms.Padding(5);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(44, 52);
            this.subtractButton.TabIndex = 14;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.Operator_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsButton.Location = new System.Drawing.Point(221, 191);
            this.equalsButton.Margin = new System.Windows.Forms.Padding(5);
            this.equalsButton.Name = "equalsButton";
            this.tableLayoutPanel1.SetRowSpan(this.equalsButton, 2);
            this.equalsButton.Size = new System.Drawing.Size(46, 118);
            this.equalsButton.TabIndex = 15;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.Operator_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroButton.Location = new System.Drawing.Point(5, 253);
            this.zeroButton.Margin = new System.Windows.Forms.Padding(5);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(44, 56);
            this.zeroButton.TabIndex = 16;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.Value_Click);
            // 
            // signchangeButton
            // 
            this.signchangeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signchangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signchangeButton.Location = new System.Drawing.Point(59, 253);
            this.signchangeButton.Margin = new System.Windows.Forms.Padding(5);
            this.signchangeButton.Name = "signchangeButton";
            this.signchangeButton.Size = new System.Drawing.Size(44, 56);
            this.signchangeButton.TabIndex = 17;
            this.signchangeButton.Text = "N";
            this.signchangeButton.UseVisualStyleBackColor = true;
            this.signchangeButton.Click += new System.EventHandler(this.SingleOp_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalButton.Location = new System.Drawing.Point(113, 253);
            this.decimalButton.Margin = new System.Windows.Forms.Padding(5);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(44, 56);
            this.decimalButton.TabIndex = 18;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.Value_Click);
            // 
            // additionButton
            // 
            this.additionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.additionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionButton.Location = new System.Drawing.Point(167, 253);
            this.additionButton.Margin = new System.Windows.Forms.Padding(5);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(44, 56);
            this.additionButton.TabIndex = 19;
            this.additionButton.Text = "+";
            this.additionButton.UseVisualStyleBackColor = true;
            this.additionButton.Click += new System.EventHandler(this.Operator_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.buttonpower, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.sinebutton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cosinebutton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tangentbutton, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonSquare, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonroot, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttoncube, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttoncuberoot, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.factorial, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonOct, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonHex, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonBoolean, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonPermutation, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttoncombination, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttoninverse, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonlog, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonln, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonisin, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttoniCos, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttoniTan, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(267, 314);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Click += new System.EventHandler(this.SingleOp_Click);
            // 
            // buttonpower
            // 
            this.buttonpower.AccessibleName = "";
            this.buttonpower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonpower.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpower.Location = new System.Drawing.Point(137, 129);
            this.buttonpower.Margin = new System.Windows.Forms.Padding(5);
            this.buttonpower.Name = "buttonpower";
            this.buttonpower.Size = new System.Drawing.Size(56, 52);
            this.buttonpower.TabIndex = 11;
            this.buttonpower.Text = "x^y";
            this.buttonpower.UseVisualStyleBackColor = true;
            this.buttonpower.Click += new System.EventHandler(this.Operator_Click);
            // 
            // sinebutton
            // 
            this.sinebutton.AccessibleName = "";
            this.sinebutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sinebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinebutton.Location = new System.Drawing.Point(5, 67);
            this.sinebutton.Margin = new System.Windows.Forms.Padding(5);
            this.sinebutton.Name = "sinebutton";
            this.sinebutton.Size = new System.Drawing.Size(56, 52);
            this.sinebutton.TabIndex = 0;
            this.sinebutton.Text = "Sin";
            this.sinebutton.UseVisualStyleBackColor = true;
            this.sinebutton.Click += new System.EventHandler(this.SingleOp_Click);
            // 
            // cosinebutton
            // 
            this.cosinebutton.AccessibleName = "";
            this.cosinebutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cosinebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cosinebutton.Location = new System.Drawing.Point(71, 67);
            this.cosinebutton.Margin = new System.Windows.Forms.Padding(5);
            this.cosinebutton.Name = "cosinebutton";
            this.cosinebutton.Size = new System.Drawing.Size(56, 52);
            this.cosinebutton.TabIndex = 1;
            this.cosinebutton.Text = "Cos";
            this.cosinebutton.UseVisualStyleBackColor = true;
            this.cosinebutton.Click += new System.EventHandler(this.SingleOp_Click);
            // 
            // tangentbutton
            // 
            this.tangentbutton.AccessibleName = "";
            this.tangentbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tangentbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tangentbutton.Location = new System.Drawing.Point(137, 67);
            this.tangentbutton.Margin = new System.Windows.Forms.Padding(5);
            this.tangentbutton.Name = "tangentbutton";
            this.tangentbutton.Size = new System.Drawing.Size(56, 52);
            this.tangentbutton.TabIndex = 2;
            this.tangentbutton.Text = "Tan";
            this.tangentbutton.UseVisualStyleBackColor = true;
            this.tangentbutton.Click += new System.EventHandler(this.SingleOp_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.AccessibleName = "";
            this.buttonSquare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSquare.Location = new System.Drawing.Point(5, 129);
            this.buttonSquare.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(56, 52);
            this.buttonSquare.TabIndex = 3;
            this.buttonSquare.Text = "x²";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.SingleOp_Click);
            // 
            // buttonroot
            // 
            this.buttonroot.AccessibleName = "";
            this.buttonroot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonroot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonroot.Location = new System.Drawing.Point(71, 129);
            this.buttonroot.Margin = new System.Windows.Forms.Padding(5);
            this.buttonroot.Name = "buttonroot";
            this.buttonroot.Size = new System.Drawing.Size(56, 52);
            this.buttonroot.TabIndex = 4;
            this.buttonroot.Text = "x½";
            this.buttonroot.UseVisualStyleBackColor = true;
            this.buttonroot.Click += new System.EventHandler(this.SingleOp_Click);
            // 
            // buttoncube
            // 
            this.buttoncube.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttoncube.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncube.Location = new System.Drawing.Point(5, 191);
            this.buttoncube.Margin = new System.Windows.Forms.Padding(5);
            this.buttoncube.Name = "buttoncube";
            this.buttoncube.Size = new System.Drawing.Size(56, 52);
            this.buttoncube.TabIndex = 5;
            this.buttoncube.Text = "x³";
            this.buttoncube.UseVisualStyleBackColor = true;
            this.buttoncube.Click += new System.EventHandler(this.SingleOp_Click);
            // 
            // buttoncuberoot
            // 
            this.buttoncuberoot.AccessibleName = "";
            this.buttoncuberoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttoncuberoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncuberoot.Location = new System.Drawing.Point(71, 191);
            this.buttoncuberoot.Margin = new System.Windows.Forms.Padding(5);
            this.buttoncuberoot.Name = "buttoncuberoot";
            this.buttoncuberoot.Size = new System.Drawing.Size(56, 52);
            this.buttoncuberoot.TabIndex = 6;
            this.buttoncuberoot.Text = "x^1/3";
            this.buttoncuberoot.UseVisualStyleBackColor = true;
            this.buttoncuberoot.Click += new System.EventHandler(this.SingleOp_Click);
            // 
            // factorial
            // 
            this.factorial.AccessibleName = "";
            this.factorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.factorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factorial.Location = new System.Drawing.Point(137, 191);
            this.factorial.Margin = new System.Windows.Forms.Padding(5);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(56, 52);
            this.factorial.TabIndex = 7;
            this.factorial.Text = "n!";
            this.factorial.UseVisualStyleBackColor = true;
            this.factorial.Click += new System.EventHandler(this.SingleOp_Click);
            // 
            // buttonOct
            // 
            this.buttonOct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOct.Location = new System.Drawing.Point(5, 253);
            this.buttonOct.Margin = new System.Windows.Forms.Padding(5);
            this.buttonOct.Name = "buttonOct";
            this.buttonOct.Size = new System.Drawing.Size(56, 56);
            this.buttonOct.TabIndex = 12;
            this.buttonOct.Text = "Oct";
            this.buttonOct.UseVisualStyleBackColor = true;
            this.buttonOct.Click += new System.EventHandler(this.BaseChange_Click);
            // 
            // buttonHex
            // 
            this.buttonHex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHex.Location = new System.Drawing.Point(71, 253);
            this.buttonHex.Margin = new System.Windows.Forms.Padding(5);
            this.buttonHex.Name = "buttonHex";
            this.buttonHex.Size = new System.Drawing.Size(56, 56);
            this.buttonHex.TabIndex = 13;
            this.buttonHex.Text = "Hex";
            this.buttonHex.UseVisualStyleBackColor = true;
            this.buttonHex.Click += new System.EventHandler(this.BaseChange_Click);
            // 
            // buttonBoolean
            // 
            this.buttonBoolean.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBoolean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBoolean.Location = new System.Drawing.Point(137, 253);
            this.buttonBoolean.Margin = new System.Windows.Forms.Padding(5);
            this.buttonBoolean.Name = "buttonBoolean";
            this.buttonBoolean.Size = new System.Drawing.Size(56, 56);
            this.buttonBoolean.TabIndex = 14;
            this.buttonBoolean.Text = "Bool";
            this.buttonBoolean.UseVisualStyleBackColor = true;
            this.buttonBoolean.Click += new System.EventHandler(this.BaseChange_Click);
            // 
            // buttonPermutation
            // 
            this.buttonPermutation.AccessibleName = "";
            this.buttonPermutation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPermutation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPermutation.Location = new System.Drawing.Point(203, 129);
            this.buttonPermutation.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPermutation.Name = "buttonPermutation";
            this.buttonPermutation.Size = new System.Drawing.Size(59, 52);
            this.buttonPermutation.TabIndex = 15;
            this.buttonPermutation.Text = "nPr";
            this.buttonPermutation.UseVisualStyleBackColor = true;
            this.buttonPermutation.Click += new System.EventHandler(this.Operator_Click);
            // 
            // buttoncombination
            // 
            this.buttoncombination.AccessibleName = "";
            this.buttoncombination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttoncombination.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncombination.Location = new System.Drawing.Point(203, 191);
            this.buttoncombination.Margin = new System.Windows.Forms.Padding(5);
            this.buttoncombination.Name = "buttoncombination";
            this.buttoncombination.Size = new System.Drawing.Size(59, 52);
            this.buttoncombination.TabIndex = 16;
            this.buttoncombination.Text = "nCr";
            this.buttoncombination.UseVisualStyleBackColor = true;
            this.buttoncombination.Click += new System.EventHandler(this.Operator_Click);
            // 
            // buttoninverse
            // 
            this.buttoninverse.AccessibleName = "";
            this.buttoninverse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttoninverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoninverse.Location = new System.Drawing.Point(203, 253);
            this.buttoninverse.Margin = new System.Windows.Forms.Padding(5);
            this.buttoninverse.Name = "buttoninverse";
            this.buttoninverse.Size = new System.Drawing.Size(59, 56);
            this.buttoninverse.TabIndex = 17;
            this.buttoninverse.Text = "1/x";
            this.buttoninverse.UseVisualStyleBackColor = true;
            this.buttoninverse.Click += new System.EventHandler(this.SingleOp_Click);
            // 
            // buttonlog
            // 
            this.buttonlog.AccessibleName = "";
            this.buttonlog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlog.Location = new System.Drawing.Point(203, 67);
            this.buttonlog.Margin = new System.Windows.Forms.Padding(5);
            this.buttonlog.Name = "buttonlog";
            this.buttonlog.Size = new System.Drawing.Size(59, 52);
            this.buttonlog.TabIndex = 18;
            this.buttonlog.Text = "Log x";
            this.buttonlog.UseVisualStyleBackColor = true;
            this.buttonlog.Click += new System.EventHandler(this.SingleOp_Click);
            // 
            // buttonln
            // 
            this.buttonln.AccessibleName = "";
            this.buttonln.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonln.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonln.Location = new System.Drawing.Point(203, 5);
            this.buttonln.Margin = new System.Windows.Forms.Padding(5);
            this.buttonln.Name = "buttonln";
            this.buttonln.Size = new System.Drawing.Size(59, 52);
            this.buttonln.TabIndex = 19;
            this.buttonln.Text = "Ln x";
            this.buttonln.UseVisualStyleBackColor = true;
            this.buttonln.Click += new System.EventHandler(this.SingleOp_Click);
            // 
            // buttonisin
            // 
            this.buttonisin.AccessibleName = "";
            this.buttonisin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonisin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonisin.Location = new System.Drawing.Point(5, 5);
            this.buttonisin.Margin = new System.Windows.Forms.Padding(5);
            this.buttonisin.Name = "buttonisin";
            this.buttonisin.Size = new System.Drawing.Size(56, 52);
            this.buttonisin.TabIndex = 20;
            this.buttonisin.Text = "iSin";
            this.buttonisin.UseVisualStyleBackColor = true;
            this.buttonisin.Click += new System.EventHandler(this.SingleOp_Click);
            // 
            // buttoniCos
            // 
            this.buttoniCos.AccessibleName = "";
            this.buttoniCos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttoniCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoniCos.Location = new System.Drawing.Point(71, 5);
            this.buttoniCos.Margin = new System.Windows.Forms.Padding(5);
            this.buttoniCos.Name = "buttoniCos";
            this.buttoniCos.Size = new System.Drawing.Size(56, 52);
            this.buttoniCos.TabIndex = 21;
            this.buttoniCos.Text = "iCos";
            this.buttoniCos.UseVisualStyleBackColor = true;
            this.buttoniCos.Click += new System.EventHandler(this.SingleOp_Click);
            // 
            // buttoniTan
            // 
            this.buttoniTan.AccessibleName = "";
            this.buttoniTan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttoniTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoniTan.Location = new System.Drawing.Point(137, 5);
            this.buttoniTan.Margin = new System.Windows.Forms.Padding(5);
            this.buttoniTan.Name = "buttoniTan";
            this.buttoniTan.Size = new System.Drawing.Size(56, 52);
            this.buttoniTan.TabIndex = 22;
            this.buttoniTan.Text = "iTan";
            this.buttoniTan.UseVisualStyleBackColor = true;
            this.buttoniTan.Click += new System.EventHandler(this.SingleOp_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(551, 43);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scientificToolStripMenuItem,
            this.programmerToolStripMenuItem,
            this.standardToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.optionsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(190, 30);
            this.scientificToolStripMenuItem.Text = "Scientific";
            this.scientificToolStripMenuItem.Click += new System.EventHandler(this.scientificToolStripMenuItem_Click);
            // 
            // programmerToolStripMenuItem
            // 
            this.programmerToolStripMenuItem.Name = "programmerToolStripMenuItem";
            this.programmerToolStripMenuItem.Size = new System.Drawing.Size(190, 30);
            this.programmerToolStripMenuItem.Text = "Programmer";
            this.programmerToolStripMenuItem.Click += new System.EventHandler(this.programmerToolStripMenuItem_Click_1);
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(190, 30);
            this.standardToolStripMenuItem.Text = "Standard";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.standardToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versiToolStripMenuItem});
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 39);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // versiToolStripMenuItem
            // 
            this.versiToolStripMenuItem.Name = "versiToolStripMenuItem";
            this.versiToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.versiToolStripMenuItem.Text = "Calculator";
            this.versiToolStripMenuItem.Click += new System.EventHandler(this.versiToolStripMenuItem_Click);
            // 
            // txtMode
            // 
            this.txtMode.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMode.Location = new System.Drawing.Point(337, 11);
            this.txtMode.Margin = new System.Windows.Forms.Padding(5);
            this.txtMode.Name = "txtMode";
            this.txtMode.Size = new System.Drawing.Size(181, 26);
            this.txtMode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Mode";
            // 
            // DemoCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(551, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMode);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DemoCalculator";
            this.Text = "My Calculator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button signchangeButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button additionButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonpower;
        private System.Windows.Forms.Button sinebutton;
        private System.Windows.Forms.Button cosinebutton;
        private System.Windows.Forms.Button tangentbutton;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonroot;
        private System.Windows.Forms.Button buttoncube;
        private System.Windows.Forms.Button buttoncuberoot;
        private System.Windows.Forms.Button factorial;
        private System.Windows.Forms.Button buttonOct;
        private System.Windows.Forms.Button buttonHex;
        private System.Windows.Forms.Button buttonBoolean;
        private System.Windows.Forms.Button buttonPermutation;
        private System.Windows.Forms.Button buttoncombination;
        private System.Windows.Forms.Button buttoninverse;
        private System.Windows.Forms.Button buttonlog;
        private System.Windows.Forms.Button buttonln;
        private System.Windows.Forms.Button buttonisin;
        private System.Windows.Forms.Button buttoniCos;
        private System.Windows.Forms.Button buttoniTan;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versiToolStripMenuItem;
        private System.Windows.Forms.TextBox txtMode;
        private System.Windows.Forms.Label label1;
    }
}

