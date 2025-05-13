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
            GroupBox groupBox2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            labelValue1 = new Label();
            btnSearchExit = new Button();
            comboBoxOperator = new ComboBox();
            txtValue = new TextBox();
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
            groupBox2 = new GroupBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(labelValue1);
            groupBox2.Controls.Add(btnSearchExit);
            groupBox2.Controls.Add(comboBoxOperator);
            groupBox2.Controls.Add(txtValue);
            groupBox2.Controls.Add(lblOperator);
            groupBox2.Controls.Add(lblField);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnSearchForm);
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Controls.Add(comboBoxField);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Location = new Point(25, 121);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(777, 747);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // labelValue1
            // 
            labelValue1.AutoSize = true;
            labelValue1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            labelValue1.ForeColor = Color.FromArgb(29, 48, 88);
            labelValue1.Location = new Point(531, 56);
            labelValue1.Name = "labelValue1";
            labelValue1.Size = new Size(73, 32);
            labelValue1.TabIndex = 19;
            labelValue1.Text = "Value";
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
            btnSearchExit.Location = new Point(319, 676);
            btnSearchExit.Name = "btnSearchExit";
            btnSearchExit.Size = new Size(110, 41);
            btnSearchExit.TabIndex = 22;
            btnSearchExit.Text = "EXIT";
            btnSearchExit.UseVisualStyleBackColor = false;
            // 
            // comboBoxOperator
            // 
            comboBoxOperator.BackColor = Color.FromArgb(236, 240, 241);
            comboBoxOperator.FormattingEnabled = true;
            comboBoxOperator.Location = new Point(296, 93);
            comboBoxOperator.Margin = new Padding(3, 4, 3, 4);
            comboBoxOperator.Name = "comboBoxOperator";
            comboBoxOperator.Size = new Size(165, 28);
            comboBoxOperator.TabIndex = 20;
            // 
            // txtValue
            // 
            txtValue.BackColor = Color.FromArgb(236, 240, 241);
            txtValue.Location = new Point(531, 93);
            txtValue.Margin = new Padding(3, 4, 3, 4);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(165, 28);
            txtValue.TabIndex = 21;
            // 
            // lblOperator
            // 
            lblOperator.AutoSize = true;
            lblOperator.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblOperator.ForeColor = Color.FromArgb(29, 48, 88);
            lblOperator.Location = new Point(296, 56);
            lblOperator.Name = "lblOperator";
            lblOperator.Size = new Size(113, 32);
            lblOperator.TabIndex = 18;
            lblOperator.Text = "Operator";
            lblOperator.Click += label2_Click;
            // 
            // lblField
            // 
            lblField.AutoSize = true;
            lblField.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblField.ForeColor = Color.FromArgb(29, 48, 88);
            lblField.Location = new Point(66, 56);
            lblField.Name = "lblField";
            lblField.Size = new Size(65, 32);
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
            btnClear.ForeColor = Color.FromArgb(29, 48, 88);
            btnClear.Location = new Point(445, 148);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 41);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
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
            btnSearchForm.Location = new Point(210, 148);
            btnSearchForm.Name = "btnSearchForm";
            btnSearchForm.Size = new Size(110, 41);
            btnSearchForm.TabIndex = 10;
            btnSearchForm.Text = "Search";
            btnSearchForm.UseVisualStyleBackColor = false;
            btnSearchForm.Click += btnSearchForm_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle1.ForeColor = Color.Gray;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(123, 138, 150);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(209, 233, 248);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = SystemColors.InactiveCaption;
            dataGridView.Location = new Point(16, 255);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.Name = "dataGridView";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView.Size = new Size(742, 392);
            dataGridView.TabIndex = 9;
            // 
            // Column1
            // 
            Column1.FillWeight = 1F;
            Column1.HeaderText = "VehicleRegNo\n\n";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Make\n\n";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "EngineSize\n\n";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.FillWeight = 1F;
            Column4.HeaderText = "RegisteredDate";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "RentalPerDay\n\n";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // comboBoxField
            // 
            comboBoxField.BackColor = Color.FromArgb(236, 240, 241);
            comboBoxField.FormattingEnabled = true;
            comboBoxField.Location = new Point(66, 97);
            comboBoxField.Margin = new Padding(3, 4, 3, 4);
            comboBoxField.Name = "comboBoxField";
            comboBoxField.Size = new Size(165, 28);
            comboBoxField.TabIndex = 0;
            comboBoxField.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Variable Text", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.FromArgb(29, 48, 88);
            lblSearch.Location = new Point(259, 51);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(293, 46);
            lblSearch.TabIndex = 12;
            lblSearch.Text = "Search EVMotors";
            lblSearch.Click += label1_Click;
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(832, 955);
            Controls.Add(lblSearch);
            Controls.Add(groupBox2);
            ForeColor = SystemColors.ActiveCaption;
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox txtValue;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button btnSearchForm;
        private Button btnClear;
        private Label labelValue1;
        private Label lblOperator;
        private Label lblField;
        private Button btnSearchExit;
        private Label label1;
    }
}