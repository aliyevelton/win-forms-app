namespace FinanceManager
{
    partial class ViewIncomes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewIncomes));
            label12 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label8 = new Label();
            ExitIcon4 = new PictureBox();
            label9 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dataGridView1 = new DataGridView();
            LogoutLabel4 = new Label();
            LogoutIcon4 = new PictureBox();
            ViewExpenseLabel4 = new Label();
            ViewExpenseIcon4 = new PictureBox();
            ViewIncomesLabel4 = new Label();
            ViewIncomesIcon4 = new PictureBox();
            ExpenseLabel4 = new Label();
            AddExpenseIcon4 = new PictureBox();
            IncomeLabel4 = new Label();
            AddIncomeIcon4 = new PictureBox();
            Dashboardlabel4 = new Label();
            DashboardIcon4 = new PictureBox();
            FMLogo4 = new PictureBox();
            panel13 = new Panel();
            panel1 = new Panel();
            IncomeName = new DataGridViewTextBoxColumn();
            IncomeAmount = new DataGridViewTextBoxColumn();
            IncomeCategory = new DataGridViewTextBoxColumn();
            IncomeDate = new DataGridViewTextBoxColumn();
            IncomeDescription = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ExitIcon4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoutIcon4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewExpenseIcon4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewIncomesIcon4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddExpenseIcon4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddIncomeIcon4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DashboardIcon4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FMLogo4).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(1389, 247);
            label12.Name = "label12";
            label12.Size = new Size(172, 45);
            label12.TabIndex = 46;
            label12.Text = "Categories";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            label12.Click += label12_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1567, 240);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(349, 58);
            comboBox1.TabIndex = 45;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(704, 240);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(474, 57);
            textBox1.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(478, 83);
            label8.Name = "label8";
            label8.Size = new Size(295, 59);
            label8.TabIndex = 38;
            label8.Text = "View Income";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ExitIcon4
            // 
            ExitIcon4.BackColor = Color.Transparent;
            ExitIcon4.Cursor = Cursors.Hand;
            ExitIcon4.Image = (Image)resources.GetObject("ExitIcon4.Image");
            ExitIcon4.Location = new Point(2098, 12);
            ExitIcon4.Name = "ExitIcon4";
            ExitIcon4.Size = new Size(108, 78);
            ExitIcon4.SizeMode = PictureBoxSizeMode.Zoom;
            ExitIcon4.TabIndex = 37;
            ExitIcon4.TabStop = false;
            ExitIcon4.Click += ExitIcon4_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(478, 247);
            label9.Name = "label9";
            label9.Size = new Size(220, 45);
            label9.TabIndex = 40;
            label9.Text = "Income Name";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IncomeName, IncomeAmount, IncomeCategory, IncomeDate, IncomeDescription });
            dataGridView1.Location = new Point(439, 380);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1732, 941);
            dataGridView1.TabIndex = 47;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // LogoutLabel4
            // 
            LogoutLabel4.AutoSize = true;
            LogoutLabel4.Cursor = Cursors.Hand;
            LogoutLabel4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LogoutLabel4.ForeColor = Color.Teal;
            LogoutLabel4.Location = new Point(117, 1256);
            LogoutLabel4.Name = "LogoutLabel4";
            LogoutLabel4.Size = new Size(131, 45);
            LogoutLabel4.TabIndex = 14;
            LogoutLabel4.Text = "Logout";
            LogoutLabel4.TextAlign = ContentAlignment.MiddleLeft;
            LogoutLabel4.Click += LogoutLabel4_Click;
            // 
            // LogoutIcon4
            // 
            LogoutIcon4.BackColor = SystemColors.Window;
            LogoutIcon4.Cursor = Cursors.Hand;
            LogoutIcon4.Image = (Image)resources.GetObject("LogoutIcon4.Image");
            LogoutIcon4.Location = new Point(23, 1228);
            LogoutIcon4.Name = "LogoutIcon4";
            LogoutIcon4.Size = new Size(88, 93);
            LogoutIcon4.SizeMode = PictureBoxSizeMode.Zoom;
            LogoutIcon4.TabIndex = 13;
            LogoutIcon4.TabStop = false;
            // 
            // ViewExpenseLabel4
            // 
            ViewExpenseLabel4.AutoSize = true;
            ViewExpenseLabel4.Cursor = Cursors.Hand;
            ViewExpenseLabel4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ViewExpenseLabel4.ForeColor = Color.Teal;
            ViewExpenseLabel4.Location = new Point(117, 950);
            ViewExpenseLabel4.Name = "ViewExpenseLabel4";
            ViewExpenseLabel4.Size = new Size(251, 45);
            ViewExpenseLabel4.TabIndex = 12;
            ViewExpenseLabel4.Text = "View Expenses";
            ViewExpenseLabel4.TextAlign = ContentAlignment.MiddleLeft;
            ViewExpenseLabel4.Click += ViewExpenseLabel4_Click;
            // 
            // ViewExpenseIcon4
            // 
            ViewExpenseIcon4.BackColor = SystemColors.Window;
            ViewExpenseIcon4.Cursor = Cursors.Hand;
            ViewExpenseIcon4.Image = (Image)resources.GetObject("ViewExpenseIcon4.Image");
            ViewExpenseIcon4.Location = new Point(23, 922);
            ViewExpenseIcon4.Name = "ViewExpenseIcon4";
            ViewExpenseIcon4.Size = new Size(88, 93);
            ViewExpenseIcon4.SizeMode = PictureBoxSizeMode.Zoom;
            ViewExpenseIcon4.TabIndex = 11;
            ViewExpenseIcon4.TabStop = false;
            // 
            // ViewIncomesLabel4
            // 
            ViewIncomesLabel4.AutoSize = true;
            ViewIncomesLabel4.BackColor = SystemColors.Info;
            ViewIncomesLabel4.Cursor = Cursors.Hand;
            ViewIncomesLabel4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ViewIncomesLabel4.ForeColor = Color.Teal;
            ViewIncomesLabel4.Location = new Point(117, 818);
            ViewIncomesLabel4.Name = "ViewIncomesLabel4";
            ViewIncomesLabel4.Size = new Size(221, 45);
            ViewIncomesLabel4.TabIndex = 10;
            ViewIncomesLabel4.Text = "View Income";
            ViewIncomesLabel4.TextAlign = ContentAlignment.MiddleLeft;
            ViewIncomesLabel4.Click += ViewIncomesLabel4_Click;
            // 
            // ViewIncomesIcon4
            // 
            ViewIncomesIcon4.BackColor = SystemColors.Info;
            ViewIncomesIcon4.Cursor = Cursors.Hand;
            ViewIncomesIcon4.Image = (Image)resources.GetObject("ViewIncomesIcon4.Image");
            ViewIncomesIcon4.Location = new Point(23, 790);
            ViewIncomesIcon4.Name = "ViewIncomesIcon4";
            ViewIncomesIcon4.Size = new Size(88, 93);
            ViewIncomesIcon4.SizeMode = PictureBoxSizeMode.Zoom;
            ViewIncomesIcon4.TabIndex = 9;
            ViewIncomesIcon4.TabStop = false;
            // 
            // ExpenseLabel4
            // 
            ExpenseLabel4.AutoSize = true;
            ExpenseLabel4.Cursor = Cursors.Hand;
            ExpenseLabel4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExpenseLabel4.ForeColor = Color.Teal;
            ExpenseLabel4.Location = new Point(117, 686);
            ExpenseLabel4.Name = "ExpenseLabel4";
            ExpenseLabel4.Size = new Size(225, 45);
            ExpenseLabel4.TabIndex = 8;
            ExpenseLabel4.Text = "Add Expense";
            ExpenseLabel4.TextAlign = ContentAlignment.MiddleLeft;
            ExpenseLabel4.Click += ExpenseLabel4_Click;
            // 
            // AddExpenseIcon4
            // 
            AddExpenseIcon4.BackColor = SystemColors.Window;
            AddExpenseIcon4.Cursor = Cursors.Hand;
            AddExpenseIcon4.Image = (Image)resources.GetObject("AddExpenseIcon4.Image");
            AddExpenseIcon4.Location = new Point(23, 658);
            AddExpenseIcon4.Name = "AddExpenseIcon4";
            AddExpenseIcon4.Size = new Size(88, 93);
            AddExpenseIcon4.SizeMode = PictureBoxSizeMode.Zoom;
            AddExpenseIcon4.TabIndex = 7;
            AddExpenseIcon4.TabStop = false;
            // 
            // IncomeLabel4
            // 
            IncomeLabel4.AutoSize = true;
            IncomeLabel4.Cursor = Cursors.Hand;
            IncomeLabel4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            IncomeLabel4.ForeColor = Color.Teal;
            IncomeLabel4.Location = new Point(117, 554);
            IncomeLabel4.Name = "IncomeLabel4";
            IncomeLabel4.Size = new Size(210, 45);
            IncomeLabel4.TabIndex = 6;
            IncomeLabel4.Text = "Add Income";
            IncomeLabel4.TextAlign = ContentAlignment.MiddleLeft;
            IncomeLabel4.Click += IncomeLabel4_Click;
            // 
            // AddIncomeIcon4
            // 
            AddIncomeIcon4.BackColor = SystemColors.Window;
            AddIncomeIcon4.Cursor = Cursors.Hand;
            AddIncomeIcon4.Image = (Image)resources.GetObject("AddIncomeIcon4.Image");
            AddIncomeIcon4.Location = new Point(23, 526);
            AddIncomeIcon4.Name = "AddIncomeIcon4";
            AddIncomeIcon4.Size = new Size(88, 93);
            AddIncomeIcon4.SizeMode = PictureBoxSizeMode.Zoom;
            AddIncomeIcon4.TabIndex = 5;
            AddIncomeIcon4.TabStop = false;
            // 
            // Dashboardlabel4
            // 
            Dashboardlabel4.AutoSize = true;
            Dashboardlabel4.BackColor = SystemColors.Window;
            Dashboardlabel4.Cursor = Cursors.Hand;
            Dashboardlabel4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Dashboardlabel4.ForeColor = Color.Teal;
            Dashboardlabel4.Location = new Point(117, 414);
            Dashboardlabel4.Name = "Dashboardlabel4";
            Dashboardlabel4.Size = new Size(191, 45);
            Dashboardlabel4.TabIndex = 4;
            Dashboardlabel4.Text = "Dashboard";
            Dashboardlabel4.TextAlign = ContentAlignment.MiddleLeft;
            Dashboardlabel4.Click += Dashboardlabel4_Click;
            // 
            // DashboardIcon4
            // 
            DashboardIcon4.BackColor = SystemColors.Window;
            DashboardIcon4.Cursor = Cursors.Hand;
            DashboardIcon4.Image = (Image)resources.GetObject("DashboardIcon4.Image");
            DashboardIcon4.Location = new Point(23, 386);
            DashboardIcon4.Name = "DashboardIcon4";
            DashboardIcon4.Size = new Size(88, 93);
            DashboardIcon4.SizeMode = PictureBoxSizeMode.Zoom;
            DashboardIcon4.TabIndex = 3;
            DashboardIcon4.TabStop = false;
            // 
            // FMLogo4
            // 
            FMLogo4.BackColor = SystemColors.Window;
            FMLogo4.Image = (Image)resources.GetObject("FMLogo4.Image");
            FMLogo4.Location = new Point(0, -58);
            FMLogo4.Name = "FMLogo4";
            FMLogo4.Size = new Size(435, 391);
            FMLogo4.SizeMode = PictureBoxSizeMode.Zoom;
            FMLogo4.TabIndex = 1;
            FMLogo4.TabStop = false;
            // 
            // panel13
            // 
            panel13.BackColor = SystemColors.Info;
            panel13.Cursor = Cursors.Hand;
            panel13.Location = new Point(0, 771);
            panel13.Name = "panel13";
            panel13.Size = new Size(400, 133);
            panel13.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(LogoutLabel4);
            panel1.Controls.Add(LogoutIcon4);
            panel1.Controls.Add(ViewExpenseLabel4);
            panel1.Controls.Add(ViewExpenseIcon4);
            panel1.Controls.Add(ViewIncomesLabel4);
            panel1.Controls.Add(ViewIncomesIcon4);
            panel1.Controls.Add(ExpenseLabel4);
            panel1.Controls.Add(AddExpenseIcon4);
            panel1.Controls.Add(IncomeLabel4);
            panel1.Controls.Add(AddIncomeIcon4);
            panel1.Controls.Add(Dashboardlabel4);
            panel1.Controls.Add(DashboardIcon4);
            panel1.Controls.Add(FMLogo4);
            panel1.Controls.Add(panel13);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 1372);
            panel1.TabIndex = 48;
            // 
            // IncomeName
            // 
            IncomeName.HeaderText = "Income Name";
            IncomeName.MinimumWidth = 10;
            IncomeName.Name = "IncomeName";
            // 
            // IncomeAmount
            // 
            IncomeAmount.HeaderText = "Amount";
            IncomeAmount.MinimumWidth = 10;
            IncomeAmount.Name = "IncomeAmount";
            // 
            // IncomeCategory
            // 
            IncomeCategory.HeaderText = "Category";
            IncomeCategory.MinimumWidth = 10;
            IncomeCategory.Name = "IncomeCategory";
            // 
            // IncomeDate
            // 
            IncomeDate.HeaderText = "Date";
            IncomeDate.MinimumWidth = 10;
            IncomeDate.Name = "IncomeDate";
            // 
            // IncomeDescription
            // 
            IncomeDescription.HeaderText = "Description";
            IncomeDescription.MinimumWidth = 10;
            IncomeDescription.Name = "IncomeDescription";
            // 
            // ViewIncomes
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2211, 1372);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label9);
            Controls.Add(label12);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(ExitIcon4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewIncomes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewIncomes";
            ((System.ComponentModel.ISupportInitialize)ExitIcon4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoutIcon4).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewExpenseIcon4).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewIncomesIcon4).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddExpenseIcon4).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddIncomeIcon4).EndInit();
            ((System.ComponentModel.ISupportInitialize)DashboardIcon4).EndInit();
            ((System.ComponentModel.ISupportInitialize)FMLogo4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label12;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label8;
        private PictureBox ExitIcon4;
        private Label label9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dataGridView1;
        private Label LogoutLabel4;
        private PictureBox LogoutIcon4;
        private Label ViewExpenseLabel4;
        private PictureBox ViewExpenseIcon4;
        private Label ViewIncomesLabel4;
        private PictureBox ViewIncomesIcon4;
        private Label ExpenseLabel4;
        private PictureBox AddExpenseIcon4;
        private Label IncomeLabel4;
        private PictureBox AddIncomeIcon4;
        private Label Dashboardlabel4;
        private PictureBox DashboardIcon4;
        private PictureBox FMLogo4;
        private Panel panel13;
        private Panel panel1;
        private DataGridViewTextBoxColumn IncomeName;
        private DataGridViewTextBoxColumn IncomeAmount;
        private DataGridViewTextBoxColumn IncomeCategory;
        private DataGridViewTextBoxColumn IncomeDate;
        private DataGridViewTextBoxColumn IncomeDescription;
    }
}