using System.Windows.Forms;
using System.Drawing;

namespace FormEVMotors
{
    partial class FormSearch
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));

            groupBox2 = new GroupBox();
            comboBoxOperator = new ComboBox();
            lblValue = new Label();
            lblOperator = new Label();
            lblField = new Label();
            btnClear = new Button();
            btnSearchForm = new Button();
            dataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            comboBoxField = new ComboBox();
            lblSearch = new Label();
            btnSearchExit = new Button();
            comboBoxValue = new ComboBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnSearchExit);
            groupBox2.Controls.Add(comboBoxOperator);
            groupBox2.Controls.Add(comboBoxValue);
            groupBox2.Controls.Add(lblOperator);
            groupBox2.Controls.Add(lblField);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnSearchForm);
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Controls.Add(comboBoxField);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Location = new Point(22, 91);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(680, 560);
            groupBox2.TabIndex = 11;

            // comboBoxOperator
            comboBoxOperator.BackColor = Color.FromArgb(236, 240, 241);
            comboBoxOperator.FormattingEnabled = true;
            comboBoxOperator.Location = new Point(259, 70);
            comboBoxOperator.Name = "comboBoxOperator";
            comboBoxOperator.Size = new Size(145, 23);
            comboBoxOperator.TabIndex = 20;
            //
            // lblValue
            //
            lblValue.AutoSize = true;
            lblValue.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblValue.ForeColor = Color.FromArgb(29, 48, 88);
            lblValue.Location = new Point(465, 42);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(59, 25);
            lblValue.TabIndex = 19;
            lblValue.Text = "Value";
            lblValue.Click += label3_Click;
            //
            // lblOperator
            // 
            lblOperator.AutoSize = true;
            lblOperator.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblOperator.ForeColor = Color.FromArgb(29, 48, 88);
            lblOperator.Location = new Point(259, 42);
            lblOperator.Name = "lblOperator";
            lblOperator.Size = new Size(89, 25);
            lblOperator.TabIndex = 18;
            lblOperator.Text = "Operator";
            lblOperator.Click += label2_Click;
            // 
            // lblField
            // 
            lblField.AutoSize = true;
            lblField.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblField.ForeColor = Color.FromArgb(29, 48, 88);
            lblField.Location = new Point(58, 42);
            lblField.Name = "lblField";
            lblField.Size = new Size(53, 25);
            lblField.TabIndex = 17;
            lblField.Text = "Field";
            lblField.Click += lblMake_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Black;
            btnClear.BackgroundImage = (Image)resources.GetObject("btnClear.BackgroundImage");
            btnClear.BackgroundImageLayout = ImageLayout.Stretch;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.FromArgb(47, 116, 193);
            btnClear.Location = new Point(389, 111);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 31);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSearchForm
            // 
            btnSearchForm.BackColor = Color.Black;
            btnSearchForm.BackgroundImage = (Image)resources.GetObject("btnSearchForm.BackgroundImage");
            btnSearchForm.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearchForm.FlatAppearance.BorderSize = 0;
            btnSearchForm.FlatStyle = FlatStyle.Flat;
            btnSearchForm.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchForm.ForeColor = Color.FromArgb(47, 116, 193);
            btnSearchForm.Location = new Point(184, 111);
            btnSearchForm.Margin = new Padding(3, 2, 3, 2);
            btnSearchForm.Name = "btnSearchForm";
            btnSearchForm.Size = new Size(96, 31);
            btnSearchForm.TabIndex = 10;
            btnSearchForm.Text = "Search";
            btnSearchForm.UseVisualStyleBackColor = false;
             // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle6.ForeColor = Color.Gray;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(123, 138, 150);
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(209, 233, 248);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = SystemColors.InactiveCaption;
            dataGridView.Location = new Point(14, 191);
            dataGridView.Name = "dataGridView";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView.Size = new Size(649, 294);
            dataGridView.TabIndex = 9;
            // 
            // Column1
            // 
            Column1.FillWeight = 1F;
            Column1.HeaderText = "VehicleRegNo\n\n";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Make\n\n";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "EngineSize\n\n";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.FillWeight = 1F;
            Column4.HeaderText = "RegisteredDate";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "RentalPerDay\n\n";
            Column5.Name = "Column5";
            // comboBoxField
            // 
            comboBoxField.BackColor = Color.FromArgb(236, 240, 241);
            comboBoxField.FormattingEnabled = true;
            comboBoxField.Location = new Point(58, 73);
            comboBoxField.Name = "comboBoxField";
            comboBoxField.Size = new Size(145, 23);
            comboBoxField.TabIndex = 0;
            comboBoxField.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Variable Text", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.FromArgb(29, 48, 88);
            lblSearch.Location = new Point(227, 38);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(233, 36);
            lblSearch.TabIndex = 12;
            lblSearch.Text = "Search EVMotors";
            lblSearch.Click += label1_Click;
            // 
            // btnSearchExit
            // 
            btnSearchExit.BackColor = Color.Black;
            btnSearchExit.BackgroundImage = (Image)resources.GetObject("btnSearchExit.BackgroundImage");
            btnSearchExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearchExit.FlatAppearance.BorderSize = 0;
            btnSearchExit.FlatStyle = FlatStyle.Flat;
            btnSearchExit.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchExit.ForeColor = Color.FromArgb(29, 48, 88);
            btnSearchExit.Location = new Point(279, 507);
            btnSearchExit.Margin = new Padding(3, 2, 3, 2);
            btnSearchExit.Name = "btnSearchExit";
            btnSearchExit.Size = new Size(96, 31);
            btnSearchExit.TabIndex = 22;
            btnSearchExit.Text = "EXIT";
            btnSearchExit.UseVisualStyleBackColor = false;
            btnClear.FlatStyle = FlatStyle.Flat;

            // comboBoxValue
            btnClear.ForeColor = Color.FromArgb(29, 48, 88);
            comboBoxValue.BackColor = Color.FromArgb(236, 240, 241);
            comboBoxValue.Font = new Font("Segoe UI", 12F);
            comboBoxValue.Location = new Point(465, 71);
            comboBoxValue.Margin = new Padding(3, 2, 3, 2);
            comboBoxValue.Name = "comboBoxValue";
            comboBoxValue.Size = new Size(139, 22);
            comboBoxValue.TabIndex = 24;
            comboBoxValue.TextChanged += txtValue_TextChanged;
            btnClear.UseVisualStyleBackColor = false;
            // 
            // lblField
            // 
            lblField.AutoSize = true;
            lblField.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblField.ForeColor = Color.FromArgb(29, 48, 88);
            lblField.Location = new Point(58, 42);
            lblField.Name = "lblField";
            lblField.Size = new Size(53, 25);
            lblField.TabIndex = 17;
            lblField.Text = "Field";
            lblField.Click += lblMake_Click;
            // 
            // lblOperator
            // 
            lblOperator.AutoSize = true;
            lblOperator.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblOperator.ForeColor = Color.FromArgb(29, 48, 88);
            lblOperator.Location = new Point(259, 42);
            lblOperator.Name = "lblOperator";
            lblOperator.Size = new Size(89, 25);
            lblOperator.TabIndex = 18;
            lblOperator.Text = "Operator";
            lblOperator.Click += label2_Click;
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblValue.ForeColor = Color.FromArgb(29, 48, 88);
            lblValue.Location = new Point(465, 42);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(59, 25);
            lblValue.TabIndex = 19;
            lblValue.Text = "Value";
            lblValue.Click += label3_Click;
            // 
            // comboBoxOperator
            // 
            comboBoxOperator.BackColor = Color.FromArgb(236, 240, 241);
            comboBoxOperator.FormattingEnabled = true;
            comboBoxOperator.Location = new Point(259, 70);
            comboBoxOperator.Name = "comboBoxOperator";
            comboBoxOperator.Size = new Size(145, 23);
            comboBoxOperator.TabIndex = 20;
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(728, 716);
            Controls.Add(lblSearch);
            Controls.Add(groupBox2);
            ForeColor = SystemColors.ActiveCaption;
            Name = "FormSearch";
            Text = "Form1";
            Load += FormSearch_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Label lblSearch;
        private ComboBox comboBoxField;
        private ComboBox comboBoxOperator;
        private ComboBox comboBoxValue;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
   
        private Button btnSearchForm;
        private Button btnClear;
        private Label lblValue;
        private Label lblOperator;
        private Label lblField;
        private Button btnSearchExit;
    }
}