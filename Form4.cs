using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIZZAKOPIZZAMO
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizza_firstDataSet1.AcustomersOrdersRFU' table. You can move, or remove it, as needed.
            this.acustomersOrdersRFUTableAdapter.Fill(this.pizza_firstDataSet1.AcustomersOrdersRFU);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        
        }

        private void acustomersOrdersRFUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.acustomersOrdersRFUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizza_firstDataSet1);

        }

        private void acustomersOrdersRFUDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
     
            Visible = false;
     
        }
    }
}
