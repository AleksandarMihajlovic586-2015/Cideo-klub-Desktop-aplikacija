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
    public partial class DeleteUser : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        SqlConnection connection;
        SqlDataAdapter adapter;
        SqlDataAdapter adapter2;
        public DeleteUser()
        {
            adapter = new SqlDataAdapter();
            adapter2 = new SqlDataAdapter();
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Ime,Prezime,Username,Email,BrojTelefona,Grad FROM Registering", connection);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            DataGrid1.DataSource = dtbl;


        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string sqlQuery;
            string sqlQuery2;
            SqlCommand command;
            SqlCommand command2;
            if (txtUser.Text.Length > 0)
            {
                sqlQuery = "DELETE Registering WHERE Username = '"+txtUser.Text+"'";
                sqlQuery2 = "DELETE login WHERE username = '" + txtUser.Text + "'";
                command = new SqlCommand(sqlQuery, connection);
                command2 = new SqlCommand(sqlQuery2, connection);
                adapter.DeleteCommand = command;
                adapter.DeleteCommand.ExecuteNonQuery();
                adapter2.DeleteCommand = command2;
                adapter2.DeleteCommand.ExecuteNonQuery();
                command.Dispose();
                command2.Dispose();
                MsgBox msg1 = new MsgBox();
                msg1.ChangeLabel("Radnik je uspešno izbrisan!");
                msg1.Show();

            }
            else {
                MsgBox msg2 = new MsgBox();
                msg2.ChangeLabel("Niste uneli korisnika!");
                msg2.Show();
            }
        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Ime,Prezime,Username,Email,BrojTelefona,Grad FROM Registering", connection);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            DataGrid1.DataSource = dtbl;
        }
    }
}
