namespace PIZZAKOPIZZAMO
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pizza_firstDataSet = new PIZZAKOPIZZAMO.Pizza_firstDataSet();
            this.pizzaForm1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzaForm1TableAdapter = new PIZZAKOPIZZAMO.Pizza_firstDataSetTableAdapters.PizzaForm1TableAdapter();
            this.tableAdapterManager = new PIZZAKOPIZZAMO.Pizza_firstDataSetTableAdapters.TableAdapterManager();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pizza_firstDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaForm1BindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pizza_firstDataSet
            // 
            this.pizza_firstDataSet.DataSetName = "Pizza_firstDataSet";
            this.pizza_firstDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pizzaForm1BindingSource
            // 
            this.pizzaForm1BindingSource.DataMember = "PizzaForm1";
            this.pizzaForm1BindingSource.DataSource = this.pizza_firstDataSet;
            // 
            // pizzaForm1TableAdapter
            // 
            this.pizzaForm1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PizzaForm1TableAdapter = this.pizzaForm1TableAdapter;
            this.tableAdapterManager.UpdateOrder = PIZZAKOPIZZAMO.Pizza_firstDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(765, 580);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "--------------------------------------------------";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 90);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("ROG Fonts", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 50);
            this.button3.TabIndex = 26;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Vivaldi", 51.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(565, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 82);
            this.label3.TabIndex = 27;
            this.label3.Text = "Resto Flash";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(601, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Crave, Choose, Click, And Enjoy!";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 90);
            this.button4.TabIndex = 29;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(68, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 10);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(916, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 240);
            this.panel2.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(916, 332);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 271);
            this.panel3.TabIndex = 32;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(51, 596);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(875, 10);
            this.panel4.TabIndex = 31;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(634, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(114, 96);
            this.panel5.TabIndex = 33;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button4);
            this.panel7.Location = new System.Drawing.Point(768, 100);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(114, 96);
            this.panel7.TabIndex = 34;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button3);
            this.panel6.Location = new System.Drawing.Point(12, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(50, 56);
            this.panel6.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 615);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pizza_firstDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaForm1BindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Pizza_firstDataSet pizza_firstDataSet;
        private System.Windows.Forms.BindingSource pizzaForm1BindingSource;
        private Pizza_firstDataSetTableAdapters.PizzaForm1TableAdapter pizzaForm1TableAdapter;
        private Pizza_firstDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
    }
}

