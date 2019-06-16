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
using System.Configuration;



namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        SqlConnection connection;
        SqlDataAdapter adapter;
        SqlDataAdapter adapter2;
        
        public Register()
        {
            adapter = new SqlDataAdapter();
            adapter2 = new SqlDataAdapter();
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            String sqlQuery = @"INSERT INTO Registering(Ime, Prezime, Username, Email, Sifra, BrojTelefona, Grad) VALUES ('" + txtName.Text + "','" + txtLast.Text + "','" + txtUsr.Text + "','" +
                txtEmail.Text + "','" + txtPass1.Text + "','" + txtNum.Text + "','" + txtCity.Text + "')";
            String sqlQuery1 = @"INSERT INTO login(username, password) VALUES ('"+txtUsr.Text+"','"+txtPass1.Text+"')";

            if (txtName.Text.Length > 0 && txtLast.Text.Length > 0 && txtUsr.Text.Length > 0 && txtEmail.Text.Length > 0 && txtPass1.Text.Length > 0 && txtNum.Text.Length > 0 && txtCity.Text.Length > 0)
            {
                if (txtPass1.Text.Equals(txtPass2.Text))
                {

                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    SqlCommand command2 = new SqlCommand(sqlQuery1, connection);
                    adapter.InsertCommand = command;
                    adapter.InsertCommand.ExecuteNonQuery();
                    adapter2.InsertCommand = command2;
                    adapter2.InsertCommand.ExecuteNonQuery();
                    command.Dispose();
                    command2.Dispose();
                    MsgBox msg1 = new MsgBox();
                    msg1.ChangeLabel("Uspešna registracija radnika!");
                    msg1.Show();
                    this.Hide();


                }
                else
                {
                    MsgBox msg2 = new MsgBox();
                    msg2.ChangeLabel("Unete šifre se ne poklapaju!");
                    msg2.Show();
                }
            }
            else
            {
                MsgBox msg3 = new MsgBox();
                msg3.ChangeLabel("Morate uneti sva polja u formi!");
                msg3.Show();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
