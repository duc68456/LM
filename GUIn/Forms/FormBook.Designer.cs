namespace GUIn.Forms
{
    partial class FormBook
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Today = new Guna.UI2.WinForms.Guna2DateTimePicker();
            btnAddBook = new Guna.UI2.WinForms.Guna2Button();
            btnDeleteBook = new Guna.UI2.WinForms.Guna2Button();
            btnUpdateBook = new Guna.UI2.WinForms.Guna2Button();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            dataGridViewBooks = new Guna.UI2.WinForms.Guna2DataGridView();
            BookID = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // Today
            // 
            Today.BackColor = Color.White;
            Today.BorderRadius = 20;
            Today.Checked = true;
            Today.CustomizableEdges = customizableEdges1;
            Today.FillColor = Color.FromArgb(16, 52, 68);
            Today.Font = new Font("Microsoft Sans Serif", 10F);
            Today.ForeColor = Color.White;
            Today.Format = DateTimePickerFormat.Long;
            Today.Location = new Point(50, 50);
            Today.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            Today.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            Today.Name = "Today";
            Today.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Today.Size = new Size(300, 40);
            Today.TabIndex = 0;
            Today.Value = new DateTime(2024, 12, 8, 16, 24, 37, 962);
            Today.ValueChanged += Today_ValueChanged;
            // 
            // btnAddBook
            // 
            btnAddBook.BorderRadius = 25;
            btnAddBook.CustomizableEdges = customizableEdges3;
            btnAddBook.DisabledState.BorderColor = Color.DarkGray;
            btnAddBook.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddBook.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddBook.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddBook.FillColor = Color.FromArgb(16, 52, 68);
            btnAddBook.Font = new Font("Microsoft Sans Serif", 10F);
            btnAddBook.ForeColor = Color.White;
            btnAddBook.Location = new Point(700, 700);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAddBook.Size = new Size(150, 50);
            btnAddBook.TabIndex = 1;
            btnAddBook.Text = "THÊM";
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.BorderRadius = 25;
            btnDeleteBook.CustomizableEdges = customizableEdges5;
            btnDeleteBook.DisabledState.BorderColor = Color.DarkGray;
            btnDeleteBook.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDeleteBook.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDeleteBook.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDeleteBook.FillColor = Color.FromArgb(16, 52, 68);
            btnDeleteBook.Font = new Font("Microsoft Sans Serif", 10F);
            btnDeleteBook.ForeColor = Color.White;
            btnDeleteBook.Location = new Point(900, 700);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnDeleteBook.Size = new Size(150, 50);
            btnDeleteBook.TabIndex = 2;
            btnDeleteBook.Text = "XÓA";
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.BorderRadius = 25;
            btnUpdateBook.CustomizableEdges = customizableEdges7;
            btnUpdateBook.DisabledState.BorderColor = Color.DarkGray;
            btnUpdateBook.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUpdateBook.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUpdateBook.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUpdateBook.FillColor = Color.FromArgb(16, 52, 68);
            btnUpdateBook.Font = new Font("Microsoft Sans Serif", 10F);
            btnUpdateBook.ForeColor = Color.White;
            btnUpdateBook.Location = new Point(1100, 700);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnUpdateBook.Size = new Size(150, 50);
            btnUpdateBook.TabIndex = 3;
            btnUpdateBook.Text = "SỬA";
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(dataGridViewBooks);
            guna2ShadowPanel1.FillColor = Color.FromArgb(241, 241, 246);
            guna2ShadowPanel1.Location = new Point(50, 150);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            guna2ShadowPanel1.Size = new Size(1200, 500);
            guna2ShadowPanel1.TabIndex = 4;
            // 
            // dataGridViewBooks
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(241, 241, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewBooks.ColumnHeadersHeight = 22;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewBooks.Columns.AddRange(new DataGridViewColumn[] { BookID, Title, Author, Category, Status });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewBooks.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewBooks.GridColor = Color.FromArgb(241, 241, 246);
            dataGridViewBooks.Location = new Point(3, 26);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersVisible = false;
            dataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewBooks.RowTemplate.Height = 60;
            dataGridViewBooks.Size = new Size(1194, 458);
            dataGridViewBooks.TabIndex = 0;
            dataGridViewBooks.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridViewBooks.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridViewBooks.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridViewBooks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridViewBooks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridViewBooks.ThemeStyle.BackColor = Color.White;
            dataGridViewBooks.ThemeStyle.GridColor = Color.FromArgb(241, 241, 246);
            dataGridViewBooks.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(241, 241, 255);
            dataGridViewBooks.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewBooks.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dataGridViewBooks.ThemeStyle.HeaderStyle.ForeColor = Color.Gray;
            dataGridViewBooks.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewBooks.ThemeStyle.HeaderStyle.Height = 22;
            dataGridViewBooks.ThemeStyle.ReadOnly = false;
            dataGridViewBooks.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridViewBooks.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewBooks.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dataGridViewBooks.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewBooks.ThemeStyle.RowsStyle.Height = 60;
            dataGridViewBooks.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewBooks.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewBooks.CellFormatting += dataGridViewBooks_CellFormatting;
            // 
            // BookID
            // 
            BookID.DataPropertyName = "BookID";
            BookID.HeaderText = "Mã Sách";
            BookID.MinimumWidth = 6;
            BookID.Name = "BookID";
            // 
            // Title
            // 
            Title.DataPropertyName = "Title";
            Title.HeaderText = "Tên Sách";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            // 
            // Author
            // 
            Author.DataPropertyName = "Author";
            Author.HeaderText = "Tác Giả";
            Author.MinimumWidth = 6;
            Author.Name = "Author";
            // 
            // Category
            // 
            Category.DataPropertyName = "Category";
            Category.HeaderText = "Thể Loại";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Trạng Thái";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // FormBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1314, 781);
            Controls.Add(guna2ShadowPanel1);
            Controls.Add(btnUpdateBook);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnAddBook);
            Controls.Add(Today);
            Name = "FormBook";
            Text = "FormBook";
            Load += FormBook_Load;
            guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker Today;
        private Guna.UI2.WinForms.Guna2Button btnAddBook;
        private Guna.UI2.WinForms.Guna2Button btnDeleteBook;
        private Guna.UI2.WinForms.Guna2Button btnUpdateBook;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewBooks;
        private DataGridViewTextBoxColumn BookID;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Status;
    }
}