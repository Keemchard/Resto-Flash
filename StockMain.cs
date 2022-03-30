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
    public partial class StockMain : Form
    {        
        public StockMain()
        {
            InitializeComponent();
        }

        private void StockMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void stocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void bACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Visible = false;
            f1.ShowDialog();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ratings rt = new ratings();
            rt.ShowDialog();

 
        }

        private void StockMain_Load(object sender, EventArgs e)
        {

        }
    }
}
