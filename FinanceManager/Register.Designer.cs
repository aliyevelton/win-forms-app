namespace FinanceManager
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            NoAccountText = new Label();
            LoginBtn = new Button();
            RegisterBtn = new Button();
            RegisterPasswordLabel = new Label();
            PasswordInput = new TextBox();
            FullNameLabel = new Label();
            FullNameInput = new TextBox();
            LoginLogo = new PictureBox();
            RegisterUsernameLabel = new Label();
            RegisterUsernameInput = new TextBox();
            ConfirmPasswordLabel = new Label();
            ConfirmPasswordInput = new TextBox();
            ((System.ComponentModel.ISupportInitialize)LoginLogo).BeginInit();
            SuspendLayout();
            // 
            // NoAccountText
            // 
            NoAccountText.AutoSize = true;
            NoAccountText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NoAccountText.ForeColor = SystemColors.ActiveCaptionText;
            NoAccountText.Location = new Point(410, 715);
            NoAccountText.Name = "NoAccountText";
            NoAccountText.Size = new Size(380, 45);
            NoAccountText.TabIndex = 45;
            NoAccountText.Text = "Already have an account?";
            NoAccountText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.ControlLightLight;
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.Font = new Font("Segoe UI Semibold", 11.875F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.Location = new Point(508, 772);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(168, 66);
            LoginBtn.TabIndex = 101;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.Black;
            RegisterBtn.Cursor = Cursors.Hand;
            RegisterBtn.Font = new Font("Segoe UI Semibold", 12.875F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterBtn.ForeColor = SystemColors.Window;
            RegisterBtn.Location = new Point(821, 565);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(216, 81);
            RegisterBtn.TabIndex = 100;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // RegisterPasswordLabel
            // 
            RegisterPasswordLabel.AutoSize = true;
            RegisterPasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterPasswordLabel.ForeColor = SystemColors.ActiveCaptionText;
            RegisterPasswordLabel.Location = new Point(654, 268);
            RegisterPasswordLabel.Name = "RegisterPasswordLabel";
            RegisterPasswordLabel.Size = new Size(153, 45);
            RegisterPasswordLabel.TabIndex = 42;
            RegisterPasswordLabel.Text = "Password";
            RegisterPasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PasswordInput
            // 
            PasswordInput.BorderStyle = BorderStyle.FixedSingle;
            PasswordInput.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordInput.Location = new Point(654, 321);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(383, 57);
            PasswordInput.TabIndex = 48;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FullNameLabel.ForeColor = SystemColors.ActiveCaptionText;
            FullNameLabel.Location = new Point(153, 268);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(164, 45);
            FullNameLabel.TabIndex = 40;
            FullNameLabel.Text = "Full Name";
            FullNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            FullNameLabel.Click += LoginUsernameLabel_Click;
            // 
            // FullNameInput
            // 
            FullNameInput.BorderStyle = BorderStyle.FixedSingle;
            FullNameInput.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            FullNameInput.Location = new Point(153, 321);
            FullNameInput.Name = "FullNameInput";
            FullNameInput.Size = new Size(383, 57);
            FullNameInput.TabIndex = 39;
            // 
            // LoginLogo
            // 
            LoginLogo.BackColor = SystemColors.Window;
            LoginLogo.Image = (Image)resources.GetObject("LoginLogo.Image");
            LoginLogo.Location = new Point(363, -49);
            LoginLogo.Name = "LoginLogo";
            LoginLogo.Size = new Size(449, 328);
            LoginLogo.SizeMode = PictureBoxSizeMode.Zoom;
            LoginLogo.TabIndex = 46;
            LoginLogo.TabStop = false;
            // 
            // RegisterUsernameLabel
            // 
            RegisterUsernameLabel.AutoSize = true;
            RegisterUsernameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterUsernameLabel.ForeColor = SystemColors.ActiveCaptionText;
            RegisterUsernameLabel.Location = new Point(153, 402);
            RegisterUsernameLabel.Name = "RegisterUsernameLabel";
            RegisterUsernameLabel.Size = new Size(163, 45);
            RegisterUsernameLabel.TabIndex = 48;
            RegisterUsernameLabel.Text = "Username";
            RegisterUsernameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RegisterUsernameInput
            // 
            RegisterUsernameInput.BorderStyle = BorderStyle.FixedSingle;
            RegisterUsernameInput.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterUsernameInput.Location = new Point(153, 455);
            RegisterUsernameInput.Name = "RegisterUsernameInput";
            RegisterUsernameInput.Size = new Size(383, 57);
            RegisterUsernameInput.TabIndex = 47;
            // 
            // ConfirmPasswordLabel
            // 
            ConfirmPasswordLabel.AutoSize = true;
            ConfirmPasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmPasswordLabel.ForeColor = SystemColors.ActiveCaptionText;
            ConfirmPasswordLabel.Location = new Point(654, 402);
            ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            ConfirmPasswordLabel.Size = new Size(276, 45);
            ConfirmPasswordLabel.TabIndex = 50;
            ConfirmPasswordLabel.Text = "Confirm Password";
            ConfirmPasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ConfirmPasswordInput
            // 
            ConfirmPasswordInput.BorderStyle = BorderStyle.FixedSingle;
            ConfirmPasswordInput.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            ConfirmPasswordInput.Location = new Point(654, 455);
            ConfirmPasswordInput.Name = "ConfirmPasswordInput";
            ConfirmPasswordInput.Size = new Size(383, 57);
            ConfirmPasswordInput.TabIndex = 49;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1204, 872);
            Controls.Add(ConfirmPasswordLabel);
            Controls.Add(ConfirmPasswordInput);
            Controls.Add(RegisterUsernameLabel);
            Controls.Add(RegisterUsernameInput);
            Controls.Add(NoAccountText);
            Controls.Add(LoginBtn);
            Controls.Add(RegisterBtn);
            Controls.Add(RegisterPasswordLabel);
            Controls.Add(PasswordInput);
            Controls.Add(FullNameLabel);
            Controls.Add(FullNameInput);
            Controls.Add(LoginLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)LoginLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NoAccountText;
        private Button LoginBtn;
        private Button RegisterBtn;
        private Label RegisterPasswordLabel;
        private TextBox PasswordInput;
        private Label FullNameLabel;
        private TextBox FullNameInput;
        private PictureBox LoginLogo;
        private Label RegisterUsernameLabel;
        private TextBox RegisterUsernameInput;
        private Label ConfirmPasswordLabel;
        private TextBox ConfirmPasswordInput;
    }
}