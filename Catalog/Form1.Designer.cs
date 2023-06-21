namespace Catalog
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
            lblUsername = new Label();
            lblPassword = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            lblLoging = new Label();
            pictureBox1 = new PictureBox();
            pcbMin = new PictureBox();
            pcbClose = new PictureBox();
            pnl = new Panel();
            lbTip = new ListBox();
            lblSelect = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbClose).BeginInit();
            pnl.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.White;
            lblUsername.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(35, 183);
            lblUsername.Name = "lblUsername";
            lblUsername.Padding = new Padding(0, 0, 20, 0);
            lblUsername.Size = new Size(166, 26);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Nume de utilizator";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.White;
            lblPassword.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(122, 226);
            lblPassword.Name = "lblPassword";
            lblPassword.Padding = new Padding(0, 0, 20, 0);
            lblPassword.Size = new Size(79, 26);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Parolă";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbUsername.ForeColor = Color.Black;
            tbUsername.Location = new Point(207, 183);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(230, 33);
            tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.Location = new Point(207, 226);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(230, 33);
            tbPassword.TabIndex = 3;
            // 
            // lblLoging
            // 
            lblLoging.AutoSize = true;
            lblLoging.BackColor = SystemColors.ButtonFace;
            lblLoging.BorderStyle = BorderStyle.FixedSingle;
            lblLoging.Font = new Font("UT Sans Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoging.ForeColor = Color.Black;
            lblLoging.Location = new Point(207, 262);
            lblLoging.Name = "lblLoging";
            lblLoging.Size = new Size(109, 28);
            lblLoging.TabIndex = 4;
            lblLoging.Text = "Autentificare";
            lblLoging.Click += lblLoging_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoUnitbv;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(25, 25, 0, 0);
            pictureBox1.Size = new Size(201, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pcbMin
            // 
            pcbMin.Image = Properties.Resources.minimize;
            pcbMin.Location = new Point(453, 3);
            pcbMin.Name = "pcbMin";
            pcbMin.Padding = new Padding(0, 2, 2, 0);
            pcbMin.Size = new Size(44, 42);
            pcbMin.SizeMode = PictureBoxSizeMode.Zoom;
            pcbMin.TabIndex = 9;
            pcbMin.TabStop = false;
            pcbMin.Click += pcbMin_Click;
            // 
            // pcbClose
            // 
            pcbClose.Image = Properties.Resources.close10;
            pcbClose.Location = new Point(503, 3);
            pcbClose.Name = "pcbClose";
            pcbClose.Padding = new Padding(0, 2, 2, 0);
            pcbClose.Size = new Size(44, 45);
            pcbClose.SizeMode = PictureBoxSizeMode.Zoom;
            pcbClose.TabIndex = 10;
            pcbClose.TabStop = false;
            pcbClose.Click += pcbClose_Click;
            // 
            // pnl
            // 
            pnl.BackColor = Color.CadetBlue;
            pnl.Controls.Add(pictureBox1);
            pnl.Controls.Add(pcbClose);
            pnl.Controls.Add(pcbMin);
            pnl.Dock = DockStyle.Top;
            pnl.Location = new Point(0, 0);
            pnl.Name = "pnl";
            pnl.Size = new Size(550, 55);
            pnl.TabIndex = 11;
            pnl.MouseDown += Pnl_MouseDown;
            pnl.MouseMove += Pnl_MouseMove;
            // 
            // lbTip
            // 
            lbTip.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbTip.ForeColor = Color.Black;
            lbTip.FormattingEnabled = true;
            lbTip.ItemHeight = 26;
            lbTip.Items.AddRange(new object[] { "administrator", "secretar", "cadru didactic" });
            lbTip.Location = new Point(207, 147);
            lbTip.Name = "lbTip";
            lbTip.Size = new Size(250, 30);
            lbTip.TabIndex = 12;
            // 
            // lblSelect
            // 
            lblSelect.AutoSize = true;
            lblSelect.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSelect.ForeColor = Color.Black;
            lblSelect.Location = new Point(207, 118);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new Size(206, 26);
            lblSelect.TabIndex = 13;
            lblSelect.Text = "Selectați tipul utilizatorului";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 400);
            Controls.Add(lblSelect);
            Controls.Add(lbTip);
            Controls.Add(lblLoging);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(pnl);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(550, 400);
            MinimumSize = new Size(550, 400);
            Name = "Form1";
            Text = "Authentification";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbClose).EndInit();
            pnl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label lblLoging;
        private PictureBox pictureBox1;
        private Label lblTop;
        private PictureBox pcbMin;
        private PictureBox pcbClose;
        private Panel pnl;
        private ListBox lbTip;
        private Label lblSelect;
    }
}