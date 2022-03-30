namespace PIZZAKOPIZZAMO
{
    partial class ratings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ratings));
            this.pizza_firstDataSet1 = new PIZZAKOPIZZAMO.Pizza_firstDataSet1();
            this.form_RatingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form_RatingsTableAdapter = new PIZZAKOPIZZAMO.Pizza_firstDataSet1TableAdapters.Form_RatingsTableAdapter();
            this.tableAdapterManager = new PIZZAKOPIZZAMO.Pizza_firstDataSet1TableAdapters.TableAdapterManager();
            this.form_RatingsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pizza_firstDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form_RatingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form_RatingsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pizza_firstDataSet1
            // 
            this.pizza_firstDataSet1.DataSetName = "Pizza_firstDataSet1";
            this.pizza_firstDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // form_RatingsBindingSource
            // 
            this.form_RatingsBindingSource.DataMember = "Form_Ratings";
            this.form_RatingsBindingSource.DataSource = this.pizza_firstDataSet1;
            // 
            // form_RatingsTableAdapter
            // 
            this.form_RatingsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AcustomersOrdersRFUTableAdapter = null;
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersOrdersRFTableAdapter = null;
            this.tableAdapterManager.CustomersOrdersTableAdapter = null;
            this.tableAdapterManager.Form_RatingsTableAdapter = this.form_RatingsTableAdapter;
            this.tableAdapterManager.Form1TableAdapter = null;
            this.tableAdapterManager.PizzaForm2TableAdapter = null;
            this.tableAdapterManager.StocksRFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PIZZAKOPIZZAMO.Pizza_firstDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // form_RatingsDataGridView
            // 
            this.form_RatingsDataGridView.AutoGenerateColumns = false;
            this.form_RatingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.form_RatingsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.form_RatingsDataGridView.DataSource = this.form_RatingsBindingSource;
            this.form_RatingsDataGridView.Location = new System.Drawing.Point(158, 215);
            this.form_RatingsDataGridView.Name = "form_RatingsDataGridView";
            this.form_RatingsDataGridView.Size = new System.Drawing.Size(450, 220);
            this.form_RatingsDataGridView.TabIndex = 1;
            this.form_RatingsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.form_RatingsDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Ratings_Stars";
            this.dataGridViewTextBoxColumn1.HeaderText = "Ratings_Stars";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Comments";
            this.dataGridViewTextBoxColumn2.HeaderText = "Comments";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vivaldi", 51.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(261, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 82);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ratings";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ratings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.form_RatingsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ratings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ratings";
            this.Load += new System.EventHandler(this.ratings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pizza_firstDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form_RatingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form_RatingsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Pizza_firstDataSet1 pizza_firstDataSet1;
        private System.Windows.Forms.BindingSource form_RatingsBindingSource;
        private Pizza_firstDataSet1TableAdapters.Form_RatingsTableAdapter form_RatingsTableAdapter;
        private Pizza_firstDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView form_RatingsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}