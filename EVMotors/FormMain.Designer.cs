namespace WinFormsApp1
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            btnUpdate = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            BtnFirst = new Button();
            BtnPrevious = new Button();
            BtnNext = new Button();
            BtnLast = new Button();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            cobMake = new ComboBox();
            chkAvailable = new CheckBox();
            txtRentalPerDay = new TextBox();
            txtDateRegistered = new TextBox();
            txtEngineSize = new TextBox();
            txtVehicleRegNo = new TextBox();
            lblRecordCount = new Label();
            txtAvailable = new Label();
            lblMake = new Label();
            lblRentalPerDay = new Label();
            ldlDateRegistered = new Label();
            lblEngineSize = new Label();
            lblVehicleRegNumber = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Black;
            btnUpdate.BackgroundImage = (Image)resources.GetObject("btnUpdate.BackgroundImage");
            btnUpdate.BackgroundImageLayout = ImageLayout.Stretch;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.FromArgb(47, 116, 193);
            btnUpdate.Location = new Point(37, 96);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(96, 31);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Black;
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.FromArgb(47, 116, 193);
            btnAdd.Location = new Point(153, 96);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 31);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Black;
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.FromArgb(47, 116, 193);
            btnSearch.Location = new Point(270, 96);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(96, 31);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Black;
            btnCancel.BackgroundImage = (Image)resources.GetObject("btnCancel.BackgroundImage");
            btnCancel.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(47, 116, 193);
            btnCancel.Location = new Point(386, 96);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 31);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Black;
            btnDelete.BackgroundImage = (Image)resources.GetObject("btnDelete.BackgroundImage");
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.FromArgb(208, 72, 55);
            btnDelete.Location = new Point(502, 96);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 31);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Black;
            btnExit.BackgroundImage = (Image)resources.GetObject("btnExit.BackgroundImage");
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(29, 48, 88);
            btnExit.Location = new Point(277, 460);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(96, 31);
            btnExit.TabIndex = 5;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // BtnFirst
            // 
            BtnFirst.BackColor = Color.Black;
            BtnFirst.BackgroundImage = (Image)resources.GetObject("BtnFirst.BackgroundImage");
            BtnFirst.BackgroundImageLayout = ImageLayout.Stretch;
            BtnFirst.FlatAppearance.BorderSize = 0;
            BtnFirst.FlatStyle = FlatStyle.Flat;
            BtnFirst.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFirst.ForeColor = Color.FromArgb(47, 116, 193);
            BtnFirst.Location = new Point(53, 402);
            BtnFirst.Margin = new Padding(3, 2, 3, 2);
            BtnFirst.Name = "BtnFirst";
            BtnFirst.Size = new Size(80, 26);
            BtnFirst.TabIndex = 6;
            BtnFirst.Text = "First";
            BtnFirst.UseVisualStyleBackColor = false;
            BtnFirst.Click += BtnFirst_Click;
            // 
            // BtnPrevious
            // 
            BtnPrevious.BackColor = Color.Black;
            BtnPrevious.BackgroundImage = (Image)resources.GetObject("BtnPrevious.BackgroundImage");
            BtnPrevious.BackgroundImageLayout = ImageLayout.Stretch;
            BtnPrevious.FlatAppearance.BorderSize = 0;
            BtnPrevious.FlatStyle = FlatStyle.Flat;
            BtnPrevious.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPrevious.ForeColor = Color.FromArgb(47, 116, 193);
            BtnPrevious.Location = new Point(153, 402);
            BtnPrevious.Margin = new Padding(3, 2, 3, 2);
            BtnPrevious.Name = "BtnPrevious";
            BtnPrevious.Size = new Size(80, 26);
            BtnPrevious.TabIndex = 7;
            BtnPrevious.Text = "Previous";
            BtnPrevious.UseVisualStyleBackColor = false;
            BtnPrevious.Click += BtnPrevious_Click;
            // 
            // BtnNext
            // 
            BtnNext.BackColor = Color.Black;
            BtnNext.BackgroundImage = (Image)resources.GetObject("BtnNext.BackgroundImage");
            BtnNext.BackgroundImageLayout = ImageLayout.Stretch;
            BtnNext.FlatAppearance.BorderSize = 0;
            BtnNext.FlatStyle = FlatStyle.Flat;
            BtnNext.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNext.ForeColor = Color.FromArgb(47, 116, 193);
            BtnNext.Location = new Point(402, 402);
            BtnNext.Margin = new Padding(3, 2, 3, 2);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(80, 26);
            BtnNext.TabIndex = 8;
            BtnNext.Text = "Next";
            BtnNext.UseVisualStyleBackColor = false;
            BtnNext.Click += BtnNext_Click;
            // 
            // BtnLast
            // 
            BtnLast.BackColor = Color.Black;
            BtnLast.BackgroundImage = (Image)resources.GetObject("BtnLast.BackgroundImage");
            BtnLast.BackgroundImageLayout = ImageLayout.Stretch;
            BtnLast.FlatAppearance.BorderSize = 0;
            BtnLast.FlatStyle = FlatStyle.Flat;
            BtnLast.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLast.ForeColor = Color.FromArgb(47, 116, 193);
            BtnLast.Location = new Point(519, 402);
            BtnLast.Margin = new Padding(3, 2, 3, 2);
            BtnLast.Name = "BtnLast";
            BtnLast.Size = new Size(80, 26);
            BtnLast.TabIndex = 9;
            BtnLast.Text = " Last";
            BtnLast.UseVisualStyleBackColor = false;
            BtnLast.Click += BtnLast_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Window;
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(cobMake);
            groupBox1.Controls.Add(chkAvailable);
            groupBox1.Controls.Add(txtRentalPerDay);
            groupBox1.Controls.Add(txtDateRegistered);
            groupBox1.Controls.Add(txtEngineSize);
            groupBox1.Controls.Add(txtVehicleRegNo);
            groupBox1.Controls.Add(lblRecordCount);
            groupBox1.Controls.Add(txtAvailable);
            groupBox1.Controls.Add(lblMake);
            groupBox1.Controls.Add(lblRentalPerDay);
            groupBox1.Controls.Add(ldlDateRegistered);
            groupBox1.Controls.Add(lblEngineSize);
            groupBox1.Controls.Add(lblVehicleRegNumber);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(25, 71);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(585, 432);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(28, 223);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 25;
            // 
            // cobMake
            // 
            cobMake.BackColor = Color.FromArgb(236, 240, 241);
            cobMake.Font = new Font("Segoe UI", 12F);
            cobMake.FormattingEnabled = true;
            cobMake.Location = new Point(344, 114);
            cobMake.Margin = new Padding(3, 2, 3, 2);
            cobMake.Name = "cobMake";
            cobMake.Size = new Size(133, 29);
            cobMake.TabIndex = 24;
            // 
            // chkAvailable
            // 
            chkAvailable.AutoSize = true;
            chkAvailable.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            chkAvailable.ForeColor = Color.FromArgb(59, 152, 97);
            chkAvailable.Location = new Point(344, 220);
            chkAvailable.Margin = new Padding(3, 2, 3, 2);
            chkAvailable.Name = "chkAvailable";
            chkAvailable.Size = new Size(62, 29);
            chkAvailable.TabIndex = 23;
            chkAvailable.Text = "YES";
            chkAvailable.UseVisualStyleBackColor = true;
            // 
            // txtRentalPerDay
            // 
            txtRentalPerDay.BackColor = Color.FromArgb(236, 240, 241);
            txtRentalPerDay.Font = new Font("Segoe UI", 12F);
            txtRentalPerDay.Location = new Point(28, 273);
            txtRentalPerDay.Margin = new Padding(3, 2, 3, 2);
            txtRentalPerDay.Name = "txtRentalPerDay";
            txtRentalPerDay.Size = new Size(227, 29);
            txtRentalPerDay.TabIndex = 22;
            // 
            // txtDateRegistered
            // 
            txtDateRegistered.BackColor = Color.FromArgb(236, 240, 241);
            txtDateRegistered.Font = new Font("Segoe UI", 12F);
            txtDateRegistered.Location = new Point(6, 389);
            txtDateRegistered.Margin = new Padding(3, 2, 3, 2);
            txtDateRegistered.Name = "txtDateRegistered";
            txtDateRegistered.Size = new Size(227, 29);
            txtDateRegistered.TabIndex = 21;
            // 
            // txtEngineSize
            // 
            txtEngineSize.BackColor = Color.FromArgb(236, 240, 241);
            txtEngineSize.Font = new Font("Segoe UI", 12F);
            txtEngineSize.Location = new Point(28, 168);
            txtEngineSize.Margin = new Padding(3, 2, 3, 2);
            txtEngineSize.Name = "txtEngineSize";
            txtEngineSize.Size = new Size(227, 29);
            txtEngineSize.TabIndex = 20;
            // 
            // txtVehicleRegNo
            // 
            txtVehicleRegNo.BackColor = Color.FromArgb(236, 240, 241);
            txtVehicleRegNo.Font = new Font("Segoe UI", 12F);
            txtVehicleRegNo.Location = new Point(28, 115);
            txtVehicleRegNo.Margin = new Padding(3, 2, 3, 2);
            txtVehicleRegNo.Name = "txtVehicleRegNo";
            txtVehicleRegNo.Size = new Size(270, 29);
            txtVehicleRegNo.TabIndex = 19;
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.BorderStyle = BorderStyle.FixedSingle;
            lblRecordCount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblRecordCount.ForeColor = Color.FromArgb(29, 48, 88);
            lblRecordCount.Location = new Point(270, 332);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(54, 23);
            lblRecordCount.TabIndex = 18;
            lblRecordCount.Text = "0 of 0";
            // 
            // txtAvailable
            // 
            txtAvailable.AutoSize = true;
            txtAvailable.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtAvailable.ForeColor = Color.FromArgb(29, 48, 88);
            txtAvailable.Location = new Point(344, 196);
            txtAvailable.Name = "txtAvailable";
            txtAvailable.Size = new Size(76, 21);
            txtAvailable.TabIndex = 17;
            txtAvailable.Text = "Available";
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblMake.ForeColor = Color.FromArgb(29, 48, 88);
            lblMake.Location = new Point(344, 92);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(50, 21);
            lblMake.TabIndex = 16;
            lblMake.Text = "Make";
            // 
            // lblRentalPerDay
            // 
            lblRentalPerDay.AutoSize = true;
            lblRentalPerDay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblRentalPerDay.ForeColor = Color.FromArgb(29, 48, 88);
            lblRentalPerDay.Location = new Point(28, 249);
            lblRentalPerDay.Name = "lblRentalPerDay";
            lblRentalPerDay.Size = new Size(138, 21);
            lblRentalPerDay.TabIndex = 15;
            lblRentalPerDay.Text = "Rental Per Day      ";
            // 
            // ldlDateRegistered
            // 
            ldlDateRegistered.AutoSize = true;
            ldlDateRegistered.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            ldlDateRegistered.ForeColor = Color.FromArgb(29, 48, 88);
            ldlDateRegistered.Location = new Point(28, 196);
            ldlDateRegistered.Name = "ldlDateRegistered";
            ldlDateRegistered.Size = new Size(128, 21);
            ldlDateRegistered.TabIndex = 14;
            ldlDateRegistered.Text = "Date Registered";
            // 
            // lblEngineSize
            // 
            lblEngineSize.AutoSize = true;
            lblEngineSize.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEngineSize.ForeColor = Color.FromArgb(29, 48, 88);
            lblEngineSize.Location = new Point(28, 144);
            lblEngineSize.Name = "lblEngineSize";
            lblEngineSize.Size = new Size(92, 21);
            lblEngineSize.TabIndex = 13;
            lblEngineSize.Text = "Engine Size";
            // 
            // lblVehicleRegNumber
            // 
            lblVehicleRegNumber.AutoSize = true;
            lblVehicleRegNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblVehicleRegNumber.ForeColor = Color.FromArgb(29, 48, 88);
            lblVehicleRegNumber.Location = new Point(28, 92);
            lblVehicleRegNumber.Name = "lblVehicleRegNumber";
            lblVehicleRegNumber.Size = new Size(219, 21);
            lblVehicleRegNumber.TabIndex = 12;
            lblVehicleRegNumber.Text = "Vehicle Registration Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(29, 48, 88);
            label1.Location = new Point(153, 22);
            label1.Name = "label1";
            label1.Size = new Size(302, 36);
            label1.TabIndex = 11;
            label1.Text = "Welcome to EVMotors";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(635, 531);
            Controls.Add(label1);
            Controls.Add(BtnLast);
            Controls.Add(BtnNext);
            Controls.Add(BtnPrevious);
            Controls.Add(BtnFirst);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            Text = "EVMotors";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Button btnAdd;
        private Button btnSearch;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnExit;
        private Button BtnFirst;
        private Button BtnPrevious;
        private Button BtnNext;
        private Button BtnLast;
        private GroupBox groupBox1;
        private CheckBox chkAvailable;
        private TextBox txtRentalPerDay;
        private TextBox txtDateRegistered;
        private TextBox txtEngineSize;
        private TextBox txtVehicleRegNo;
        private Label lblRecordCount;
        private Label txtAvailable;
        private Label lblMake;
        private Label lblRentalPerDay;
        private Label ldlDateRegistered;
        private Label lblEngineSize;
        private Label lblVehicleRegNumber;
        private Label label1;
        private ComboBox cobMake;
        private DateTimePicker dateTimePicker1;
    }
}
