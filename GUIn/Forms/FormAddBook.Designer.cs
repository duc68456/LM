﻿namespace GUIn.Forms
{
    partial class FormAddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddBook));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            txtAuthor = new Guna.UI2.WinForms.Guna2TextBox();
            txtCategory = new Guna.UI2.WinForms.Guna2TextBox();
            btnAddBook = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 52, 68);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 753);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(-3, 139);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(490, 464);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F);
            label1.Location = new Point(510, 200);
            label1.Name = "label1";
            label1.Size = new Size(97, 24);
            label1.TabIndex = 1;
            label1.Text = "Tên Sách:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F);
            label2.Location = new Point(510, 300);
            label2.Name = "label2";
            label2.Size = new Size(75, 24);
            label2.TabIndex = 2;
            label2.Text = "Tác Giả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F);
            label3.Location = new Point(510, 400);
            label3.Name = "label3";
            label3.Size = new Size(89, 24);
            label3.TabIndex = 3;
            label3.Text = "Thể Loại:";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.White;
            txtTitle.BorderRadius = 20;
            txtTitle.CustomizableEdges = customizableEdges1;
            txtTitle.DefaultText = "";
            txtTitle.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTitle.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTitle.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTitle.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTitle.FillColor = Color.FromArgb(16, 52, 68);
            txtTitle.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTitle.Font = new Font("Microsoft Sans Serif", 10F);
            txtTitle.ForeColor = Color.White;
            txtTitle.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTitle.Location = new Point(650, 193);
            txtTitle.Margin = new Padding(4, 4, 4, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.PasswordChar = '\0';
            txtTitle.PlaceholderText = "";
            txtTitle.SelectedText = "";
            txtTitle.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTitle.Size = new Size(300, 40);
            txtTitle.TabIndex = 4;
            // 
            // txtAuthor
            // 
            txtAuthor.BorderRadius = 20;
            txtAuthor.CustomizableEdges = customizableEdges3;
            txtAuthor.DefaultText = "";
            txtAuthor.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtAuthor.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtAuthor.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtAuthor.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtAuthor.FillColor = Color.FromArgb(16, 52, 68);
            txtAuthor.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAuthor.Font = new Font("Microsoft Sans Serif", 10F);
            txtAuthor.ForeColor = Color.White;
            txtAuthor.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAuthor.Location = new Point(650, 293);
            txtAuthor.Margin = new Padding(4, 4, 4, 4);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.PasswordChar = '\0';
            txtAuthor.PlaceholderText = "";
            txtAuthor.SelectedText = "";
            txtAuthor.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtAuthor.Size = new Size(300, 40);
            txtAuthor.TabIndex = 5;
            // 
            // txtCategory
            // 
            txtCategory.BorderRadius = 20;
            txtCategory.CustomizableEdges = customizableEdges5;
            txtCategory.DefaultText = "";
            txtCategory.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCategory.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCategory.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCategory.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCategory.FillColor = Color.FromArgb(16, 52, 68);
            txtCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCategory.Font = new Font("Microsoft Sans Serif", 10F);
            txtCategory.ForeColor = Color.White;
            txtCategory.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCategory.Location = new Point(650, 393);
            txtCategory.Margin = new Padding(4, 4, 4, 4);
            txtCategory.Name = "txtCategory";
            txtCategory.PasswordChar = '\0';
            txtCategory.PlaceholderText = "";
            txtCategory.SelectedText = "";
            txtCategory.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtCategory.Size = new Size(300, 40);
            txtCategory.TabIndex = 6;
            // 
            // btnAddBook
            // 
            btnAddBook.BorderRadius = 25;
            btnAddBook.CustomizableEdges = customizableEdges7;
            btnAddBook.DisabledState.BorderColor = Color.DarkGray;
            btnAddBook.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddBook.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddBook.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddBook.FillColor = Color.FromArgb(16, 52, 68);
            btnAddBook.Font = new Font("Microsoft Sans Serif", 10F);
            btnAddBook.ForeColor = Color.White;
            btnAddBook.Location = new Point(684, 504);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnAddBook.Size = new Size(150, 50);
            btnAddBook.TabIndex = 7;
            btnAddBook.Text = "THÊM";
            btnAddBook.Click += btnAddBook_Click;
            // 
            // FormAddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 753);
            Controls.Add(btnAddBook);
            Controls.Add(txtCategory);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FormAddBook";
            Text = "FormAddBook";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtAuthor;
        private Guna.UI2.WinForms.Guna2TextBox txtCategory;
        private Guna.UI2.WinForms.Guna2Button btnAddBook;
    }
}