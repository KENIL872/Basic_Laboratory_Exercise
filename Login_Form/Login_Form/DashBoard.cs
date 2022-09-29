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
    public partial class DashBoard : Form
    {
        SqlConnection con;
        public DashBoard()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\kenil\onedrive\documents\visual studio 2010\Projects\Login_Form\Login_Form\Database1.mdf;Integrated Security=True;User Instance=True");
            label1.Text = Login_page.id.ToString();
            SqlCommand cmd = new SqlCommand("SELECT [name] FROM [user] WHERE [id]=@id", con);
            cmd.Parameters.AddWithValue("@id", Login_page.id);

            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                label1.Text = rd.GetString(0);
            }
        }
    }
}
