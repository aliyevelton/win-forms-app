namespace FinanceManager
{
    partial class ViewExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewExpenses));
            label9 = new Label();
            textBox1 = new TextBox();
            label8 = new Label();
            ExitIcon5 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            comboBox1 = new ComboBox();
            label12 = new Label();
            LogoutLabel5 = new Label();
            LogoutIcon5 = new PictureBox();
            ViewExpenseLabel5 = new Label();
            ViewExpenseIcon5 = new PictureBox();
            ViewIncomeLabel5 = new Label();
            ViewIncomeIcon5 = new PictureBox();
            ExpenseLabel5 = new Label();
            AddExpenseIcon5 = new PictureBox();
            IncomeLabel5 = new Label();
            AddIncomeIcon5 = new PictureBox();
            DashboardLabel5 = new Label();
            DashboardIcon5 = new PictureBox();
            FMLogo5 = new PictureBox();
            panel13 = new Panel();
            panel1 = new Panel();
            dataGridView2 = new DataGridView();
            ExpenseName = new DataGridViewTextBoxColumn();
            ExpenseAmount = new DataGridViewTextBoxColumn();
            ExpenseCategory = new DataGridViewTextBoxColumn();
            ExpenseDate = new DataGridViewTextBoxColumn();
            ExpenseDescription = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ExitIcon5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoutIcon5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewExpenseIcon5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewIncomeIcon5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddExpenseIcon5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddIncomeIcon5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DashboardIcon5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FMLogo5).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(480, 247);
            label9.Name = "label9";
            label9.Size = new Size(230, 45);
            label9.TabIndex = 52;
            label9.Text = "Expense Name";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(716, 240);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(474, 57);
            textBox1.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(480, 83);
            label8.Name = "label8";
            label8.Size = new Size(336, 59);
            label8.TabIndex = 51;
            label8.Text = "View Expenses";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ExitIcon5
            // 
            ExitIcon5.BackColor = Color.Transparent;
            ExitIcon5.Cursor = Cursors.Hand;
            ExitIcon5.Image = (Image)resources.GetObject("ExitIcon5.Image");
            ExitIcon5.Location = new Point(2100, 12);
            ExitIcon5.Name = "ExitIcon5";
            ExitIcon5.Size = new Size(108, 78);
            ExitIcon5.SizeMode = PictureBoxSizeMode.Zoom;
            ExitIcon5.TabIndex = 50;
            ExitIcon5.TabStop = false;
            ExitIcon5.Click += ExitIcon5_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1569, 240);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(349, 58);
            comboBox1.TabIndex = 53;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(1391, 247);
            label12.Name = "label12";
            label12.Size = new Size(172, 45);
            label12.TabIndex = 54;
            label12.Text = "Categories";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LogoutLabel5
            // 
            LogoutLabel5.AutoSize = true;
            LogoutLabel5.Cursor = Cursors.Hand;
            LogoutLabel5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LogoutLabel5.ForeColor = Color.Teal;
            LogoutLabel5.Location = new Point(117, 1256);
            LogoutLabel5.Name = "LogoutLabel5";
            LogoutLabel5.Size = new Size(131, 45);
            LogoutLabel5.TabIndex = 14;
            LogoutLabel5.Text = "Logout";
            LogoutLabel5.TextAlign = ContentAlignment.MiddleLeft;
            LogoutLabel5.Click += LogoutLabel5_Click;
            // 
            // LogoutIcon5
            // 
            LogoutIcon5.BackColor = SystemColors.Window;
            LogoutIcon5.Cursor = Cursors.Hand;
            LogoutIcon5.Image = (Image)resources.GetObject("LogoutIcon5.Image");
            LogoutIcon5.Location = new Point(23, 1228);
            LogoutIcon5.Name = "LogoutIcon5";
            LogoutIcon5.Size = new Size(88, 93);
            LogoutIcon5.SizeMode = PictureBoxSizeMode.Zoom;
            LogoutIcon5.TabIndex = 13;
            LogoutIcon5.TabStop = false;
            // 
            // ViewExpenseLabel5
            // 
            ViewExpenseLabel5.AutoSize = true;
            ViewExpenseLabel5.BackColor = SystemColors.Info;
            ViewExpenseLabel5.Cursor = Cursors.Hand;
            ViewExpenseLabel5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ViewExpenseLabel5.ForeColor = Color.Teal;
            ViewExpenseLabel5.Location = new Point(117, 950);
            ViewExpenseLabel5.Name = "ViewExpenseLabel5";
            ViewExpenseLabel5.Size = new Size(251, 45);
            ViewExpenseLabel5.TabIndex = 12;
            ViewExpenseLabel5.Text = "View Expenses";
            ViewExpenseLabel5.TextAlign = ContentAlignment.MiddleLeft;
            ViewExpenseLabel5.Click += ViewExpenseLabel5_Click;
            // 
            // ViewExpenseIcon5
            // 
            ViewExpenseIcon5.BackColor = SystemColors.Info;
            ViewExpenseIcon5.Cursor = Cursors.Hand;
            ViewExpenseIcon5.Image = (Image)resources.GetObject("ViewExpenseIcon5.Image");
            ViewExpenseIcon5.Location = new Point(23, 922);
            ViewExpenseIcon5.Name = "ViewExpenseIcon5";
            ViewExpenseIcon5.Size = new Size(88, 93);
            ViewExpenseIcon5.SizeMode = PictureBoxSizeMode.Zoom;
            ViewExpenseIcon5.TabIndex = 11;
            ViewExpenseIcon5.TabStop = false;
            // 
            // ViewIncomeLabel5
            // 
            ViewIncomeLabel5.AutoSize = true;
            ViewIncomeLabel5.Cursor = Cursors.Hand;
            ViewIncomeLabel5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ViewIncomeLabel5.ForeColor = Color.Teal;
            ViewIncomeLabel5.Location = new Point(117, 818);
            ViewIncomeLabel5.Name = "ViewIncomeLabel5";
            ViewIncomeLabel5.Size = new Size(221, 45);
            ViewIncomeLabel5.TabIndex = 10;
            ViewIncomeLabel5.Text = "View Income";
            ViewIncomeLabel5.TextAlign = ContentAlignment.MiddleLeft;
            ViewIncomeLabel5.Click += ViewIncomeLabel5_Click;
            // 
            // ViewIncomeIcon5
            // 
            ViewIncomeIcon5.BackColor = SystemColors.Window;
            ViewIncomeIcon5.Cursor = Cursors.Hand;
            ViewIncomeIcon5.Image = (Image)resources.GetObject("ViewIncomeIcon5.Image");
            ViewIncomeIcon5.Location = new Point(23, 790);
            ViewIncomeIcon5.Name = "ViewIncomeIcon5";
            ViewIncomeIcon5.Size = new Size(88, 93);
            ViewIncomeIcon5.SizeMode = PictureBoxSizeMode.Zoom;
            ViewIncomeIcon5.TabIndex = 9;
            ViewIncomeIcon5.TabStop = false;
            // 
            // ExpenseLabel5
            // 
            ExpenseLabel5.AutoSize = true;
            ExpenseLabel5.Cursor = Cursors.Hand;
            ExpenseLabel5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExpenseLabel5.ForeColor = Color.Teal;
            ExpenseLabel5.Location = new Point(117, 686);
            ExpenseLabel5.Name = "ExpenseLabel5";
            ExpenseLabel5.Size = new Size(225, 45);
            ExpenseLabel5.TabIndex = 8;
            ExpenseLabel5.Text = "Add Expense";
            ExpenseLabel5.TextAlign = ContentAlignment.MiddleLeft;
            ExpenseLabel5.Click += ExpenseLabel5_Click;
            // 
            // AddExpenseIcon5
            // 
            AddExpenseIcon5.BackColor = SystemColors.Window;
            AddExpenseIcon5.Cursor = Cursors.Hand;
            AddExpenseIcon5.Image = (Image)resources.GetObject("AddExpenseIcon5.Image");
            AddExpenseIcon5.Location = new Point(23, 658);
            AddExpenseIcon5.Name = "AddExpenseIcon5";
            AddExpenseIcon5.Size = new Size(88, 93);
            AddExpenseIcon5.SizeMode = PictureBoxSizeMode.Zoom;
            AddExpenseIcon5.TabIndex = 7;
            AddExpenseIcon5.TabStop = false;
            // 
            // IncomeLabel5
            // 
            IncomeLabel5.AutoSize = true;
            IncomeLabel5.Cursor = Cursors.Hand;
            IncomeLabel5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            IncomeLabel5.ForeColor = Color.Teal;
            IncomeLabel5.Location = new Point(117, 554);
            IncomeLabel5.Name = "IncomeLabel5";
            IncomeLabel5.Size = new Size(210, 45);
            IncomeLabel5.TabIndex = 6;
            IncomeLabel5.Text = "Add Income";
            IncomeLabel5.TextAlign = ContentAlignment.MiddleLeft;
            IncomeLabel5.Click += IncomeLabel5_Click;
            // 
            // AddIncomeIcon5
            // 
            AddIncomeIcon5.BackColor = SystemColors.Window;
            AddIncomeIcon5.Cursor = Cursors.Hand;
            AddIncomeIcon5.Image = (Image)resources.GetObject("AddIncomeIcon5.Image");
            AddIncomeIcon5.Location = new Point(23, 526);
            AddIncomeIcon5.Name = "AddIncomeIcon5";
            AddIncomeIcon5.Size = new Size(88, 93);
            AddIncomeIcon5.SizeMode = PictureBoxSizeMode.Zoom;
            AddIncomeIcon5.TabIndex = 5;
            AddIncomeIcon5.TabStop = false;
            // 
            // DashboardLabel5
            // 
            DashboardLabel5.AutoSize = true;
            DashboardLabel5.BackColor = SystemColors.Window;
            DashboardLabel5.Cursor = Cursors.Hand;
            DashboardLabel5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DashboardLabel5.ForeColor = Color.Teal;
            DashboardLabel5.Location = new Point(117, 414);
            DashboardLabel5.Name = "DashboardLabel5";
            DashboardLabel5.Size = new Size(191, 45);
            DashboardLabel5.TabIndex = 4;
            DashboardLabel5.Text = "Dashboard";
            DashboardLabel5.TextAlign = ContentAlignment.MiddleLeft;
            DashboardLabel5.Click += DashboardLabel5_Click;
            // 
            // DashboardIcon5
            // 
            DashboardIcon5.BackColor = SystemColors.Window;
            DashboardIcon5.Cursor = Cursors.Hand;
            DashboardIcon5.Image = (Image)resources.GetObject("DashboardIcon5.Image");
            DashboardIcon5.Location = new Point(23, 386);
            DashboardIcon5.Name = "DashboardIcon5";
            DashboardIcon5.Size = new Size(88, 93);
            DashboardIcon5.SizeMode = PictureBoxSizeMode.Zoom;
            DashboardIcon5.TabIndex = 3;
            DashboardIcon5.TabStop = false;
            // 
            // FMLogo5
            // 
            FMLogo5.BackColor = SystemColors.Window;
            FMLogo5.Image = (Image)resources.GetObject("FMLogo5.Image");
            FMLogo5.Location = new Point(0, -58);
            FMLogo5.Name = "FMLogo5";
            FMLogo5.Size = new Size(435, 391);
            FMLogo5.SizeMode = PictureBoxSizeMode.Zoom;
            FMLogo5.TabIndex = 1;
            FMLogo5.TabStop = false;
            // 
            // panel13
            // 
            panel13.BackColor = SystemColors.Info;
            panel13.Cursor = Cursors.Hand;
            panel13.Location = new Point(0, 903);
            panel13.Name = "panel13";
            panel13.Size = new Size(400, 133);
            panel13.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(LogoutLabel5);
            panel1.Controls.Add(LogoutIcon5);
            panel1.Controls.Add(ViewExpenseLabel5);
            panel1.Controls.Add(ViewExpenseIcon5);
            panel1.Controls.Add(ViewIncomeLabel5);
            panel1.Controls.Add(ViewIncomeIcon5);
            panel1.Controls.Add(ExpenseLabel5);
            panel1.Controls.Add(AddExpenseIcon5);
            panel1.Controls.Add(IncomeLabel5);
            panel1.Controls.Add(AddIncomeIcon5);
            panel1.Controls.Add(DashboardLabel5);
            panel1.Controls.Add(DashboardIcon5);
            panel1.Controls.Add(FMLogo5);
            panel1.Controls.Add(panel13);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 1372);
            panel1.TabIndex = 56;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = SystemColors.Window;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ExpenseName, ExpenseAmount, ExpenseCategory, ExpenseDate, ExpenseDescription });
            dataGridView2.Location = new Point(441, 380);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 82;
            dataGridView2.RowTemplate.Height = 41;
            dataGridView2.Size = new Size(1732, 941);
            dataGridView2.TabIndex = 57;
            // 
            // ExpenseName
            // 
            ExpenseName.HeaderText = "Expense Name";
            ExpenseName.MinimumWidth = 10;
            ExpenseName.Name = "ExpenseName";
            // 
            // ExpenseAmount
            // 
            ExpenseAmount.HeaderText = "Amount";
            ExpenseAmount.MinimumWidth = 10;
            ExpenseAmount.Name = "ExpenseAmount";
            // 
            // ExpenseCategory
            // 
            ExpenseCategory.HeaderText = "Category";
            ExpenseCategory.MinimumWidth = 10;
            ExpenseCategory.Name = "ExpenseCategory";
            // 
            // ExpenseDate
            // 
            ExpenseDate.HeaderText = "Date";
            ExpenseDate.MinimumWidth = 10;
            ExpenseDate.Name = "ExpenseDate";
            // 
            // ExpenseDescription
            // 
            ExpenseDescription.HeaderText = "Description";
            ExpenseDescription.MinimumWidth = 10;
            ExpenseDescription.Name = "ExpenseDescription";
            // 
            // ViewExpenses
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2211, 1372);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(ExitIcon5);
            Controls.Add(comboBox1);
            Controls.Add(label12);
            Controls.Add(dataGridView2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewExpenses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewExpenses";
            ((System.ComponentModel.ISupportInitialize)ExitIcon5).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoutIcon5).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewExpenseIcon5).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewIncomeIcon5).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddExpenseIcon5).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddIncomeIcon5).EndInit();
            ((System.ComponentModel.ISupportInitialize)DashboardIcon5).EndInit();
            ((System.ComponentModel.ISupportInitialize)FMLogo5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private TextBox textBox1;
        private Label label8;
        private PictureBox ExitIcon5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox comboBox1;
        private Label label12;
        private Label LogoutLabel5;
        private PictureBox LogoutIcon5;
        private Label ViewExpenseLabel5;
        private PictureBox ViewExpenseIcon5;
        private Label ViewIncomeLabel5;
        private PictureBox ViewIncomeIcon5;
        private Label ExpenseLabel5;
        private PictureBox AddExpenseIcon5;
        private Label IncomeLabel5;
        private PictureBox AddIncomeIcon5;
        private Label DashboardLabel5;
        private PictureBox DashboardIcon5;
        private PictureBox FMLogo5;
        private Panel panel13;
        private Panel panel1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn ExpenseName;
        private DataGridViewTextBoxColumn ExpenseAmount;
        private DataGridViewTextBoxColumn ExpenseCategory;
        private DataGridViewTextBoxColumn ExpenseDate;
        private DataGridViewTextBoxColumn ExpenseDescription;
    }
}