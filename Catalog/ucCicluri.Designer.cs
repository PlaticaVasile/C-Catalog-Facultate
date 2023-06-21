namespace Catalog
{
    partial class ucCicluri
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblF = new Label();
            lblA = new Label();
            tbF = new TextBox();
            tbA = new TextBox();
            tbAn = new TextBox();
            lblAn = new Label();
            SuspendLayout();
            // 
            // lblF
            // 
            lblF.AutoSize = true;
            lblF.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblF.Location = new Point(5, 17);
            lblF.Name = "lblF";
            lblF.Size = new Size(79, 26);
            lblF.TabIndex = 0;
            lblF.Text = "Facultate";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblA.Location = new Point(2, 51);
            lblA.Name = "lblA";
            lblA.Size = new Size(82, 26);
            lblA.TabIndex = 1;
            lblA.Text = "Abreviere";
            // 
            // tbF
            // 
            tbF.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbF.Location = new Point(90, 10);
            tbF.Name = "tbF";
            tbF.Size = new Size(191, 33);
            tbF.TabIndex = 2;
            // 
            // tbA
            // 
            tbA.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbA.Location = new Point(90, 44);
            tbA.Name = "tbA";
            tbA.Size = new Size(191, 33);
            tbA.TabIndex = 3;
            // 
            // tbAn
            // 
            tbAn.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbAn.Location = new Point(90, 78);
            tbAn.Name = "tbAn";
            tbAn.Size = new Size(191, 33);
            tbAn.TabIndex = 5;
            // 
            // lblAn
            // 
            lblAn.AutoSize = true;
            lblAn.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAn.Location = new Point(49, 85);
            lblAn.Name = "lblAn";
            lblAn.Size = new Size(35, 26);
            lblAn.TabIndex = 4;
            lblAn.Text = "Ani";
            // 
            // ucCicluri
            // 
            AutoScaleDimensions = new SizeF(7F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tbAn);
            Controls.Add(lblAn);
            Controls.Add(tbA);
            Controls.Add(tbF);
            Controls.Add(lblA);
            Controls.Add(lblF);
            Font = new Font("UT Sans", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ucCicluri";
            Size = new Size(290, 124);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblF;
        private Label lblA;
        private TextBox tbF;
        private TextBox tbA;
        private TextBox tbAn;
        private Label lblAn;
    }
}
