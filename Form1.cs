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
    public partial class Form1 : Form
    {
       
        private SqlConnection connection = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = "Data Source=LAPTOP-H7G3NT34\\SQLEXPRESS;Initial Catalog=Pizza_first;Integrated Security=True";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            WinAPI.AnimateWindow(this.Handle, 2000, WinAPI.VER_NEGATIVE);

            // TODO: This line of code loads data into the 'pizza_firstDataSet.PizzaForm1' table. You can move, or remove it, as needed.
            this.pizzaForm1TableAdapter.Fill(this.pizza_firstDataSet.PizzaForm1);

            try
            {
                connection.Open();
                label4.Text = "Connection Successful";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //it will show the form2

            Form2 f2 = new Form2();
            Visible = false;
            f2.Show();



        }

        private void pizzaForm1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
          

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //exit the program
            MessageBox.Show("Thank You!");
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //it will show the KCform
            KCform kc = new KCform();
            Visible = false;
            kc.Show();



            
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
