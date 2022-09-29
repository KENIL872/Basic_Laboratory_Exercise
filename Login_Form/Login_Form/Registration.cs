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
    public partial class Registration : Form
    {
        SqlConnection con;
        public Registration()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\kenil\onedrive\documents\visual studio 2010\Projects\Login_Form\Login_Form\Database1.mdf;Integrated Security=True;User Instance=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox4.Text)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [user] ([name],[username],[password]) VALUES (@name, @username, @password)", con);
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@username", textBox2.Text);
                cmd.Parameters.AddWithValue("@password", textBox4.Text);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (i == 1)
                {
                    MessageBox.Show("YOUR DATA IS INSERTED");
                    Login_page f1 = new Login_page();
                    f1.Show();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ERROR!");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
            }
            else
            {
                MessageBox.Show("PLZ ENTER SAME PASSWORD IN PASSWOERD AND CONFIRM PASSWORD");
            }
        }
    }
}
