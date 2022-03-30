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

namespace PIZZAKOPIZZAMO
{
    public partial class NoeForm : Form
    {
        private SqlConnection connection = new SqlConnection();
        public NoeForm()
        {
            InitializeComponent();
            connection.ConnectionString = "Data Source=LAPTOP-H7G3NT34\\SQLEXPRESS;Initial Catalog=Pizza_first;Integrated Security=True";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please Enter Your UserName.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please Enter Your Password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }
            connection.Open();
            int i = 0;
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Admin where [Admin]='" + textBox1.Text + "' and [Password]='" + textBox2.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("this Username password does not match.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Log In Succesfull.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form5 sm = new Form5();
                Visible = false;
                sm.Show();

            }
            connection.Close();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            Visible = false;
            f3.Show();
            //this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
