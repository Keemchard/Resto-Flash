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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void stocksRFBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stocksRFBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizza_firstDataSet1);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizza_firstDataSet1.StocksRF' table. You can move, or remove it, as needed.
            this.stocksRFTableAdapter.Fill(this.pizza_firstDataSet1.StocksRF);

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            Visible = false;
    
        }
    }
}
