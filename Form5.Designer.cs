namespace PIZZAKOPIZZAMO
{
    partial class Form5
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.pizza_firstDataSet1 = new PIZZAKOPIZZAMO.Pizza_firstDataSet1();
            this.stocksRFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stocksRFTableAdapter = new PIZZAKOPIZZAMO.Pizza_firstDataSet1TableAdapters.StocksRFTableAdapter();
            this.tableAdapterManager = new PIZZAKOPIZZAMO.Pizza_firstDataSet1TableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.RF = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocksRFDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pizza_firstDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksRFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksRFDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pizza_firstDataSet1
            // 
            this.pizza_firstDataSet1.DataSetName = "Pizza_firstDataSet1";
            this.pizza_firstDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stocksRFBindingSource
            // 
            this.stocksRFBindingSource.DataMember = "StocksRF";
            this.stocksRFBindingSource.DataSource = this.pizza_firstDataSet1;
            // 
            // stocksRFTableAdapter
            // 
            this.stocksRFTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AcustomersOrdersRFUTableAdapter = null;
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersOrdersRFTableAdapter = null;
            this.tableAdapterManager.CustomersOrdersTableAdapter = null;
            this.tableAdapterManager.Form_RatingsTableAdapter = null;
            this.tableAdapterManager.Form1TableAdapter = null;
            this.tableAdapterManager.PizzaForm2TableAdapter = null;
            this.tableAdapterManager.StocksRFTableAdapter = this.stocksRFTableAdapter;
            this.tableAdapterManager.UpdateOrder = PIZZAKOPIZZAMO.Pizza_firstDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vivaldi", 51.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(461, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 82);
            this.label1.TabIndex = 5;
            this.label1.Text = "Management";
            // 
            // RF
            // 
            this.RF.AutoSize = true;
            this.RF.BackColor = System.Drawing.Color.Transparent;
            this.RF.Font = new System.Drawing.Font("Vivaldi", 51.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RF.ForeColor = System.Drawing.Color.White;
            this.RF.Location = new System.Drawing.Point(264, 26);
            this.RF.Name = "RF";
            this.RF.Size = new System.Drawing.Size(206, 82);
            this.RF.TabIndex = 4;
            this.RF.Text = "Stock";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(965, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Drinks_Stock";
            this.dataGridViewTextBoxColumn10.HeaderText = "Drinks_Stock";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "St_Louis_Pizza_Stock";
            this.dataGridViewTextBoxColumn9.HeaderText = "St_Louis_Pizza_Stock";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Detroit_Pizza_Stock";
            this.dataGridViewTextBoxColumn8.HeaderText = "Detroit_Pizza_Stock";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Califorinia_Pizza_Stock";
            this.dataGridViewTextBoxColumn7.HeaderText = "Califorinia_Pizza_Stock";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Greek_Pizza_Stock";
            this.dataGridViewTextBoxColumn6.HeaderText = "Greek_Pizza_Stock";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sicilian_Pizza_Stock";
            this.dataGridViewTextBoxColumn5.HeaderText = "Sicilian_Pizza_Stock";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "New_York_Pizza_Stock";
            this.dataGridViewTextBoxColumn4.HeaderText = "New_York_Pizza_Stock";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Chicago_Pizza_Stock";
            this.dataGridViewTextBoxColumn3.HeaderText = "Chicago_Pizza_Stock";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Neapolitan_Pizza_Stock";
            this.dataGridViewTextBoxColumn2.HeaderText = "Neapolitan_Pizza_Stock";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // stocksRFDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            this.stocksRFDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.stocksRFDataGridView.AutoGenerateColumns = false;
            this.stocksRFDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.stocksRFDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stocksRFDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.stocksRFDataGridView.DataSource = this.stocksRFBindingSource;
            this.stocksRFDataGridView.Location = new System.Drawing.Point(12, 161);
            this.stocksRFDataGridView.Name = "stocksRFDataGridView";
            this.stocksRFDataGridView.Size = new System.Drawing.Size(1028, 183);
            this.stocksRFDataGridView.TabIndex = 1;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 402);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RF);
            this.Controls.Add(this.stocksRFDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pizza_firstDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksRFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksRFDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Pizza_firstDataSet1 pizza_firstDataSet1;
        private System.Windows.Forms.BindingSource stocksRFBindingSource;
        private Pizza_firstDataSet1TableAdapters.StocksRFTableAdapter stocksRFTableAdapter;
        private Pizza_firstDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView stocksRFDataGridView;
    }
}