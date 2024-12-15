namespace GUIn.Forms
{
    partial class FormReader
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            dataGridViewReaders = new Guna.UI2.WinForms.Guna2DataGridView();
            ReaderID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            IDNumber = new DataGridViewTextBoxColumn();
            btnUpdateReader = new Guna.UI2.WinForms.Guna2Button();
            btnDeleteReader = new Guna.UI2.WinForms.Guna2Button();
            btnAddReader = new Guna.UI2.WinForms.Guna2Button();
            guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReaders).BeginInit();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(dataGridViewReaders);
            guna2ShadowPanel1.FillColor = Color.FromArgb(241, 241, 246);
            guna2ShadowPanel1.Location = new Point(50, 150);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            guna2ShadowPanel1.Size = new Size(1200, 500);
            guna2ShadowPanel1.TabIndex = 9;
            // 
            // dataGridViewReaders
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewReaders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(241, 241, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewReaders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewReaders.ColumnHeadersHeight = 22;
            dataGridViewReaders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewReaders.Columns.AddRange(new DataGridViewColumn[] { ReaderID, Name, Gender, IDNumber });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewReaders.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewReaders.GridColor = Color.FromArgb(241, 241, 246);
            dataGridViewReaders.Location = new Point(3, 26);
            dataGridViewReaders.Name = "dataGridViewReaders";
            dataGridViewReaders.RowHeadersVisible = false;
            dataGridViewReaders.RowHeadersWidth = 51;
            dataGridViewReaders.RowTemplate.Height = 60;
            dataGridViewReaders.Size = new Size(1194, 458);
            dataGridViewReaders.TabIndex = 0;
            dataGridViewReaders.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridViewReaders.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridViewReaders.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridViewReaders.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridViewReaders.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridViewReaders.ThemeStyle.BackColor = Color.White;
            dataGridViewReaders.ThemeStyle.GridColor = Color.FromArgb(241, 241, 246);
            dataGridViewReaders.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(241, 241, 255);
            dataGridViewReaders.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewReaders.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dataGridViewReaders.ThemeStyle.HeaderStyle.ForeColor = Color.Gray;
            dataGridViewReaders.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewReaders.ThemeStyle.HeaderStyle.Height = 22;
            dataGridViewReaders.ThemeStyle.ReadOnly = false;
            dataGridViewReaders.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridViewReaders.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewReaders.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dataGridViewReaders.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewReaders.ThemeStyle.RowsStyle.Height = 60;
            dataGridViewReaders.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewReaders.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // ReaderID
            // 
            ReaderID.DataPropertyName = "ReaderID";
            ReaderID.HeaderText = "Mã Độc Giả";
            ReaderID.MinimumWidth = 6;
            ReaderID.Name = "ReaderID";
            // 
            // Name
            // 
            Name.DataPropertyName = "Name";
            Name.HeaderText = "Tên Độc Giả";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Giới Tính";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            // 
            // IDNumber
            // 
            IDNumber.DataPropertyName = "IDNumber";
            IDNumber.HeaderText = "Số CCCD";
            IDNumber.MinimumWidth = 6;
            IDNumber.Name = "IDNumber";
            // 
            // btnUpdateReader
            // 
            btnUpdateReader.BorderRadius = 25;
            btnUpdateReader.CustomizableEdges = customizableEdges1;
            btnUpdateReader.DisabledState.BorderColor = Color.DarkGray;
            btnUpdateReader.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUpdateReader.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUpdateReader.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUpdateReader.FillColor = Color.FromArgb(16, 52, 68);
            btnUpdateReader.Font = new Font("Microsoft Sans Serif", 10F);
            btnUpdateReader.ForeColor = Color.White;
            btnUpdateReader.Location = new Point(1100, 700);
            btnUpdateReader.Name = "btnUpdateReader";
            btnUpdateReader.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnUpdateReader.Size = new Size(150, 50);
            btnUpdateReader.TabIndex = 8;
            btnUpdateReader.Text = "SỬA";
            btnUpdateReader.Click += btnUpdateReader_Click;
            // 
            // btnDeleteReader
            // 
            btnDeleteReader.BorderRadius = 25;
            btnDeleteReader.CustomizableEdges = customizableEdges3;
            btnDeleteReader.DisabledState.BorderColor = Color.DarkGray;
            btnDeleteReader.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDeleteReader.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDeleteReader.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDeleteReader.FillColor = Color.FromArgb(16, 52, 68);
            btnDeleteReader.Font = new Font("Microsoft Sans Serif", 10F);
            btnDeleteReader.ForeColor = Color.White;
            btnDeleteReader.Location = new Point(900, 700);
            btnDeleteReader.Name = "btnDeleteReader";
            btnDeleteReader.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnDeleteReader.Size = new Size(150, 50);
            btnDeleteReader.TabIndex = 7;
            btnDeleteReader.Text = "XÓA";
            btnDeleteReader.Click += btnDeleteReader_Click;
            // 
            // btnAddReader
            // 
            btnAddReader.BorderRadius = 25;
            btnAddReader.CustomizableEdges = customizableEdges5;
            btnAddReader.DisabledState.BorderColor = Color.DarkGray;
            btnAddReader.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddReader.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddReader.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddReader.FillColor = Color.FromArgb(16, 52, 68);
            btnAddReader.Font = new Font("Microsoft Sans Serif", 10F);
            btnAddReader.ForeColor = Color.White;
            btnAddReader.Location = new Point(700, 700);
            btnAddReader.Name = "btnAddReader";
            btnAddReader.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAddReader.Size = new Size(150, 50);
            btnAddReader.TabIndex = 6;
            btnAddReader.Text = "THÊM";
            btnAddReader.Click += btnAddReader_Click;
            // 
            // FormReader
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1314, 781);
            Controls.Add(guna2ShadowPanel1);
            Controls.Add(btnUpdateReader);
            Controls.Add(btnDeleteReader);
            Controls.Add(btnAddReader);
            //Name = "FormReader";
            Text = "FormReader";
            Load += FormReader_Load;
            guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReaders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewReaders;
        private Guna.UI2.WinForms.Guna2Button btnUpdateReader;
        private Guna.UI2.WinForms.Guna2Button btnDeleteReader;
        private Guna.UI2.WinForms.Guna2Button btnAddReader;
        private DataGridViewTextBoxColumn ReaderID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn IDNumber;
    }
}