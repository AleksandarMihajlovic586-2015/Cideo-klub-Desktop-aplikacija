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
    public partial class Uskoro : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        SqlConnection connection;
        public Uskoro()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            connection.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT ID_Uskoro,Uskoro_Naslov,Uskoro_Vrsta FROM Uskoro", connection);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            DataGrid1.DataSource = dtbl;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT  ID_Uskoro,Uskoro_Naslov,Uskoro_Vrsta,Uskoro_Slika FROM Uskoro WHERE ID_Uskoro =" + txtNaslov.Text + "";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader readerr = command.ExecuteReader();
                readerr.Read();
                if (readerr.HasRows)
                {
                   
                    byte[] img1 = (byte[])(readerr[3]);
                    MemoryStream ms1 = new MemoryStream(img1);
                    pictureBox13.Image = Image.FromStream(ms1);
                    command.Dispose();
                    readerr.Close();
                    
    

                }
                else
                {
                    MsgBox msg1 = new MsgBox();
                    msg1.ChangeLabel("Ne postoji uneti naslov!");
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

        
    }
}
