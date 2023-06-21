namespace Catalog
{
    partial class Menu
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
            pcbClose = new PictureBox();
            pcbMin = new PictureBox();
            pnl = new Panel();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            btnSpec = new Button();
            btnCicluri = new Button();
            panel1 = new Panel();
            btnSearch = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnInsert = new Button();
            dgvMain = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pcbClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbMin).BeginInit();
            pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            SuspendLayout();
            // 
            // pcbClose
            // 
            pcbClose.Image = Properties.Resources.close10;
            pcbClose.Location = new Point(644, 7);
            pcbClose.Name = "pcbClose";
            pcbClose.Padding = new Padding(0, 2, 2, 0);
            pcbClose.Size = new Size(54, 45);
            pcbClose.SizeMode = PictureBoxSizeMode.Zoom;
            pcbClose.TabIndex = 10;
            pcbClose.TabStop = false;
            pcbClose.Click += pcbClose_Click;
            // 
            // pcbMin
            // 
            pcbMin.Image = Properties.Resources.minimize;
            pcbMin.Location = new Point(585, 10);
            pcbMin.Name = "pcbMin";
            pcbMin.Padding = new Padding(0, 2, 2, 0);
            pcbMin.Size = new Size(53, 42);
            pcbMin.SizeMode = PictureBoxSizeMode.Zoom;
            pcbMin.TabIndex = 9;
            pcbMin.TabStop = false;
            pcbMin.Click += pcbMin_Click;
            // 
            // pnl
            // 
            pnl.BackColor = Color.CadetBlue;
            pnl.Controls.Add(pictureBox1);
            pnl.Controls.Add(button4);
            pnl.Controls.Add(button3);
            pnl.Controls.Add(btnSpec);
            pnl.Controls.Add(btnCicluri);
            pnl.Controls.Add(pcbClose);
            pnl.Controls.Add(pcbMin);
            pnl.Dock = DockStyle.Top;
            pnl.Location = new Point(0, 0);
            pnl.Name = "pnl";
            pnl.Size = new Size(710, 55);
            pnl.TabIndex = 19;
            pnl.MouseMove += Pnl_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoUnitbv;
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(359, 26);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 23;
            button4.Text = "Studenți";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(463, 26);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 22;
            button3.Text = "Profesori";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnSpec
            // 
            btnSpec.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSpec.Location = new Point(245, 26);
            btnSpec.Name = "btnSpec";
            btnSpec.Size = new Size(108, 29);
            btnSpec.TabIndex = 21;
            btnSpec.Text = "Specializare";
            btnSpec.UseVisualStyleBackColor = true;
            btnSpec.Click += btnSpec_Click;
            // 
            // btnCicluri
            // 
            btnCicluri.Font = new Font("UT Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCicluri.ForeColor = Color.Black;
            btnCicluri.Location = new Point(145, 26);
            btnCicluri.Name = "btnCicluri";
            btnCicluri.Size = new Size(94, 29);
            btnCicluri.TabIndex = 20;
            btnCicluri.Text = "Facultate";
            btnCicluri.UseVisualStyleBackColor = true;
            btnCicluri.Click += cicluri_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnInsert);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 405);
            panel1.Name = "panel1";
            panel1.Size = new Size(710, 55);
            panel1.TabIndex = 25;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("UT Sans Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(444, 5);
            btnSearch.Margin = new Padding(15, 0, 15, 1);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(113, 40);
            btnSearch.TabIndex = 28;
            btnSearch.Text = "Caută";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("UT Sans Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(301, 5);
            btnUpdate.Margin = new Padding(15, 0, 15, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 40);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Modifică";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("UT Sans Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(158, 5);
            btnDelete.Margin = new Padding(15, 0, 15, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 40);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Șterge";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("UT Sans Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsert.ForeColor = Color.Black;
            btnInsert.Location = new Point(15, 5);
            btnInsert.Margin = new Padding(15, 0, 15, 1);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(113, 40);
            btnInsert.TabIndex = 25;
            btnInsert.Text = "Inserează";
            btnInsert.UseVisualStyleBackColor = true;
            // 
            // dgvMain
            // 
            dgvMain.BackgroundColor = Color.White;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Location = new Point(12, 227);
            dgvMain.Name = "dgvMain";
            dgvMain.RowHeadersWidth = 51;
            dgvMain.RowTemplate.Height = 29;
            dgvMain.Size = new Size(686, 172);
            dgvMain.TabIndex = 27;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(710, 460);
            Controls.Add(dgvMain);
            Controls.Add(panel1);
            Controls.Add(pnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)pcbClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbMin).EndInit();
            pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pcbClose;
        private PictureBox pcbMin;
        private Panel pnl;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button btnSpec;
        private Button btnCicluri;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnSearch;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnInsert;
        private DataGridView dgvMain;
        private Label label1;
        private Label label2;
    }
}