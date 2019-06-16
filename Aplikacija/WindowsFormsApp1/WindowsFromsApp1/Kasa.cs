using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;



namespace WindowsFormsApp1
{
    public partial class Kasa : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        SqlConnection connection;

        public Kasa()
        {
            
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            connection.Open();
            string sql = "SELECT Naslov FROM Proizvodi WHERE Vrsta = 'Film' ";
            string sql1 = "SELECT Naslov FROM Proizvodi WHERE Vrsta = 'Video igrica' ";
            
            SqlCommand cm = new SqlCommand( sql, connection);
            SqlCommand cm1 = new SqlCommand(sql1, connection);


            try
            {
                SqlDataReader dr = cm.ExecuteReader();
                comboNaslov1.Items.Add("/");
                while (dr.Read())
                {

                    comboNaslov1.Items.Add(dr["Naslov"]);
                }
                dr.Close();
                dr.Dispose();
              
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            try
            {
                SqlDataReader dr1 = cm1.ExecuteReader();
                comboNaslov2.Items.Add("/");
                while (dr1.Read())
                {

                    comboNaslov2.Items.Add(dr1["Naslov"]);
                }
                dr1.Close();
                dr1.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboNaslov1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlc = "SELECT * FROM Proizvodi WHERE Naslov ='"+comboNaslov1.Text+ "'";
            SqlCommand cmc = new SqlCommand(sqlc, connection);
            cmc.ExecuteNonQuery();
            SqlDataReader drc;
            drc = cmc.ExecuteReader();
            while (drc.Read()) {
                txtCena1.Text = drc["Cena"].ToString();
            }


        }

        private void comboNaslov2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlc2 = "SELECT * FROM Proizvodi WHERE Naslov ='" + comboNaslov2.Text + "'";
            SqlCommand cmc2 = new SqlCommand(sqlc2, connection);
            cmc2.ExecuteNonQuery();
            SqlDataReader drc2;
            drc2 = cmc2.ExecuteReader();
            while (drc2.Read())
            {
                txtCena2.Text = drc2["Cena"].ToString();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string cena1 = txtCena1.Text;
            string cena2 = txtCena2.Text;

            int cena11 = Convert.ToInt32(cena1);
            int cena22 = Convert.ToInt32(cena2);

            double suma = cena11 + cena22;
            if (CheckBox.Checked)
            {
                double suma2 = suma - suma * 0.10;
                txtSuma.Text = suma2.ToString();

            }
            else
            {
                txtSuma.Text = suma.ToString();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Racun r = new Racun(comboNaslov2.Text,comboNaslov1.Text,txtSuma.Text);
            r.Show();
            this.Hide();
        }
    }
}
