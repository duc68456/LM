namespace GUIn.Forms
{
    partial class FormBorrowingHistory
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            dataGridViewBorrowings = new Guna.UI2.WinForms.Guna2DataGridView();
            ReaderName = new DataGridViewTextBoxColumn();
            BookTitle = new DataGridViewTextBoxColumn();
            BorrowDate = new DataGridViewTextBoxColumn();
            ReturnDate = new DataGridViewTextBoxColumn();
            guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBorrowings).BeginInit();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(dataGridViewBorrowings);
            guna2ShadowPanel1.FillColor = Color.FromArgb(241, 241, 246);
            guna2ShadowPanel1.Location = new Point(91, 26);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            guna2ShadowPanel1.Size = new Size(1200, 500);
            guna2ShadowPanel1.TabIndex = 5;
            // 
            // dataGridViewBorrowings
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewBorrowings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(241, 241, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.Gray;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewBorrowings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewBorrowings.ColumnHeadersHeight = 22;
            dataGridViewBorrowings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewBorrowings.Columns.AddRange(new DataGridViewColumn[] { ReaderName, BookTitle, BorrowDate, ReturnDate });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridViewBorrowings.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewBorrowings.GridColor = Color.FromArgb(241, 241, 246);
            dataGridViewBorrowings.Location = new Point(3, 26);
            dataGridViewBorrowings.Name = "dataGridViewBorrowings";
            dataGridViewBorrowings.RowHeadersVisible = false;
            dataGridViewBorrowings.RowHeadersWidth = 51;
            dataGridViewBorrowings.RowTemplate.Height = 60;
            dataGridViewBorrowings.Size = new Size(1194, 458);
            dataGridViewBorrowings.TabIndex = 0;
            dataGridViewBorrowings.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridViewBorrowings.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridViewBorrowings.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridViewBorrowings.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridViewBorrowings.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridViewBorrowings.ThemeStyle.BackColor = Color.White;
            dataGridViewBorrowings.ThemeStyle.GridColor = Color.FromArgb(241, 241, 246);
            dataGridViewBorrowings.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(241, 241, 255);
            dataGridViewBorrowings.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewBorrowings.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dataGridViewBorrowings.ThemeStyle.HeaderStyle.ForeColor = Color.Gray;
            dataGridViewBorrowings.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewBorrowings.ThemeStyle.HeaderStyle.Height = 22;
            dataGridViewBorrowings.ThemeStyle.ReadOnly = false;
            dataGridViewBorrowings.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridViewBorrowings.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewBorrowings.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dataGridViewBorrowings.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewBorrowings.ThemeStyle.RowsStyle.Height = 60;
            dataGridViewBorrowings.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewBorrowings.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // ReaderName
            // 
            ReaderName.DataPropertyName = "ReaderName";
            ReaderName.HeaderText = "Tên Độc Giả";
            ReaderName.MinimumWidth = 6;
            ReaderName.Name = "ReaderName";
            // 
            // BookTitle
            // 
            BookTitle.DataPropertyName = "BookTitle";
            BookTitle.HeaderText = "Tên Sách";
            BookTitle.MinimumWidth = 6;
            BookTitle.Name = "BookTitle";
            // 
            // BorrowDate
            // 
            BorrowDate.DataPropertyName = "BorrowDate";
            BorrowDate.HeaderText = "Ngày Mượn";
            BorrowDate.MinimumWidth = 6;
            BorrowDate.Name = "BorrowDate";
            // 
            // ReturnDate
            // 
            ReturnDate.DataPropertyName = "ReturnDate";
            ReturnDate.HeaderText = "Ngày Trả";
            ReturnDate.MinimumWidth = 6;
            ReturnDate.Name = "ReturnDate";
            // 
            // FormBorrowingHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1382, 553);
            Controls.Add(guna2ShadowPanel1);
            Name = "FormBorrowingHistory";
            Text = "FormBorrowingHistory";
            Load += FormBorrowingHistory_Load;
            guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBorrowings).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewBorrowings;
        private DataGridViewTextBoxColumn ReaderName;
        private DataGridViewTextBoxColumn BookTitle;
        private DataGridViewTextBoxColumn BorrowDate;
        private DataGridViewTextBoxColumn ReturnDate;
    }
}