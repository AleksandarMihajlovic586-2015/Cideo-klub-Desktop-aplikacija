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
    public partial class Izdati : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        SqlConnection connection;
        SqlDataAdapter adapter;
        public Izdati()
        {
            adapter = new SqlDataAdapter();
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            connection.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT ID_DUgovanja,Ime,Prezime,Datum_uzimanja, Datum_vracanja, Broj_telefona,Uzeti_naslovi FROM Dugovanje", connection);
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
            string sqlQuery;
            SqlCommand command;
            if (txtId.Text.Length > 0)
            {
                sqlQuery = "DELETE Dugovanje WHERE ID_Dugovanja = '" + txtId.Text + "'";
                command = new SqlCommand(sqlQuery, connection);
                adapter.DeleteCommand = command;
                adapter.DeleteCommand.ExecuteNonQuery();
                command.Dispose();
                MsgBox msg1 = new MsgBox();
                msg1.ChangeLabel("Kupac je razdužio dugovanje!");
                msg1.Show();

            }
            else
            {
                MsgBox msg2 = new MsgBox();
                msg2.ChangeLabel("Niste uneli kupca!");
                msg2.Show();
            }

        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT ID_DUgovanja,Ime,Prezime,Datum_uzimanja, Datum_vracanja, Broj_telefona,Uzeti_naslovi FROM Dugovanje", connection);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            DataGrid1.DataSource = dtbl;
        }
    }
}
