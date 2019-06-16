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
    public partial class Dodavanje : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        SqlConnection connection;
        SqlDataAdapter adapter;
        string imgLoc = "";
        public Dodavanje()
        {
            adapter = new SqlDataAdapter();
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            if (txtCena.Text.Length>0 && txtOpis.Text.Length>0 && txtProizvod.Text.Length>0) {
                
                try
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    String sqlQuery = @"INSERT INTO Proizvodi(Vrsta, Naslov, Opis,Ocena, Cena,Slika) VALUES ('" + comboVrsta.Text + "','" + txtProizvod.Text + "','" + txtOpis.Text + "','"+txtOcena.Text+ "','" + txtCena.Text + "',@img)";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.Add(new SqlParameter("@img",img));
                    int x = command.ExecuteNonQuery();
                    connection.Close();
                    MsgBox msg1 = new MsgBox();
                    msg1.ChangeLabel("Uspešno dodavanje proizvoda!");
                    msg1.Show();
                    this.Hide();

                }
                catch(Exception ex) {
                    MsgBox msg2 = new MsgBox();
                    msg2.ChangeLabel(ex.Message);
                    msg2.Show();
                }
               
            }
            else {
                MsgBox msg3 = new MsgBox();
                msg3.ChangeLabel("Morate uneti sva polja u formu!");
                msg3.Show();
            }

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|All Files (*.*)|*.*";
                dlg.Title = "Slika proizvoda";
                if (dlg.ShowDialog()== DialogResult.OK) {
                    imgLoc = dlg.FileName.ToString();
                    pictureBox1.ImageLocation = imgLoc;
                }
            }
            catch(Exception ex) {
                MsgBox msg4 = new MsgBox();
                msg4.ChangeLabel(ex.Message);
                msg4.Show();
            }
        }
    }
}
