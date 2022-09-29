using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login_Form
{
    public partial class Login_page : Form
    {
        public static int id;
        SqlConnection con;
        public Login_page()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\kenil\onedrive\documents\visual studio 2010\Projects\Login_Form\Login_Form\Database1.mdf;Integrated Security=True;User Instance=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM [user] WHERE [username]=@username AND [password]=@password", con);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            con.Open();
            id = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            if (id > 0)
            {
                DashBoard Db = new DashBoard();
                Db.Show();
                textBox2.Clear();
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("INVALID USER ID AND PASSWORD");
                textBox2.Clear();
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration rg = new Registration();
            rg.Show();
        }
    }
}
