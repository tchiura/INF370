namespace Insight_Prototype_
{
    partial class AddEquipmentPage
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
            this.insightDataSet = new Insight_Prototype_.InsightDataSet();
            this.insightDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentTypeTableAdapter = new Insight_Prototype_.InsightDataSetTableAdapters.EquipmentTypeTableAdapter();
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.Userlbl = new System.Windows.Forms.Label();
            this.MinimisePicBx = new System.Windows.Forms.PictureBox();
            this.ClosePicBx = new System.Windows.Forms.PictureBox();
            this.AddEquipmentTab = new System.Windows.Forms.TabControl();
            this.tabPage29 = new System.Windows.Forms.TabPage();
            this.label233 = new System.Windows.Forms.Label();
            this.AEqConditionCmb = new System.Windows.Forms.ComboBox();
            this.AEqQuantityUD = new System.Windows.Forms.NumericUpDown();
            this.AEqCancelBtn = new System.Windows.Forms.Button();
            this.AEqNextBtn = new System.Windows.Forms.Button();
            this.label217 = new System.Windows.Forms.Label();
            this.label220 = new System.Windows.Forms.Label();
            this.label222 = new System.Windows.Forms.Label();
            this.AEqTypeCmb = new System.Windows.Forms.ComboBox();
            this.AEqDecripTb = new System.Windows.Forms.TextBox();
            this.tabPage30 = new System.Windows.Forms.TabPage();
            this.AEqQuantityLbl = new System.Windows.Forms.Label();
            this.label234 = new System.Windows.Forms.Label();
            this.label235 = new System.Windows.Forms.Label();
            this.label239 = new System.Windows.Forms.Label();
            this.label240 = new System.Windows.Forms.Label();
            this.label226 = new System.Windows.Forms.Label();
            this.label227 = new System.Windows.Forms.Label();
            this.label228 = new System.Windows.Forms.Label();
            this.AEqBackBtn = new System.Windows.Forms.Button();
            this.AEqConfirmBtn = new System.Windows.Forms.Button();
            this.AEqDescripLbl = new System.Windows.Forms.Label();
            this.AEqTypeLbl = new System.Windows.Forms.Label();
            this.AEqConditionLbl = new System.Windows.Forms.Label();
            this.tabPage31 = new System.Windows.Forms.TabPage();
            this.label232 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.insightDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insightDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTypeBindingSource)).BeginInit();
            this.TopBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimisePicBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBx)).BeginInit();
            this.AddEquipmentTab.SuspendLayout();
            this.tabPage29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AEqQuantityUD)).BeginInit();
            this.tabPage30.SuspendLayout();
            this.tabPage31.SuspendLayout();
            this.SuspendLayout();
            // 
            // insightDataSet
            // 
            this.insightDataSet.DataSetName = "InsightDataSet";
            this.insightDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // insightDataSetBindingSource
            // 
            this.insightDataSetBindingSource.DataSource = this.insightDataSet;
            this.insightDataSetBindingSource.Position = 0;
            // 
            // equipmentTypeBindingSource
            // 
            this.equipmentTypeBindingSource.DataMember = "EquipmentType";
            this.equipmentTypeBindingSource.DataSource = this.insightDataSetBindingSource;
            // 
            // equipmentTypeTableAdapter
            // 
            this.equipmentTypeTableAdapter.ClearBeforeFill = true;
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
            this.TopBarPanel.Size = new System.Drawing.Size(490, 30);
            this.TopBarPanel.TabIndex = 47;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox14.Image = global::Insight_Prototype_.Properties.Resources.Minus_100px;
            this.pictureBox14.Location = new System.Drawing.Point(406, 0);
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
            this.Userlbl.Size = new System.Drawing.Size(132, 23);
            this.Userlbl.TabIndex = 0;
            this.Userlbl.Text = "Add Equipment";
            // 
            // MinimisePicBx
            // 
            this.MinimisePicBx.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimisePicBx.Image = global::Insight_Prototype_.Properties.Resources.Minus_100px;
            this.MinimisePicBx.Location = new System.Drawing.Point(434, 0);
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
            this.ClosePicBx.Location = new System.Drawing.Point(462, 0);
            this.ClosePicBx.Name = "ClosePicBx";
            this.ClosePicBx.Size = new System.Drawing.Size(28, 30);
            this.ClosePicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClosePicBx.TabIndex = 0;
            this.ClosePicBx.TabStop = false;
            // 
            // AddEquipmentTab
            // 
            this.AddEquipmentTab.Controls.Add(this.tabPage29);
            this.AddEquipmentTab.Controls.Add(this.tabPage30);
            this.AddEquipmentTab.Controls.Add(this.tabPage31);
            this.AddEquipmentTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddEquipmentTab.Location = new System.Drawing.Point(0, 30);
            this.AddEquipmentTab.Name = "AddEquipmentTab";
            this.AddEquipmentTab.SelectedIndex = 0;
            this.AddEquipmentTab.Size = new System.Drawing.Size(490, 277);
            this.AddEquipmentTab.TabIndex = 48;
            // 
            // tabPage29
            // 
            this.tabPage29.BackColor = System.Drawing.Color.White;
            this.tabPage29.Controls.Add(this.label233);
            this.tabPage29.Controls.Add(this.AEqConditionCmb);
            this.tabPage29.Controls.Add(this.AEqQuantityUD);
            this.tabPage29.Controls.Add(this.AEqCancelBtn);
            this.tabPage29.Controls.Add(this.AEqNextBtn);
            this.tabPage29.Controls.Add(this.label217);
            this.tabPage29.Controls.Add(this.label220);
            this.tabPage29.Controls.Add(this.label222);
            this.tabPage29.Controls.Add(this.AEqTypeCmb);
            this.tabPage29.Controls.Add(this.AEqDecripTb);
            this.tabPage29.ForeColor = System.Drawing.Color.Black;
            this.tabPage29.Location = new System.Drawing.Point(4, 28);
            this.tabPage29.Name = "tabPage29";
            this.tabPage29.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage29.Size = new System.Drawing.Size(482, 245);
            this.tabPage29.TabIndex = 0;
            this.tabPage29.Text = "Details";
            // 
            // label233
            // 
            this.label233.AutoSize = true;
            this.label233.Location = new System.Drawing.Point(25, 120);
            this.label233.Name = "label233";
            this.label233.Size = new System.Drawing.Size(75, 19);
            this.label233.TabIndex = 34;
            this.label233.Text = "Condition:";
            // 
            // AEqConditionCmb
            // 
            this.AEqConditionCmb.FormattingEnabled = true;
            this.AEqConditionCmb.Items.AddRange(new object[] {
            "New",
            "Second Hand"});
            this.AEqConditionCmb.Location = new System.Drawing.Point(202, 117);
            this.AEqConditionCmb.Name = "AEqConditionCmb";
            this.AEqConditionCmb.Size = new System.Drawing.Size(245, 27);
            this.AEqConditionCmb.TabIndex = 35;
            // 
            // AEqQuantityUD
            // 
            this.AEqQuantityUD.Location = new System.Drawing.Point(202, 163);
            this.AEqQuantityUD.Name = "AEqQuantityUD";
            this.AEqQuantityUD.Size = new System.Drawing.Size(120, 27);
            this.AEqQuantityUD.TabIndex = 33;
            // 
            // AEqCancelBtn
            // 
            this.AEqCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AEqCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AEqCancelBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AEqCancelBtn.Location = new System.Drawing.Point(318, 207);
            this.AEqCancelBtn.Name = "AEqCancelBtn";
            this.AEqCancelBtn.Size = new System.Drawing.Size(75, 30);
            this.AEqCancelBtn.TabIndex = 31;
            this.AEqCancelBtn.Text = "Cancel";
            this.AEqCancelBtn.UseVisualStyleBackColor = true;
            this.AEqCancelBtn.Click += new System.EventHandler(this.button184_Click);
            // 
            // AEqNextBtn
            // 
            this.AEqNextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AEqNextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AEqNextBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AEqNextBtn.Location = new System.Drawing.Point(399, 207);
            this.AEqNextBtn.Name = "AEqNextBtn";
            this.AEqNextBtn.Size = new System.Drawing.Size(75, 30);
            this.AEqNextBtn.TabIndex = 30;
            this.AEqNextBtn.Text = "Next";
            this.AEqNextBtn.UseVisualStyleBackColor = true;
            this.AEqNextBtn.Click += new System.EventHandler(this.AEqNextBtn_Click);
            // 
            // label217
            // 
            this.label217.AutoSize = true;
            this.label217.Location = new System.Drawing.Point(25, 75);
            this.label217.Name = "label217";
            this.label217.Size = new System.Drawing.Size(43, 19);
            this.label217.TabIndex = 6;
            this.label217.Text = "Type:";
            // 
            // label220
            // 
            this.label220.AutoSize = true;
            this.label220.Location = new System.Drawing.Point(25, 160);
            this.label220.Name = "label220";
            this.label220.Size = new System.Drawing.Size(69, 19);
            this.label220.TabIndex = 5;
            this.label220.Text = "Quantity:";
            // 
            // label222
            // 
            this.label222.AutoSize = true;
            this.label222.Location = new System.Drawing.Point(25, 25);
            this.label222.Name = "label222";
            this.label222.Size = new System.Drawing.Size(87, 19);
            this.label222.TabIndex = 3;
            this.label222.Text = "Description:";
            // 
            // AEqTypeCmb
            // 
            this.AEqTypeCmb.DataSource = this.equipmentTypeBindingSource;
            this.AEqTypeCmb.DisplayMember = "EquipmentTypeDescription";
            this.AEqTypeCmb.FormattingEnabled = true;
            this.AEqTypeCmb.Location = new System.Drawing.Point(202, 72);
            this.AEqTypeCmb.Name = "AEqTypeCmb";
            this.AEqTypeCmb.Size = new System.Drawing.Size(245, 27);
            this.AEqTypeCmb.TabIndex = 27;
            this.AEqTypeCmb.ValueMember = "EquipmentTypeID";
            // 
            // AEqDecripTb
            // 
            this.AEqDecripTb.Location = new System.Drawing.Point(202, 22);
            this.AEqDecripTb.Name = "AEqDecripTb";
            this.AEqDecripTb.Size = new System.Drawing.Size(245, 27);
            this.AEqDecripTb.TabIndex = 32;
            // 
            // tabPage30
            // 
            this.tabPage30.BackColor = System.Drawing.Color.White;
            this.tabPage30.Controls.Add(this.AEqQuantityLbl);
            this.tabPage30.Controls.Add(this.label234);
            this.tabPage30.Controls.Add(this.label235);
            this.tabPage30.Controls.Add(this.label239);
            this.tabPage30.Controls.Add(this.label240);
            this.tabPage30.Controls.Add(this.label226);
            this.tabPage30.Controls.Add(this.label227);
            this.tabPage30.Controls.Add(this.label228);
            this.tabPage30.Controls.Add(this.AEqBackBtn);
            this.tabPage30.Controls.Add(this.AEqConfirmBtn);
            this.tabPage30.Controls.Add(this.AEqDescripLbl);
            this.tabPage30.Controls.Add(this.AEqTypeLbl);
            this.tabPage30.Controls.Add(this.AEqConditionLbl);
            this.tabPage30.ForeColor = System.Drawing.Color.Black;
            this.tabPage30.Location = new System.Drawing.Point(4, 28);
            this.tabPage30.Name = "tabPage30";
            this.tabPage30.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage30.Size = new System.Drawing.Size(482, 245);
            this.tabPage30.TabIndex = 1;
            this.tabPage30.Text = "Confirmation";
            // 
            // AEqQuantityLbl
            // 
            this.AEqQuantityLbl.AutoSize = true;
            this.AEqQuantityLbl.Location = new System.Drawing.Point(303, 150);
            this.AEqQuantityLbl.Name = "AEqQuantityLbl";
            this.AEqQuantityLbl.Size = new System.Drawing.Size(17, 19);
            this.AEqQuantityLbl.TabIndex = 63;
            this.AEqQuantityLbl.Text = "5";
            // 
            // label234
            // 
            this.label234.AutoSize = true;
            this.label234.Location = new System.Drawing.Point(31, 110);
            this.label234.Name = "label234";
            this.label234.Size = new System.Drawing.Size(75, 19);
            this.label234.TabIndex = 62;
            this.label234.Text = "Condition:";
            // 
            // label235
            // 
            this.label235.AutoSize = true;
            this.label235.Location = new System.Drawing.Point(31, 65);
            this.label235.Name = "label235";
            this.label235.Size = new System.Drawing.Size(43, 19);
            this.label235.TabIndex = 61;
            this.label235.Text = "Type:";
            // 
            // label239
            // 
            this.label239.AutoSize = true;
            this.label239.Location = new System.Drawing.Point(31, 150);
            this.label239.Name = "label239";
            this.label239.Size = new System.Drawing.Size(69, 19);
            this.label239.TabIndex = 60;
            this.label239.Text = "Quantity:";
            // 
            // label240
            // 
            this.label240.AutoSize = true;
            this.label240.Location = new System.Drawing.Point(31, 22);
            this.label240.Name = "label240";
            this.label240.Size = new System.Drawing.Size(87, 19);
            this.label240.TabIndex = 59;
            this.label240.Text = "Description:";
            // 
            // label226
            // 
            this.label226.AutoSize = true;
            this.label226.Location = new System.Drawing.Point(31, 65);
            this.label226.Name = "label226";
            this.label226.Size = new System.Drawing.Size(43, 19);
            this.label226.TabIndex = 58;
            this.label226.Text = "Type:";
            // 
            // label227
            // 
            this.label227.AutoSize = true;
            this.label227.Location = new System.Drawing.Point(31, 108);
            this.label227.Name = "label227";
            this.label227.Size = new System.Drawing.Size(69, 19);
            this.label227.TabIndex = 57;
            this.label227.Text = "Quantity:";
            // 
            // label228
            // 
            this.label228.AutoSize = true;
            this.label228.Location = new System.Drawing.Point(31, 22);
            this.label228.Name = "label228";
            this.label228.Size = new System.Drawing.Size(87, 19);
            this.label228.TabIndex = 56;
            this.label228.Text = "Description:";
            // 
            // AEqBackBtn
            // 
            this.AEqBackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AEqBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AEqBackBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AEqBackBtn.Location = new System.Drawing.Point(320, 207);
            this.AEqBackBtn.Name = "AEqBackBtn";
            this.AEqBackBtn.Size = new System.Drawing.Size(75, 30);
            this.AEqBackBtn.TabIndex = 37;
            this.AEqBackBtn.Text = "Back";
            this.AEqBackBtn.UseVisualStyleBackColor = true;
            this.AEqBackBtn.Click += new System.EventHandler(this.AEqBackBtn_Click);
            // 
            // AEqConfirmBtn
            // 
            this.AEqConfirmBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AEqConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AEqConfirmBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AEqConfirmBtn.Location = new System.Drawing.Point(401, 209);
            this.AEqConfirmBtn.Name = "AEqConfirmBtn";
            this.AEqConfirmBtn.Size = new System.Drawing.Size(75, 30);
            this.AEqConfirmBtn.TabIndex = 36;
            this.AEqConfirmBtn.Text = "Confirm";
            this.AEqConfirmBtn.UseVisualStyleBackColor = true;
            this.AEqConfirmBtn.Click += new System.EventHandler(this.AEqConfirmBtn_Click);
            // 
            // AEqDescripLbl
            // 
            this.AEqDescripLbl.AutoSize = true;
            this.AEqDescripLbl.Location = new System.Drawing.Point(303, 22);
            this.AEqDescripLbl.Name = "AEqDescripLbl";
            this.AEqDescripLbl.Size = new System.Drawing.Size(100, 19);
            this.AEqDescripLbl.TabIndex = 33;
            this.AEqDescripLbl.Text = "ClimbUp 1.5m";
            // 
            // AEqTypeLbl
            // 
            this.AEqTypeLbl.AutoSize = true;
            this.AEqTypeLbl.Location = new System.Drawing.Point(303, 65);
            this.AEqTypeLbl.Name = "AEqTypeLbl";
            this.AEqTypeLbl.Size = new System.Drawing.Size(53, 19);
            this.AEqTypeLbl.TabIndex = 32;
            this.AEqTypeLbl.Text = "Ladder";
            // 
            // AEqConditionLbl
            // 
            this.AEqConditionLbl.AutoSize = true;
            this.AEqConditionLbl.Location = new System.Drawing.Point(303, 108);
            this.AEqConditionLbl.Name = "AEqConditionLbl";
            this.AEqConditionLbl.Size = new System.Drawing.Size(38, 19);
            this.AEqConditionLbl.TabIndex = 31;
            this.AEqConditionLbl.Text = "New";
            // 
            // tabPage31
            // 
            this.tabPage31.BackColor = System.Drawing.Color.White;
            this.tabPage31.Controls.Add(this.label232);
            this.tabPage31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(109)))), ((int)(((byte)(251)))));
            this.tabPage31.Location = new System.Drawing.Point(4, 28);
            this.tabPage31.Name = "tabPage31";
            this.tabPage31.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage31.Size = new System.Drawing.Size(482, 245);
            this.tabPage31.TabIndex = 2;
            this.tabPage31.Text = "Complete";
            // 
            // label232
            // 
            this.label232.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label232.AutoSize = true;
            this.label232.Font = new System.Drawing.Font("Calibri", 20F);
            this.label232.Location = new System.Drawing.Point(68, 106);
            this.label232.Name = "label232";
            this.label232.Size = new System.Drawing.Size(346, 33);
            this.label232.TabIndex = 1;
            this.label232.Text = "Eqiupment Successfully Added";
            // 
            // AddEquipmentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 307);
            this.Controls.Add(this.AddEquipmentTab);
            this.Controls.Add(this.TopBarPanel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEquipmentPage";
            this.Text = "AddEquipmentPage";
            this.Load += new System.EventHandler(this.AddEquipmentPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.insightDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insightDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTypeBindingSource)).EndInit();
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimisePicBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBx)).EndInit();
            this.AddEquipmentTab.ResumeLayout(false);
            this.tabPage29.ResumeLayout(false);
            this.tabPage29.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AEqQuantityUD)).EndInit();
            this.tabPage30.ResumeLayout(false);
            this.tabPage30.PerformLayout();
            this.tabPage31.ResumeLayout(false);
            this.tabPage31.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource insightDataSetBindingSource;
        private InsightDataSet insightDataSet;
        private System.Windows.Forms.BindingSource equipmentTypeBindingSource;
        private InsightDataSetTableAdapters.EquipmentTypeTableAdapter equipmentTypeTableAdapter;
        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.Label Userlbl;
        private System.Windows.Forms.PictureBox MinimisePicBx;
        private System.Windows.Forms.PictureBox ClosePicBx;
        private System.Windows.Forms.TabControl AddEquipmentTab;
        private System.Windows.Forms.TabPage tabPage29;
        private System.Windows.Forms.Label label233;
        private System.Windows.Forms.ComboBox AEqConditionCmb;
        private System.Windows.Forms.NumericUpDown AEqQuantityUD;
        private System.Windows.Forms.Button AEqCancelBtn;
        private System.Windows.Forms.Button AEqNextBtn;
        private System.Windows.Forms.Label label217;
        private System.Windows.Forms.Label label220;
        private System.Windows.Forms.Label label222;
        private System.Windows.Forms.ComboBox AEqTypeCmb;
        private System.Windows.Forms.TextBox AEqDecripTb;
        private System.Windows.Forms.TabPage tabPage30;
        private System.Windows.Forms.Label AEqQuantityLbl;
        private System.Windows.Forms.Label label234;
        private System.Windows.Forms.Label label235;
        private System.Windows.Forms.Label label239;
        private System.Windows.Forms.Label label240;
        private System.Windows.Forms.Label label226;
        private System.Windows.Forms.Label label227;
        private System.Windows.Forms.Label label228;
        private System.Windows.Forms.Button AEqBackBtn;
        private System.Windows.Forms.Button AEqConfirmBtn;
        private System.Windows.Forms.Label AEqDescripLbl;
        private System.Windows.Forms.Label AEqTypeLbl;
        private System.Windows.Forms.Label AEqConditionLbl;
        private System.Windows.Forms.TabPage tabPage31;
        private System.Windows.Forms.Label label232;
    }
}