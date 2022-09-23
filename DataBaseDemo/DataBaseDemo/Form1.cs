using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataBaseDemo
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        int id;
        string gender="";
        string language="";
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\SUBJECT_PDF\Sem_5\C#.NET\Progamming\DataBaseDemo\DataBaseDemo\Database1.mdf;Integrated Security=True;User Instance=True");
            Print();
        }

        public void Print()
        {
            SqlDataAdapter adpt = new SqlDataAdapter("SELECT * FROM [user]", con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void allClear()
        {
            textBox1.Clear();
            textBox2.Clear();
            numericUpDown1.Value = 0;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            comboBox1.SelectedItem = 0;
        }

        public void genderAndCheckbox()
        {
            // for gender selection
            if (radioButton1.Checked == true)
                gender = radioButton1.Text;
            if (radioButton2.Checked == true)
                gender = radioButton2.Text;

            // for language selection
            if (checkBox1.Checked == true)
                language += "Hindi,";
            if (checkBox2.Checked == true)
                language += "English,";
            if (checkBox3.Checked == true)
                language += "Gujrati";
        }
        // for data insert 

        private void button1_Click(object sender, EventArgs e)
        {
            genderAndCheckbox();

            SqlCommand cmd = new SqlCommand("INSERT INTO [user] ([name],[phone],[age],[gender],[language],[city]) VALUES ( @name, @phone, @age, @gender, @language, @city)", con);
            cmd.Parameters.AddWithValue("@name",textBox1.Text);
            cmd.Parameters.AddWithValue("@phone", textBox2.Text);
            cmd.Parameters.AddWithValue("@age", numericUpDown1.Value);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@language", language);
            cmd.Parameters.AddWithValue("@city", comboBox1.SelectedItem.ToString());

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i == 1)
            {
                MessageBox.Show("Your data is Successfully Insterted!");
                Print();
                allClear();
            }
            else
            {
                MessageBox.Show("Eror!");
                Print();
                allClear();
            }
        }

       
        // for update data 

        private void button2_Click(object sender, EventArgs e)
        {
            language = "";
            genderAndCheckbox();

            SqlCommand cmd = new SqlCommand("UPDATE [user] SET name=@name, phone=@phone, age=@age, gender=@gender, language=@language, city=@city WHERE id = @id", con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@phone", textBox2.Text);
            cmd.Parameters.AddWithValue("@age", numericUpDown1.Value);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@language", language);
            cmd.Parameters.AddWithValue("@city", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i == 1)
            {
                MessageBox.Show("Your data is Successfully Updated!");
                Print();
                allClear();
            }
            else
            {
                MessageBox.Show("Eror!");
                Print();
                allClear();
            }
        }

        // for delete data 

        private void button3_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("DELETE FROM [user] WHERE id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);

            SqlCommand cmd = new SqlCommand("TRUNCATE TABLE [user]", con);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i == 1)
            {
                MessageBox.Show("Your data is Successfully Deleted!");
                Print();
                allClear();
            }
            else
            {
                MessageBox.Show("Eror!");
                Print();
                allClear();
            }
        }

        // this mathode is use for re fill old data in form for update data 

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            numericUpDown1.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);

            //for checked radiobutton
            if (dataGridView1.SelectedRows[0].Cells[4].Value.ToString() == radioButton1.Text)
                radioButton1.Checked = true;
            if (dataGridView1.SelectedRows[0].Cells[4].Value.ToString() == radioButton2.Text)
                radioButton2.Checked = true;

            //for checked checkbox
            language = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

            string[] lang = language.Split(',');
            foreach (var item in lang)
            {
                if (checkBox1.Text==item)
                    checkBox1.Checked = true;
                else if (checkBox2.Text == item)
                    checkBox2.Checked = true;
                else if (checkBox3.Text == item)
                    checkBox3.Checked = true;
            }
            comboBox1.SelectedItem = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }
    }
}
