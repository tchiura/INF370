namespace Insight_Prototype_
{
    partial class GenerateProjectQuotationPage
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
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.Userlbl = new System.Windows.Forms.Label();
            this.MinimisePicBx = new System.Windows.Forms.PictureBox();
            this.ClosePicBx = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button78 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvJobType = new System.Windows.Forms.DataGridView();
            this.jobTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insightDataSet = new Insight_Prototype_.InsightDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.ProductType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Product = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fKProductProductTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvcJobType = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvcProduct = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTypeTableAdapter = new Insight_Prototype_.InsightDataSetTableAdapters.ProductTypeTableAdapter();
            this.productTableAdapter = new Insight_Prototype_.InsightDataSetTableAdapters.ProductTableAdapter();
            this.jobTypeTableAdapter = new Insight_Prototype_.InsightDataSetTableAdapters.JobTypeTableAdapter();
            this.jobTableAdapter = new Insight_Prototype_.InsightDataSetTableAdapters.JobTableAdapter();
            this.fKJobTypePriceJobTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobTypePriceTableAdapter = new Insight_Prototype_.InsightDataSetTableAdapters.JobTypePriceTableAdapter();
            this.JobType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimisePicBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBx)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insightDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductProductTypeBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcJobType)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKJobTypePriceJobTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.TopBarPanel.Controls.Add(this.Userlbl);
            this.TopBarPanel.Controls.Add(this.MinimisePicBx);
            this.TopBarPanel.Controls.Add(this.ClosePicBx);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopBarPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(109)))), ((int)(((byte)(251)))));
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(1081, 29);
            this.TopBarPanel.TabIndex = 1;
            // 
            // Userlbl
            // 
            this.Userlbl.AutoSize = true;
            this.Userlbl.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.Userlbl.Location = new System.Drawing.Point(3, 2);
            this.Userlbl.Name = "Userlbl";
            this.Userlbl.Size = new System.Drawing.Size(230, 23);
            this.Userlbl.TabIndex = 0;
            this.Userlbl.Text = "Generate Project Quotation";
            // 
            // MinimisePicBx
            // 
            this.MinimisePicBx.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimisePicBx.Image = global::Insight_Prototype_.Properties.Resources.Minus_100px;
            this.MinimisePicBx.Location = new System.Drawing.Point(1025, 0);
            this.MinimisePicBx.Name = "MinimisePicBx";
            this.MinimisePicBx.Size = new System.Drawing.Size(28, 29);
            this.MinimisePicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimisePicBx.TabIndex = 1;
            this.MinimisePicBx.TabStop = false;
            this.MinimisePicBx.Click += new System.EventHandler(this.MinimisePicBx_Click);
            // 
            // ClosePicBx
            // 
            this.ClosePicBx.Dock = System.Windows.Forms.DockStyle.Right;
            this.ClosePicBx.Image = global::Insight_Prototype_.Properties.Resources.Cancel_100px2;
            this.ClosePicBx.Location = new System.Drawing.Point(1053, 0);
            this.ClosePicBx.Name = "ClosePicBx";
            this.ClosePicBx.Size = new System.Drawing.Size(28, 29);
            this.ClosePicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClosePicBx.TabIndex = 0;
            this.ClosePicBx.TabStop = false;
            this.ClosePicBx.Click += new System.EventHandler(this.ClosePicBx_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1081, 534);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button78);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1073, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quote Content";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(415, 462);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(903, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 27);
            this.button1.TabIndex = 11;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button78
            // 
            this.button78.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button78.Location = new System.Drawing.Point(757, 462);
            this.button78.Name = "button78";
            this.button78.Size = new System.Drawing.Size(140, 27);
            this.button78.TabIndex = 10;
            this.button78.Text = "Cancel";
            this.button78.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvJobType);
            this.groupBox2.Location = new System.Drawing.Point(549, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 419);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Job Types";
            // 
            // dgvJobType
            // 
            this.dgvJobType.BackgroundColor = System.Drawing.Color.White;
            this.dgvJobType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobType,
            this.Rate});
            this.dgvJobType.Location = new System.Drawing.Point(6, 19);
            this.dgvJobType.Name = "dgvJobType";
            this.dgvJobType.Size = new System.Drawing.Size(482, 394);
            this.dgvJobType.TabIndex = 4;
            this.dgvJobType.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJobType_CellValueChanged);
            this.dgvJobType.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvJobType_EditingControlShowing);
            // 
            // jobTypeBindingSource
            // 
            this.jobTypeBindingSource.DataMember = "JobType";
            this.jobTypeBindingSource.DataSource = this.insightDataSet;
            // 
            // insightDataSet
            // 
            this.insightDataSet.DataSetName = "InsightDataSet";
            this.insightDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProduct);
            this.groupBox1.Location = new System.Drawing.Point(28, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 419);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            // 
            // dgvProduct
            // 
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductType,
            this.Product,
            this.Quantity});
            this.dgvProduct.Location = new System.Drawing.Point(6, 19);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(480, 394);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // ProductType
            // 
            this.ProductType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductType.DataSource = this.productTypeBindingSource;
            this.ProductType.DisplayMember = "ProductTypeDescription";
            this.ProductType.HeaderText = "ProductType";
            this.ProductType.Name = "ProductType";
            this.ProductType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProductType.ValueMember = "ProductTypeDescription";
            // 
            // productTypeBindingSource
            // 
            this.productTypeBindingSource.DataMember = "ProductType";
            this.productTypeBindingSource.DataSource = this.insightDataSet;
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product.DataSource = this.fKProductProductTypeBindingSource;
            this.Product.DisplayMember = "ProductDescription";
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Product.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Product.ValueMember = "ProductDescription";
            // 
            // fKProductProductTypeBindingSource
            // 
            this.fKProductProductTypeBindingSource.DataMember = "FK_Product_ProductType";
            this.fKProductProductTypeBindingSource.DataSource = this.productTypeBindingSource;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1073, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Confirmation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(904, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 27);
            this.button2.TabIndex = 15;
            this.button2.Text = "Confirm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(758, 463);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 27);
            this.button3.TabIndex = 14;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvcJobType);
            this.groupBox3.Location = new System.Drawing.Point(550, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 419);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Job Types";
            // 
            // dgvcJobType
            // 
            this.dgvcJobType.BackgroundColor = System.Drawing.Color.White;
            this.dgvcJobType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcJobType.Location = new System.Drawing.Point(6, 19);
            this.dgvcJobType.Name = "dgvcJobType";
            this.dgvcJobType.ReadOnly = true;
            this.dgvcJobType.Size = new System.Drawing.Size(482, 394);
            this.dgvcJobType.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvcProduct);
            this.groupBox4.Location = new System.Drawing.Point(29, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(492, 419);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Products";
            // 
            // dgvcProduct
            // 
            this.dgvcProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvcProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcProduct.Location = new System.Drawing.Point(6, 19);
            this.dgvcProduct.Name = "dgvcProduct";
            this.dgvcProduct.ReadOnly = true;
            this.dgvcProduct.Size = new System.Drawing.Size(480, 394);
            this.dgvcProduct.TabIndex = 1;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.insightDataSet;
            // 
            // productTypeTableAdapter
            // 
            this.productTypeTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // jobTypeTableAdapter
            // 
            this.jobTypeTableAdapter.ClearBeforeFill = true;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // fKJobTypePriceJobTypeBindingSource
            // 
            this.fKJobTypePriceJobTypeBindingSource.DataMember = "FK_JobTypePrice_JobType";
            this.fKJobTypePriceJobTypeBindingSource.DataSource = this.jobTypeBindingSource;
            // 
            // jobTypePriceTableAdapter
            // 
            this.jobTypePriceTableAdapter.ClearBeforeFill = true;
            // 
            // JobType
            // 
            this.JobType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JobType.DataSource = this.jobTypeBindingSource;
            this.JobType.DisplayMember = "JobTypeDescription";
            this.JobType.HeaderText = "Job Type";
            this.JobType.Name = "JobType";
            this.JobType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.JobType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.JobType.ValueMember = "JobTypeDescription";
            // 
            // Rate
            // 
            this.Rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rate.DataPropertyName = "JobTypePriceAmount";
            this.Rate.HeaderText = "Rate/hr";
            this.Rate.Name = "Rate";
            this.Rate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // GenerateProjectQuotationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1081, 563);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.TopBarPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(109)))), ((int)(((byte)(251)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenerateProjectQuotationPage";
            this.Text = "GenerateProjectQuotationPage";
            this.Load += new System.EventHandler(this.GenerateProjectQuotationPage_Load);
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimisePicBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBx)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insightDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductProductTypeBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcJobType)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKJobTypePriceJobTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Label Userlbl;
        private System.Windows.Forms.PictureBox MinimisePicBx;
        private System.Windows.Forms.PictureBox ClosePicBx;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button78;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvJobType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvProduct;
        private InsightDataSet insightDataSet;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
        private InsightDataSetTableAdapters.ProductTypeTableAdapter productTypeTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
        private InsightDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource jobTypeBindingSource;
        private InsightDataSetTableAdapters.JobTypeTableAdapter jobTypeTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource fKProductProductTypeBindingSource;
        private InsightDataSetTableAdapters.JobTableAdapter jobTableAdapter;
        private System.Windows.Forms.BindingSource fKJobTypePriceJobTypeBindingSource;
        private InsightDataSetTableAdapters.JobTypePriceTableAdapter jobTypePriceTableAdapter;
        private System.Windows.Forms.DataGridView dgvcJobType;
        private System.Windows.Forms.DataGridView dgvcProduct;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewComboBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewComboBoxColumn JobType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
    }
}