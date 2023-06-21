namespace Catalog
{
    partial class ucSpec
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
            tbAn = new TextBox();
            lblA = new Label();
            tbA = new TextBox();
            tbF = new TextBox();
            lblS = new Label();
            lblF = new Label();
            SuspendLayout();
            // 
            // tbAn
            // 
            tbAn.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbAn.Location = new Point(148, 79);
            tbAn.Name = "tbAn";
            tbAn.Size = new Size(191, 33);
            tbAn.TabIndex = 11;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblA.Location = new Point(60, 86);
            lblA.Name = "lblA";
            lblA.Size = new Size(82, 26);
            lblA.TabIndex = 10;
            lblA.Text = "Abreviere";
            // 
            // tbA
            // 
            tbA.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbA.Location = new Point(148, 45);
            tbA.Name = "tbA";
            tbA.Size = new Size(191, 33);
            tbA.TabIndex = 9;
            // 
            // tbF
            // 
            tbF.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbF.Location = new Point(148, 11);
            tbF.Name = "tbF";
            tbF.Size = new Size(191, 33);
            tbF.TabIndex = 8;
            // 
            // lblS
            // 
            lblS.AutoSize = true;
            lblS.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblS.Location = new Point(43, 52);
            lblS.Name = "lblS";
            lblS.Size = new Size(99, 26);
            lblS.TabIndex = 7;
            lblS.Text = "Specializare";
            // 
            // lblF
            // 
            lblF.AutoSize = true;
            lblF.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblF.Location = new Point(7, 18);
            lblF.Name = "lblF";
            lblF.Size = new Size(135, 26);
            lblF.TabIndex = 6;
            lblF.Text = "Facultate (abrev.)";
            // 
            // ucSpec
            // 
            AutoScaleDimensions = new SizeF(7F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tbAn);
            Controls.Add(lblA);
            Controls.Add(tbA);
            Controls.Add(tbF);
            Controls.Add(lblS);
            Controls.Add(lblF);
            Font = new Font("UT Sans", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ucSpec";
            Size = new Size(349, 124);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbAn;
        private Label lblA;
        private TextBox tbA;
        private TextBox tbF;
        private Label lblS;
        private Label lblF;
    }
}
