namespace Insight_Prototype_
{
    partial class ViewProjectRequestTypePage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.insightDataSet = new Insight_Prototype_.InsightDataSet();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.VehicleTypeDgv = new System.Windows.Forms.DataGridView();
            this.label260 = new System.Windows.Forms.Label();
            this.button191 = new System.Windows.Forms.Button();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.Userlbl = new System.Windows.Forms.Label();
            this.MinimisePicBx = new System.Windows.Forms.PictureBox();
            this.ClosePicBx = new System.Windows.Forms.PictureBox();
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.ViewVehicleType = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.button192 = new System.Windows.Forms.Button();
            this.tableLayoutPanel30 = new System.Windows.Forms.TableLayoutPanel();
            this.DVTypeBtn = new System.Windows.Forms.Button();
            this.UVTypeBtn = new System.Windows.Forms.Button();
            this.projectRequestTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectRequestTypeTableAdapter = new Insight_Prototype_.InsightDataSetTableAdapters.ProjectRequestTypeTableAdapter();
            this.projectRequestTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectRequestDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.insightDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleTypeDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimisePicBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBx)).BeginInit();
            this.TopBarPanel.SuspendLayout();
            this.ViewVehicleType.SuspendLayout();
            this.panel18.SuspendLayout();
            this.tableLayoutPanel30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectRequestTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // insightDataSet
            // 
            this.insightDataSet.DataSetName = "InsightDataSet";
            this.insightDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox55
            // 
            this.textBox55.Location = new System.Drawing.Point(12, 36);
            this.textBox55.Name = "textBox55";
            this.textBox55.Size = new System.Drawing.Size(265, 27);
            this.textBox55.TabIndex = 1;
            // 
            // VehicleTypeDgv
            // 
            this.VehicleTypeDgv.AllowUserToAddRows = false;
            this.VehicleTypeDgv.AllowUserToDeleteRows = false;
            this.VehicleTypeDgv.AutoGenerateColumns = false;
            this.VehicleTypeDgv.BackgroundColor = System.Drawing.Color.White;
            this.VehicleTypeDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehicleTypeDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectRequestTypeIDDataGridViewTextBoxColumn,
            this.projectRequestDescriptionDataGridViewTextBoxColumn});
            this.VehicleTypeDgv.DataSource = this.projectRequestTypeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(109)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VehicleTypeDgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.VehicleTypeDgv.Location = new System.Drawing.Point(12, 76);
            this.VehicleTypeDgv.Name = "VehicleTypeDgv";
            this.VehicleTypeDgv.Size = new System.Drawing.Size(885, 585);
            this.VehicleTypeDgv.TabIndex = 0;
            this.VehicleTypeDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VehicleTypeDgv_CellContentClick);
            // 
            // label260
            // 
            this.label260.AutoSize = true;
            this.label260.Location = new System.Drawing.Point(15, 14);
            this.label260.Name = "label260";
            this.label260.Size = new System.Drawing.Size(52, 19);
            this.label260.TabIndex = 4;
            this.label260.Text = "Search";
            // 
            // button191
            // 
            this.button191.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button191.Location = new System.Drawing.Point(297, 36);
            this.button191.Name = "button191";
            this.button191.Size = new System.Drawing.Size(140, 27);
            this.button191.TabIndex = 3;
            this.button191.Text = "Search";
            this.button191.UseVisualStyleBackColor = true;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox14.Image = global::Insight_Prototype_.Properties.Resources.Minus_100px;
            this.pictureBox14.Location = new System.Drawing.Point(983, 0);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(28, 30);
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
            this.Userlbl.Size = new System.Drawing.Size(222, 23);
            this.Userlbl.TabIndex = 0;
            this.Userlbl.Text = "View Project Request Type";
            // 
            // MinimisePicBx
            // 
            this.MinimisePicBx.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimisePicBx.Image = global::Insight_Prototype_.Properties.Resources.Minus_100px;
            this.MinimisePicBx.Location = new System.Drawing.Point(1011, 0);
            this.MinimisePicBx.Name = "MinimisePicBx";
            this.MinimisePicBx.Size = new System.Drawing.Size(28, 30);
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
            this.ClosePicBx.Size = new System.Drawing.Size(28, 30);
            this.ClosePicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClosePicBx.TabIndex = 0;
            this.ClosePicBx.TabStop = false;
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
            this.TopBarPanel.Size = new System.Drawing.Size(1067, 30);
            this.TopBarPanel.TabIndex = 51;
            // 
            // ViewVehicleType
            // 
            this.ViewVehicleType.BackColor = System.Drawing.Color.White;
            this.ViewVehicleType.Controls.Add(this.label260);
            this.ViewVehicleType.Controls.Add(this.button191);
            this.ViewVehicleType.Controls.Add(this.textBox55);
            this.ViewVehicleType.Controls.Add(this.VehicleTypeDgv);
            this.ViewVehicleType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewVehicleType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(109)))), ((int)(((byte)(251)))));
            this.ViewVehicleType.Location = new System.Drawing.Point(0, 0);
            this.ViewVehicleType.Name = "ViewVehicleType";
            this.ViewVehicleType.Size = new System.Drawing.Size(1067, 628);
            this.ViewVehicleType.TabIndex = 52;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel18.Controls.Add(this.button192);
            this.panel18.Controls.Add(this.tableLayoutPanel30);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(109)))), ((int)(((byte)(251)))));
            this.panel18.Location = new System.Drawing.Point(923, 30);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(144, 598);
            this.panel18.TabIndex = 56;
            // 
            // button192
            // 
            this.button192.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button192.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button192.Location = new System.Drawing.Point(0, 539);
            this.button192.Name = "button192";
            this.button192.Size = new System.Drawing.Size(144, 59);
            this.button192.TabIndex = 3;
            this.button192.Text = "Back";
            this.button192.UseVisualStyleBackColor = true;
            this.button192.Click += new System.EventHandler(this.button192_Click);
            // 
            // tableLayoutPanel30
            // 
            this.tableLayoutPanel30.ColumnCount = 1;
            this.tableLayoutPanel30.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel30.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel30.Controls.Add(this.DVTypeBtn, 0, 0);
            this.tableLayoutPanel30.Controls.Add(this.UVTypeBtn, 0, 1);
            this.tableLayoutPanel30.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel30.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel30.Name = "tableLayoutPanel30";
            this.tableLayoutPanel30.RowCount = 4;
            this.tableLayoutPanel30.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel30.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel30.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel30.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel30.Size = new System.Drawing.Size(144, 264);
            this.tableLayoutPanel30.TabIndex = 0;
            // 
            // DVTypeBtn
            // 
            this.DVTypeBtn.Enabled = false;
            this.DVTypeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DVTypeBtn.Location = new System.Drawing.Point(3, 3);
            this.DVTypeBtn.Name = "DVTypeBtn";
            this.DVTypeBtn.Size = new System.Drawing.Size(138, 56);
            this.DVTypeBtn.TabIndex = 0;
            this.DVTypeBtn.Text = "Delete Project Request Type";
            this.DVTypeBtn.UseVisualStyleBackColor = true;
            this.DVTypeBtn.Click += new System.EventHandler(this.DVTypeBtn_Click);
            // 
            // UVTypeBtn
            // 
            this.UVTypeBtn.Enabled = false;
            this.UVTypeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UVTypeBtn.Location = new System.Drawing.Point(3, 65);
            this.UVTypeBtn.Name = "UVTypeBtn";
            this.UVTypeBtn.Size = new System.Drawing.Size(138, 56);
            this.UVTypeBtn.TabIndex = 2;
            this.UVTypeBtn.Text = "Update Project Request Type";
            this.UVTypeBtn.UseVisualStyleBackColor = true;
            this.UVTypeBtn.Click += new System.EventHandler(this.UVTypeBtn_Click);
            // 
            // projectRequestTypeBindingSource
            // 
            this.projectRequestTypeBindingSource.DataMember = "ProjectRequestType";
            this.projectRequestTypeBindingSource.DataSource = this.insightDataSet;
            // 
            // projectRequestTypeTableAdapter
            // 
            this.projectRequestTypeTableAdapter.ClearBeforeFill = true;
            // 
            // projectRequestTypeIDDataGridViewTextBoxColumn
            // 
            this.projectRequestTypeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.projectRequestTypeIDDataGridViewTextBoxColumn.DataPropertyName = "ProjectRequestTypeID";
            this.projectRequestTypeIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.projectRequestTypeIDDataGridViewTextBoxColumn.Name = "projectRequestTypeIDDataGridViewTextBoxColumn";
            this.projectRequestTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.projectRequestTypeIDDataGridViewTextBoxColumn.Width = 48;
            // 
            // projectRequestDescriptionDataGridViewTextBoxColumn
            // 
            this.projectRequestDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.projectRequestDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProjectRequestDescription";
            this.projectRequestDescriptionDataGridViewTextBoxColumn.HeaderText = "ProjectRequestDescription";
            this.projectRequestDescriptionDataGridViewTextBoxColumn.Name = "projectRequestDescriptionDataGridViewTextBoxColumn";
            // 
            // ViewProjectRequestTypePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 628);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.TopBarPanel);
            this.Controls.Add(this.ViewVehicleType);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewProjectRequestTypePage";
            this.Text = "ViewProjectRequestType";
            this.Load += new System.EventHandler(this.ViewProjectRequestTypePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.insightDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleTypeDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimisePicBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBx)).EndInit();
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            this.ViewVehicleType.ResumeLayout(false);
            this.ViewVehicleType.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.tableLayoutPanel30.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectRequestTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private InsightDataSet insightDataSet;
        private System.Windows.Forms.TextBox textBox55;
        private System.Windows.Forms.DataGridView VehicleTypeDgv;
        private System.Windows.Forms.Label label260;
        private System.Windows.Forms.Button button191;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.Label Userlbl;
        private System.Windows.Forms.PictureBox MinimisePicBx;
        private System.Windows.Forms.PictureBox ClosePicBx;
        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Panel ViewVehicleType;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button button192;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel30;
        private System.Windows.Forms.Button DVTypeBtn;
        private System.Windows.Forms.Button UVTypeBtn;
        private System.Windows.Forms.BindingSource projectRequestTypeBindingSource;
        private InsightDataSetTableAdapters.ProjectRequestTypeTableAdapter projectRequestTypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectRequestTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectRequestDescriptionDataGridViewTextBoxColumn;
    }
}