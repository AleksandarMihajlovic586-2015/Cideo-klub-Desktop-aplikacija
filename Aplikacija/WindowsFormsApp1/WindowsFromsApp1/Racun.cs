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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Configuration;


namespace WindowsFormsApp1
{
    
    public partial class Racun : Form
    {
        int idIgrice, idFilma;
        string uzetiNaslovi;
        static string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        SqlConnection connection;
        SqlDataAdapter adapter;
        SqlDataAdapter adapter2;
        public Racun(string igrica, string film, string iznos)
        {
            adapter = new SqlDataAdapter();
            adapter2 = new SqlDataAdapter();
            InitializeComponent();
            txtFilm.Text = film;
            txtIgrica.Text = igrica;
            txtIznos.Text = iznos;
            uzetiNaslovi = film + " , " + igrica;
            connection = new SqlConnection(connectionString);
            connection.Open();
             
            if (txtFilm.Text == "/")
            {
                idFilma = 0;
            }
            if (txtIgrica.Text == "/")
            {
                idIgrice = 0;
            }
           
                string sql2 = "SELECT ID_Proizvoda FROM Proizvodi WHERE Naslov='" + txtFilm.Text+ " ' ";
                SqlCommand cm2 = new SqlCommand(sql2, connection);
                string sql3 = "SELECT ID_Proizvoda FROM Proizvodi WHERE Naslov='" + txtIgrica.Text + " ' ";
                SqlCommand cm3 = new SqlCommand(sql3, connection);
                try
                {
                    SqlDataReader dr2 = cm2.ExecuteReader();
                    while (dr2.Read())
                    { 
                       idFilma = Convert.ToInt32(dr2["ID_Proizvoda"]);
                    }
                    dr2.Close();
                    dr2.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    SqlDataReader dr3 = cm3.ExecuteReader();
                    while (dr3.Read())
                    {
                        idIgrice = Convert.ToInt32(dr3["ID_Proizvoda"]);
                    }
                    dr3.Close();
                    dr3.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            

            string sql = "SELECT ID,Username FROM Registering ";

            SqlCommand cm = new SqlCommand(sql, connection);


            try
            {
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    comboRadnik.Items.Add(dr["Username"]);
                }
                dr.Close();
                dr.Dispose();

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

        private void comboRadnik_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql4 = "SELECT ID FROM Registering WHERE Username='"+ comboRadnik.Text +"'";

            SqlCommand cm4 = new SqlCommand(sql4, connection);


            try
            {
                SqlDataReader dr4 = cm4.ExecuteReader();
                while (dr4.Read())
                {

                    txtID.Text = dr4["ID"].ToString();
                }
                dr4.Close();
                dr4.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            String sqlQuery = @"INSERT INTO Racun(Uzeti_proizvodi, Datum_uzimanja, Datum_vracanja, Ime_kupca, Prezime_kupca, Adresa_kupca, Broj_telefona,Iznos_racuna,ID,ID_igrice,ID_filma) VALUES ('" + uzetiNaslovi + "','" + date1.Text + "','" + date2.Text + "','" +
               txtIme.Text + "','" + txtPrezime.Text + "','" + txtAdresa.Text + "','" + txtBroj.Text + "','" + txtIznos.Text + "','" + txtID.Text + "','" + idIgrice + "','" + idFilma + "')";
            String sqlQuery1 = @"INSERT INTO Dugovanje(Ime,Prezime,Datum_uzimanja, Datum_vracanja, Broj_telefona,Uzeti_naslovi,ID,ID_igrice,ID_filma) VALUES ('" + txtIme.Text + "','" + txtPrezime.Text + "','" + date1.Text + "','" +
                 date2.Text + "','" + txtBroj.Text + "','" + uzetiNaslovi + "','" + txtID.Text + "','" + idIgrice + "','" + idFilma + "')";
            

            if (date1.Text.Length > 0 && date2.Text.Length > 0 && txtIme.Text.Length > 0 && txtPrezime.Text.Length > 0 && txtAdresa.Text.Length > 0 && txtBroj.Text.Length > 0 && txtIznos.Text.Length > 0)
            {
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlCommand command2 = new SqlCommand(sqlQuery1, connection);
                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();
                adapter2.InsertCommand = command2;
                adapter2.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                command2.Dispose();
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10,10,42,35);
                PdfWriter wri = PdfWriter.GetInstance(doc,new FileStream("Racun.pdf", FileMode.Create));
                doc.Open();
                Paragraph pa = new Paragraph("Racun:\n Racun primio: "+txtIme.Text+" " + 
                txtPrezime.Text + " \n Uzeti proizvodi: " + txtIgrica.Text+ "\n Datum vracanja proizvoda: "+ date2.Text+ "\n Iznos racuna: "+ txtIznos.Text +" \n Hvala na kupovini u prodavnici TNT!!!");
                doc.Add(pa);
                doc.Close();
                System.Diagnostics.Process.Start("Racun.pdf");
                MsgBox msg1 = new MsgBox();
                msg1.ChangeLabel("Račun se štampa!");
                msg1.Show();
                this.Hide();
            }
            else
            {
                MsgBox msg2 = new MsgBox();
                msg2.ChangeLabel("Niste popunili sva polja forme!");
                msg2.Show();
            }
        }
    }
}

