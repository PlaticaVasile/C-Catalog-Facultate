using System.Data.SqlClient;
using System.Windows.Forms;

namespace Catalog
{
    public partial class Form1 : Form
    {
        private Point mouse_location;
        public Form1()
        {
            InitializeComponent();
        }

        private void Pnl_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_location = new Point(-e.X, -e.Y);
        }

        private void Pnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mouse_pose = Control.MousePosition;
                mouse_pose.Offset(mouse_location.X, mouse_location.Y);
                Location = mouse_pose;
            }
        }

        private void pcbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcbMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblLoging_Click(object sender, EventArgs e)
        {
            bool chk = false;
            try
            {
                SqlConnection con = new SqlConnection
                    ("Data Source=DESKTOP-C6CO6Q0;Initial Catalog=CatalogVirtual;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Tip, [Nume utilizator], [Parolă] " +
                    "from Utilizatori where Tip=@a and [Nume utilizator]=@b and " +
                    "[Parolă]=@c", con);
                cmd.Parameters.AddWithValue("@a", lbTip.GetItemText(lbTip.SelectedItem));
                cmd.Parameters.AddWithValue("@b", tbUsername.Text);
                cmd.Parameters.AddWithValue("@c", tbPassword.Text);
                //face ce face selectul din SSMS, adica returneaza un tabel cu conditiile impuse

                SqlDataReader reader = cmd.ExecuteReader();//returneaza fiecare coloana in parte
                if (reader.HasRows)//aici intra daca are minim un rand in afisarea selectului
                    chk = false;
                else
                    chk = true;

                con.Close();
            }
            catch (Exception ex) { chk = true; MessageBox.Show(ex.Message); }
            if (chk == false)
            {
                MessageBox.Show("Autentificare cu succes");
                this.Hide();
                Menu menu = new Menu();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Parolă sau/și nume de utilizator greșit/greșite");
                tbUsername.Text = ""; tbPassword.Text = ""; lbTip.SelectedItem = "";
            }
        }
    }
}