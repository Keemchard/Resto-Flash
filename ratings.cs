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
    public partial class ratings : Form
    {
        public ratings()
        {
            InitializeComponent();
        }

        private void form_RatingsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.form_RatingsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizza_firstDataSet1);

        }

        private void form_RatingsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.form_RatingsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizza_firstDataSet1);

        }

        private void ratings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizza_firstDataSet1.Form_Ratings' table. You can move, or remove it, as needed.
            this.form_RatingsTableAdapter.Fill(this.pizza_firstDataSet1.Form_Ratings);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Visible = false;
            
        }

        private void form_RatingsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
