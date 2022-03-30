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
    public partial class Form3 : Form
    {
        private SqlConnection connection = new SqlConnection();
        public Form3()
        {
            InitializeComponent();
            connection.ConnectionString = "Data Source=LAPTOP-H7G3NT34\\SQLEXPRESS;Initial Catalog=Pizza_first;Integrated Security=True";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
         
            if (connection.State==ConnectionState.Open)
            {
                connection.Close();
            }
            connection.Open();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              

            
        }

        private void adminBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adminBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizza_firstDataSet1);

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
   
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            JapForm jf = new JapForm();
            Visible = false;
            jf.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MicForm mf = new MicForm();
            Visible = false;
            mf.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GlazeForm gf = new GlazeForm();
            Visible = false;
            gf.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            NoeForm nf = new NoeForm();
            Visible = false;
            nf.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_3(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
