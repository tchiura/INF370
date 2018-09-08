namespace Insight_Prototype_
{
    partial class AddProjectPage
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
            this.Userlbl = new System.Windows.Forms.Label();
            this.ClosePicBx = new System.Windows.Forms.PictureBox();
            this.phaseDetail = new System.Windows.Forms.RichTextBox();
            this.phasetypecbx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MinimisePicBx = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.jobDetail = new System.Windows.Forms.RichTextBox();
            this.jobTypecbx = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.jobEnd = new System.Windows.Forms.DateTimePicker();
            this.jobStart = new System.Windows.Forms.DateTimePicker();
            this.jobgp = new System.Windows.Forms.GroupBox();
            this.phaseEnd = new System.Windows.Forms.DateTimePicker();
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.phaseStart = new System.Windows.Forms.DateTimePicker();
            this.button8 = new System.Windows.Forms.Button();
            this.phasegb = new System.Windows.Forms.GroupBox();
            this.phasenum = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.projectDetail = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.projectgb = new System.Windows.Forms.GroupBox();
            this.insightDataSet = new Insight_Prototype_.InsightDataSet();
            this.projectPhaseTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectPhaseTypeTableAdapter = new Insight_Prototype_.InsightDataSetTableAdapters.ProjectPhaseTypeTableAdapter();
            this.jobTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobTypeTableAdapter = new Insight_Prototype_.InsightDataSetTableAdapters.JobTypeTableAdapter();
            this.jobnum = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.jobnumlbl = new System.Windows.Forms.Label();
            this.phasenumlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimisePicBx)).BeginInit();
            this.jobgp.SuspendLayout();
            this.TopBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            this.phasegb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phasenum)).BeginInit();
            this.projectgb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insightDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectPhaseTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobnum)).BeginInit();
            this.SuspendLayout();
            // 
            // Userlbl
            // 
            this.Userlbl.AutoSize = true;
            this.Userlbl.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.Userlbl.Location = new System.Drawing.Point(3, 2);
            this.Userlbl.Name = "Userlbl";
            this.Userlbl.Size = new System.Drawing.Size(103, 23);
            this.Userlbl.TabIndex = 0;
            this.Userlbl.Text = "Add Project";
            // 
            // ClosePicBx
            // 
            this.ClosePicBx.Dock = System.Windows.Forms.DockStyle.Right;
            this.ClosePicBx.Image = global::Insight_Prototype_.Properties.Resources.Cancel_100px2;
            this.ClosePicBx.Location = new System.Drawing.Point(1269, 0);
            this.ClosePicBx.Name = "ClosePicBx";
            this.ClosePicBx.Size = new System.Drawing.Size(28, 29);
            this.ClosePicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClosePicBx.TabIndex = 0;
            this.ClosePicBx.TabStop = false;
            this.ClosePicBx.Click += new System.EventHandler(this.ClosePicBx_Click);
            // 
            // phaseDetail
            // 
            this.phaseDetail.Location = new System.Drawing.Point(142, 30);
            this.phaseDetail.Name = "phaseDetail";
            this.phaseDetail.Size = new System.Drawing.Size(245, 143);
            this.phaseDetail.TabIndex = 56;
            this.phaseDetail.Text = "";
            // 
            // phasetypecbx
            // 
            this.phasetypecbx.DataSource = this.projectPhaseTypeBindingSource;
            this.phasetypecbx.DisplayMember = "ProjectPhaseTypeDescription";
            this.phasetypecbx.FormattingEnabled = true;
            this.phasetypecbx.Location = new System.Drawing.Point(142, 290);
            this.phasetypecbx.Name = "phasetypecbx";
            this.phasetypecbx.Size = new System.Drawing.Size(245, 27);
            this.phasetypecbx.TabIndex = 55;
            this.phasetypecbx.ValueMember = "ProjectPhaseTypeID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 53;
            this.label4.Text = "Phase Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 50;
            this.label1.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 49;
            this.label2.Text = "End Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "Phase Type:";
            // 
            // MinimisePicBx
            // 
            this.MinimisePicBx.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimisePicBx.Image = global::Insight_Prototype_.Properties.Resources.Minus_100px;
            this.MinimisePicBx.Location = new System.Drawing.Point(1241, 0);
            this.MinimisePicBx.Name = "MinimisePicBx";
            this.MinimisePicBx.Size = new System.Drawing.Size(28, 29);
            this.MinimisePicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimisePicBx.TabIndex = 1;
            this.MinimisePicBx.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(109)))), ((int)(((byte)(251)))));
            this.button1.Location = new System.Drawing.Point(1199, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 51;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // jobDetail
            // 
            this.jobDetail.Location = new System.Drawing.Point(147, 30);
            this.jobDetail.Name = "jobDetail";
            this.jobDetail.Size = new System.Drawing.Size(245, 143);
            this.jobDetail.TabIndex = 62;
            this.jobDetail.Text = "";
            // 
            // jobTypecbx
            // 
            this.jobTypecbx.DataSource = this.jobTypeBindingSource;
            this.jobTypecbx.DisplayMember = "JobTypeDescription";
            this.jobTypecbx.FormattingEnabled = true;
            this.jobTypecbx.Location = new System.Drawing.Point(147, 290);
            this.jobTypecbx.Name = "jobTypecbx";
            this.jobTypecbx.Size = new System.Drawing.Size(245, 27);
            this.jobTypecbx.TabIndex = 61;
            this.jobTypecbx.ValueMember = "JobTypeID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 19);
            this.label12.TabIndex = 60;
            this.label12.Text = "Job Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 19);
            this.label9.TabIndex = 58;
            this.label9.Text = "Job Description:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 19);
            this.label10.TabIndex = 55;
            this.label10.Text = "Start Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 19);
            this.label11.TabIndex = 54;
            this.label11.Text = "End Date:";
            // 
            // jobEnd
            // 
            this.jobEnd.Location = new System.Drawing.Point(147, 243);
            this.jobEnd.Name = "jobEnd";
            this.jobEnd.Size = new System.Drawing.Size(245, 27);
            this.jobEnd.TabIndex = 57;
            this.jobEnd.Value = new System.DateTime(2018, 5, 6, 23, 19, 0, 0);
            // 
            // jobStart
            // 
            this.jobStart.Location = new System.Drawing.Point(147, 199);
            this.jobStart.Name = "jobStart";
            this.jobStart.Size = new System.Drawing.Size(245, 27);
            this.jobStart.TabIndex = 56;
            this.jobStart.Value = new System.DateTime(2018, 5, 6, 23, 19, 0, 0);
            // 
            // jobgp
            // 
            this.jobgp.Controls.Add(this.jobDetail);
            this.jobgp.Controls.Add(this.jobTypecbx);
            this.jobgp.Controls.Add(this.label12);
            this.jobgp.Controls.Add(this.label9);
            this.jobgp.Controls.Add(this.label10);
            this.jobgp.Controls.Add(this.label11);
            this.jobgp.Controls.Add(this.jobEnd);
            this.jobgp.Controls.Add(this.jobStart);
            this.jobgp.Location = new System.Drawing.Point(864, 51);
            this.jobgp.Name = "jobgp";
            this.jobgp.Size = new System.Drawing.Size(410, 371);
            this.jobgp.TabIndex = 48;
            this.jobgp.TabStop = false;
            this.jobgp.Text = "Job Details";
            // 
            // phaseEnd
            // 
            this.phaseEnd.Location = new System.Drawing.Point(142, 243);
            this.phaseEnd.Name = "phaseEnd";
            this.phaseEnd.Size = new System.Drawing.Size(245, 27);
            this.phaseEnd.TabIndex = 52;
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
            this.TopBarPanel.Size = new System.Drawing.Size(1297, 29);
            this.TopBarPanel.TabIndex = 49;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox14.Image = global::Insight_Prototype_.Properties.Resources.Minus_100px;
            this.pictureBox14.Location = new System.Drawing.Point(1213, 0);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(28, 29);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 2;
            this.pictureBox14.TabStop = false;
            // 
            // phaseStart
            // 
            this.phaseStart.Location = new System.Drawing.Point(142, 199);
            this.phaseStart.Name = "phaseStart";
            this.phaseStart.Size = new System.Drawing.Size(245, 27);
            this.phaseStart.TabIndex = 51;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(109)))), ((int)(((byte)(251)))));
            this.button8.Location = new System.Drawing.Point(1118, 428);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 30);
            this.button8.TabIndex = 50;
            this.button8.Text = "Back";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // phasegb
            // 
            this.phasegb.Controls.Add(this.jobnum);
            this.phasegb.Controls.Add(this.label13);
            this.phasegb.Controls.Add(this.phaseDetail);
            this.phasegb.Controls.Add(this.phasetypecbx);
            this.phasegb.Controls.Add(this.label4);
            this.phasegb.Controls.Add(this.label1);
            this.phasegb.Controls.Add(this.label2);
            this.phasegb.Controls.Add(this.label3);
            this.phasegb.Controls.Add(this.phaseEnd);
            this.phasegb.Controls.Add(this.phaseStart);
            this.phasegb.Location = new System.Drawing.Point(437, 51);
            this.phasegb.Name = "phasegb";
            this.phasegb.Size = new System.Drawing.Size(410, 371);
            this.phasegb.TabIndex = 47;
            this.phasegb.TabStop = false;
            this.phasegb.Text = "Phase Details";
            // 
            // phasenum
            // 
            this.phasenum.Location = new System.Drawing.Point(148, 291);
            this.phasenum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.phasenum.Name = "phasenum";
            this.phasenum.Size = new System.Drawing.Size(123, 27);
            this.phasenum.TabIndex = 66;
            this.phasenum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 19);
            this.label8.TabIndex = 65;
            this.label8.Text = "Number of Phases:";
            // 
            // projectDetail
            // 
            this.projectDetail.Location = new System.Drawing.Point(148, 30);
            this.projectDetail.Name = "projectDetail";
            this.projectDetail.Size = new System.Drawing.Size(245, 143);
            this.projectDetail.TabIndex = 64;
            this.projectDetail.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 19);
            this.label5.TabIndex = 62;
            this.label5.Text = "Project Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 59;
            this.label6.Text = "Start Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 58;
            this.label7.Text = "End Date:";
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(148, 243);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(245, 27);
            this.endDate.TabIndex = 61;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(148, 199);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(245, 27);
            this.startDate.TabIndex = 60;
            // 
            // projectgb
            // 
            this.projectgb.Controls.Add(this.phasenum);
            this.projectgb.Controls.Add(this.label8);
            this.projectgb.Controls.Add(this.projectDetail);
            this.projectgb.Controls.Add(this.label5);
            this.projectgb.Controls.Add(this.label6);
            this.projectgb.Controls.Add(this.label7);
            this.projectgb.Controls.Add(this.endDate);
            this.projectgb.Controls.Add(this.startDate);
            this.projectgb.Location = new System.Drawing.Point(15, 51);
            this.projectgb.Name = "projectgb";
            this.projectgb.Size = new System.Drawing.Size(410, 371);
            this.projectgb.TabIndex = 46;
            this.projectgb.TabStop = false;
            this.projectgb.Text = "Project Details";
            // 
            // insightDataSet
            // 
            this.insightDataSet.DataSetName = "InsightDataSet";
            this.insightDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectPhaseTypeBindingSource
            // 
            this.projectPhaseTypeBindingSource.DataMember = "ProjectPhaseType";
            this.projectPhaseTypeBindingSource.DataSource = this.insightDataSet;
            // 
            // projectPhaseTypeTableAdapter
            // 
            this.projectPhaseTypeTableAdapter.ClearBeforeFill = true;
            // 
            // jobTypeBindingSource
            // 
            this.jobTypeBindingSource.DataMember = "JobType";
            this.jobTypeBindingSource.DataSource = this.insightDataSet;
            // 
            // jobTypeTableAdapter
            // 
            this.jobTypeTableAdapter.ClearBeforeFill = true;
            // 
            // jobnum
            // 
            this.jobnum.Location = new System.Drawing.Point(142, 338);
            this.jobnum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.jobnum.Name = "jobnum";
            this.jobnum.Size = new System.Drawing.Size(123, 27);
            this.jobnum.TabIndex = 68;
            this.jobnum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 340);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 19);
            this.label13.TabIndex = 67;
            this.label13.Text = "Number of Jobs:";
            // 
            // jobnumlbl
            // 
            this.jobnumlbl.AutoSize = true;
            this.jobnumlbl.Location = new System.Drawing.Point(1007, 33);
            this.jobnumlbl.Name = "jobnumlbl";
            this.jobnumlbl.Size = new System.Drawing.Size(85, 19);
            this.jobnumlbl.TabIndex = 52;
            this.jobnumlbl.Text = "Job Number";
            // 
            // phasenumlbl
            // 
            this.phasenumlbl.AutoSize = true;
            this.phasenumlbl.Location = new System.Drawing.Point(575, 33);
            this.phasenumlbl.Name = "phasenumlbl";
            this.phasenumlbl.Size = new System.Drawing.Size(103, 19);
            this.phasenumlbl.TabIndex = 53;
            this.phasenumlbl.Text = "Phase Number";
            // 
            // AddProjectPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1297, 470);
            this.Controls.Add(this.phasenumlbl);
            this.Controls.Add(this.jobnumlbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.jobgp);
            this.Controls.Add(this.TopBarPanel);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.phasegb);
            this.Controls.Add(this.projectgb);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProjectPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProjectPage";
            this.Load += new System.EventHandler(this.AddProjectPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimisePicBx)).EndInit();
            this.jobgp.ResumeLayout(false);
            this.jobgp.PerformLayout();
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            this.phasegb.ResumeLayout(false);
            this.phasegb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phasenum)).EndInit();
            this.projectgb.ResumeLayout(false);
            this.projectgb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insightDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectPhaseTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobnum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Userlbl;
        private System.Windows.Forms.PictureBox ClosePicBx;
        private System.Windows.Forms.RichTextBox phaseDetail;
        private System.Windows.Forms.ComboBox phasetypecbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox MinimisePicBx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox jobDetail;
        private System.Windows.Forms.ComboBox jobTypecbx;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker jobEnd;
        private System.Windows.Forms.DateTimePicker jobStart;
        private System.Windows.Forms.GroupBox jobgp;
        private System.Windows.Forms.DateTimePicker phaseEnd;
        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.DateTimePicker phaseStart;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox phasegb;
        private System.Windows.Forms.NumericUpDown phasenum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox projectDetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.GroupBox projectgb;
        private InsightDataSet insightDataSet;
        private System.Windows.Forms.BindingSource projectPhaseTypeBindingSource;
        private InsightDataSetTableAdapters.ProjectPhaseTypeTableAdapter projectPhaseTypeTableAdapter;
        private System.Windows.Forms.BindingSource jobTypeBindingSource;
        private InsightDataSetTableAdapters.JobTypeTableAdapter jobTypeTableAdapter;
        private System.Windows.Forms.NumericUpDown jobnum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label jobnumlbl;
        private System.Windows.Forms.Label phasenumlbl;
    }
}