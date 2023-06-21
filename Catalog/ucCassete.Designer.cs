namespace Catalog
{
    partial class ucCassete
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
            pcbRight = new PictureBox();
            lblLeft = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbRight).BeginInit();
            SuspendLayout();
            // 
            // pcbRight
            // 
            pcbRight.BackColor = SystemColors.ActiveCaption;
            pcbRight.Dock = DockStyle.Right;
            pcbRight.Location = new Point(136, 0);
            pcbRight.Name = "pcbRight";
            pcbRight.Size = new Size(224, 140);
            pcbRight.SizeMode = PictureBoxSizeMode.Zoom;
            pcbRight.TabIndex = 0;
            pcbRight.TabStop = false;
            // 
            // lblLeft
            // 
            lblLeft.AutoSize = true;
            lblLeft.Dock = DockStyle.Left;
            lblLeft.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblLeft.Location = new Point(0, 0);
            lblLeft.Name = "lblLeft";
            lblLeft.Size = new Size(48, 26);
            lblLeft.TabIndex = 1;
            lblLeft.Text = "TEXT";
            // 
            // ucCassete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblLeft);
            Controls.Add(pcbRight);
            Margin = new Padding(0);
            MaximumSize = new Size(360, 140);
            MinimumSize = new Size(360, 140);
            Name = "ucCassete";
            Size = new Size(360, 140);
            ((System.ComponentModel.ISupportInitialize)pcbRight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbRight;
        private Label lblLeft;
    }
}
