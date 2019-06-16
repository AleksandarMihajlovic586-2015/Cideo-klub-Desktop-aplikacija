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
    public partial class UskoroDodavanje : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        SqlConnection connection;
        string imgLoc = "";
        public UskoroDodavanje()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|All Files (*.*)|*.*";
                dlg.Title = "Slika proizvoda";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    pictureBox1.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MsgBox msg4 = new MsgBox();
                msg4.ChangeLabel(ex.Message);
                msg4.Show();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (txtNaslov.Text.Length > 0)
            {

                try
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    String sqlQuery = @"INSERT INTO Uskoro(Uskoro_Naslov,Uskoro_Vrsta,Uskoro_Slika) VALUES ('" + txtNaslov.Text + "','" + comboVrsta.Text + "',@img)";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.Add(new SqlParameter("@img", img));
                    int x = command.ExecuteNonQuery();
                    connection.Close();
                    MsgBox msg1 = new MsgBox();
                    msg1.ChangeLabel("Uspešno dodavanje najave proizvoda!");
                    msg1.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MsgBox msg2 = new MsgBox();
                    msg2.ChangeLabel(ex.Message);
                    msg2.Show();
                }

            }
            else
            {
                MsgBox msg3 = new MsgBox();
                msg3.ChangeLabel("Morate uneti naslov proizvoda!");
                msg3.Show();
            }
        }
    }
}
