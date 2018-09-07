namespace Insight_Prototype_
{
    partial class UpdateVehicleStatusPage
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
            this.UpdateVehicleStatusTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.VStatusLbl = new System.Windows.Forms.Label();
            this.UVSCancelBtn = new System.Windows.Forms.Button();
            this.UVSNextBtn = new System.Windows.Forms.Button();
            this.label58 = new System.Windows.Forms.Label();
            this.VStatusCmb = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CVStatusLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UVSBackBtn = new System.Windows.Forms.Button();
            this.UVSConfirmBtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label99 = new System.Windows.Forms.Label();
            this.insightDataSet = new Insight_Prototype_.InsightDataSet();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleTableAdapter = new Insight_Prototype_.InsightDataSetTableAdapters.VehicleTableAdapter();
            this.vehicleStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleStatusTableAdapter = new Insight_Prototype_.InsightDataSetTableAdapters.VehicleStatusTableAdapter();
            this.TopBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimisePicBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBx)).BeginInit();
            this.UpdateVehicleStatusTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insightDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleStatusBindingSource)).BeginInit();
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
            this.TopBarPanel.Size = new System.Drawing.Size(460, 29);
            this.TopBarPanel.TabIndex = 1;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox14.Image = global::Insight_Prototype_.Properties.Resources.Minus_100px;
            this.pictureBox14.Location = new System.Drawing.Point(376, 0);
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
            this.Userlbl.Size = new System.Drawing.Size(184, 23);
            this.Userlbl.TabIndex = 0;
            this.Userlbl.Text = "Update Vehicle Status";
            // 
            // MinimisePicBx
            // 
            this.MinimisePicBx.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimisePicBx.Image = global::Insight_Prototype_.Properties.Resources.Minus_100px;
            this.MinimisePicBx.Location = new System.Drawing.Point(404, 0);
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
            this.ClosePicBx.Location = new System.Drawing.Point(432, 0);
            this.ClosePicBx.Name = "ClosePicBx";
            this.ClosePicBx.Size = new System.Drawing.Size(28, 29);
            this.ClosePicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClosePicBx.TabIndex = 0;
            this.ClosePicBx.TabStop = false;
            // 
            // UpdateVehicleStatusTab
            // 
            this.UpdateVehicleStatusTab.Controls.Add(this.tabPage1);
            this.UpdateVehicleStatusTab.Controls.Add(this.tabPage2);
            this.UpdateVehicleStatusTab.Controls.Add(this.tabPage3);
            this.UpdateVehicleStatusTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateVehicleStatusTab.Location = new System.Drawing.Point(0, 29);
            this.UpdateVehicleStatusTab.Name = "UpdateVehicleStatusTab";
            this.UpdateVehicleStatusTab.SelectedIndex = 0;
            this.UpdateVehicleStatusTab.Size = new System.Drawing.Size(460, 171);
            this.UpdateVehicleStatusTab.TabIndex = 83;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.VStatusLbl);
            this.tabPage1.Controls.Add(this.UVSCancelBtn);
            this.tabPage1.Controls.Add(this.UVSNextBtn);
            this.tabPage1.Controls.Add(this.label58);
            this.tabPage1.Controls.Add(this.VStatusCmb);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(452, 139);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Details";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(380, 57);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(34, 19);
            this.linkLabel1.TabIndex = 35;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Edit";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // VStatusLbl
            // 
            this.VStatusLbl.AutoSize = true;
            this.VStatusLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VStatusLbl.Location = new System.Drawing.Point(154, 30);
            this.VStatusLbl.Name = "VStatusLbl";
            this.VStatusLbl.Size = new System.Drawing.Size(69, 19);
            this.VStatusLbl.TabIndex = 33;
            this.VStatusLbl.Text = "Available";
            // 
            // UVSCancelBtn
            // 
            this.UVSCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UVSCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UVSCancelBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UVSCancelBtn.Location = new System.Drawing.Point(288, 101);
            this.UVSCancelBtn.Name = "UVSCancelBtn";
            this.UVSCancelBtn.Size = new System.Drawing.Size(75, 30);
            this.UVSCancelBtn.TabIndex = 31;
            this.UVSCancelBtn.Text = "Cancel";
            this.UVSCancelBtn.UseVisualStyleBackColor = true;
            this.UVSCancelBtn.Click += new System.EventHandler(this.UVSCancelBtn_Click);
            // 
            // UVSNextBtn
            // 
            this.UVSNextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UVSNextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UVSNextBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UVSNextBtn.Location = new System.Drawing.Point(369, 101);
            this.UVSNextBtn.Name = "UVSNextBtn";
            this.UVSNextBtn.Size = new System.Drawing.Size(75, 30);
            this.UVSNextBtn.TabIndex = 30;
            this.UVSNextBtn.Text = "Next";
            this.UVSNextBtn.UseVisualStyleBackColor = true;
            this.UVSNextBtn.Click += new System.EventHandler(this.UVSNextBtn_Click);
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(31, 30);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(53, 19);
            this.label58.TabIndex = 7;
            this.label58.Text = "Status:";
            // 
            // VStatusCmb
            // 
            this.VStatusCmb.DataSource = this.vehicleStatusBindingSource;
            this.VStatusCmb.DisplayMember = "VehicleStatusDescription";
            this.VStatusCmb.FormattingEnabled = true;
            this.VStatusCmb.Location = new System.Drawing.Point(157, 27);
            this.VStatusCmb.Name = "VStatusCmb";
            this.VStatusCmb.Size = new System.Drawing.Size(245, 27);
            this.VStatusCmb.TabIndex = 36;
            this.VStatusCmb.ValueMember = "VehicleStatusID";
            this.VStatusCmb.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.CVStatusLbl);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.UVSBackBtn);
            this.tabPage2.Controls.Add(this.UVSConfirmBtn);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(452, 139);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Confirmation";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // CVStatusLbl
            // 
            this.CVStatusLbl.AutoSize = true;
            this.CVStatusLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CVStatusLbl.Location = new System.Drawing.Point(178, 43);
            this.CVStatusLbl.Name = "CVStatusLbl";
            this.CVStatusLbl.Size = new System.Drawing.Size(69, 19);
            this.CVStatusLbl.TabIndex = 42;
            this.CVStatusLbl.Text = "Available";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 41;
            this.label5.Text = "Status:";
            // 
            // UVSBackBtn
            // 
            this.UVSBackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UVSBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UVSBackBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UVSBackBtn.Location = new System.Drawing.Point(288, 101);
            this.UVSBackBtn.Name = "UVSBackBtn";
            this.UVSBackBtn.Size = new System.Drawing.Size(75, 30);
            this.UVSBackBtn.TabIndex = 37;
            this.UVSBackBtn.Text = "Back";
            this.UVSBackBtn.UseVisualStyleBackColor = true;
            this.UVSBackBtn.Click += new System.EventHandler(this.UVSBackBtn_Click);
            // 
            // UVSConfirmBtn
            // 
            this.UVSConfirmBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UVSConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UVSConfirmBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UVSConfirmBtn.Location = new System.Drawing.Point(369, 101);
            this.UVSConfirmBtn.Name = "UVSConfirmBtn";
            this.UVSConfirmBtn.Size = new System.Drawing.Size(75, 30);
            this.UVSConfirmBtn.TabIndex = 36;
            this.UVSConfirmBtn.Text = "Confirm";
            this.UVSConfirmBtn.UseVisualStyleBackColor = true;
            this.UVSConfirmBtn.Click += new System.EventHandler(this.UVSConfirmBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.label99);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(452, 139);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Complete";
            // 
            // label99
            // 
            this.label99.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Calibri", 20F);
            this.label99.Location = new System.Drawing.Point(26, 53);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(401, 33);
            this.label99.TabIndex = 1;
            this.label99.Text = "Vehicle Status Successfully Updated";
            // 
            // insightDataSet
            // 
            this.insightDataSet.DataSetName = "InsightDataSet";
            this.insightDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "Vehicle";
            this.vehicleBindingSource.DataSource = this.insightDataSet;
            // 
            // vehicleTableAdapter
            // 
            this.vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // vehicleStatusBindingSource
            // 
            this.vehicleStatusBindingSource.DataMember = "VehicleStatus";
            this.vehicleStatusBindingSource.DataSource = this.insightDataSet;
            // 
            // vehicleStatusTableAdapter
            // 
            this.vehicleStatusTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateVehicleStatusPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 200);
            this.Controls.Add(this.UpdateVehicleStatusTab);
            this.Controls.Add(this.TopBarPanel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateVehicleStatusPage";
            this.Text = "UpdateVehicleStatusPage";
            this.Load += new System.EventHandler(this.UpdateVehicleStatusPage_Load);
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimisePicBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBx)).EndInit();
            this.UpdateVehicleStatusTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insightDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleStatusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.Label Userlbl;
        private System.Windows.Forms.PictureBox MinimisePicBx;
        private System.Windows.Forms.PictureBox ClosePicBx;
        private System.Windows.Forms.TabControl UpdateVehicleStatusTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button UVSCancelBtn;
        private System.Windows.Forms.Button UVSNextBtn;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button UVSBackBtn;
        private System.Windows.Forms.Button UVSConfirmBtn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label VStatusLbl;
        private System.Windows.Forms.ComboBox VStatusCmb;
        private System.Windows.Forms.Label CVStatusLbl;
        private System.Windows.Forms.Label label5;
        private InsightDataSet insightDataSet;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private InsightDataSetTableAdapters.VehicleTableAdapter vehicleTableAdapter;
        private System.Windows.Forms.BindingSource vehicleStatusBindingSource;
        private InsightDataSetTableAdapters.VehicleStatusTableAdapter vehicleStatusTableAdapter;
    }
}