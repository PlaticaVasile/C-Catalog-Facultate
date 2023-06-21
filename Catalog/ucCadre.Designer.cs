namespace Catalog
{
    partial class ucCadre
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
            tbPost = new TextBox();
            lblA = new Label();
            tbPrenumeProf = new TextBox();
            tbNumeProf = new TextBox();
            lblS = new Label();
            lblF = new Label();
            SuspendLayout();
            // 
            // tbPost
            // 
            tbPost.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbPost.Location = new Point(144, 86);
            tbPost.Name = "tbPost";
            tbPost.Size = new Size(191, 33);
            tbPost.TabIndex = 17;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblA.Location = new Point(36, 89);
            lblA.Name = "lblA";
            lblA.Size = new Size(45, 26);
            lblA.TabIndex = 16;
            lblA.Text = "Post";
            // 
            // tbPrenumeProf
            // 
            tbPrenumeProf.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbPrenumeProf.Location = new Point(144, 47);
            tbPrenumeProf.Name = "tbPrenumeProf";
            tbPrenumeProf.Size = new Size(191, 33);
            tbPrenumeProf.TabIndex = 15;
            // 
            // tbNumeProf
            // 
            tbNumeProf.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbNumeProf.Location = new Point(144, 8);
            tbNumeProf.Name = "tbNumeProf";
            tbNumeProf.Size = new Size(191, 33);
            tbNumeProf.TabIndex = 14;
            // 
            // lblS
            // 
            lblS.AutoSize = true;
            lblS.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblS.Location = new Point(36, 54);
            lblS.Name = "lblS";
            lblS.Size = new Size(78, 26);
            lblS.TabIndex = 13;
            lblS.Text = "Prenume";
            // 
            // lblF
            // 
            lblF.AutoSize = true;
            lblF.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblF.Location = new Point(36, 15);
            lblF.Name = "lblF";
            lblF.Size = new Size(55, 26);
            lblF.TabIndex = 12;
            lblF.Text = "Nume";
            // 
            // ucCadre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbPost);
            Controls.Add(lblA);
            Controls.Add(tbPrenumeProf);
            Controls.Add(tbNumeProf);
            Controls.Add(lblS);
            Controls.Add(lblF);
            Name = "ucCadre";
            Size = new Size(360, 154);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPost;
        private Label lblA;
        private TextBox tbPrenumeProf;
        private TextBox tbNumeProf;
        private Label lblS;
        private Label lblF;
    }
}
