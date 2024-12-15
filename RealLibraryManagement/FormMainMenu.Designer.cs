namespace RealLibraryManagement
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenu = new Panel();
            btnSetting = new Button();
            button1 = new Button();
            btnReader = new Button();
            btnBook = new Button();
            panelLogo = new Panel();
            panelTitleBar = new Panel();
            btnCloseChildForm = new Button();
            lblTitle = new Label();
            panelDesktopPane = new Panel();
            panelMenu.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnSetting);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(btnReader);
            panelMenu.Controls.Add(btnBook);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 953);
            panelMenu.TabIndex = 0;
            // 
            // btnSetting
            // 
            btnSetting.Dock = DockStyle.Bottom;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Microsoft Sans Serif", 13F);
            btnSetting.ForeColor = Color.Gainsboro;
            btnSetting.Location = new Point(0, 893);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(250, 60);
            btnSetting.TabIndex = 4;
            btnSetting.Text = "CÀI ĐẶT";
            btnSetting.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 13F);
            button1.ForeColor = Color.Gainsboro;
            button1.Location = new Point(0, 245);
            button1.Name = "button1";
            button1.Size = new Size(250, 60);
            button1.TabIndex = 3;
            button1.Text = "MƯỢN SÁCH";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnReader
            // 
            btnReader.Dock = DockStyle.Top;
            btnReader.FlatAppearance.BorderSize = 0;
            btnReader.FlatStyle = FlatStyle.Flat;
            btnReader.Font = new Font("Microsoft Sans Serif", 13F);
            btnReader.ForeColor = Color.Gainsboro;
            btnReader.Location = new Point(0, 185);
            btnReader.Name = "btnReader";
            btnReader.Size = new Size(250, 60);
            btnReader.TabIndex = 2;
            btnReader.Text = "ĐỘC GIẢ";
            btnReader.UseVisualStyleBackColor = true;
            // 
            // btnBook
            // 
            btnBook.Dock = DockStyle.Top;
            btnBook.FlatAppearance.BorderSize = 0;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Microsoft Sans Serif", 13F);
            btnBook.ForeColor = Color.Gainsboro;
            btnBook.Location = new Point(0, 125);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(250, 60);
            btnBook.TabIndex = 1;
            btnBook.Text = "SÁCH";
            btnBook.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 125);
            panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(250, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1332, 125);
            panelTitleBar.TabIndex = 1;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Image = (Image)resources.GetObject("btnCloseChildForm.Image");
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(100, 125);
            btnCloseChildForm.TabIndex = 1;
            btnCloseChildForm.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(638, 48);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(95, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(250, 125);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(1332, 828);
            panelDesktopPane.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 953);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "Form1";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button button1;
        private Button btnReader;
        private Button btnBook;
        private Panel panelLogo;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Button btnSetting;
        private Panel panelDesktopPane;
        private Button btnCloseChildForm;
    }
}
