namespace MainFormEVMotors
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            txtLogin = new TextBox();
            lblSubtitle1 = new Label();
            btnLogin = new Button();
            lblSubtitle2 = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(236, 240, 241);
            txtLogin.Font = new Font("Segoe UI", 16.2F);
            txtLogin.Location = new Point(178, 244);
            txtLogin.Margin = new Padding(3, 2, 3, 2);
            txtLogin.MaxLength = 50;
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Username";
            txtLogin.Size = new Size(293, 36);
            txtLogin.TabIndex = 21;
            txtLogin.TextChanged += textBox1_TextChanged;
            // 
            // lblSubtitle1
            // 
            lblSubtitle1.AutoSize = true;
            lblSubtitle1.BackColor = Color.Transparent;
            lblSubtitle1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            lblSubtitle1.ForeColor = Color.FromArgb(29, 48, 88);
            lblSubtitle1.Location = new Point(143, 154);
            lblSubtitle1.Name = "lblSubtitle1";
            lblSubtitle1.Size = new Size(338, 37);
            lblSubtitle1.TabIndex = 20;
            lblSubtitle1.Text = "Log in to manage vehicle";
            lblSubtitle1.Click += label2_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Black;
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(47, 116, 193);
            btnLogin.Location = new Point(254, 335);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(136, 31);
            btnLogin.TabIndex = 23;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblSubtitle2
            // 
            lblSubtitle2.AutoSize = true;
            lblSubtitle2.BackColor = Color.Transparent;
            lblSubtitle2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            lblSubtitle2.ForeColor = Color.FromArgb(29, 48, 88);
            lblSubtitle2.Location = new Point(143, 189);
            lblSubtitle2.Name = "lblSubtitle2";
            lblSubtitle2.Size = new Size(255, 37);
            lblSubtitle2.TabIndex = 24;
            lblSubtitle2.Text = "records efficiently.";
            lblSubtitle2.Click += label1_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(236, 240, 241);
            txtPassword.Font = new Font("Segoe UI", 16.2F);
            txtPassword.Location = new Point(178, 290);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(293, 36);
            txtPassword.TabIndex = 22;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(653, 713);
            Controls.Add(txtPassword);
            Controls.Add(lblSubtitle2);
            Controls.Add(btnLogin);
            Controls.Add(txtLogin);
            Controls.Add(lblSubtitle1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormLogin";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private Label lblSubtitle1;
        private Button btnLogin;
        private Label lblSubtitle2;
        private TextBox txtPassword;
    }
}