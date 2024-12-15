namespace GUIn
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            panelMenu = new Panel();
            btnSetting = new Button();
            button1 = new Button();
            btnReader = new Button();
            btnBook = new Button();
            panelLogo = new Panel();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            btnCloseChildForm = new Button();
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
            btnSetting.Font = new Font("Microsoft Sans Serif", 10F);
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
            button1.Font = new Font("Microsoft Sans Serif", 10F);
            button1.ForeColor = Color.Gainsboro;
            button1.Location = new Point(0, 245);
            button1.Name = "button1";
            button1.Size = new Size(250, 60);
            button1.TabIndex = 3;
            button1.Text = "MƯỢN SÁCH";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnReader
            // 
            btnReader.Dock = DockStyle.Top;
            btnReader.FlatAppearance.BorderSize = 0;
            btnReader.FlatStyle = FlatStyle.Flat;
            btnReader.Font = new Font("Microsoft Sans Serif", 10F);
            btnReader.ForeColor = Color.Gainsboro;
            btnReader.Location = new Point(0, 185);
            btnReader.Name = "btnReader";
            btnReader.Size = new Size(250, 60);
            btnReader.TabIndex = 2;
            btnReader.Text = "ĐỘC GIẢ";
            btnReader.UseVisualStyleBackColor = true;
            btnReader.Click += btnReader_Click;
            // 
            // btnBook
            // 
            btnBook.Dock = DockStyle.Top;
            btnBook.FlatAppearance.BorderSize = 0;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Microsoft Sans Serif", 10F);
            btnBook.ForeColor = Color.Gainsboro;
            btnBook.Location = new Point(0, 125);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(250, 60);
            btnBook.TabIndex = 1;
            btnBook.Text = "SÁCH";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
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
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(250, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1332, 125);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(648, 42);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(95, 31);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "HOME";
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Font = new Font("Microsoft Sans Serif", 10F);
            btnCloseChildForm.ForeColor = Color.Gainsboro;
            btnCloseChildForm.Image = (Image)resources.GetObject("btnCloseChildForm.Image");
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(125, 125);
            btnCloseChildForm.TabIndex = 4;
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(250, 125);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(1332, 828);
            panelDesktopPane.TabIndex = 2;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 953);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "FormMainMenu";
            Text = "FormMainMenu";
            panelMenu.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnReader;
        private Button btnBook;
        private Panel panelLogo;
        private Panel panelTitleBar;
        private Button btnSetting;
        private Button button1;
        private Label lblTitle;
        private Button btnCloseChildForm;
        private Panel panelDesktopPane;
    }
}