namespace Insight_Prototype_
{
    partial class ViewEquipmentPage
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
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.Userlbl = new System.Windows.Forms.Label();
            this.MinimisePicBx = new System.Windows.Forms.PictureBox();
            this.ClosePicBx = new System.Windows.Forms.PictureBox();
            this.ViewEquipmentPanel = new System.Windows.Forms.Panel();
            this.label76 = new System.Windows.Forms.Label();
            this.button102 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button103 = new System.Windows.Forms.Button();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.button104 = new System.Windows.Forms.Button();
            this.button105 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button106 = new System.Windows.Forms.Button();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.EQDgv = new System.Windows.Forms.DataGridView();
            this.insightDataSet = new Insight_Prototype_.InsightDataSet();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentTableAdapter = new Insight_Prototype_.InsightDataSetTableAdapters.EquipmentTableAdapter();
            this.equipmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimisePicBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBx)).BeginInit();
            this.ViewEquipmentPanel.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EQDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insightDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.TopBarPanel.Controls.Add(this.pictureBox14);
            this.TopBarPanel.Controls.Add(this.Userlbl);
            this.TopBarPanel.Controls.Add(this.MinimisePicBx);
            this.TopBarPanel.Controls.Add(this.ClosePicBx);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopBarPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(109)))), ((int)(((byte)(251)))));
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(1067, 29);
            this.TopBarPanel.TabIndex = 22;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox14.Image = global::Insight_Prototype_.Properties.Resources.Minus_100px;
            this.pictureBox14.Location = new System.Drawing.Point(983, 0);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(28, 29);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 2;
            this.pictureBox14.TabStop = false;
            // 
            // Userlbl
            // 
            this.Userlbl.AutoSize = true;
            this.Userlbl.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.Userlbl.Location = new System.Drawing.Point(3, 2);
            this.Userlbl.Name = "Userlbl";
            this.Userlbl.Size = new System.Drawing.Size(140, 23);
            this.Userlbl.TabIndex = 0;
            this.Userlbl.Text = "View Equipment";
            // 
            // MinimisePicBx
            // 
            this.MinimisePicBx.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimisePicBx.Image = global::Insight_Prototype_.Properties.Resources.Minus_100px;
            this.MinimisePicBx.Location = new System.Drawing.Point(1011, 0);
            this.MinimisePicBx.Name = "MinimisePicBx";
            this.MinimisePicBx.Size = new System.Drawing.Size(28, 29);
            this.MinimisePicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimisePicBx.TabIndex = 1;
            this.MinimisePicBx.TabStop = false;
            // 
            // ClosePicBx
            // 
            this.ClosePicBx.Dock = System.Windows.Forms.DockStyle.Right;
            this.ClosePicBx.Image = global::Insight_Prototype_.Properties.Resources.Cancel_100px2;
            this.ClosePicBx.Location = new System.Drawing.Point(1039, 0);
            this.ClosePicBx.Name = "ClosePicBx";
            this.ClosePicBx.Size = new System.Drawing.Size(28, 29);
            this.ClosePicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClosePicBx.TabIndex = 0;
            this.ClosePicBx.TabStop = false;
            // 
            // ViewEquipmentPanel
            // 
            this.ViewEquipmentPanel.Controls.Add(this.label76);
            this.ViewEquipmentPanel.Controls.Add(this.button102);
            this.ViewEquipmentPanel.Controls.Add(this.panel9);
            this.ViewEquipmentPanel.Controls.Add(this.textBox20);
            this.ViewEquipmentPanel.Controls.Add(this.EQDgv);
            this.ViewEquipmentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewEquipmentPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(109)))), ((int)(((byte)(251)))));
            this.ViewEquipmentPanel.Location = new System.Drawing.Point(0, 29);
            this.ViewEquipmentPanel.Name = "ViewEquipmentPanel";
            this.ViewEquipmentPanel.Size = new System.Drawing.Size(1067, 629);
            this.ViewEquipmentPanel.TabIndex = 23;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(15, 14);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(52, 19);
            this.label76.TabIndex = 4;
            this.label76.Text = "Search";
            // 
            // button102
            // 
            this.button102.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button102.Location = new System.Drawing.Point(297, 36);
            this.button102.Name = "button102";
            this.button102.Size = new System.Drawing.Size(140, 27);
            this.button102.TabIndex = 3;
            this.button102.Text = "Search";
            this.button102.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel9.Controls.Add(this.button103);
            this.panel9.Controls.Add(this.tableLayoutPanel17);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(923, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(144, 629);
            this.panel9.TabIndex = 2;
            // 
            // button103
            // 
            this.button103.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button103.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button103.Location = new System.Drawing.Point(0, 570);
            this.button103.Name = "button103";
            this.button103.Size = new System.Drawing.Size(144, 59);
            this.button103.TabIndex = 3;
            this.button103.Text = "Back";
            this.button103.UseVisualStyleBackColor = true;
            this.button103.Click += new System.EventHandler(this.button103_Click);
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 1;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.Controls.Add(this.button104, 0, 1);
            this.tableLayoutPanel17.Controls.Add(this.button105, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel17.Controls.Add(this.button106, 0, 3);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 6;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(144, 386);
            this.tableLayoutPanel17.TabIndex = 0;
            // 
            // button104
            // 
            this.button104.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button104.Location = new System.Drawing.Point(3, 67);
            this.button104.Name = "button104";
            this.button104.Size = new System.Drawing.Size(138, 56);
            this.button104.TabIndex = 1;
            this.button104.Text = "Delete Equipment";
            this.button104.UseVisualStyleBackColor = true;
            this.button104.Click += new System.EventHandler(this.button104_Click);
            // 
            // button105
            // 
            this.button105.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button105.Location = new System.Drawing.Point(3, 3);
            this.button105.Name = "button105";
            this.button105.Size = new System.Drawing.Size(138, 56);
            this.button105.TabIndex = 0;
            this.button105.Text = "Update Equipment";
            this.button105.UseVisualStyleBackColor = true;
            this.button105.Click += new System.EventHandler(this.button105_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "Remove Equipment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button106
            // 
            this.button106.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button106.Location = new System.Drawing.Point(3, 195);
            this.button106.Name = "button106";
            this.button106.Size = new System.Drawing.Size(138, 56);
            this.button106.TabIndex = 2;
            this.button106.Text = "Assign Equipment";
            this.button106.UseVisualStyleBackColor = true;
            this.button106.Click += new System.EventHandler(this.button106_Click);
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(12, 36);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(265, 27);
            this.textBox20.TabIndex = 1;
            // 
            // EQDgv
            // 
            this.EQDgv.AutoGenerateColumns = false;
            this.EQDgv.BackgroundColor = System.Drawing.Color.White;
            this.EQDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EQDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipmentIDDataGridViewTextBoxColumn,
            this.equipmentDescriptionDataGridViewTextBoxColumn,
            this.equipmentQuantityDataGridViewTextBoxColumn,
            this.equipmentTypeIDDataGridViewTextBoxColumn});
            this.EQDgv.DataSource = this.equipmentBindingSource;
            this.EQDgv.Location = new System.Drawing.Point(12, 75);
            this.EQDgv.Name = "EQDgv";
            this.EQDgv.Size = new System.Drawing.Size(885, 585);
            this.EQDgv.TabIndex = 0;
            this.EQDgv.SelectionChanged += new System.EventHandler(this.EQDgv_SelectionChanged);
            // 
            // insightDataSet
            // 
            this.insightDataSet.DataSetName = "InsightDataSet";
            this.insightDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataMember = "Equipment";
            this.equipmentBindingSource.DataSource = this.insightDataSet;
            // 
            // equipmentTableAdapter
            // 
            this.equipmentTableAdapter.ClearBeforeFill = true;
            // 
            // equipmentIDDataGridViewTextBoxColumn
            // 
            this.equipmentIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.equipmentIDDataGridViewTextBoxColumn.DataPropertyName = "EquipmentID";
            this.equipmentIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.equipmentIDDataGridViewTextBoxColumn.Name = "equipmentIDDataGridViewTextBoxColumn";
            this.equipmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.equipmentIDDataGridViewTextBoxColumn.Width = 48;
            // 
            // equipmentDescriptionDataGridViewTextBoxColumn
            // 
            this.equipmentDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.equipmentDescriptionDataGridViewTextBoxColumn.DataPropertyName = "EquipmentDescription";
            this.equipmentDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.equipmentDescriptionDataGridViewTextBoxColumn.Name = "equipmentDescriptionDataGridViewTextBoxColumn";
            // 
            // equipmentQuantityDataGridViewTextBoxColumn
            // 
            this.equipmentQuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.equipmentQuantityDataGridViewTextBoxColumn.DataPropertyName = "EquipmentQuantity";
            this.equipmentQuantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.equipmentQuantityDataGridViewTextBoxColumn.Name = "equipmentQuantityDataGridViewTextBoxColumn";
            this.equipmentQuantityDataGridViewTextBoxColumn.Width = 90;
            // 
            // equipmentTypeIDDataGridViewTextBoxColumn
            // 
            this.equipmentTypeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.equipmentTypeIDDataGridViewTextBoxColumn.DataPropertyName = "EquipmentTypeID";
            this.equipmentTypeIDDataGridViewTextBoxColumn.HeaderText = "TypeID";
            this.equipmentTypeIDDataGridViewTextBoxColumn.Name = "equipmentTypeIDDataGridViewTextBoxColumn";
            this.equipmentTypeIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // ViewEquipmentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(this.ViewEquipmentPanel);
            this.Controls.Add(this.TopBarPanel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewEquipmentPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewEquipmentPage";
            this.Load += new System.EventHandler(this.ViewEquipmentPage_Load);
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimisePicBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBx)).EndInit();
            this.ViewEquipmentPanel.ResumeLayout(false);
            this.ViewEquipmentPanel.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EQDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insightDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.Label Userlbl;
        private System.Windows.Forms.PictureBox MinimisePicBx;
        private System.Windows.Forms.PictureBox ClosePicBx;
        private System.Windows.Forms.Panel ViewEquipmentPanel;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Button button102;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button103;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.Button button104;
        private System.Windows.Forms.Button button105;
        private System.Windows.Forms.Button button106;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.DataGridView EQDgv;
        private System.Windows.Forms.Button button1;
        private InsightDataSet insightDataSet;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private InsightDataSetTableAdapters.EquipmentTableAdapter equipmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentTypeIDDataGridViewTextBoxColumn;
    }
}