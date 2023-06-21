using Catalog.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalog
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private Point mouse_location;
        private bool[] btnCheck = new bool[5];
        private Point middle = new Point(175, 136);//mijlocul meniului unde vine uc-ul
        //List<ucCassete> list = new List<ucCassete>(); asa nu merge
        ucCassete[] list = new ucCassete[8];
        private void Menu_Load(object sender, EventArgs e)
        {
            //Image myImage = Resources.myImage;
            String[] str = new string[8] { "Ciclu de învățământ", "Programe de studii/Ani de studii",
            "Planuri de învățământ / Discipline","Studenți","Grupe","Cadre didactice","Utilizatori","Cataloage / note"};
            Image[] img = new Image[8] { Resources.ciclu1, Resources.facultati23, Resources.discipline, Resources.studenti,
            Resources.grupe1,Resources.ed1_cadre1,Resources.utiliz1,Resources.cat1};

            for (int i = 0; i <= 7; i++)
            {
                list[i] = new ucCassete();
                list[i].Location = middle;
                list[i].Img = img[i];
                list[i].Title = str[i];
            }
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

        private void EnableDisable(bool a, bool b, bool c, bool d)
        {
            btnInsert.Enabled = a;
            btnDelete.Enabled = b;
            btnUpdate.Enabled = c;
            btnSearch.Enabled = d;
        }


        ucCicluri cassete = new ucCicluri();//buton faculatate
        ucSpec spec = new ucSpec();//buton specializare
        ucCadre cadre = new ucCadre();//buton cadre
        ucStudenti studenti = new ucStudenti();//buton studenti

        private void cicluri_Click(object sender, EventArgs e)
        {
            //this.Controls.Add(list[2]);//de la 0 la 7
            spec.Hide();
            int i = btnCheck.Length;
            while (i > 0)
            {
                i--; btnCheck[i] = false; ;
            }
            btnCheck[0] = true;
            EnableDisable(false, false, false, true);

            cassete.Location = new Point(190, 70);
            this.Controls.Add(cassete);
            cassete.Show();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (btnCheck[0] == true)
            {
                try
                {
                    SqlConnection con = new SqlConnection
                        ("Data Source=DESKTOP-C6CO6Q0;Initial Catalog=CatalogVirtual;Integrated Security=True");
                    con.Open();
                    if (cassete.StrF() == "" && cassete.StrA() == "" && cassete.StrAn() == "")
                    {
                        SqlCommand cmd = new SqlCommand("select * from Facultate", con);
                        //cmd.ExecuteNonQuery;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;//preia afisarea
                        con.Close();
                    }
                    if (cassete.StrF() != "" && cassete.StrA() == "" && cassete.StrAn() == "")
                    {
                        SqlCommand cmd = new SqlCommand("select * from Facultate where [Denumire]=@a", con);
                        cmd.Parameters.AddWithValue("@a", cassete.StrF());
                        //cmd.ExecuteNonQuery;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;//preia afisarea
                        con.Close();
                    }
                    if (cassete.StrF() == "" && cassete.StrA() != "" && cassete.StrAn() == "")
                    {
                        SqlCommand cmd = new SqlCommand("select * from Facultate where [Abreviere/Prescurtare]=@a", con);
                        cmd.Parameters.AddWithValue("@a", cassete.StrA());
                        //cmd.ExecuteNonQuery;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;//preia afisarea
                        con.Close();
                    }
                    if (cassete.StrF() == "" && cassete.StrA() == "" && cassete.StrAn() != "")
                    {
                        SqlCommand cmd = new SqlCommand("select * from Facultate where [Ani de studiu - Licență]=@a", con);
                        cmd.Parameters.AddWithValue("@a", int.Parse(cassete.StrAn()));
                        //cmd.ExecuteNonQuery;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;//preia afisarea
                        con.Close();
                    }
                    if (cassete.StrF() != "" && cassete.StrA() != "" && cassete.StrAn() == "")
                    {
                        SqlCommand cmd = new SqlCommand("select * from Facultate where Facultate=@a and " +
                            "[Abreviere/Prescurtare]=@b", con);
                        cmd.Parameters.AddWithValue("@a", cassete.StrF());
                        cmd.Parameters.AddWithValue("@b", cassete.StrA());
                        //cmd.ExecuteNonQuery;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;//preia afisarea
                        con.Close();
                    }
                    if (cassete.StrF() == "" && cassete.StrA() != "" && cassete.StrAn() != "")
                    {
                        SqlCommand cmd = new SqlCommand("select * from Facultate where [Abreviere/Prescurtare]=@a and " +
                            "[Ani de studiu - Licență]=@b", con);
                        cmd.Parameters.AddWithValue("@a", cassete.StrA());
                        cmd.Parameters.AddWithValue("@b", int.Parse(cassete.StrAn()));
                        //cmd.ExecuteNonQuery;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;//preia afisarea
                        con.Close();
                    }
                    if (cassete.StrF() != "" && cassete.StrA() == "" && cassete.StrAn() == "")
                    {
                        SqlCommand cmd = new SqlCommand("select * from Facultate where Facultate=@a and " +
                            "[Ani de studiu - Licență]=@b", con);
                        cmd.Parameters.AddWithValue("@a", cassete.StrF());
                        cmd.Parameters.AddWithValue("@b", int.Parse(cassete.StrAn()));
                        //cmd.ExecuteNonQuery;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;//preia afisarea
                        con.Close();
                    }
                    if (cassete.StrF() != "" && cassete.StrA() != "" && cassete.StrAn() != "")
                    {
                        SqlCommand cmd = new SqlCommand("select * from Facultate where Facultate=@a and " +
                            "[Abreviere/Prescurtare]=@b and [Ani de studiu - Licență]=@c", con);
                        cmd.Parameters.AddWithValue("@a", cassete.StrF());
                        cmd.Parameters.AddWithValue("@c", int.Parse(cassete.StrAn()));
                        cmd.Parameters.AddWithValue("@b", cassete.StrA());
                        //cmd.ExecuteNonQuery;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;//preia afisarea
                        con.Close();
                    }


                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            if (btnCheck[1] == true)
            {
                try
                {
                    SqlConnection con = new SqlConnection
                          ("Data Source=DESKTOP-C6CO6Q0;Initial Catalog=CatalogVirtual;Integrated Security=True");
                    con.Open();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            if (btnCheck[2] == true)
            {
                try
                {
                    SqlConnection con = new SqlConnection
                        ("Data Source=DESKTOP-C6CO6Q0;Initial Catalog=CatalogVirtual;Integrated Security=True");
                    con.Open();

                    if (studenti.strNume() == "" && studenti.strPrenume() == "" && studenti.strFacultate() == "" && studenti.strSpecializare() == "")
                    {
                        SqlCommand cmd = new SqlCommand("select * from Student", con);
                        //cmd.ExecuteNonQuery;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;//preia afisarea
                        con.Close();
                    }
                    if (studenti.strNume() != "" && studenti.strPrenume() != "" && studenti.strFacultate() == "" && studenti.strSpecializare() == "")
                    {
                        SqlCommand cmd = new SqlCommand("select * from Student" + con);
                        //cmd.ExecuteNonQuery;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;//preia afisarea
                        con.Close();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (btnCheck[3] == true)
            {
                try
                {
                    SqlConnection con = new SqlConnection
                        ("Data Source=DESKTOP-C6CO6Q0;Initial Catalog=CatalogVirtual;Integrated Security=True");
                    con.Open();
                    if (cadre.strNumeProf() == "" && cadre.strPrenumeProf() == "" && cadre.strPost() == "")
                    {
                        SqlCommand cmd = new SqlCommand("select * from [Cadre Didactice]", con);
                        //cmd.ExecuteNonQuery;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;//preia afisarea
                        con.Close();
                    }
                    if (cadre.strNumeProf() != "" && cadre.strPrenumeProf() == "" && cadre.strPost() == "")
                    {
                        SqlCommand cmd = new SqlCommand("select * from [Cadre Didactice] where Nume=@a", con);
                        cmd.Parameters.AddWithValue("@a", cadre.strNumeProf());
                        //cmd.ExecuteNonQuery;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;//preia afisarea
                        con.Close();
                    }
                    if (cadre.strNumeProf() == "" && cadre.strPrenumeProf() != "" && cadre.strPost() == "")
                    {
                        SqlCommand cmd = new SqlCommand("select * from [Cadre Didactice] where Prenume=@a", con);
                        cmd.Parameters.AddWithValue("@a", cadre.strPrenumeProf());
                        //cmd.ExecuteNonQuery;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;//preia afisarea
                        con.Close();
                    }
                    if (cadre.strNumeProf() == "" && cadre.strPrenumeProf() == "" && cadre.strPost() != "")
                    {
                        SqlCommand cmd = new SqlCommand("select * from [Cadre Didactice] where Post=@a", con);
                        cmd.Parameters.AddWithValue("@a", cadre.strPost());
                        //cmd.ExecuteNonQuery;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;//preia afisarea
                        con.Close();
                    }
                    if (cadre.strNumeProf() != "" && cadre.strPrenumeProf() != "" && cadre.strPost() == "")
                    {
                        SqlCommand cmd = new SqlCommand("select * from [Cadre Didactice] where Nume=@a and " +
                            "Prenume=@b", con);
                        cmd.Parameters.AddWithValue("@a", cadre.strNumeProf());
                        cmd.Parameters.AddWithValue("@b", cadre.strPrenumeProf());
                        //cmd.ExecuteNonQuery;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;//preia afisarea
                        con.Close();
                    }
                    if (cadre.strNumeProf() == "" && cadre.strPrenumeProf() != "" && cadre.strPost() != "")
                    {
                        SqlCommand cmd = new SqlCommand("select * from [Cadre Didactice] where Nume=@a and ", con);
                        cmd.Parameters.AddWithValue("@a", cadre.strNumeProf());

                        //cmd.ExecuteNonQuery;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;//preia afisarea
                        con.Close();
                    }
                    if (cadre.strNumeProf() != "" && cadre.strPrenumeProf() == "" && cadre.strPost() == "")
                    {
                        SqlCommand cmd = new SqlCommand("select * from [Cadre Didactice] where Prenume=@a and " +
                            "Post=@b", con);
                        cmd.Parameters.AddWithValue("@a", cadre.strPrenumeProf);
                        cmd.Parameters.AddWithValue("@b", cadre.strPost);
                        //cmd.ExecuteNonQuery;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;//preia afisarea
                        con.Close();
                    }
                    if (cadre.strNumeProf() != "" && cadre.strPrenumeProf() != "" && cadre.strPost() != "")
                    {
                        SqlCommand cmd = new SqlCommand("select * [Cadre Didactice] where Nume=@a and " +
                            "Prenume=@b and Post=@c", con);
                        cmd.Parameters.AddWithValue("@a", cadre.strNumeProf);
                        cmd.Parameters.AddWithValue("@c", cadre.strPrenumeProf);
                        cmd.Parameters.AddWithValue("@b", cadre.strPost);
                        //cmd.ExecuteNonQuery;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvMain.DataSource = dt;//preia afisarea
                        con.Close();
                    }


                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cassete = new ucCicluri();
            label1.Text = cassete.StrF();
            label2.Text = cassete.StrA();
        }


        private void btnSpec_Click(object sender, EventArgs e)
        {
            cassete.Hide();
            studenti.Hide();
            cadre.Hide();
            int i = btnCheck.Length;
            while (i > 0)
            {
                i--; btnCheck[i] = false; ;
            }
            btnCheck[1] = true;
            EnableDisable(true, true, true, true);

            spec.Location = new Point(190, 70);
            this.Controls.Add(spec);
            spec.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cassete.Hide();
            spec.Hide();
            studenti.Hide();
            int i = btnCheck.Length;
            while (i > 0)
            {
                i--; btnCheck[i] = false; ;
            }
            btnCheck[3] = true;
            EnableDisable(true, true, true, true);

            cadre.Location = new Point(190, 70);
            this.Controls.Add(cadre);
            cadre.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cassete.Hide();
            spec.Hide();
            cadre.Hide();
            int i = btnCheck.Length;
            while (i > 0)
            {
                i--; btnCheck[i] = false; ;
            }
            btnCheck[2] = true;
            EnableDisable(true, true, true, true);

            studenti.Location = new Point(190, 70);
            this.Controls.Add(studenti);
            studenti.Show();
        }
    }
}
