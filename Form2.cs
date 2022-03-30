using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PIZZAKOPIZZAMO
{
    public partial class Form2 : Form
    {
        //it will connect this to the sql database
        private SqlConnection connection = new SqlConnection();
        string operation;
        Double firstnum;
        Double secondnum;
        Double answer;

        public Form2()
        {
            InitializeComponent();
            connection.ConnectionString = "Data Source=LAPTOP-H7G3NT34\\SQLEXPRESS;Initial Catalog=Pizza_first;Integrated Security=True";
        }
        string Gender;

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void pizzaForm2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pizzaForm2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizza_firstDataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        

            // TODO: This line of code loads data into the 'pizza_firstDataSet1.PizzaForm2' table. You can move, or remove it, as needed.

            DateTime iDate = DateTime.Now;

            order_DateTextBox.Text = iDate.ToString("dd/MM/yyyy");
            order_TimeTextBox.Text = iDate.ToString("HH:mm:ss");



        }

        private void pizzaForm2BindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Button_Clickers(object sender, EventArgs e)
        {
            //this is for the hidden calculator, you can disregards this codes

            Button num = (Button)sender;

            if (lblDisplay.Text == "0")
                lblDisplay.Text = num.Text;
            else
                lblDisplay.Text = lblDisplay.Text + num.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //this is for the hidden calculator, you can disregards this codes
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!lblDisplay.Text.Contains("."))
                    lblDisplay.Text = lblDisplay.Text + num.Text;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Cal_Oper(object sender, EventArgs e)
        {
            //this is for the hidden calculator, you can disregards this codes

            Button ops = (Button)sender;
            firstnum = Double.Parse(lblDisplay.Text);
            lblDisplay.Text = "";
            operation = ops.Text;
            lblShowCal.Text = System.Convert.ToString(firstnum) + "" + operation;//todisplay
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //this is for the hidden calculator, you can disregards this codes

            lblShowCal.Text = "";
            secondnum = Double.Parse(lblDisplay.Text);
            switch (operation)
            {
                case "/":
                    answer = (firstnum / secondnum);
                    lblDisplay.Text = System.Convert.ToString(answer);
                    break;
                case "-":
                    answer = (firstnum - secondnum);
                    lblDisplay.Text = System.Convert.ToString(answer);
                    break;
                case "*":
                    answer = (firstnum * secondnum);
                    lblDisplay.Text = System.Convert.ToString(answer);
                    break;
                case "+":
                    answer = (firstnum + secondnum);
                    lblDisplay.Text = System.Convert.ToString(answer);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this is for the hidden calculator, you can disregards this codes

            if (lblDisplay.Text.Length > 0)
                lblDisplay.Text = lblDisplay.Text.Remove(lblDisplay.Text.Length - 1, 1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this is for the hidden calculator, you can disregards this codes

            lblDisplay.Text = "";
            lblShowCal.Text = "";
            lblDisplay.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            calc.Visible = false;
        }

        private void calculatirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calc.Visible = false;

        }

        private void closeCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calc.Visible = true;
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            calc.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "3 Stars";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //ratings database, this code will save the users suggestions, comments and ratings in the database
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "insert into Form_Ratings ([Ratings_Stars],[Comments]) values('" + Gender + "','" + textBox1.Text + "')";

                command.ExecuteNonQuery();
                MessageBox.Show("Saved, Thank You!!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }


            textBox18.Text = "0";


            int a, b, c, d, l, f, g, h, i;

            a = Int32.Parse(NeapolitanAmount.Text);
            b = Int32.Parse(ChicagoAmount.Text);
            c = Int32.Parse(newyorkAmount.Text);
            d = Int32.Parse(siciAmount.Text);
            l = Int32.Parse(greekAmount.Text);
            f = Int32.Parse(calAmount.Text);
            g = Int32.Parse(detAmount.Text);
            h = Int32.Parse(stAmount.Text);
            i = Int32.Parse(all.Text);




            textBox18.Text = (a + b + c + d + l + f + g + h + i).ToString();





            if (string.IsNullOrEmpty(NeapolitanAmount.Text))
            {
                MessageBox.Show("Thank You.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox18.Text = (b + c + d + l + f + g + h).ToString();
            }

            if (string.IsNullOrEmpty(ChicagoAmount.Text))
            {
                MessageBox.Show("Thank You.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox18.Text = (a + c + d + l + f + g + h).ToString();
            }

            if (string.IsNullOrEmpty(newyorkAmount.Text))
            {
                MessageBox.Show("Thank You.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox18.Text = (b + a + d + l + f + g + h).ToString();
            }

            if (string.IsNullOrEmpty(siciAmount.Text))
            {
                MessageBox.Show("Thank You.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox18.Text = (b + c + a + l + f + g + h).ToString();
            }

            if (string.IsNullOrEmpty(greekAmount.Text))
            {
                MessageBox.Show("Thank You.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox18.Text = (b + c + d + a + f + g + h).ToString();
            }

            if (string.IsNullOrEmpty(calAmount.Text))
            {
                MessageBox.Show("Thank You.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox18.Text = (b + c + d + l + a + g + h).ToString();
            }

            if (string.IsNullOrEmpty(detAmount.Text))
            {
                MessageBox.Show("Thank You.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox18.Text = (b + c + d + l + f + a + h).ToString();
            }

            if (string.IsNullOrEmpty(stAmount.Text))
            {
                MessageBox.Show("Thank You.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox18.Text = (b + c + d + l + f + g + a).ToString();
            }
            else
            {
                textBox18.Text = (a + b + c + d + l + f + g + h + i).ToString();
            }

            tabPage1.Show();
            tabControl1.SelectTab(tabPage1);



        }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "5 Stars";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "4 Stars";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "2 Stars";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "1 Stars";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            //PIzza descriptions in tooltip

            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.button20, "Neapolitan is the original pizza. This delicious pie dates all the way back to 18th century Naples Italy.");
            panel9.Visible = true;
            label5.Visible = false;


        }

        private void button21_Click(object sender, EventArgs e)
        {
            ToolTip toolTip2 = new ToolTip();
            toolTip2.ShowAlways = true;
            toolTip2.SetToolTip(this.button21, "Instead of imitating the noturiously thin pie Ike sewell created a pizza with athick crust that had raised edges, simmilar to a pie, and ingredients in reverse.");
            panel10.Visible = true;
            label6.Visible = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ToolTip toolTip3 = new ToolTip();
            toolTip3.ShowAlways = true;
            toolTip3.SetToolTip(this.button22, "Largefoldable slices and crispy outer crust, New York style pizza is one of American's most famous regional pizza type.");
            panel16.Visible = true;
            label7.Visible = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ToolTip toolTip4 = new ToolTip();
            toolTip4.ShowAlways = true;
            toolTip4.SetToolTip(this.button23, "Thick cut of pizza with pillowy dough, a crunchy crust, and robust tomato sauce. This square cut pizza is served with or without cheese");
            panel15.Visible = true;
            label8.Visible = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            ToolTip toolTip5 = new ToolTip();
            toolTip5.ShowAlways = true;
            toolTip5.SetToolTip(this.button24, "A thick and chewy crustcooked in shallow, oiled pans, resulting in a nearly deep fried buttom.");
            panel14.Visible = true;
            label9.Visible = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            ToolTip toolTip6 = new ToolTip();
            toolTip6.ShowAlways = true;
            toolTip6.SetToolTip(this.button25, "PIzza with mustard, ricotta, pate, and red pepper");
            panel13.Visible = true;
            label10.Visible = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            ToolTip toolTip7 = new ToolTip();
            toolTip7.ShowAlways = true;
            toolTip7.SetToolTip(this.button28, "Fist top with pepperoni followed by brick cheese which is spread to the very edges of the pan, yielding a caramelized cheese perimeter");
            panel12.Visible = true;
            label12.Visible = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            ToolTip toolTip8 = new ToolTip();
            toolTip8.ShowAlways = true;
            toolTip8.SetToolTip(this.button29, "Thin crust with the cracker like consistency that is made without yeast.");
            panel11.Visible = true;
            label11.Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {   
            //same as other cart pizza buttons, so this cart button for neapolitan; or all of the comments here are the same with the other cart buttons
            //only the object name are different


            //from form here to data base. it will subtruct the orderes pizza into the stock in sql database       
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            string query = "update StocksRF set [Neapolitan_Pizza_Stock]='" + stock1.Text + "'   where  [ID]=" + num.Text + "";

            command.CommandText = query;

            command.ExecuteNonQuery();
            connection.Close();


            int pe1 = Int32.Parse(NeaNumSmall.Text);
         
            int ppe1 = Int32.Parse(NeaNumMedium.Text);
          
            int ppee2 = Int32.Parse(NeaNumLarge.Text);

            int pepe = Int32.Parse(tutipi.Text);

            
            p1.Text = (pe1 + ppee2 + ppee2).ToString();
            int pupu = Int32.Parse(p1.Text);
            stock1.Text = (pepe - pupu).ToString();
            

            //if the order exceeded the limits of stocks
            int number;
            number = int.Parse(p1.Text);
            if (number > 25)
            {
                MessageBox.Show("Sorry your order is beyond in the limit of our stocks today for this pizza", "Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                NeaNumSmall.Text = "0";
                NeaNumMedium.Text = "0";
                NeaNumLarge.Text = "0";
                NeaCart.Text = "..........";
                NeapolitanAmount.Text = "0";
                NeapolitanAmount.Visible = false;
                stock1.Text = "25";
            }
            else
            {
                //if the user does not choose a size and number of pizza, then they click the cart, this will be happen
                NeapolitanAmount.Visible = true;
                if (string.IsNullOrEmpty(NeaSizeSmall.Text))
                {
                    MessageBox.Show("Please choose from choices of sizes above before you calculate.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NeaSizeSmall.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(NeaNumSmall.Text))
                {
                    MessageBox.Show("Please Enter how many order/orders do you want before you calculate.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NeaNumSmall.Focus();
                    return;
                }

                int a = Int32.Parse(NeaNumSmall.Text);
                int b = Int32.Parse(NeaSizeSmall.Text);
                int c = Int32.Parse(NeaNumMedium.Text);
                int d = Int32.Parse(NeaSizeMedium.Text);
                int k = Int32.Parse(NeaNumLarge.Text);
                int f = Int32.Parse(NeaSizeLarge.Text);

                NeapolitanAmount.Text = (a * b + c * d + k * f).ToString();

                //small
                int aa = Int32.Parse(NeaSizeSmall.Text);
                int bb = Int32.Parse(NeaNumSmall.Text);

                comneasmall.Text = (aa * bb).ToString();

                string cc = NeaNumSmall.Text, dd = button33.Text, kk = comneasmall.Text, ff = EnterSpace.Text;
                neatotsmall.Text = (cc + dd + kk + ff);

                //medium
                int aaa = Int32.Parse(NeaSizeMedium.Text);
                int bbb = Int32.Parse(NeaNumMedium.Text);

                comneamedium.Text = (aaa * bbb).ToString();

                string ccc = NeaNumMedium.Text, ddd = button32.Text, kkk = comneamedium.Text, fff = EnterSpace.Text;
                neatotmedium.Text = (ccc + ddd + kkk + fff);

                //large
                int aaaa = Int32.Parse(NeaSizeLarge.Text);
                int bbbb = Int32.Parse(NeaNumLarge.Text);

                comnealarge.Text = (aaaa * bbbb).ToString();

                string cccc = NeaNumLarge.Text, dddd = button31.Text, kkkk = comnealarge.Text, ffff = EnterSpace.Text;
                neatotlarge.Text = (cccc + dddd + kkkk + ffff);

                //cart on tabpage
                string aaaaa = neatotsmall.Text, bbbbb = neatotmedium.Text, zzz = neatotlarge.Text;

                NeaCart.Text = (aaaaa +
                    bbbbb +
                    zzz);
            }


           
        }

        private void button33_Click(object sender, EventArgs e)
        {
            //visibility and amout of small nea pizza
            NeaNumSmall.Visible = true;
            NeaSizeSmall.Visible = true;
            NeaSizeSmall.Text = "350";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //visibility and amout of medium nea pizza
            NeaNumMedium.Visible = true;
            NeaSizeMedium.Visible = true;
            NeaSizeMedium.Text = "550";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            //visibility and amout of large nea pizza
            NeaNumLarge.Visible = true;
            NeaSizeLarge.Visible = true;
            NeaSizeLarge.Text = "750";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {
            //visibility and amout of small chic pizza
            ChicNumSmall.Visible = true;
            ChicSizeSmall.Visible = true;
            ChicSizeSmall.Text = "650";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            //visibility and amout of medium chic pizza
            ChicNumMedium.Visible = true;
            ChicSizeMedium.Visible = true;
            ChicSizeMedium.Text = "1500";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            //visibility and amout of large chic pizza
            ChicNumLarge.Visible = true;
            ChicSizeLarge.Visible = true;
            ChicSizeLarge.Text = "1999";
        }

        private void button34_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            string query = "update StocksRF set [Chicago_Pizza_Stock]='" + stock2.Text + "'   where  [ID]=" + num.Text + "";
           
            command.CommandText = query;

            command.ExecuteNonQuery();
            connection.Close();


            int pe1 = Int32.Parse(ChicNumSmall.Text);

            int ppe1 = Int32.Parse(ChicNumMedium.Text);

            int ppee2 = Int32.Parse(ChicNumLarge.Text);

            int pepe = Int32.Parse(tutipi.Text);


            p2.Text = (pe1 + ppee2 + ppee2).ToString();
            int pupu = Int32.Parse(p2.Text);
            stock2.Text = (pepe - pupu).ToString();

            int number;
            number = int.Parse(p2.Text);
            if (number > 25)
            {
                MessageBox.Show("Sorry your order is beyond in the limit of our stocks today for this pizza", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChicNumSmall.Text = "0";
                ChicNumMedium.Text = "0";
                ChicNumLarge.Text = "0";
                ChicCart.Text = "..........";
                ChicagoAmount.Text = "0";
                ChicagoAmount.Visible = false;
                stock2.Text = "25";
            }
            else
            {


                ChicagoAmount.Visible = true;
                if (string.IsNullOrEmpty(ChicSizeSmall.Text))
                {
                    MessageBox.Show("Please choose from choices of sizes above before you calculate.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ChicSizeSmall.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(ChicNumSmall.Text))
                {
                    MessageBox.Show("Please Enter how many order/orders do you want before you calculate.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ChicNumSmall.Focus();
                    return;
                }

                int a = Int32.Parse(ChicNumSmall.Text);
                int b = Int32.Parse(ChicSizeSmall.Text);
                int c = Int32.Parse(ChicNumMedium.Text);
                int d = Int32.Parse(ChicSizeMedium.Text);
                int k = Int32.Parse(ChicNumLarge.Text);
                int f = Int32.Parse(ChicSizeLarge.Text);

                ChicagoAmount.Text = (a * b + c * d + k * f).ToString();

                //small
                int aa = Int32.Parse(ChicSizeSmall.Text);
                int bb = Int32.Parse(ChicNumSmall.Text);

                comchicsmall.Text = (aa * bb).ToString();

                string cc = ChicNumSmall.Text, dd = button37.Text, kk = comchicsmall.Text, ff = EnterSpace.Text;
                chictotsmall.Text = (cc + dd + kk + ff);

                //medium
                int aaa = Int32.Parse(ChicSizeMedium.Text);
                int bbb = Int32.Parse(ChicNumMedium.Text);

                comchicmedium.Text = (aaa * bbb).ToString();

                string ccc = ChicNumMedium.Text, ddd = button36.Text, kkk = comchicmedium.Text, fff = EnterSpace.Text;
                chictotmedium.Text = (ccc + ddd + kkk + fff);

                //large
                int aaaa = Int32.Parse(ChicSizeLarge.Text);
                int bbbb = Int32.Parse(ChicNumLarge.Text);

                comchiclarge.Text = (aaaa * bbbb).ToString();

                string cccc = ChicNumLarge.Text, dddd = button35.Text, kkkk = comchiclarge.Text, ffff = EnterSpace.Text;
                chictotlarge.Text = (cccc + dddd + kkkk + ffff);

                //cart
                string aaaaa = chictotsmall.Text, bbbbb = chictotmedium.Text, zzz = chictotlarge.Text;

                ChicCart.Text = (aaaaa +
                    bbbbb +
                    zzz);
            }





        }

        private void button41_Click(object sender, EventArgs e)
        {
            //visibility and amout of small new pizza
            newNumSmall.Visible = true;
            newSizeSmall.Visible = true;
            newSizeSmall.Text = "300";
        }

        private void button40_Click(object sender, EventArgs e)
        {
            //visibility and amout of medium new pizza
            newNumMedium.Visible = true;
            newSizeMedium.Visible = true;
            newSizeMedium.Text = "500";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            //visibility and amout of large new pizza
            newNumLarge.Visible = true;
            newSizeLarge.Visible = true;
            newSizeLarge.Text = "700";
        }

        private void button38_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            string query = "update StocksRF set [New_York_Pizza_Stock]='" + stock3.Text + "'   where  [ID]=" + num.Text + "";
         
            command.CommandText = query;

            command.ExecuteNonQuery();
            connection.Close();




            int pe1 = Int32.Parse(newNumSmall.Text);

            int ppe1 = Int32.Parse(newNumMedium.Text);

            int ppee2 = Int32.Parse(newNumLarge.Text);

            int pepe = Int32.Parse(tutipi.Text);


            p3.Text = (pe1 + ppee2 + ppee2).ToString();
            int pupu = Int32.Parse(p3.Text);
            stock3.Text = (pepe - pupu).ToString();

            int number;
            number = int.Parse(p3.Text);
            if (number > 25)
            {
                MessageBox.Show("Sorry your order is beyond in the limit of our stocks today for this pizza", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                newNumSmall.Text = "0";
                newNumMedium.Text = "0";
                newNumLarge.Text = "0";
                NewCart.Text = "..........";
                newyorkAmount.Text = "0";
                newyorkAmount.Visible = false;
                stock3.Text = "25";
            }
            else
            {
                newyorkAmount.Visible = true;
                if (string.IsNullOrEmpty(newSizeSmall.Text))
                {
                    MessageBox.Show("Please choose from choices of sizes above before you calculate.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    newSizeSmall.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(newNumSmall.Text))
                {
                    MessageBox.Show("Please Enter how many order/orders do you want before you calculate.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    newNumSmall.Focus();
                    return;
                }


                int a = Int32.Parse(newNumSmall.Text);
                int b = Int32.Parse(newSizeSmall.Text);
                int c = Int32.Parse(newNumMedium.Text);
                int d = Int32.Parse(newSizeMedium.Text);
                int k = Int32.Parse(newNumLarge.Text);
                int f = Int32.Parse(newSizeLarge.Text);

                newyorkAmount.Text = (a * b + c * d + k * f).ToString();

                //small
                int aa = Int32.Parse(newSizeSmall.Text);
                int bb = Int32.Parse(newNumSmall.Text);

                comnewsmall.Text = (aa * bb).ToString();

                string cc = newNumSmall.Text, dd = button41.Text, kk = comnewsmall.Text, ff = EnterSpace.Text;
                newtotsmall.Text = (cc + dd + kk + ff);

                //medium
                int aaa = Int32.Parse(newSizeMedium.Text);
                int bbb = Int32.Parse(newNumMedium.Text);

                comnewmedium.Text = (aaa * bbb).ToString();

                string ccc = newNumMedium.Text, ddd = button40.Text, kkk = comnewmedium.Text, fff = EnterSpace.Text;
                newtotmedium.Text = (ccc + ddd + kkk + fff);

                //large
                int aaaa = Int32.Parse(newSizeLarge.Text);
                int bbbb = Int32.Parse(newNumLarge.Text);

                comnewlarge.Text = (aaaa * bbbb).ToString();

                string cccc = newNumLarge.Text, dddd = button39.Text, kkkk = comnewlarge.Text, ffff = EnterSpace.Text;
                newtotlarge.Text = (cccc + dddd + kkkk + ffff);

                //cart
                string aaaaa = newtotsmall.Text, bbbbb = newtotmedium.Text, zzz = newtotlarge.Text;

                NewCart.Text = (aaaaa +
                    bbbbb +
                    zzz);


            }




        }

        private void button45_Click(object sender, EventArgs e)
        {
            //visibility and amout of small sici pizza
            siciNumSmall.Visible = true;
            siciSizeSmall.Visible = true;
            siciSizeSmall.Text = "400";
        }

        private void button44_Click(object sender, EventArgs e)
        {
            //visibility and amout of medium sici pizza
            siciNumMedium.Visible = true;
            siciSizeMedium.Visible = true;
            siciSizeMedium.Text = "600";
        }

        private void button43_Click(object sender, EventArgs e)
        {
            //visibility and amout of large sici pizza
            siciNumLarge.Visible = true;
            siciSizeLarge.Visible = true;
            siciSizeLarge.Text = "950";
        }

        private void button42_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            string query = "update StocksRF set [Sicilian_Pizza_Stock]='" + stock4.Text + "'   where  [ID]=" + num.Text + "";
            
            command.CommandText = query;

            command.ExecuteNonQuery();
            connection.Close();


            int pe1 = Int32.Parse(siciNumSmall.Text);

            int ppe1 = Int32.Parse(siciNumMedium.Text);

            int ppee2 = Int32.Parse(siciNumLarge.Text);

            int pepe = Int32.Parse(tutipi.Text);


            p4.Text = (pe1 + ppee2 + ppee2).ToString();
            int pupu = Int32.Parse(p4.Text);
            stock4.Text = (pepe - pupu).ToString();

            int number;
            number = int.Parse(p4.Text);
            if (number > 25)
            {
                MessageBox.Show("Sorry your order is beyond in the limit of our stocks today for this pizza", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                siciNumSmall.Text = "0";
                siciNumMedium.Text = "0";
                siciNumLarge.Text = "0";
                SiciCart.Text = "..........";
                siciAmount.Text = "0";
                siciAmount.Visible = false;
                stock4.Text = "25";
            }
            else
            {

                siciAmount.Visible = true;
                if (string.IsNullOrEmpty(siciSizeSmall.Text))
                {
                    MessageBox.Show("Please choose from choices of sizes above before you calculate.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    siciSizeSmall.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(siciNumSmall.Text))
                {
                    MessageBox.Show("Please Enter how many order/orders do you want before you calculate.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    siciNumSmall.Focus();
                    return;
                }

                int a = Int32.Parse(siciNumSmall.Text);
                int b = Int32.Parse(siciSizeSmall.Text);
                int c = Int32.Parse(siciNumMedium.Text);
                int d = Int32.Parse(siciSizeMedium.Text);
                int k = Int32.Parse(siciNumLarge.Text);
                int f = Int32.Parse(siciSizeLarge.Text);

                siciAmount.Text = (a * b + c * d + k * f).ToString();

                //small
                int aa = Int32.Parse(siciSizeSmall.Text);
                int bb = Int32.Parse(siciNumSmall.Text);

                comsicismall.Text = (aa * bb).ToString();

                string cc = siciNumSmall.Text, dd = button45.Text, kk = comsicismall.Text, ff = EnterSpace.Text;
                sicitotsmall.Text = (cc + dd + kk + ff);

                //medium
                int aaa = Int32.Parse(siciSizeMedium.Text);
                int bbb = Int32.Parse(siciNumMedium.Text);

                comsicimedium.Text = (aaa * bbb).ToString();

                string ccc = siciNumMedium.Text, ddd = button44.Text, kkk = comsicimedium.Text, fff = EnterSpace.Text;
                sicitotmedium.Text = (ccc + ddd + kkk + fff);

                //large
                int aaaa = Int32.Parse(siciSizeLarge.Text);
                int bbbb = Int32.Parse(siciNumLarge.Text);

                comsicilarge.Text = (aaaa * bbbb).ToString();

                string cccc = siciNumLarge.Text, dddd = button43.Text, kkkk = comsicilarge.Text, ffff = EnterSpace.Text;
                sicitotlarge.Text = (cccc + dddd + kkkk + ffff);

                //cart
                string aaaaa = sicitotsmall.Text, bbbbb = sicitotmedium.Text, zzz = sicitotlarge.Text;

                SiciCart.Text = (aaaaa +
                    bbbbb +
                    zzz);
            }








        }

        private void button49_Click(object sender, EventArgs e)
        {
            //visibility and amout of small greek pizza
            greekNumSmall.Visible = true;
            greekSizeSmall.Visible = true;
            greekSizeSmall.Text = "450";
        }

        private void button48_Click(object sender, EventArgs e)
        {
            //visibility and amout of medium greek pizza
            greekNumMedium.Visible = true;
            greekSizeMedium.Visible = true;
            greekSizeMedium.Text = "625";
        }

        private void button47_Click(object sender, EventArgs e)
        {
            //visibility and amout of large greek pizza
            greekNumLarge.Visible = true;
            greekSizeLarge.Visible = true;
            greekSizeLarge.Text = "975";
        }

        private void button46_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            string query = "update StocksRF set [Greek_Pizza_Stock]='" + stock5.Text + "'   where  [ID]=" + num.Text + "";
           
            command.CommandText = query;

            command.ExecuteNonQuery();
            connection.Close();



            int pe1 = Int32.Parse(greekNumSmall.Text);

            int ppe1 = Int32.Parse(greekNumMedium.Text);

            int ppee2 = Int32.Parse(greekNumLarge.Text);

            int pepe = Int32.Parse(tutipi.Text);


            p5.Text = (pe1 + ppee2 + ppee2).ToString();
            int pupu = Int32.Parse(p5.Text);
            stock5.Text = (pepe - pupu).ToString();

            int number;
            number = int.Parse(p5.Text);
            if (number > 25)
            {
                MessageBox.Show("Sorry your order is beyond in the limit of our stocks today for this pizza", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                greekNumSmall.Text = "0";
                greekNumMedium.Text = "0";
                greekNumLarge.Text = "0";
                GreekCart.Text = "..........";
                greekAmount.Text = "0";
                greekAmount.Visible = false;
                stock5.Text = "25";
            }
            else
            {
                greekAmount.Visible = true;
                if (string.IsNullOrEmpty(greekSizeSmall.Text))
                {
                    MessageBox.Show("Please choose from choices of sizes above before you calculate.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    greekSizeSmall.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(greekNumSmall.Text))
                {
                    MessageBox.Show("Please Enter how many order/orders do you want before you calculate.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    greekNumSmall.Focus();
                    return;
                }

                int a = Int32.Parse(greekNumSmall.Text);
                int b = Int32.Parse(greekSizeSmall.Text);
                int c = Int32.Parse(greekNumMedium.Text);
                int d = Int32.Parse(greekSizeMedium.Text);
                int k = Int32.Parse(greekNumLarge.Text);
                int f = Int32.Parse(greekSizeLarge.Text);

                greekAmount.Text = (a * b + c * d + k * f).ToString();

                //small
                int aa = Int32.Parse(greekSizeSmall.Text);
                int bb = Int32.Parse(greekNumSmall.Text);

                comgreeksmall.Text = (aa * bb).ToString();

                string cc = greekNumSmall.Text, dd = button49.Text, kk = comgreeksmall.Text, ff = EnterSpace.Text;
                greektotsmall.Text = (cc + dd + kk + ff);

                //medium
                int aaa = Int32.Parse(greekSizeMedium.Text);
                int bbb = Int32.Parse(greekNumMedium.Text);

                comgreekmedium.Text = (aaa * bbb).ToString();

                string ccc = greekNumMedium.Text, ddd = button48.Text, kkk = comgreekmedium.Text, fff = EnterSpace.Text;
                greektotmedium.Text = (ccc + ddd + kkk + fff);

                //large
                int aaaa = Int32.Parse(greekSizeLarge.Text);
                int bbbb = Int32.Parse(greekNumLarge.Text);

                comgreeklarge.Text = (aaaa * bbbb).ToString();

                string cccc = greekNumLarge.Text, dddd = button47.Text, kkkk = comgreeklarge.Text, ffff = EnterSpace.Text;
                greektotlarge.Text = (cccc + dddd + kkkk + ffff);

                //cart
                string aaaaa = greektotsmall.Text, bbbbb = greektotmedium.Text, zzz = greektotlarge.Text;

                GreekCart.Text = (aaaaa +
                    bbbbb +
                    zzz);

            }





        }

        private void button53_Click(object sender, EventArgs e)
        {
            //visibility and amout of small cal pizza
            calNumSmall.Visible = true;
            calSizeSmall.Visible = true;
            calSizeSmall.Text = "525";
        }

        private void button52_Click(object sender, EventArgs e)
        {
            //visibility and amout of medium cal pizza
            calNumMedium.Visible = true;
            calSizeMedium.Visible = true;
            calSizeMedium.Text = "750";
        }

        private void button51_Click(object sender, EventArgs e)
        {
            //visibility and amout of large cal pizza
            calNumLarge.Visible = true;
            calSizeLarge.Visible = true;
            calSizeLarge.Text = "900";
        }

        private void button50_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            string query = "update StocksRF set [Califorinia_Pizza_Stock]='" + stock6.Text + "'   where  [ID]=" + num.Text + "";
           
            command.CommandText = query;

            command.ExecuteNonQuery();
            connection.Close();


            int pe1 = Int32.Parse(calNumSmall.Text);

            int ppe1 = Int32.Parse(calNumMedium.Text);

            int ppee2 = Int32.Parse(calNumLarge.Text);

            int pepe = Int32.Parse(tutipi.Text);


            p6.Text = (pe1 + ppee2 + ppee2).ToString();
            int pupu = Int32.Parse(p6.Text);
            stock6.Text = (pepe - pupu).ToString();

            int number;
            number = int.Parse(p6.Text);
            if (number > 25)
            {
                MessageBox.Show("Sorry your order is beyond in the limit of our stocks today for this pizza", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                calNumSmall.Text = "0";
                calNumMedium.Text = "0";
                calNumLarge.Text = "0";
                CalCart.Text = "..........";
                calAmount.Text = "0";
                calAmount.Visible = false;
                stock6.Text = "25";
            }
            else
            {
                calAmount.Visible = true;
                if (string.IsNullOrEmpty(calSizeSmall.Text))
                {
                    MessageBox.Show("Please choose from choices of sizes above before you calculate.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    calSizeSmall.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(calNumSmall.Text))
                {
                    MessageBox.Show("Please Enter how many order/orders do you want before you calculate.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    calNumSmall.Focus();
                    return;
                }

                int a = Int32.Parse(calNumSmall.Text);
                int b = Int32.Parse(calSizeSmall.Text);
                int c = Int32.Parse(calNumMedium.Text);
                int d = Int32.Parse(calSizeMedium.Text);
                int k = Int32.Parse(calNumLarge.Text);
                int f = Int32.Parse(calSizeLarge.Text);

                calAmount.Text = (a * b + c * d + k * f).ToString();

                //small
                int aa = Int32.Parse(calSizeSmall.Text);
                int bb = Int32.Parse(calNumSmall.Text);

                comcalsmall.Text = (aa * bb).ToString();

                string cc = calNumSmall.Text, dd = button53.Text, kk = comcalsmall.Text, ff = EnterSpace.Text;
                caltotsmall.Text = (cc + dd + kk + ff);

                //medium
                int aaa = Int32.Parse(calSizeMedium.Text);
                int bbb = Int32.Parse(calNumMedium.Text);

                comcalmedium.Text = (aaa * bbb).ToString();

                string ccc = calNumMedium.Text, ddd = button52.Text, kkk = comcalmedium.Text, fff = EnterSpace.Text;
                caltotmedium.Text = (ccc + ddd + kkk + fff);

                //large
                int aaaa = Int32.Parse(calSizeLarge.Text);
                int bbbb = Int32.Parse(calNumLarge.Text);

                comcallarge.Text = (aaaa * bbbb).ToString();

                string cccc = calNumLarge.Text, dddd = button51.Text, kkkk = comcallarge.Text, ffff = EnterSpace.Text;
                caltotlarge.Text = (cccc + dddd + kkkk + ffff);

                //cart
                string aaaaa = caltotsmall.Text, bbbbb = caltotmedium.Text, zzz = caltotlarge.Text;

                CalCart.Text = (aaaaa +
                    bbbbb +
                    zzz);
            }


           


        }

        private void button57_Click(object sender, EventArgs e)
        {
            //visibility and amout of small det pizza
            detNumSmall.Visible = true;
            detSizeSmall.Visible = true;
            detSizeSmall.Text = "425";
        }

        private void button56_Click(object sender, EventArgs e)
        {
            //visibility and amout of large det pizza
            detNumMedium.Visible = true;
            detSizeMedium.Visible = true;
            detSizeMedium.Text = "675";
        }

        private void button55_Click(object sender, EventArgs e)
        {
            //visibility and amout of large det pizza
            detNumLarge.Visible = true;
            detSizeLarge.Visible = true;
            detSizeLarge.Text = "895";
        }

        private void button54_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            string query = "update StocksRF set [Detroit_Pizza_Stock]='" + stock7.Text + "'   where  [ID]=" + num.Text + "";
           
            command.CommandText = query;

            command.ExecuteNonQuery();
            connection.Close();


            int pe1 = Int32.Parse(detNumSmall.Text);

            int ppe1 = Int32.Parse(detNumMedium.Text);

            int ppee2 = Int32.Parse(detNumLarge.Text);

            int pepe = Int32.Parse(tutipi.Text);


            p7.Text = (pe1 + ppee2 + ppee2).ToString();
            int pupu = Int32.Parse(p7.Text);
            stock7.Text = (pepe - pupu).ToString();

            int number;
            number = int.Parse(p7.Text);
            if (number > 25)
            {
                MessageBox.Show("Sorry your order is beyond in the limit of our stocks today for this pizza", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                detNumSmall.Text = "0";
                detNumMedium.Text = "0";
                detNumLarge.Text = "0";
                DetCart.Text = "..........";
                detAmount.Text = "0";
                detAmount.Visible = false;
                stock7.Text = "25";
            }
            else
            {
                detAmount.Visible = true;
                if (string.IsNullOrEmpty(detSizeSmall.Text))
                {
                    MessageBox.Show("Please choose from choices of sizes above before you calculate.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    detSizeSmall.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(detNumSmall.Text))
                {
                    MessageBox.Show("Please Enter how many order/orders do you want before you calculate.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    detNumSmall.Focus();
                    return;
                }

                int a = Int32.Parse(detNumSmall.Text);
                int b = Int32.Parse(detSizeSmall.Text);
                int c = Int32.Parse(detNumMedium.Text);
                int d = Int32.Parse(detSizeMedium.Text);
                int k = Int32.Parse(detNumLarge.Text);
                int f = Int32.Parse(detSizeLarge.Text);

                detAmount.Text = (a * b + c * d + k * f).ToString();

                //small
                int aa = Int32.Parse(detSizeSmall.Text);
                int bb = Int32.Parse(detNumSmall.Text);

                comdetsmall.Text = (aa * bb).ToString();

                string cc = detNumSmall.Text, dd = button57.Text, kk = comdetsmall.Text, ff = EnterSpace.Text;
                dettotsmall.Text = (cc + dd + kk + ff);

                //medium
                int aaa = Int32.Parse(detSizeMedium.Text);
                int bbb = Int32.Parse(detNumMedium.Text);

                comdetmedium.Text = (aaa * bbb).ToString();

                string ccc = detNumMedium.Text, ddd = button56.Text, kkk = comdetmedium.Text, fff = EnterSpace.Text;
                dettotmedium.Text = (ccc + ddd + kkk + fff);

                //large
                int aaaa = Int32.Parse(detSizeLarge.Text);
                int bbbb = Int32.Parse(detNumLarge.Text);

                comdetlarge.Text = (aaaa * bbbb).ToString();

                string cccc = detNumLarge.Text, dddd = button55.Text, kkkk = comdetlarge.Text, ffff = EnterSpace.Text;
                dettotlarge.Text = (cccc + dddd + kkkk + ffff);

                //cart
                string aaaaa = dettotsmall.Text, bbbbb = dettotmedium.Text, zzz = dettotlarge.Text;

                DetCart.Text = (aaaaa +
                    bbbbb +
                    zzz);
            }


            

        }

        private void button61_Click(object sender, EventArgs e)
        {
            //visibility and amout of small st pizza
            stNumSmall.Visible = true;
            stSizeSmall.Visible = true;
            stSizeSmall.Text = "675";
        }

        private void button60_Click(object sender, EventArgs e)
        {
            //visibility and amout of medium st pizza
            stNumMedium.Visible = true;
            stSizeMedium.Visible = true;
            stSizeMedium.Text = "950";
        }

        private void button59_Click(object sender, EventArgs e)
        {
            //visibility and amout of large st pizza
            stNumLarge.Visible = true;
            stSizeLarge.Visible = true;
            stSizeLarge.Text = "1125";
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void button58_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            string query = "update StocksRF set [St_Louis_Pizza_Stock]='" + stock8.Text + "'   where  [ID]=" + num.Text + "";
          
            command.CommandText = query;

            command.ExecuteNonQuery();
            connection.Close();

            int pe1 = Int32.Parse(stNumSmall.Text);

            int ppe1 = Int32.Parse(stNumMedium.Text);

            int ppee2 = Int32.Parse(stNumLarge.Text);

            int pepe = Int32.Parse(tutipi.Text);


            p8.Text = (pe1 + ppee2 + ppee2).ToString();
            int pupu = Int32.Parse(p8.Text);
            stock8.Text = (pepe - pupu).ToString();

            int number;
            number = int.Parse(p8.Text);
            if (number > 25)
            {
                MessageBox.Show("Sorry your order is beyond in the limit of our stocks today for this pizza", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                stNumSmall.Text = "0";
                stNumMedium.Text = "0";
                stNumLarge.Text = "0";
                StCart.Text = "..........";
                stAmount.Text = "0";
                stAmount.Visible = false;
                stock8.Text = "25";
            }



            stAmount.Visible = true;
            if (string.IsNullOrEmpty(stSizeSmall.Text))
            {
                MessageBox.Show("Please choose from choices of sizes above before you calculate.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                stSizeSmall.Focus();
                return;
            }

            if (string.IsNullOrEmpty(stNumSmall.Text))
            {
                MessageBox.Show("Please Enter how many order/orders do you want before you calculate.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                stNumSmall.Focus();
                return;
            }

            int a = Int32.Parse(stNumSmall.Text);
            int b = Int32.Parse(stSizeSmall.Text);
            int c = Int32.Parse(stNumMedium.Text);
            int d = Int32.Parse(stSizeMedium.Text);
            int k = Int32.Parse(stNumLarge.Text);
            int f = Int32.Parse(stSizeLarge.Text);

            stAmount.Text = (a * b + c * d + k * f).ToString();

            //small
            int aa = Int32.Parse(stSizeSmall.Text);
            int bb = Int32.Parse(stNumSmall.Text);

            comstsmall.Text = (aa * bb).ToString();

            string cc = stNumSmall.Text, dd = button61.Text, kk = comstsmall.Text, ff = EnterSpace.Text;
            sttotsmall.Text = (cc + dd + kk + ff);

            //medium
            int aaa = Int32.Parse(stSizeMedium.Text);
            int bbb = Int32.Parse(stNumMedium.Text);

            comstmedium.Text = (aaa * bbb).ToString();

            string ccc = stNumMedium.Text, ddd = button60.Text, kkk = comstmedium.Text, fff = EnterSpace.Text;
            sttotmedium.Text = (ccc + ddd + kkk + fff);

            //large
            int aaaa = Int32.Parse(stSizeLarge.Text);
            int bbbb = Int32.Parse(stNumLarge.Text);

            comstlarge.Text = (aaaa * bbbb).ToString();

            string cccc = stNumLarge.Text, dddd = button59.Text, kkkk = comstlarge.Text, ffff = EnterSpace.Text;
            sttotlarge.Text = (cccc + dddd + kkkk + ffff);

            //cart
            string aaaaa = sttotsmall.Text, bbbbb = sttotmedium.Text, zzz = sttotlarge.Text;

            StCart.Text = (aaaaa +
                bbbbb +
                zzz);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void lblShowCal_Click(object sender, EventArgs e)
        {

        }

        private void receiptToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            //it will calculate the total payment of the user's orders

            //it will show the cilck to order button
            button62.Visible = true;

            //message box to go to rate tabpage
            DialogResult dialogResult = MessageBox.Show("Do you want to rate us?","Message",MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                tabPage3.Show();
                tabControl1.SelectTab(tabPage3);
            }
            else
            {
                //computations

                textBox18.Text = "0";


                int a, b, c, d, l, f, g, h, i;

                a = Int32.Parse(NeapolitanAmount.Text);
                b = Int32.Parse(ChicagoAmount.Text);
                c = Int32.Parse(newyorkAmount.Text);
                d = Int32.Parse(siciAmount.Text);
                l = Int32.Parse(greekAmount.Text);
                f = Int32.Parse(calAmount.Text);
                g = Int32.Parse(detAmount.Text);
                h = Int32.Parse(stAmount.Text);
                i = Int32.Parse(all.Text);




                textBox18.Text = (a + b + c + d + l + f + g + h + i).ToString();





                if (string.IsNullOrEmpty(NeapolitanAmount.Text))
                {
                    MessageBox.Show("Thank You.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox18.Text = (b + c + d + l + f + g + h).ToString();
                }

                if (string.IsNullOrEmpty(ChicagoAmount.Text))
                {
                    MessageBox.Show("Thank You.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox18.Text = (a + c + d + l + f + g + h).ToString();
                }

                if (string.IsNullOrEmpty(newyorkAmount.Text))
                {
                    MessageBox.Show("Thank You.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox18.Text = (b + a + d + l + f + g + h).ToString();
                }

                if (string.IsNullOrEmpty(siciAmount.Text))
                {
                    MessageBox.Show("Thank You.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox18.Text = (b + c + a + l + f + g + h).ToString();
                }

                if (string.IsNullOrEmpty(greekAmount.Text))
                {
                    MessageBox.Show("Thank You.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox18.Text = (b + c + d + a + f + g + h).ToString();
                }

                if (string.IsNullOrEmpty(calAmount.Text))
                {
                    MessageBox.Show("Thank You.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox18.Text = (b + c + d + l + a + g + h).ToString();
                }

                if (string.IsNullOrEmpty(detAmount.Text))
                {
                    MessageBox.Show("Thank You.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox18.Text = (b + c + d + l + f + a + h).ToString();
                }

                if (string.IsNullOrEmpty(stAmount.Text))
                {
                    MessageBox.Show("Thank You.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox18.Text = (b + c + d + l + f + g + a).ToString();
                }
                else
                {
                    textBox18.Text = (a + b + c + d + l + f + g + h + i).ToString();
                }

            }

           





        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void button62_Click(object sender, EventArgs e)
        {
            
        }

        private void button63_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You!");
            Application.Exit();
        }

        private void button64_Click(object sender, EventArgs e)
        {
            //back to form1
            Form1 f1 = new Form1();
            Visible = false;
            f1.Show();



        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button71_Click(object sender, EventArgs e)
        {


        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button69_Click(object sender, EventArgs e)
        {






        }

        private void button70_Click(object sender, EventArgs e)
        {

        }

        private void button72_Click(object sender, EventArgs e)
        {


        }

        private void button68_Click(object sender, EventArgs e)
        {

        }

        private void button67_Click(object sender, EventArgs e)
        {

        }

        private void button66_Click(object sender, EventArgs e)
        {

        }

        private void button65_Click(object sender, EventArgs e)
        {

        }

        private void button65_Click_1(object sender, EventArgs e)
        {


        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button65_Click_2(object sender, EventArgs e)
        {





        }

        private void label18_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void button66_Click_1(object sender, EventArgs e)
        {




        }

        private void button67_Click_1(object sender, EventArgs e)
        {

        }

        private void button68_Click_1(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {




        }

        private void button72_Click_1(object sender, EventArgs e)
        {




        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button65_Click_3(object sender, EventArgs e)
        {
           
        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void button67_Click_2(object sender, EventArgs e)
        {
            
        }

        private void button68_Click_2(object sender, EventArgs e)
        {
            
        }

        private void button66_Click_2(object sender, EventArgs e)
        {

            MessageBox.Show("Added to Cart!");
            tabPage1.Show();
            tabControl1.SelectTab(tabPage1);

            panel17.Visible = true;
            csrall.Visible = true;
            string a = coke.Text, b = sprite.Text, z = royal.Text;
            
            csrall.Text = (a +
                b +
                z);

            //coke
            int d, g;
            d = Int32.Parse(price.Text);
            g = Int32.Parse(cbcoke.Text);
            rcoke.Text = (d * g).ToString();

            string aa = cbcoke.Text, bb = lcoke.Text, c = rcoke.Text, zz = entercoke.Text;
            coke.Text = (aa + bb + c + zz);

            //sprite
            int dd, gg;
            dd = Int32.Parse(price.Text);
            gg = Int32.Parse(cbsprite.Text);
            rsprite.Text = (dd * gg).ToString();

            string aaa = cbsprite.Text, bbb = lsprite.Text, cc = rsprite.Text, zzz = entersprite.Text;
            sprite.Text = (aaa + bbb + cc + zzz);

            //royal
            int ddd, ggg;
            ddd = Int32.Parse(price.Text);
            ggg = Int32.Parse(cbroyal.Text);
            rroyal.Text = (ddd * ggg).ToString();

            string aaaa = cbroyal.Text, bbbb = lroyal.Text, ccc = rroyal.Text, zzzz = enterroyal.Text;
            royal.Text = (aaaa + bbbb + ccc + zzzz);

            //totalsoda
            int aaaaa, bbbbb, ccccc;
            aaaaa = Int32.Parse(rcoke.Text);
            bbbbb = Int32.Parse(rsprite.Text);
            ccccc = Int32.Parse(rroyal.Text);
            all.Text = (aaaaa + bbbbb + ccccc).ToString();

            
            //cart
            string aaaaaa = coke.Text, bbbbbb = sprite.Text, zzzzz = royal.Text;

            csrall.Text = (aaaaaa +
                bbbbbb +
                zzzzz);


        }

        private void button69_Click_1(object sender, EventArgs e)
        {
    

        }

        private void button70_Click_1(object sender, EventArgs e)
        {
            
        }

        private void mobnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button71_Click_1(object sender, EventArgs e)
        {
       
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChicagoNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChicSizeSmall_TextChanged(object sender, EventArgs e)
        {

        }

        private void newSizeSmall_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void newyorkNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void NeaSizeMedium_TextChanged(object sender, EventArgs e)
        {

        }

        private void NeaNumMedium_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NeaSizeLarge_TextChanged(object sender, EventArgs e)
        {

        }

        private void NeaNumLarge_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void greekSizeSmall_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChicSizeLarge_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChicNumLarge_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChicNumMedium_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calSizeSmall_TextChanged(object sender, EventArgs e)
        {

        }

        private void calNumMedium_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calSizeLarge_TextChanged(object sender, EventArgs e)
        {

        }

        private void calNumLarge_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void siciNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click_1(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void neatotsmall_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click_1(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void NeaCart_Click(object sender, EventArgs e)
        {

        }

        private void button71_Click_2(object sender, EventArgs e)
        {
            tabPage3.Show();
            tabControl1.SelectTab(tabPage3);
        }

        private void button62_Click_1(object sender, EventArgs e)
        {

            //if the customer does not input its data; name,address, mobile number
            if (string.IsNullOrEmpty(cusname.Text))
            {
                MessageBox.Show("Please Enter Your Name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cusname.Focus();
                return;
            }

            if (string.IsNullOrEmpty(mobnum.Text))
            {
                MessageBox.Show("Please Enter Your Mobile Number .", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mobnum.Focus();
                return;
            }

            if (string.IsNullOrEmpty(add.Text))
            {
                MessageBox.Show("Please Enter Your Address.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                add.Focus();
                return;
            }

            //it will add the Customers data as well as their orders in the database
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "insert into AcustomersOrdersRFU ([Customers_Name],[Mobile_Number],[Address],[Order_Date]" +
                    ",[Order_Time],[Neapolitan_Pizza],[Neapolitan_Total],[Chicago_Pizza],[Chicago_Total],[NewYork_Style_Pizza],[NewYork_Style_Total],[Sicilian_Pizza],[Sicilian_Total],[Greek_Pizza],[Greek_Total]" +
                    ",[California_Pizza],[California_Total],[Detroit_Pizza],[Detroit_Total],[St_Louis_Pizza],[St_Louis_Total],[Drinks_Order],[Drinks_Total],[All_Total_Payment]) values('" + cusname.Text + "','" + mobnum.Text + "','" + add.Text + "'" +
                    ",'" + order_DateTextBox.Text + "','" + order_TimeTextBox.Text + "','" + NeaCart.Text + "','" + NeapolitanAmount.Text + "'" +
                    ",'" + ChicCart.Text + "','" + ChicagoAmount.Text + "','" + NewCart.Text + "','" + newyorkAmount.Text + "'" +
                    ",'" + SiciCart.Text + "','" + siciAmount.Text + "','" + GreekCart.Text + "','" + greekAmount.Text + "'" +
                    ",'" + CalCart.Text + "','" + calAmount.Text + "','" + DetCart.Text + "','" + detAmount.Text + "'" +
                    ",'" + StCart.Text + "','" + stAmount.Text + "','" + csrall.Text + "','" + all.Text + "'" +
                    ",'" + textBox18.Text + "')";

                command.ExecuteNonQuery();
                MessageBox.Show("Your Order is on the way to your address","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }

            //update stocks
            try
            {

                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                string query = "update StocksRF set [Neapolitan_Pizza_Stock]='" + stock1.Text + "' ,[Chicago_Pizza_Stock]='" + stock2.Text + "' ,[New_York_Pizza_Stock]='" + stock3.Text + "' ,[Sicilian_Pizza_Stock]='" + stock4.Text + "' ,[Greek_Pizza_Stock]='" + stock5.Text + "',[Califorinia_Pizza_Stock]='" + stock6.Text + "',[Detroit_Pizza_Stock]='" + stock7.Text + "',[St_Louis_Pizza_Stock]='" + stock8.Text + "'  where  [ID]=" + num.Text + "";
               
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Please Wait : )","Update");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }


            //for resiboooooooooooooooooooooooo
            //the objects are on tabpage so this codes will get the users input then will put in the organized list form which is the reciept in tabpage 5
            tabPage5.Show();
            tabControl1.SelectTab(tabPage5);
            string a = cusname.Text, b = add.Text, c = mobnum.Text;
            rname.Text = a;
            radd.Text = b;
            rmob.Text = c;

            string d = NeaCart.Text, f = ChicCart.Text, g = NewCart.Text, h = SiciCart.Text, i = GreekCart.Text, j = CalCart.Text, k = DetCart.Text, l = StCart.Text, z = csrall.Text, x = textBox18.Text, m = EnterSpace.Text;
            resibolahat.Text = d + m + f + m + g + m + h + m + i + m + j + m + k + m + l + m + z + m;
            tp.Text = "P " + x + ".00";
            first.Text = d;
            second.Text = f;
            third.Text = g;
            fourth.Text = h;
            fifth.Text = i;
            sixth.Text = j;
            seventh.Text = k;
            eight.Text = l;
            nine.Text = z;


        }

        private void order_TimeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click_2(object sender, EventArgs e)
        {

        }

        private void StCart_Click(object sender, EventArgs e)
        {

        }

        private void DetCart_Click(object sender, EventArgs e)
        {

        }

        private void CalCart_Click(object sender, EventArgs e)
        {

        }

        private void SiciCart_Click(object sender, EventArgs e)
        {

        }

        private void panel17_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void NewCart_Click(object sender, EventArgs e)
        {

        }

        private void ChicCart_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click_1(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click_1(object sender, EventArgs e)
        {

        }

        private void button65_Click_4(object sender, EventArgs e)
        {
            //will show the tabpage 2; which is the drinks tabpage
            tabPage2.Show();
            tabControl1.SelectTab(tabPage2);
            panel17.Visible = true;
        }

        private void button67_Click_3(object sender, EventArgs e)
        {
            //will show the tabpage1
            tabPage1.Show();
            tabControl1.SelectTab(tabPage1);
        }

        private void button68_Click_3(object sender, EventArgs e)
        {
            tabPage5.Show();
            tabControl1.SelectTab(tabPage5);
            string a = cusname.Text, b = add.Text, c = mobnum.Text;
            rname.Text = a;
            radd.Text = b;
            rmob.Text = c;

            string d = NeaCart.Text, f = ChicCart.Text, g = NewCart.Text, h = SiciCart.Text, i = GreekCart.Text, j = CalCart.Text, k = DetCart.Text, l = StCart.Text, z = csrall.Text, x = textBox18.Text, m = EnterSpace.Text;
            resibolahat.Text = d + m + f + m + g + m + h + m + i + m + j + m + k + m + l + m + z + m + x;

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stock1_Click(object sender, EventArgs e)
        {
           






        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 2000, WinAPI.VER_NEGATIVE);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button69_Click_2(object sender, EventArgs e)
        {
            //will clear all the users input datas


            //RESIBOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO

            rname.Text = "---------------------------";
            radd.Text = "---------------------------";
            rmob.Text = "---------------------------";

            first.Text = "...............";
            second.Text = "...............";
            third.Text = "...............";
            fourth.Text = "...............";
            fifth.Text = "...............";
            sixth.Text = "...............";
            seventh.Text = "...............";
            eight.Text = "...............";
            nine.Text = "...............";
            tp.Text = "...............";

            //CARTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT

            NeapolitanAmount.Visible = false;
            ChicagoAmount.Visible = false;
            newyorkAmount.Visible = false;
            siciAmount.Visible = false;
            greekAmount.Visible = false;
            calAmount.Visible = false;
            detAmount.Visible = false;
            stAmount.Visible = false;
            all.Visible = false;
            csrall.Visible = false;







            NeaCart.Text = "..........";
            ChicCart.Text = "..........";
            NewCart.Text = "..........";
            SiciCart.Text = "..........";

            GreekCart.Text = "..........";
            CalCart.Text = "..........";
            DetCart.Text = "..........";
            StCart.Text = "..........";

            NeapolitanAmount.Text = "0";
            NeaNumSmall.Text = "0";
            NeaNumMedium.Text = "0";
            NeaNumLarge.Text = "0";


            ChicagoAmount.Text = "0";
            ChicNumSmall.Text = "0";
            ChicNumMedium.Text = "0";
            ChicNumLarge.Text = "0";


            newyorkAmount.Text = "0";
            newNumSmall.Text = "0";
            newNumMedium.Text = "0";
            newNumLarge.Text = "0";


            siciAmount.Text = "0";
            siciNumSmall.Text = "0";
            siciNumMedium.Text = "0";
            siciNumLarge.Text = "0";


            greekAmount.Text = "0";
            greekNumSmall.Text = "0";
            greekNumMedium.Text = "0";
            greekNumLarge.Text = "0";


            calAmount.Text = "0";
            calNumSmall.Text = "0";
            calNumMedium.Text = "0";
            calNumLarge.Text = "0";


            detAmount.Text = "0";
            detNumSmall.Text = "0";
            detNumMedium.Text = "0";
            detNumLarge.Text = "0";


            stAmount.Text = "0";
            stNumSmall.Text = "0";
            stNumMedium.Text = "0";
            stNumLarge.Text = "0";


            all.Text = "0";

            cusname.Clear();
            mobnum.Clear();
            add.Clear();
            textBox18.Clear();

            tabPage1.Show();
            tabControl1.SelectTab(tabPage1);


        }

        private void rcart_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void newNumMedium_TextChanged(object sender, EventArgs e)
        {

        }

        private void customers_NameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
