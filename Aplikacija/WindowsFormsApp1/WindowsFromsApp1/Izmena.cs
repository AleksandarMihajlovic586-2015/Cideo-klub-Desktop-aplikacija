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
    public partial class Izmena : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        SqlConnection connection;
        public Izmena()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            connection.Open();
            string sql = "SELECT Naslov FROM Proizvodi ";

            SqlCommand cm = new SqlCommand(sql, connection);


            try
            {
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {

                    comboNaslov1.Items.Add(dr["Naslov"]);
                }
                dr.Close();
                dr.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboNaslov1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlc2 = "SELECT * FROM Proizvodi WHERE Naslov ='" + comboNaslov1.Text + "'";
            SqlCommand cmc2 = new SqlCommand(sqlc2, connection);
            cmc2.ExecuteNonQuery();
            SqlDataReader drc2;
            drc2 = cmc2.ExecuteReader();
            while (drc2.Read())
            {
                richTxtOpis.Text= drc2["Opis"].ToString();
                txtOcena.Text = drc2["Ocena"].ToString();
                txtCena.Text = drc2["Cena"].ToString();
                txtId.Text = comboNaslov1.Text;
    

            }
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            String qry = "UPDATE Proizvodi SET Opis='"+richTextBox2.Text+"', Ocena='" + textOcena.Text+ "', Cena='"+textCena.Text+ "' WHERE Naslov= '"+ txtId.Text+"'" ;
            SqlCommand sc = new SqlCommand(qry,connection);
            int i = sc.ExecuteNonQuery();
            MsgBox msg1 = new MsgBox();
            msg1.ChangeLabel("Uspešna izmena proizvoda!");
            msg1.Show();
        }
    }
}
