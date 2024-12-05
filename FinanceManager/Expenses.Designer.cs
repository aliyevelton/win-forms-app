namespace FinanceManager
{
    partial class Expenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expenses));
            textBox2 = new TextBox();
            label9 = new Label();
            label12 = new Label();
            comboBox1 = new ComboBox();
            label11 = new Label();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            AddExpenseBtn = new Button();
            label19 = new Label();
            label20 = new Label();
            label13 = new Label();
            textBox1 = new TextBox();
            panel4 = new Panel();
            label8 = new Label();
            ExitIcon3 = new PictureBox();
            LogoutLabel3 = new Label();
            LogoutIcon3 = new PictureBox();
            ViewExpenseLabel3 = new Label();
            ViewExpenseIcon3 = new PictureBox();
            ViewIncomeLabel3 = new Label();
            ViewIncomeIcon3 = new PictureBox();
            ExpenseLabel3 = new Label();
            AddExpenseIcon3 = new PictureBox();
            IncomeLabel3 = new Label();
            AddIncomeIcon3 = new PictureBox();
            DashboardLabel3 = new Label();
            DashboardIcon3 = new PictureBox();
            FMLogo3 = new PictureBox();
            panel13 = new Panel();
            panel1 = new Panel();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExitIcon3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoutIcon3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewExpenseIcon3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewIncomeIcon3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddExpenseIcon3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddIncomeIcon3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DashboardIcon3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FMLogo3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(478, 422);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(474, 57);
            textBox2.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(478, 208);
            label9.Name = "label9";
            label9.Size = new Size(230, 45);
            label9.TabIndex = 40;
            label9.Text = "Expense Name";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(1152, 208);
            label12.Name = "label12";
            label12.Size = new Size(148, 45);
            label12.TabIndex = 46;
            label12.Text = "Category";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "salam", "sagol" });
            comboBox1.Location = new Point(1152, 261);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(349, 58);
            comboBox1.TabIndex = 45;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(478, 543);
            label11.Name = "label11";
            label11.Size = new Size(182, 45);
            label11.TabIndex = 44;
            label11.Text = "Description";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(478, 596);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(474, 267);
            textBox3.TabIndex = 43;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(1152, 422);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(349, 57);
            dateTimePicker1.TabIndex = 47;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(478, 369);
            label10.Name = "label10";
            label10.Size = new Size(135, 45);
            label10.TabIndex = 42;
            label10.Text = "Amount";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddExpenseBtn
            // 
            AddExpenseBtn.BackColor = SystemColors.Info;
            AddExpenseBtn.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            AddExpenseBtn.Location = new Point(1222, 793);
            AddExpenseBtn.Name = "AddExpenseBtn";
            AddExpenseBtn.Size = new Size(279, 70);
            AddExpenseBtn.TabIndex = 49;
            AddExpenseBtn.Text = "Add Expense";
            AddExpenseBtn.UseVisualStyleBackColor = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.ActiveCaptionText;
            label19.Location = new Point(19, 83);
            label19.Name = "label19";
            label19.Size = new Size(281, 45);
            label19.TabIndex = 7;
            label19.Text = "AmountInManats";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = SystemColors.ActiveCaptionText;
            label20.Location = new Point(19, 20);
            label20.Name = "label20";
            label20.Size = new Size(203, 45);
            label20.TabIndex = 6;
            label20.Text = "Total Income";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(1152, 369);
            label13.Name = "label13";
            label13.Size = new Size(86, 45);
            label13.TabIndex = 48;
            label13.Text = "Date";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(478, 261);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(474, 57);
            textBox1.TabIndex = 35;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 255, 192);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(label20);
            panel4.Location = new Point(1721, 171);
            panel4.Name = "panel4";
            panel4.Size = new Size(350, 154);
            panel4.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(478, 83);
            label8.Name = "label8";
            label8.Size = new Size(395, 59);
            label8.TabIndex = 38;
            label8.Text = "Personal Expense";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ExitIcon3
            // 
            ExitIcon3.BackColor = Color.Transparent;
            ExitIcon3.Cursor = Cursors.Hand;
            ExitIcon3.Image = (Image)resources.GetObject("ExitIcon3.Image");
            ExitIcon3.Location = new Point(2098, 12);
            ExitIcon3.Name = "ExitIcon3";
            ExitIcon3.Size = new Size(108, 78);
            ExitIcon3.SizeMode = PictureBoxSizeMode.Zoom;
            ExitIcon3.TabIndex = 37;
            ExitIcon3.TabStop = false;
            ExitIcon3.Click += ExitIcon3_Click;
            // 
            // LogoutLabel3
            // 
            LogoutLabel3.AutoSize = true;
            LogoutLabel3.Cursor = Cursors.Hand;
            LogoutLabel3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LogoutLabel3.ForeColor = Color.Teal;
            LogoutLabel3.Location = new Point(117, 1256);
            LogoutLabel3.Name = "LogoutLabel3";
            LogoutLabel3.Size = new Size(131, 45);
            LogoutLabel3.TabIndex = 14;
            LogoutLabel3.Text = "Logout";
            LogoutLabel3.TextAlign = ContentAlignment.MiddleLeft;
            LogoutLabel3.Click += LogoutLabel3_Click;
            // 
            // LogoutIcon3
            // 
            LogoutIcon3.BackColor = SystemColors.Window;
            LogoutIcon3.Cursor = Cursors.Hand;
            LogoutIcon3.Image = (Image)resources.GetObject("LogoutIcon3.Image");
            LogoutIcon3.Location = new Point(23, 1228);
            LogoutIcon3.Name = "LogoutIcon3";
            LogoutIcon3.Size = new Size(88, 93);
            LogoutIcon3.SizeMode = PictureBoxSizeMode.Zoom;
            LogoutIcon3.TabIndex = 13;
            LogoutIcon3.TabStop = false;
            // 
            // ViewExpenseLabel3
            // 
            ViewExpenseLabel3.AutoSize = true;
            ViewExpenseLabel3.Cursor = Cursors.Hand;
            ViewExpenseLabel3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ViewExpenseLabel3.ForeColor = Color.Teal;
            ViewExpenseLabel3.Location = new Point(117, 950);
            ViewExpenseLabel3.Name = "ViewExpenseLabel3";
            ViewExpenseLabel3.Size = new Size(251, 45);
            ViewExpenseLabel3.TabIndex = 12;
            ViewExpenseLabel3.Text = "View Expenses";
            ViewExpenseLabel3.TextAlign = ContentAlignment.MiddleLeft;
            ViewExpenseLabel3.Click += ViewExpenseLabel3_Click;
            // 
            // ViewExpenseIcon3
            // 
            ViewExpenseIcon3.BackColor = SystemColors.Window;
            ViewExpenseIcon3.Cursor = Cursors.Hand;
            ViewExpenseIcon3.Image = (Image)resources.GetObject("ViewExpenseIcon3.Image");
            ViewExpenseIcon3.Location = new Point(23, 922);
            ViewExpenseIcon3.Name = "ViewExpenseIcon3";
            ViewExpenseIcon3.Size = new Size(88, 93);
            ViewExpenseIcon3.SizeMode = PictureBoxSizeMode.Zoom;
            ViewExpenseIcon3.TabIndex = 11;
            ViewExpenseIcon3.TabStop = false;
            // 
            // ViewIncomeLabel3
            // 
            ViewIncomeLabel3.AutoSize = true;
            ViewIncomeLabel3.Cursor = Cursors.Hand;
            ViewIncomeLabel3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ViewIncomeLabel3.ForeColor = Color.Teal;
            ViewIncomeLabel3.Location = new Point(117, 818);
            ViewIncomeLabel3.Name = "ViewIncomeLabel3";
            ViewIncomeLabel3.Size = new Size(221, 45);
            ViewIncomeLabel3.TabIndex = 10;
            ViewIncomeLabel3.Text = "View Income";
            ViewIncomeLabel3.TextAlign = ContentAlignment.MiddleLeft;
            ViewIncomeLabel3.Click += ViewIncomeLabel3_Click;
            // 
            // ViewIncomeIcon3
            // 
            ViewIncomeIcon3.BackColor = SystemColors.Window;
            ViewIncomeIcon3.Cursor = Cursors.Hand;
            ViewIncomeIcon3.Image = (Image)resources.GetObject("ViewIncomeIcon3.Image");
            ViewIncomeIcon3.Location = new Point(23, 790);
            ViewIncomeIcon3.Name = "ViewIncomeIcon3";
            ViewIncomeIcon3.Size = new Size(88, 93);
            ViewIncomeIcon3.SizeMode = PictureBoxSizeMode.Zoom;
            ViewIncomeIcon3.TabIndex = 9;
            ViewIncomeIcon3.TabStop = false;
            // 
            // ExpenseLabel3
            // 
            ExpenseLabel3.AutoSize = true;
            ExpenseLabel3.BackColor = SystemColors.Info;
            ExpenseLabel3.Cursor = Cursors.Hand;
            ExpenseLabel3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExpenseLabel3.ForeColor = Color.Teal;
            ExpenseLabel3.Location = new Point(117, 686);
            ExpenseLabel3.Name = "ExpenseLabel3";
            ExpenseLabel3.Size = new Size(225, 45);
            ExpenseLabel3.TabIndex = 8;
            ExpenseLabel3.Text = "Add Expense";
            ExpenseLabel3.TextAlign = ContentAlignment.MiddleLeft;
            ExpenseLabel3.Click += ExpenseLabel3_Click;
            // 
            // AddExpenseIcon3
            // 
            AddExpenseIcon3.BackColor = SystemColors.Info;
            AddExpenseIcon3.Cursor = Cursors.Hand;
            AddExpenseIcon3.Image = (Image)resources.GetObject("AddExpenseIcon3.Image");
            AddExpenseIcon3.Location = new Point(23, 658);
            AddExpenseIcon3.Name = "AddExpenseIcon3";
            AddExpenseIcon3.Size = new Size(88, 93);
            AddExpenseIcon3.SizeMode = PictureBoxSizeMode.Zoom;
            AddExpenseIcon3.TabIndex = 7;
            AddExpenseIcon3.TabStop = false;
            // 
            // IncomeLabel3
            // 
            IncomeLabel3.AutoSize = true;
            IncomeLabel3.Cursor = Cursors.Hand;
            IncomeLabel3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            IncomeLabel3.ForeColor = Color.Teal;
            IncomeLabel3.Location = new Point(117, 554);
            IncomeLabel3.Name = "IncomeLabel3";
            IncomeLabel3.Size = new Size(210, 45);
            IncomeLabel3.TabIndex = 6;
            IncomeLabel3.Text = "Add Income";
            IncomeLabel3.TextAlign = ContentAlignment.MiddleLeft;
            IncomeLabel3.Click += IncomeLabel3_Click;
            // 
            // AddIncomeIcon3
            // 
            AddIncomeIcon3.BackColor = SystemColors.Window;
            AddIncomeIcon3.Cursor = Cursors.Hand;
            AddIncomeIcon3.Image = (Image)resources.GetObject("AddIncomeIcon3.Image");
            AddIncomeIcon3.Location = new Point(23, 526);
            AddIncomeIcon3.Name = "AddIncomeIcon3";
            AddIncomeIcon3.Size = new Size(88, 93);
            AddIncomeIcon3.SizeMode = PictureBoxSizeMode.Zoom;
            AddIncomeIcon3.TabIndex = 5;
            AddIncomeIcon3.TabStop = false;
            // 
            // DashboardLabel3
            // 
            DashboardLabel3.AutoSize = true;
            DashboardLabel3.BackColor = SystemColors.Window;
            DashboardLabel3.Cursor = Cursors.Hand;
            DashboardLabel3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DashboardLabel3.ForeColor = Color.Teal;
            DashboardLabel3.Location = new Point(117, 414);
            DashboardLabel3.Name = "DashboardLabel3";
            DashboardLabel3.Size = new Size(191, 45);
            DashboardLabel3.TabIndex = 4;
            DashboardLabel3.Text = "Dashboard";
            DashboardLabel3.TextAlign = ContentAlignment.MiddleLeft;
            DashboardLabel3.Click += DashboardLabel3_Click;
            // 
            // DashboardIcon3
            // 
            DashboardIcon3.BackColor = SystemColors.Window;
            DashboardIcon3.Cursor = Cursors.Hand;
            DashboardIcon3.Image = (Image)resources.GetObject("DashboardIcon3.Image");
            DashboardIcon3.Location = new Point(23, 386);
            DashboardIcon3.Name = "DashboardIcon3";
            DashboardIcon3.Size = new Size(88, 93);
            DashboardIcon3.SizeMode = PictureBoxSizeMode.Zoom;
            DashboardIcon3.TabIndex = 3;
            DashboardIcon3.TabStop = false;
            // 
            // FMLogo3
            // 
            FMLogo3.BackColor = SystemColors.Window;
            FMLogo3.Image = (Image)resources.GetObject("FMLogo3.Image");
            FMLogo3.Location = new Point(0, -58);
            FMLogo3.Name = "FMLogo3";
            FMLogo3.Size = new Size(435, 391);
            FMLogo3.SizeMode = PictureBoxSizeMode.Zoom;
            FMLogo3.TabIndex = 1;
            FMLogo3.TabStop = false;
            // 
            // panel13
            // 
            panel13.BackColor = SystemColors.Info;
            panel13.Cursor = Cursors.Hand;
            panel13.Location = new Point(0, 635);
            panel13.Name = "panel13";
            panel13.Size = new Size(400, 133);
            panel13.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(LogoutLabel3);
            panel1.Controls.Add(LogoutIcon3);
            panel1.Controls.Add(ViewExpenseLabel3);
            panel1.Controls.Add(ViewExpenseIcon3);
            panel1.Controls.Add(ViewIncomeLabel3);
            panel1.Controls.Add(ViewIncomeIcon3);
            panel1.Controls.Add(ExpenseLabel3);
            panel1.Controls.Add(AddExpenseIcon3);
            panel1.Controls.Add(IncomeLabel3);
            panel1.Controls.Add(AddIncomeIcon3);
            panel1.Controls.Add(DashboardLabel3);
            panel1.Controls.Add(DashboardIcon3);
            panel1.Controls.Add(FMLogo3);
            panel1.Controls.Add(panel13);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 1372);
            panel1.TabIndex = 50;
            // 
            // Expenses
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(2211, 1372);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(label9);
            Controls.Add(label12);
            Controls.Add(comboBox1);
            Controls.Add(label11);
            Controls.Add(textBox3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label10);
            Controls.Add(AddExpenseBtn);
            Controls.Add(label13);
            Controls.Add(textBox1);
            Controls.Add(panel4);
            Controls.Add(label8);
            Controls.Add(ExitIcon3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Expenses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expenses";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ExitIcon3).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoutIcon3).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewExpenseIcon3).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewIncomeIcon3).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddExpenseIcon3).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddIncomeIcon3).EndInit();
            ((System.ComponentModel.ISupportInitialize)DashboardIcon3).EndInit();
            ((System.ComponentModel.ISupportInitialize)FMLogo3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private Label label9;
        private Label label12;
        private ComboBox comboBox1;
        private Label label11;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private Button AddExpenseBtn;
        private Label label19;
        private Label label20;
        private Label label13;
        private TextBox textBox1;
        private Panel panel4;
        private Label label8;
        private PictureBox ExitIcon3;
        private Label LogoutLabel3;
        private PictureBox LogoutIcon3;
        private Label ViewExpenseLabel3;
        private PictureBox ViewExpenseIcon3;
        private Label ViewIncomeLabel3;
        private PictureBox ViewIncomeIcon3;
        private Label ExpenseLabel3;
        private PictureBox AddExpenseIcon3;
        private Label IncomeLabel3;
        private PictureBox AddIncomeIcon3;
        private Label DashboardLabel3;
        private PictureBox DashboardIcon3;
        private PictureBox FMLogo3;
        private Panel panel13;
        private Panel panel1;
    }
}