namespace Catalog
{
    partial class ucStudenti
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
            facultate = new TextBox();
            lblA = new Label();
            prenume = new TextBox();
            nume = new TextBox();
            lblS = new Label();
            lblF = new Label();
            specializare = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // facultate
            // 
            facultate.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            facultate.Location = new Point(117, 78);
            facultate.Name = "facultate";
            facultate.Size = new Size(191, 33);
            facultate.TabIndex = 23;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblA.Location = new Point(13, 85);
            lblA.Name = "lblA";
            lblA.Size = new Size(79, 26);
            lblA.TabIndex = 22;
            lblA.Text = "Facultate";
            // 
            // prenume
            // 
            prenume.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            prenume.Location = new Point(117, 42);
            prenume.Name = "prenume";
            prenume.Size = new Size(191, 33);
            prenume.TabIndex = 21;
            // 
            // nume
            // 
            nume.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nume.Location = new Point(117, 3);
            nume.Name = "nume";
            nume.Size = new Size(191, 33);
            nume.TabIndex = 20;
            // 
            // lblS
            // 
            lblS.AutoSize = true;
            lblS.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblS.Location = new Point(13, 49);
            lblS.Name = "lblS";
            lblS.Size = new Size(78, 26);
            lblS.TabIndex = 19;
            lblS.Text = "Prenume";
            // 
            // lblF
            // 
            lblF.AutoSize = true;
            lblF.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblF.Location = new Point(12, 10);
            lblF.Name = "lblF";
            lblF.Size = new Size(55, 26);
            lblF.TabIndex = 18;
            lblF.Text = "Nume";
            // 
            // specializare
            // 
            specializare.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            specializare.Location = new Point(117, 117);
            specializare.Name = "specializare";
            specializare.Size = new Size(191, 33);
            specializare.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 120);
            label1.Name = "label1";
            label1.Size = new Size(99, 26);
            label1.TabIndex = 25;
            label1.Text = "Specializare";
            // 
            // ucStudenti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(specializare);
            Controls.Add(facultate);
            Controls.Add(lblA);
            Controls.Add(prenume);
            Controls.Add(nume);
            Controls.Add(lblS);
            Controls.Add(lblF);
            Name = "ucStudenti";
            Size = new Size(351, 167);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox facultate;
        private Label lblA;
        private TextBox prenume;
        private TextBox nume;
        private Label lblS;
        private Label lblF;
        private TextBox specializare;
        private Label label1;
    }
}
