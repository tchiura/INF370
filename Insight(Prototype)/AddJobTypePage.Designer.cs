namespace Insight_Prototype_
{
    partial class AddJobTypePage
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
            this.Userlbl = new System.Windows.Forms.Label();
            this.ClosePicBx = new System.Windows.Forms.PictureBox();
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.AddJobTypeTC = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbJobType = new System.Windows.Forms.TextBox();
            this.JTCancelBtn = new System.Windows.Forms.Button();
            this.JTNextBtn = new System.Windows.Forms.Button();
            this.label58 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.JTBackBtn = new System.Windows.Forms.Button();
            this.JTConfirmBtn = new System.Windows.Forms.Button();
            this.JTConfirmLbl = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label99 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBx)).BeginInit();
            this.TopBarPanel.SuspendLayout();
            this.AddJobTypeTC.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Userlbl
            // 
            this.Userlbl.AutoSize = true;
            this.Userlbl.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.Userlbl.Location = new System.Drawing.Point(3, 2);
            this.Userlbl.Name = "Userlbl";
            this.Userlbl.Size = new System.Drawing.Size(113, 23);
            this.Userlbl.TabIndex = 0;
            this.Userlbl.Text = "Add Job Type";
            // 
            // ClosePicBx
            // 
            this.ClosePicBx.Dock = System.Windows.Forms.DockStyle.Right;
            this.ClosePicBx.Image = global::Insight_Prototype_.Properties.Resources.Cancel_100px2;
            this.ClosePicBx.Location = new System.Drawing.Point(432, 0);
            this.ClosePicBx.Name = "ClosePicBx";
            this.ClosePicBx.Size = new System.Drawing.Size(28, 30);
            this.ClosePicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClosePicBx.TabIndex = 0;
            this.ClosePicBx.TabStop = false;
            this.ClosePicBx.Click += new System.EventHandler(this.ClosePicBx_Click);
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.TopBarPanel.Controls.Add(this.Userlbl);
            this.TopBarPanel.Controls.Add(this.ClosePicBx);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopBarPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(109)))), ((int)(((byte)(251)))));
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(460, 30);
            this.TopBarPanel.TabIndex = 12;
            // 
            // AddJobTypeTC
            // 
            this.AddJobTypeTC.Controls.Add(this.tabPage1);
            this.AddJobTypeTC.Controls.Add(this.tabPage2);
            this.AddJobTypeTC.Controls.Add(this.tabPage3);
            this.AddJobTypeTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddJobTypeTC.Location = new System.Drawing.Point(0, 30);
            this.AddJobTypeTC.Margin = new System.Windows.Forms.Padding(4);
            this.AddJobTypeTC.Name = "AddJobTypeTC";
            this.AddJobTypeTC.SelectedIndex = 0;
            this.AddJobTypeTC.Size = new System.Drawing.Size(460, 230);
            this.AddJobTypeTC.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.tbJobType);
            this.tabPage1.Controls.Add(this.JTCancelBtn);
            this.tabPage1.Controls.Add(this.JTNextBtn);
            this.tabPage1.Controls.Add(this.label58);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(452, 198);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Details";
            // 
            // tbJobType
            // 
            this.tbJobType.Location = new System.Drawing.Point(170, 25);
            this.tbJobType.Margin = new System.Windows.Forms.Padding(4);
            this.tbJobType.Name = "tbJobType";
            this.tbJobType.Size = new System.Drawing.Size(245, 27);
            this.tbJobType.TabIndex = 32;
            this.tbJobType.Text = "Organisation";
            // 
            // JTCancelBtn
            // 
            this.JTCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JTCancelBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JTCancelBtn.Location = new System.Drawing.Point(257, 131);
            this.JTCancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.JTCancelBtn.Name = "JTCancelBtn";
            this.JTCancelBtn.Size = new System.Drawing.Size(75, 30);
            this.JTCancelBtn.TabIndex = 31;
            this.JTCancelBtn.Text = "Cancel";
            this.JTCancelBtn.UseVisualStyleBackColor = true;
            this.JTCancelBtn.Click += new System.EventHandler(this.JTCancelBtn_Click);
            // 
            // JTNextBtn
            // 
            this.JTNextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JTNextBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JTNextBtn.Location = new System.Drawing.Point(340, 131);
            this.JTNextBtn.Margin = new System.Windows.Forms.Padding(4);
            this.JTNextBtn.Name = "JTNextBtn";
            this.JTNextBtn.Size = new System.Drawing.Size(75, 30);
            this.JTNextBtn.TabIndex = 30;
            this.JTNextBtn.Text = "Next";
            this.JTNextBtn.UseVisualStyleBackColor = true;
            this.JTNextBtn.Click += new System.EventHandler(this.Button22_Click);
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(24, 28);
            this.label58.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(72, 19);
            this.label58.TabIndex = 7;
            this.label58.Text = "Job Type: ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.JTBackBtn);
            this.tabPage2.Controls.Add(this.JTConfirmBtn);
            this.tabPage2.Controls.Add(this.JTConfirmLbl);
            this.tabPage2.Controls.Add(this.label91);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(452, 138);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Confirmation";
            // 
            // JTBackBtn
            // 
            this.JTBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JTBackBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JTBackBtn.Location = new System.Drawing.Point(286, 100);
            this.JTBackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.JTBackBtn.Name = "JTBackBtn";
            this.JTBackBtn.Size = new System.Drawing.Size(75, 30);
            this.JTBackBtn.TabIndex = 37;
            this.JTBackBtn.Text = "Back";
            this.JTBackBtn.UseVisualStyleBackColor = true;
            this.JTBackBtn.Click += new System.EventHandler(this.JTBackBtn_Click);
            // 
            // JTConfirmBtn
            // 
            this.JTConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JTConfirmBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JTConfirmBtn.Location = new System.Drawing.Point(369, 100);
            this.JTConfirmBtn.Margin = new System.Windows.Forms.Padding(4);
            this.JTConfirmBtn.Name = "JTConfirmBtn";
            this.JTConfirmBtn.Size = new System.Drawing.Size(75, 30);
            this.JTConfirmBtn.TabIndex = 36;
            this.JTConfirmBtn.Text = "Confirm";
            this.JTConfirmBtn.UseVisualStyleBackColor = true;
            this.JTConfirmBtn.Click += new System.EventHandler(this.button24_Click);
            // 
            // JTConfirmLbl
            // 
            this.JTConfirmLbl.AutoSize = true;
            this.JTConfirmLbl.Location = new System.Drawing.Point(227, 37);
            this.JTConfirmLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JTConfirmLbl.Name = "JTConfirmLbl";
            this.JTConfirmLbl.Size = new System.Drawing.Size(93, 19);
            this.JTConfirmLbl.TabIndex = 33;
            this.JTConfirmLbl.Text = "Organisation";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(33, 37);
            this.label91.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(72, 19);
            this.label91.TabIndex = 23;
            this.label91.Text = "Job Type: ";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.label99);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(452, 138);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Complete";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Calibri", 20F);
            this.label99.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(109)))), ((int)(((byte)(251)))));
            this.label99.Location = new System.Drawing.Point(66, 53);
            this.label99.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(321, 33);
            this.label99.TabIndex = 1;
            this.label99.Text = "Job Type Successfully Added";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(281, 74);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(134, 27);
            this.numericUpDown1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Job Type Price:";
            // 
            // AddJobTypePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 260);
            this.Controls.Add(this.AddJobTypeTC);
            this.Controls.Add(this.TopBarPanel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddJobTypePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddJobTypePage";
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBx)).EndInit();
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            this.AddJobTypeTC.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Userlbl;
        private System.Windows.Forms.PictureBox ClosePicBx;
        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.TabControl AddJobTypeTC;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbJobType;
        private System.Windows.Forms.Button JTCancelBtn;
        private System.Windows.Forms.Button JTNextBtn;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button JTBackBtn;
        private System.Windows.Forms.Button JTConfirmBtn;
        private System.Windows.Forms.Label JTConfirmLbl;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}