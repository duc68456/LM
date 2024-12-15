namespace GUIn.Forms
{
    partial class FormUpdateReader
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateReader));
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
            btnUpdateReader = new Guna.UI2.WinForms.Guna2Button();
            txtIDNumber = new Guna.UI2.WinForms.Guna2TextBox();
            txtGender = new Guna.UI2.WinForms.Guna2TextBox();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
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
            panel1.TabIndex = 16;
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
            btnUpdateReader.Location = new Point(708, 504);
            btnUpdateReader.Name = "btnUpdateReader";
            btnUpdateReader.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnUpdateReader.Size = new Size(150, 50);
            btnUpdateReader.TabIndex = 23;
            btnUpdateReader.Text = "SỬA";
            btnUpdateReader.Click += btnUpdateReader_Click;
            // 
            // txtIDNumber
            // 
            txtIDNumber.BorderRadius = 20;
            txtIDNumber.CustomizableEdges = customizableEdges3;
            txtIDNumber.DefaultText = "";
            txtIDNumber.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtIDNumber.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtIDNumber.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtIDNumber.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtIDNumber.FillColor = Color.FromArgb(16, 52, 68);
            txtIDNumber.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtIDNumber.Font = new Font("Microsoft Sans Serif", 10F);
            txtIDNumber.ForeColor = Color.White;
            txtIDNumber.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtIDNumber.Location = new Point(666, 393);
            txtIDNumber.Margin = new Padding(4, 4, 4, 4);
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.PasswordChar = '\0';
            txtIDNumber.PlaceholderText = "";
            txtIDNumber.SelectedText = "";
            txtIDNumber.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtIDNumber.Size = new Size(300, 40);
            txtIDNumber.TabIndex = 22;
            // 
            // txtGender
            // 
            txtGender.BorderRadius = 20;
            txtGender.CustomizableEdges = customizableEdges5;
            txtGender.DefaultText = "";
            txtGender.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtGender.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtGender.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtGender.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtGender.FillColor = Color.FromArgb(16, 52, 68);
            txtGender.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtGender.Font = new Font("Microsoft Sans Serif", 10F);
            txtGender.ForeColor = Color.White;
            txtGender.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtGender.Location = new Point(666, 293);
            txtGender.Margin = new Padding(4, 4, 4, 4);
            txtGender.Name = "txtGender";
            txtGender.PasswordChar = '\0';
            txtGender.PlaceholderText = "";
            txtGender.SelectedText = "";
            txtGender.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtGender.Size = new Size(300, 40);
            txtGender.TabIndex = 21;
            // 
            // txtName
            // 
            txtName.BorderRadius = 20;
            txtName.CustomizableEdges = customizableEdges7;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FillColor = Color.FromArgb(16, 52, 68);
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("Microsoft Sans Serif", 10F);
            txtName.ForeColor = Color.White;
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(666, 193);
            txtName.Margin = new Padding(4, 4, 4, 4);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderText = "";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtName.Size = new Size(300, 40);
            txtName.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F);
            label3.Location = new Point(534, 400);
            label3.Name = "label3";
            label3.Size = new Size(95, 24);
            label3.TabIndex = 19;
            label3.Text = "Số CCCD:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F);
            label2.Location = new Point(534, 300);
            label2.Name = "label2";
            label2.Size = new Size(91, 24);
            label2.TabIndex = 18;
            label2.Text = "Giới Tính:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F);
            label1.Location = new Point(534, 200);
            label1.Name = "label1";
            label1.Size = new Size(121, 24);
            label1.TabIndex = 17;
            label1.Text = "Tên Độc Giả:";
            // 
            // FormUpdateReader
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 753);
            Controls.Add(panel1);
            Controls.Add(btnUpdateReader);
            Controls.Add(txtIDNumber);
            Controls.Add(txtGender);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormUpdateReader";
            Text = "FormUpdateReader";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnUpdateReader;
        private Guna.UI2.WinForms.Guna2TextBox txtIDNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtGender;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}