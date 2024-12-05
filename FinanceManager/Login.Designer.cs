namespace FinanceManager
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            LoginUsernameLabel = new Label();
            LoginUsernameInput = new TextBox();
            LoginPasswordLabel = new Label();
            LoginPasswordInput = new TextBox();
            LoginBtn = new Button();
            RegisterBtn = new Button();
            NoAccountText = new Label();
            LoginLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)LoginLogo).BeginInit();
            SuspendLayout();
            // 
            // LoginUsernameLabel
            // 
            LoginUsernameLabel.AutoSize = true;
            LoginUsernameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginUsernameLabel.ForeColor = SystemColors.ActiveCaptionText;
            LoginUsernameLabel.Location = new Point(91, 251);
            LoginUsernameLabel.Name = "LoginUsernameLabel";
            LoginUsernameLabel.Size = new Size(163, 45);
            LoginUsernameLabel.TabIndex = 27;
            LoginUsernameLabel.Text = "Username";
            LoginUsernameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LoginUsernameInput
            // 
            LoginUsernameInput.BorderStyle = BorderStyle.FixedSingle;
            LoginUsernameInput.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            LoginUsernameInput.Location = new Point(91, 304);
            LoginUsernameInput.Name = "LoginUsernameInput";
            LoginUsernameInput.Size = new Size(383, 57);
            LoginUsernameInput.TabIndex = 26;
            LoginUsernameInput.TextChanged += LoginUsernameInput_TextChanged;
            // 
            // LoginPasswordLabel
            // 
            LoginPasswordLabel.AutoSize = true;
            LoginPasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginPasswordLabel.ForeColor = SystemColors.ActiveCaptionText;
            LoginPasswordLabel.Location = new Point(90, 380);
            LoginPasswordLabel.Name = "LoginPasswordLabel";
            LoginPasswordLabel.Size = new Size(153, 45);
            LoginPasswordLabel.TabIndex = 29;
            LoginPasswordLabel.Text = "Password";
            LoginPasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LoginPasswordInput
            // 
            LoginPasswordInput.BorderStyle = BorderStyle.FixedSingle;
            LoginPasswordInput.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            LoginPasswordInput.Location = new Point(90, 433);
            LoginPasswordInput.Name = "LoginPasswordInput";
            LoginPasswordInput.Size = new Size(383, 57);
            LoginPasswordInput.TabIndex = 28;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Black;
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.Font = new Font("Segoe UI Semibold", 12.875F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.ForeColor = SystemColors.Window;
            LoginBtn.Location = new Point(319, 534);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(154, 66);
            LoginBtn.TabIndex = 35;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = SystemColors.ControlLightLight;
            RegisterBtn.Cursor = Cursors.Hand;
            RegisterBtn.Font = new Font("Segoe UI Semibold", 11.875F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterBtn.Location = new Point(209, 752);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(168, 66);
            RegisterBtn.TabIndex = 36;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // NoAccountText
            // 
            NoAccountText.AutoSize = true;
            NoAccountText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NoAccountText.ForeColor = SystemColors.ActiveCaptionText;
            NoAccountText.Location = new Point(124, 689);
            NoAccountText.Name = "NoAccountText";
            NoAccountText.Size = new Size(350, 45);
            NoAccountText.TabIndex = 37;
            NoAccountText.Text = "Don't have an account?";
            NoAccountText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LoginLogo
            // 
            LoginLogo.BackColor = SystemColors.Window;
            LoginLogo.Image = (Image)resources.GetObject("LoginLogo.Image");
            LoginLogo.Location = new Point(64, -32);
            LoginLogo.Name = "LoginLogo";
            LoginLogo.Size = new Size(449, 328);
            LoginLogo.SizeMode = PictureBoxSizeMode.Zoom;
            LoginLogo.TabIndex = 38;
            LoginLogo.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(581, 840);
            Controls.Add(NoAccountText);
            Controls.Add(RegisterBtn);
            Controls.Add(LoginBtn);
            Controls.Add(LoginPasswordLabel);
            Controls.Add(LoginPasswordInput);
            Controls.Add(LoginUsernameLabel);
            Controls.Add(LoginUsernameInput);
            Controls.Add(LoginLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)LoginLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LoginUsernameLabel;
        private TextBox LoginUsernameInput;
        private Label LoginPasswordLabel;
        private TextBox LoginPasswordInput;
        private Button LoginBtn;
        private Button RegisterBtn;
        private Label NoAccountText;
        private PictureBox LoginLogo;
    }
}