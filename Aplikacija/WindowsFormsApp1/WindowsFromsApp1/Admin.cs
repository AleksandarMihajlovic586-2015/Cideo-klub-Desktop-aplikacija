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
    public partial class Admin : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        SqlConnection connection;
        SqlDataAdapter adapter;
        public Admin()
        {
            adapter = new SqlDataAdapter();
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT ID_Proizvoda,Vrsta,Naslov FROM Proizvodi", connection);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            DataGrid.DataSource = dtbl;
            

        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
            
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            Uklanjanje uk = new Uklanjanje();
            uk.Show();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            DeleteUser du = new DeleteUser();
            du.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Dodavanje add = new Dodavanje();
            add.Show();
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT  Vrsta,Naslov,Opis,Ocena,Cena,Slika FROM Proizvodi WHERE ID_Proizvoda =" + txtId.Text+"";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows) {
                    richTextBox1.Text = reader[2].ToString();
                    textOcena.Text = reader[3].ToString();
                    textCena.Text = reader[4].ToString();
                    byte[] img = (byte[])(reader[5]);
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox13.Image = Image.FromStream(ms);
                    command.Dispose();
                    reader.Close();

                }
                else {
                    MsgBox msg1 = new MsgBox();
                    msg1.ChangeLabel("Ne postoji uneti ID!");
                    msg1.Show();
                }

            }
            catch (Exception ex)
            {
                MsgBox msg2 = new MsgBox();
                msg2.ChangeLabel(ex.Message);
                msg2.Show();
            }
        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {
            Uskoro us = new Uskoro();
            us.Show();
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            UskoroDodavanje ud = new UskoroDodavanje();
            ud.Show();
        }

      

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            Kasa ks = new Kasa();
            ks.Show();
        }

       

        private void bunifuFlatButton14_Click_2(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT ID_Proizvoda,Vrsta,Naslov FROM Proizvodi", connection);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            DataGrid.DataSource = dtbl;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Izdati iz = new Izdati();
            iz.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
           
            SqlDataAdapter sqlDa2 = new SqlDataAdapter("SELECT ID_Proizvoda,Vrsta,Naslov FROM Proizvodi WHERE Vrsta= 'Video igrica'", connection);
            DataTable dtbl2 = new DataTable();
            sqlDa2.Fill(dtbl2);
            DataGrid.DataSource = dtbl2;
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDa3 = new SqlDataAdapter("SELECT ID_Proizvoda,Vrsta,Naslov FROM Proizvodi WHERE Vrsta= 'Film'", connection);
            DataTable dtbl3 = new DataTable();
            sqlDa3.Fill(dtbl3);
            DataGrid.DataSource = dtbl3;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT ID_Proizvoda,Vrsta,Naslov FROM Proizvodi", connection);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            DataGrid.DataSource = dtbl;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT ID_Proizvoda,Vrsta,Naslov FROM Proizvodi WHERE Naslov = '"+txtSrch.Text+"'", connection);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            DataGrid.DataSource = dtbl;
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            Help he = new Help();
            he.Show();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton15_Click(object sender, EventArgs e)
        {
            Izmena iz = new Izmena();
            iz.Show();
        }
    }
}
