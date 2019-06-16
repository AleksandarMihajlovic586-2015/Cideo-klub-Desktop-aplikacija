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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString; ;
            
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from login where username='" + txtUser.Text + "' and password='" + txtPass.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                if (txtUser.Text == "admin")
                {
                    Admin f1 = new Admin();
                    f1.Show();
                    this.Hide();
                }
                else
                {
                    User f2 = new User(txtUser.Text);
                    f2.Show();
                    this.Hide();
                }


            }
            else
            {
                MessageBox.Show("Neuspešan Login. \n Pogrešno korisničko ime ili lozinka.");
            }
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
