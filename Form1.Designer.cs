namespace AwesomeCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            out_area = new Panel();
            inout = new TextBox();
            prevExp = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            operationButton1 = new OperationButton();
            operationButton2 = new OperationButton();
            operationButton3 = new OperationButton();
            operationButton4 = new OperationButton();
            operationButton5 = new OperationButton();
            operationButton6 = new OperationButton();
            operationButton7 = new OperationButton();
            operationButton8 = new OperationButton();
            operationButton18 = new OperationButton();
            tableLayoutPanel4 = new TableLayoutPanel();
            operationButton13 = new OperationButton();
            operationButton12 = new OperationButton();
            operationButton11 = new OperationButton();
            operationButton9 = new OperationButton();
            operationButton10 = new OperationButton();
            operationButton14 = new OperationButton();
            operationButton15 = new OperationButton();
            operationButton16 = new OperationButton();
            operationButton17 = new OperationButton();
            operationButton22 = new OperationButton();
            tableLayoutPanel5 = new TableLayoutPanel();
            operationButton21 = new OperationButton();
            operationButton20 = new OperationButton();
            operationButton19 = new OperationButton();
            out_area.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // out_area
            // 
            out_area.Controls.Add(inout);
            out_area.Controls.Add(prevExp);
            out_area.Dock = DockStyle.Top;
            out_area.Location = new Point(3, 3);
            out_area.MinimumSize = new Size(0, 100);
            out_area.Name = "out_area";
            out_area.Size = new Size(348, 100);
            out_area.TabIndex = 0;
            // 
            // inout
            // 
            inout.BackColor = Color.FromArgb(26, 26, 26);
            inout.BorderStyle = BorderStyle.None;
            inout.Dock = DockStyle.Top;
            inout.Font = new Font("Segoe UI", 40F);
            inout.ForeColor = Color.FromArgb(212, 212, 212);
            inout.Location = new Point(0, 25);
            inout.Margin = new Padding(0);
            inout.Name = "inout";
            inout.ReadOnly = true;
            inout.Size = new Size(348, 71);
            inout.TabIndex = 1;
            inout.Text = "0";
            inout.TextAlign = HorizontalAlignment.Right;
            // 
            // prevExp
            // 
            prevExp.BackColor = Color.FromArgb(26, 26, 26);
            prevExp.BorderStyle = BorderStyle.None;
            prevExp.Dock = DockStyle.Top;
            prevExp.Enabled = false;
            prevExp.Font = new Font("Segoe UI", 14F);
            prevExp.ForeColor = Color.FromArgb(90, 92, 90);
            prevExp.Location = new Point(0, 0);
            prevExp.Margin = new Padding(0);
            prevExp.Name = "prevExp";
            prevExp.ReadOnly = true;
            prevExp.Size = new Size(348, 25);
            prevExp.TabIndex = 0;
            prevExp.Text = "0";
            prevExp.TextAlign = HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(out_area, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(354, 491);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 106);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2061281F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 85.79387F));
            tableLayoutPanel2.Size = new Size(354, 385);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Controls.Add(operationButton1, 0, 0);
            tableLayoutPanel3.Controls.Add(operationButton2, 1, 0);
            tableLayoutPanel3.Controls.Add(operationButton3, 2, 0);
            tableLayoutPanel3.Controls.Add(operationButton4, 3, 0);
            tableLayoutPanel3.Controls.Add(operationButton5, 4, 0);
            tableLayoutPanel3.Controls.Add(operationButton6, 4, 1);
            tableLayoutPanel3.Controls.Add(operationButton7, 4, 2);
            tableLayoutPanel3.Controls.Add(operationButton8, 4, 3);
            tableLayoutPanel3.Controls.Add(operationButton18, 3, 4);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Controls.Add(operationButton22, 0, 4);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 54);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(354, 331);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // operationButton1
            // 
            operationButton1.BackColor = Color.FromArgb(52, 52, 52);
            operationButton1.BackgroundColor = Color.FromArgb(52, 52, 52);
            operationButton1.BorderColor = Color.PaleVioletRed;
            operationButton1.BorderRadius = 7;
            operationButton1.BorderSize = 0;
            operationButton1.Dock = DockStyle.Fill;
            operationButton1.FlatAppearance.BorderSize = 0;
            operationButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 3);
            operationButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            operationButton1.FlatStyle = FlatStyle.Flat;
            operationButton1.Font = new Font("Segoe UI", 14F);
            operationButton1.ForeColor = Color.FromArgb(212, 212, 212);
            operationButton1.Location = new Point(3, 3);
            operationButton1.Name = "operationButton1";
            operationButton1.OperationType = OperationButton.Types.Clear;
            operationButton1.Size = new Size(64, 60);
            operationButton1.TabIndex = 6;
            operationButton1.Text = "CE";
            operationButton1.TextColor = Color.FromArgb(212, 212, 212);
            operationButton1.UseVisualStyleBackColor = false;
            operationButton1.Click += OnOperationButtonClick;
            // 
            // operationButton2
            // 
            operationButton2.BackColor = Color.FromArgb(52, 52, 52);
            operationButton2.BackgroundColor = Color.FromArgb(52, 52, 52);
            operationButton2.BorderColor = Color.PaleVioletRed;
            operationButton2.BorderRadius = 7;
            operationButton2.BorderSize = 0;
            operationButton2.Dock = DockStyle.Fill;
            operationButton2.FlatAppearance.BorderSize = 0;
            operationButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 3);
            operationButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            operationButton2.FlatStyle = FlatStyle.Flat;
            operationButton2.Font = new Font("Segoe UI", 14F);
            operationButton2.ForeColor = Color.FromArgb(212, 212, 212);
            operationButton2.Location = new Point(73, 3);
            operationButton2.Name = "operationButton2";
            operationButton2.OperationType = OperationButton.Types.Plus;
            operationButton2.Size = new Size(64, 60);
            operationButton2.TabIndex = 7;
            operationButton2.Text = "+";
            operationButton2.TextColor = Color.FromArgb(212, 212, 212);
            operationButton2.UseVisualStyleBackColor = false;
            operationButton2.Click += OnOperationButtonClick;
            // 
            // operationButton3
            // 
            operationButton3.BackColor = Color.FromArgb(52, 52, 52);
            operationButton3.BackgroundColor = Color.FromArgb(52, 52, 52);
            operationButton3.BorderColor = Color.PaleVioletRed;
            operationButton3.BorderRadius = 7;
            operationButton3.BorderSize = 0;
            operationButton3.Dock = DockStyle.Fill;
            operationButton3.FlatAppearance.BorderSize = 0;
            operationButton3.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 3);
            operationButton3.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            operationButton3.FlatStyle = FlatStyle.Flat;
            operationButton3.Font = new Font("Segoe UI", 14F);
            operationButton3.ForeColor = Color.FromArgb(212, 212, 212);
            operationButton3.Location = new Point(143, 3);
            operationButton3.Name = "operationButton3";
            operationButton3.OperationType = OperationButton.Types.Minus;
            operationButton3.Size = new Size(64, 60);
            operationButton3.TabIndex = 8;
            operationButton3.Text = "-";
            operationButton3.TextColor = Color.FromArgb(212, 212, 212);
            operationButton3.UseVisualStyleBackColor = false;
            operationButton3.Click += OnOperationButtonClick;
            // 
            // operationButton4
            // 
            operationButton4.BackColor = Color.FromArgb(52, 52, 52);
            operationButton4.BackgroundColor = Color.FromArgb(52, 52, 52);
            operationButton4.BorderColor = Color.PaleVioletRed;
            operationButton4.BorderRadius = 7;
            operationButton4.BorderSize = 0;
            operationButton4.Dock = DockStyle.Fill;
            operationButton4.FlatAppearance.BorderSize = 0;
            operationButton4.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 3);
            operationButton4.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            operationButton4.FlatStyle = FlatStyle.Flat;
            operationButton4.Font = new Font("Segoe UI", 14F);
            operationButton4.ForeColor = Color.FromArgb(212, 212, 212);
            operationButton4.Location = new Point(213, 3);
            operationButton4.Name = "operationButton4";
            operationButton4.OperationType = OperationButton.Types.Multiplication;
            operationButton4.Size = new Size(64, 60);
            operationButton4.TabIndex = 9;
            operationButton4.Text = "*";
            operationButton4.TextColor = Color.FromArgb(212, 212, 212);
            operationButton4.UseVisualStyleBackColor = false;
            operationButton4.Click += OnOperationButtonClick;
            // 
            // operationButton5
            // 
            operationButton5.BackColor = Color.FromArgb(52, 52, 52);
            operationButton5.BackgroundColor = Color.FromArgb(52, 52, 52);
            operationButton5.BorderColor = Color.PaleVioletRed;
            operationButton5.BorderRadius = 7;
            operationButton5.BorderSize = 0;
            operationButton5.Dock = DockStyle.Fill;
            operationButton5.FlatAppearance.BorderSize = 0;
            operationButton5.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 3);
            operationButton5.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            operationButton5.FlatStyle = FlatStyle.Flat;
            operationButton5.Font = new Font("Segoe UI", 14F);
            operationButton5.ForeColor = Color.FromArgb(212, 212, 212);
            operationButton5.Location = new Point(283, 3);
            operationButton5.Name = "operationButton5";
            operationButton5.OperationType = OperationButton.Types.Del;
            operationButton5.Size = new Size(68, 60);
            operationButton5.TabIndex = 10;
            operationButton5.Text = "DEL";
            operationButton5.TextColor = Color.FromArgb(212, 212, 212);
            operationButton5.UseVisualStyleBackColor = false;
            operationButton5.Click += OnOperationButtonClick;
            // 
            // operationButton6
            // 
            operationButton6.BackColor = Color.FromArgb(52, 52, 52);
            operationButton6.BackgroundColor = Color.FromArgb(52, 52, 52);
            operationButton6.BorderColor = Color.PaleVioletRed;
            operationButton6.BorderRadius = 7;
            operationButton6.BorderSize = 0;
            operationButton6.Dock = DockStyle.Fill;
            operationButton6.FlatAppearance.BorderSize = 0;
            operationButton6.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 3);
            operationButton6.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            operationButton6.FlatStyle = FlatStyle.Flat;
            operationButton6.Font = new Font("Segoe UI", 14F);
            operationButton6.ForeColor = Color.FromArgb(212, 212, 212);
            operationButton6.Location = new Point(283, 69);
            operationButton6.Name = "operationButton6";
            operationButton6.OperationType = OperationButton.Types.Sqrt;
            operationButton6.Size = new Size(68, 60);
            operationButton6.TabIndex = 11;
            operationButton6.Text = "sqrt";
            operationButton6.TextColor = Color.FromArgb(212, 212, 212);
            operationButton6.UseVisualStyleBackColor = false;
            operationButton6.Click += OnOperationButtonClick;
            // 
            // operationButton7
            // 
            operationButton7.BackColor = Color.FromArgb(52, 52, 52);
            operationButton7.BackgroundColor = Color.FromArgb(52, 52, 52);
            operationButton7.BorderColor = Color.PaleVioletRed;
            operationButton7.BorderRadius = 7;
            operationButton7.BorderSize = 0;
            operationButton7.Dock = DockStyle.Fill;
            operationButton7.FlatAppearance.BorderSize = 0;
            operationButton7.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 3);
            operationButton7.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            operationButton7.FlatStyle = FlatStyle.Flat;
            operationButton7.Font = new Font("Segoe UI", 14F);
            operationButton7.ForeColor = Color.FromArgb(212, 212, 212);
            operationButton7.Location = new Point(283, 135);
            operationButton7.Name = "operationButton7";
            operationButton7.OperationType = OperationButton.Types.Opposite;
            operationButton7.Size = new Size(68, 60);
            operationButton7.TabIndex = 12;
            operationButton7.Text = "1/x";
            operationButton7.TextColor = Color.FromArgb(212, 212, 212);
            operationButton7.UseVisualStyleBackColor = false;
            operationButton7.Click += OnOperationButtonClick;
            // 
            // operationButton8
            // 
            operationButton8.BackColor = Color.FromArgb(52, 52, 52);
            operationButton8.BackgroundColor = Color.FromArgb(52, 52, 52);
            operationButton8.BorderColor = Color.PaleVioletRed;
            operationButton8.BorderRadius = 7;
            operationButton8.BorderSize = 0;
            operationButton8.Dock = DockStyle.Fill;
            operationButton8.FlatAppearance.BorderSize = 0;
            operationButton8.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 3);
            operationButton8.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            operationButton8.FlatStyle = FlatStyle.Flat;
            operationButton8.Font = new Font("Segoe UI", 14F);
            operationButton8.ForeColor = Color.FromArgb(212, 212, 212);
            operationButton8.Location = new Point(283, 201);
            operationButton8.Name = "operationButton8";
            operationButton8.OperationType = OperationButton.Types.Dot;
            operationButton8.Size = new Size(68, 60);
            operationButton8.TabIndex = 13;
            operationButton8.Text = ".";
            operationButton8.TextColor = Color.FromArgb(212, 212, 212);
            operationButton8.UseVisualStyleBackColor = false;
            operationButton8.Click += OnOperationButtonClick;
            // 
            // operationButton18
            // 
            operationButton18.BackColor = Color.FromArgb(52, 52, 52);
            operationButton18.BackgroundColor = Color.FromArgb(52, 52, 52);
            operationButton18.BorderColor = Color.PaleVioletRed;
            operationButton18.BorderRadius = 7;
            operationButton18.BorderSize = 0;
            tableLayoutPanel3.SetColumnSpan(operationButton18, 2);
            operationButton18.Dock = DockStyle.Fill;
            operationButton18.FlatAppearance.BorderSize = 0;
            operationButton18.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 3);
            operationButton18.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            operationButton18.FlatStyle = FlatStyle.Flat;
            operationButton18.Font = new Font("Segoe UI", 14F);
            operationButton18.ForeColor = Color.FromArgb(212, 212, 212);
            operationButton18.Location = new Point(213, 267);
            operationButton18.Name = "operationButton18";
            operationButton18.OperationType = OperationButton.Types.Equel;
            operationButton18.Size = new Size(138, 61);
            operationButton18.TabIndex = 14;
            operationButton18.Text = "=";
            operationButton18.TextColor = Color.FromArgb(212, 212, 212);
            operationButton18.UseVisualStyleBackColor = false;
            operationButton18.Click += OnOperationButtonClick;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel3.SetColumnSpan(tableLayoutPanel4, 4);
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel4.Controls.Add(operationButton13, 0, 0);
            tableLayoutPanel4.Controls.Add(operationButton12, 1, 0);
            tableLayoutPanel4.Controls.Add(operationButton11, 2, 0);
            tableLayoutPanel4.Controls.Add(operationButton9, 0, 1);
            tableLayoutPanel4.Controls.Add(operationButton10, 1, 1);
            tableLayoutPanel4.Controls.Add(operationButton14, 0, 2);
            tableLayoutPanel4.Controls.Add(operationButton15, 2, 1);
            tableLayoutPanel4.Controls.Add(operationButton16, 0, 2);
            tableLayoutPanel4.Controls.Add(operationButton17, 0, 2);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 66);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel3.SetRowSpan(tableLayoutPanel4, 3);
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(280, 198);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // operationButton13
            // 
            operationButton13.BackColor = Color.FromArgb(52, 52, 52);
            operationButton13.BackgroundColor = Color.FromArgb(52, 52, 52);
            operationButton13.BorderColor = Color.PaleVioletRed;
            operationButton13.BorderRadius = 7;
            operationButton13.BorderSize = 0;
            operationButton13.Dock = DockStyle.Fill;
            operationButton13.FlatAppearance.BorderSize = 0;
            operationButton13.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 3);
            operationButton13.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            operationButton13.FlatStyle = FlatStyle.Flat;
            operationButton13.Font = new Font("Segoe UI", 14F);
            operationButton13.ForeColor = Color.FromArgb(212, 212, 212);
            operationButton13.Location = new Point(3, 3);
            operationButton13.Name = "operationButton13";
            operationButton13.OperationType = OperationButton.Types.Num1;
            operationButton13.Size = new Size(87, 60);
            operationButton13.TabIndex = 5;
            operationButton13.Text = "1";
            operationButton13.TextColor = Color.FromArgb(212, 212, 212);
            operationButton13.UseVisualStyleBackColor = false;
            operationButton13.Click += OnOperationButtonClick;
            // 
            // operationButton12
            // 
            operationButton12.BackColor = Color.FromArgb(52, 52, 52);
            operationButton12.BackgroundColor = Color.FromArgb(52, 52, 52);
            operationButton12.BorderColor = Color.PaleVioletRed;
            operationButton12.BorderRadius = 7;
            operationButton12.BorderSize = 0;
            operationButton12.Dock = DockStyle.Fill;
            operationButton12.FlatAppearance.BorderSize = 0;
            operationButton12.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 3);
            operationButton12.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            operationButton12.FlatStyle = FlatStyle.Flat;
            operationButton12.Font = new Font("Segoe UI", 14F);
            operationButton12.ForeColor = Color.FromArgb(212, 212, 212);
            operationButton12.Location = new Point(96, 3);
            operationButton12.Name = "operationButton12";
            operationButton12.OperationType = OperationButton.Types.Num2;
            operationButton12.Size = new Size(87, 60);
            operationButton12.TabIndex = 4;
            operationButton12.Text = "2";
            operationButton12.TextColor = Color.FromArgb(212, 212, 212);
            operationButton12.UseVisualStyleBackColor = false;
            operationButton12.Click += OnOperationButtonClick;
            // 
            // operationButton11
            // 
            operationButton11.BackColor = Color.FromArgb(52, 52, 52);
            operationButton11.BackgroundColor = Color.FromArgb(52, 52, 52);
            operationButton11.BorderColor = Color.PaleVioletRed;
            operationButton11.BorderRadius = 7;
            operationButton11.BorderSize = 0;
            operationButton11.Dock = DockStyle.Fill;
            operationButton11.FlatAppearance.BorderSize = 0;
            operationButton11.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 3);
            operationButton11.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            operationButton11.FlatStyle = FlatStyle.Flat;
            operationButton11.Font = new Font("Segoe UI", 14F);
            operationButton11.ForeColor = Color.FromArgb(212, 212, 212);
            operationButton11.Location = new Point(189, 3);
            operationButton11.Name = "operationButton11";
            operationButton11.OperationType = OperationButton.Types.Num3;
            operationButton11.Size = new Size(88, 60);
            operationButton11.TabIndex = 3;
            operationButton11.Text = "3";
            operationButton11.TextColor = Color.FromArgb(212, 212, 212);
            operationButton11.UseVisualStyleBackColor = false;
            operationButton11.Click += OnOperationButtonClick;
            // 
            // operationButton9
            // 
            operationButton9.BackColor = Color.FromArgb(52, 52, 52);
            operationButton9.BackgroundColor = Color.FromArgb(52, 52, 52);
            operationButton9.BorderColor = Color.PaleVioletRed;
            operationButton9.BorderRadius = 7;
            operationButton9.BorderSize = 0;
            operationButton9.Dock = DockStyle.Fill;
            operationButton9.FlatAppearance.BorderSize = 0;
            operationButton9.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 3);
            operationButton9.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            operationButton9.FlatStyle = FlatStyle.Flat;
            operationButton9.Font = new Font("Segoe UI", 14F);
            operationButton9.ForeColor = Color.FromArgb(212, 212, 212);
            operationButton9.Location = new Point(3, 69);
            operationButton9.Name = "operationButton9";
            operationButton9.OperationType = OperationButton.Types.Num4;
            operationButton9.Size = new Size(87, 60);
            operationButton9.TabIndex = 1;
            operationButton9.Text = "4";
            operationButton9.TextColor = Color.FromArgb(212, 212, 212);
            operationButton9.UseVisualStyleBackColor = false;
            operationButton9.Click += OnOperationButtonClick;
            // 
            // operationButton10
            // 
            operationButton10.BackColor = Color.FromArgb(52, 52, 52);
            operationButton10.BackgroundColor = Color.FromArgb(52, 52, 52);
            operationButton10.BorderColor = Color.PaleVioletRed;
            operationButton10.BorderRadius = 7;
            operationButton10.BorderSize = 0;
            operationButton10.Dock = DockStyle.Fill;
            operationButton10.FlatAppearance.BorderSize = 0;
            operationButton10.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 3);
            operationButton10.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            operationButton10.FlatStyle = FlatStyle.Flat;
            operationButton10.Font = new Font("Segoe UI", 14F);
            operationButton10.ForeColor = Color.FromArgb(212, 212, 212);
            operationButton10.Location = new Point(96, 69);
            operationButton10.Name = "operationButton10";
            operationButton10.OperationType = OperationButton.Types.Num5;
            operationButton10.Size = new Size(87, 60);
            operationButton10.TabIndex = 2;
            operationButton10.Text = "5";
            operationButton10.TextColor = Color.FromArgb(212, 212, 212);
            operationButton10.UseVisualStyleBackColor = false;
            operationButton10.Click += OnOperationButtonClick;
            // 
            // operationButton14
            // 
            operationButton14.BackColor = Color.FromArgb(52, 52, 52);
            operationButton14.BackgroundColor = Color.FromArgb(52, 52, 52);
            operationButton14.BorderColor = Color.PaleVioletRed;
            operationButton14.BorderRadius = 7;
            operationButton14.BorderSize = 0;
            operationButton14.Dock = DockStyle.Fill;
            operationButton14.FlatAppearance.BorderSize = 0;
            operationButton14.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 3);
            operationButton14.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            operationButton14.FlatStyle = FlatStyle.Flat;
            operationButton14.Font = new Font("Segoe UI", 14F);
            operationButton14.ForeColor = Color.FromArgb(212, 212, 212);
            operationButton14.Location = new Point(189, 135);
            operationButton14.Name = "operationButton14";
            operationButton14.OperationType = OperationButton.Types.Num9;
            operationButton14.Size = new Size(88, 60);
            operationButton14.TabIndex = 6;
            operationButton14.Text = "9";
            operationButton14.TextColor = Color.FromArgb(212, 212, 212);
            operationButton14.UseVisualStyleBackColor = false;
            operationButton14.Click += OnOperationButtonClick;
            // 
            // operationButton15
            // 
            operationButton15.BackColor = Color.FromArgb(52, 52, 52);
            operationButton15.BackgroundColor = Color.FromArgb(52, 52, 52);
            operationButton15.BorderColor = Color.PaleVioletRed;
            operationButton15.BorderRadius = 7;
            operationButton15.BorderSize = 0;
            operationButton15.Dock = DockStyle.Fill;
            operationButton15.FlatAppearance.BorderSize = 0;
            operationButton15.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 3);
            operationButton15.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            operationButton15.FlatStyle = FlatStyle.Flat;
            operationButton15.Font = new Font("Segoe UI", 14F);
            operationButton15.ForeColor = Color.FromArgb(212, 212, 212);
            operationButton15.Location = new Point(189, 69);
            operationButton15.Name = "operationButton15";
            operationButton15.OperationType = OperationButton.Types.Num6;
            operationButton15.Size = new Size(88, 60);
            operationButton15.TabIndex = 7;
            operationButton15.Text = "6";
            operationButton15.TextColor = Color.FromArgb(212, 212, 212);
            operationButton15.UseVisualStyleBackColor = false;
            operationButton15.Click += OnOperationButtonClick;
            // 
            // operationButton16
            // 
            operationButton16.BackColor = Color.FromArgb(52, 52, 52);
            operationButton16.BackgroundColor = Color.FromArgb(52, 52, 52);
            operationButton16.BorderColor = Color.PaleVioletRed;
            operationButton16.BorderRadius = 7;
            operationButton16.BorderSize = 0;
            operationButton16.Dock = DockStyle.Fill;
            operationButton16.FlatAppearance.BorderSize = 0;
            operationButton16.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 3);
            operationButton16.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            operationButton16.FlatStyle = FlatStyle.Flat;
            operationButton16.Font = new Font("Segoe UI", 14F);
            operationButton16.ForeColor = Color.FromArgb(212, 212, 212);
            operationButton16.Location = new Point(96, 135);
            operationButton16.Name = "operationButton16";
            operationButton16.OperationType = OperationButton.Types.Num8;
            operationButton16.Size = new Size(87, 60);
            operationButton16.TabIndex = 8;
            operationButton16.Text = "8";
            operationButton16.TextColor = Color.FromArgb(212, 212, 212);
            operationButton16.UseVisualStyleBackColor = false;
            operationButton16.Click += OnOperationButtonClick;
            // 
            // operationButton17
            // 
            operationButton17.BackColor = Color.FromArgb(52, 52, 52);
            operationButton17.BackgroundColor = Color.FromArgb(52, 52, 52);
            operationButton17.BorderColor = Color.PaleVioletRed;
            operationButton17.BorderRadius = 7;
            operationButton17.BorderSize = 0;
            operationButton17.Dock = DockStyle.Fill;
            operationButton17.FlatAppearance.BorderSize = 0;
            operationButton17.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 3);
            operationButton17.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            operationButton17.FlatStyle = FlatStyle.Flat;
            operationButton17.Font = new Font("Segoe UI", 14F);
            operationButton17.ForeColor = Color.FromArgb(212, 212, 212);
            operationButton17.Location = new Point(3, 135);
            operationButton17.Name = "operationButton17";
            operationButton17.OperationType = OperationButton.Types.Num7;
            operationButton17.Size = new Size(87, 60);
            operationButton17.TabIndex = 9;
            operationButton17.Text = "7";
            operationButton17.TextColor = Color.FromArgb(212, 212, 212);
            operationButton17.UseVisualStyleBackColor = false;
            operationButton17.Click += OnOperationButtonClick;
            // 
            // operationButton22
            // 
            operationButton22.BackColor = Color.FromArgb(52, 52, 52);
            operationButton22.BackgroundColor = Color.FromArgb(52, 52, 52);
            operationButton22.BorderColor = Color.PaleVioletRed;
            operationButton22.BorderRadius = 10;
            operationButton22.BorderSize = 0;
            tableLayoutPanel3.SetColumnSpan(operationButton22, 3);
            operationButton22.Dock = DockStyle.Fill;
            operationButton22.FlatAppearance.BorderSize = 0;
            operationButton22.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 3);
            operationButton22.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            operationButton22.FlatStyle = FlatStyle.Flat;
            operationButton22.Font = new Font("Segoe UI", 22F);
            operationButton22.ForeColor = Color.FromArgb(212, 212, 212);
            operationButton22.Location = new Point(3, 267);
            operationButton22.Name = "operationButton22";
            operationButton22.OperationType = OperationButton.Types.Num0;
            operationButton22.Size = new Size(204, 61);
            operationButton22.TabIndex = 15;
            operationButton22.Text = "0";
            operationButton22.TextColor = Color.FromArgb(212, 212, 212);
            operationButton22.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 5;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.Controls.Add(operationButton21, 0, 0);
            tableLayoutPanel5.Controls.Add(operationButton20, 0, 0);
            tableLayoutPanel5.Controls.Add(operationButton19, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.Padding = new Padding(3);
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(354, 54);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // operationButton21
            // 
            operationButton21.BackColor = Color.Transparent;
            operationButton21.BackgroundColor = Color.Transparent;
            operationButton21.BorderColor = Color.PaleVioletRed;
            operationButton21.BorderRadius = 6;
            operationButton21.BorderSize = 0;
            operationButton21.FlatAppearance.BorderSize = 0;
            operationButton21.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
            operationButton21.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            operationButton21.FlatStyle = FlatStyle.Flat;
            operationButton21.Font = new Font("Segoe UI", 14F);
            operationButton21.ForeColor = Color.FromArgb(212, 212, 212);
            operationButton21.Location = new Point(144, 6);
            operationButton21.Name = "operationButton21";
            operationButton21.OperationType = OperationButton.Types.MemPlus;
            operationButton21.Size = new Size(63, 40);
            operationButton21.TabIndex = 2;
            operationButton21.Text = "M+";
            operationButton21.TextColor = Color.FromArgb(212, 212, 212);
            operationButton21.UseVisualStyleBackColor = false;
            operationButton21.Click += OnOperationButtonClick;
            // 
            // operationButton20
            // 
            operationButton20.BackColor = Color.Transparent;
            operationButton20.BackgroundColor = Color.Transparent;
            operationButton20.BorderColor = Color.PaleVioletRed;
            operationButton20.BorderRadius = 6;
            operationButton20.BorderSize = 0;
            operationButton20.FlatAppearance.BorderSize = 0;
            operationButton20.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
            operationButton20.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            operationButton20.FlatStyle = FlatStyle.Flat;
            operationButton20.Font = new Font("Segoe UI", 14F);
            operationButton20.ForeColor = Color.FromArgb(212, 212, 212);
            operationButton20.Location = new Point(75, 6);
            operationButton20.Name = "operationButton20";
            operationButton20.OperationType = OperationButton.Types.MemRead;
            operationButton20.Size = new Size(63, 40);
            operationButton20.TabIndex = 1;
            operationButton20.Text = "MR";
            operationButton20.TextColor = Color.FromArgb(212, 212, 212);
            operationButton20.UseVisualStyleBackColor = false;
            operationButton20.Click += OnOperationButtonClick;
            // 
            // operationButton19
            // 
            operationButton19.BackColor = Color.Transparent;
            operationButton19.BackgroundColor = Color.Transparent;
            operationButton19.BorderColor = Color.PaleVioletRed;
            operationButton19.BorderRadius = 6;
            operationButton19.BorderSize = 0;
            operationButton19.FlatAppearance.BorderSize = 0;
            operationButton19.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
            operationButton19.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            operationButton19.FlatStyle = FlatStyle.Flat;
            operationButton19.Font = new Font("Segoe UI", 14F);
            operationButton19.ForeColor = Color.FromArgb(212, 212, 212);
            operationButton19.Location = new Point(6, 6);
            operationButton19.Name = "operationButton19";
            operationButton19.OperationType = OperationButton.Types.MemClear;
            operationButton19.Size = new Size(63, 40);
            operationButton19.TabIndex = 0;
            operationButton19.Text = "MC";
            operationButton19.TextColor = Color.FromArgb(212, 212, 212);
            operationButton19.UseVisualStyleBackColor = false;
            operationButton19.Click += OnOperationButtonClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(364, 501);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MaximumSize = new Size(800, 700);
            MinimumSize = new Size(380, 540);
            Name = "Form1";
            Padding = new Padding(5);
            Text = "Наследсков Михаил ДИПРБ11_2";
            TransparencyKey = Color.Red;
            KeyDown += FormKeyDown;
            out_area.ResumeLayout(false);
            out_area.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel out_area;
        private TextBox prevExp;
        private TextBox inout;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private OperationButton operationButton13;
        private OperationButton operationButton12;
        private OperationButton operationButton11;
        private OperationButton operationButton9;
        private OperationButton operationButton10;
        private OperationButton operationButton14;
        private OperationButton operationButton15;
        private OperationButton operationButton16;
        private OperationButton operationButton17;
        private OperationButton operationButton1;
        private OperationButton operationButton2;
        private OperationButton operationButton3;
        private OperationButton operationButton4;
        private OperationButton operationButton5;
        private OperationButton operationButton6;
        private OperationButton operationButton7;
        private OperationButton operationButton8;
        private OperationButton operationButton18;
        private TableLayoutPanel tableLayoutPanel5;
        private OperationButton operationButton19;
        private OperationButton operationButton21;
        private OperationButton operationButton20;
        private OperationButton operationButton22;
    }
}
