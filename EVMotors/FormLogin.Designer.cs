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
            lblLogin = new Label();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(236, 240, 241);
            txtLogin.Font = new Font("Segoe UI", 16.2F);
            txtLogin.Location = new Point(204, 325);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(334, 43);
            txtLogin.TabIndex = 21;
            txtLogin.TextChanged += textBox1_TextChanged;
            // 
            // lblSubtitle1
            // 
            lblSubtitle1.AutoSize = true;
            lblSubtitle1.BackColor = Color.Transparent;
            lblSubtitle1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            lblSubtitle1.ForeColor = Color.FromArgb(29, 48, 88);
            lblSubtitle1.Location = new Point(163, 206);
            lblSubtitle1.Name = "lblSubtitle1";
            lblSubtitle1.Size = new Size(417, 46);
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
            btnLogin.Location = new Point(290, 447);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(155, 41);
            btnLogin.TabIndex = 23;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblSubtitle2
            // 
            lblSubtitle2.AutoSize = true;
            lblSubtitle2.BackColor = Color.Transparent;
            lblSubtitle2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            lblSubtitle2.ForeColor = Color.FromArgb(29, 48, 88);
            lblSubtitle2.Location = new Point(163, 252);
            lblSubtitle2.Name = "lblSubtitle2";
            lblSubtitle2.Size = new Size(315, 46);
            lblSubtitle2.TabIndex = 24;
            lblSubtitle2.Text = "records efficiently.";
            lblSubtitle2.Click += label1_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(236, 240, 241);
            txtPassword.Font = new Font("Segoe UI", 16.2F);
            txtPassword.Location = new Point(204, 387);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(334, 43);
            txtPassword.TabIndex = 25;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.FromArgb(236, 240, 241);
            lblLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.Gray;
            lblLogin.Location = new Point(204, 325);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(47, 20);
            lblLogin.TabIndex = 26;
            lblLogin.Text = "Login";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.FromArgb(236, 240, 241);
            lblPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Gray;
            lblPassword.Location = new Point(204, 387);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 27;
            lblPassword.Text = "Password";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(726, 708);
            Controls.Add(lblPassword);
            Controls.Add(lblLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblSubtitle2);
            Controls.Add(btnLogin);
            Controls.Add(txtLogin);
            Controls.Add(lblSubtitle1);
            DoubleBuffered = true;
            Name = "Form2";
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
        private Label lblLogin;
        private Label lblPassword;
    }
}