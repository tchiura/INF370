namespace Insight_Prototype_
{
    partial class AddProductTypePage
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
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.Userlbl = new System.Windows.Forms.Label();
            this.ClosePicBx = new System.Windows.Forms.PictureBox();
            this.AddProductTypeTC = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ProdTypeTb = new System.Windows.Forms.TextBox();
            this.AProdCancelBtn = new System.Windows.Forms.Button();
            this.AProdNextBtn = new System.Windows.Forms.Button();
            this.label58 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ProdTBackBtn = new System.Windows.Forms.Button();
            this.ProbTConfirmBtn = new System.Windows.Forms.Button();
            this.ProdTConfirmLbl = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label99 = new System.Windows.Forms.Label();
            this.TopBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBx)).BeginInit();
            this.AddProductTypeTC.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
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
            this.TopBarPanel.TabIndex = 15;
            // 
            // Userlbl
            // 
            this.Userlbl.AutoSize = true;
            this.Userlbl.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.Userlbl.Location = new System.Drawing.Point(3, 2);
            this.Userlbl.Name = "Userlbl";
            this.Userlbl.Size = new System.Drawing.Size(149, 23);
            this.Userlbl.TabIndex = 0;
            this.Userlbl.Text = "Add Product Type";
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
            // AddProductTypeTC
            // 
            this.AddProductTypeTC.Controls.Add(this.tabPage1);
            this.AddProductTypeTC.Controls.Add(this.tabPage2);
            this.AddProductTypeTC.Controls.Add(this.tabPage3);
            this.AddProductTypeTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddProductTypeTC.Location = new System.Drawing.Point(0, 30);
            this.AddProductTypeTC.Margin = new System.Windows.Forms.Padding(4);
            this.AddProductTypeTC.Name = "AddProductTypeTC";
            this.AddProductTypeTC.SelectedIndex = 0;
            this.AddProductTypeTC.Size = new System.Drawing.Size(460, 170);
            this.AddProductTypeTC.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.ProdTypeTb);
            this.tabPage1.Controls.Add(this.AProdCancelBtn);
            this.tabPage1.Controls.Add(this.AProdNextBtn);
            this.tabPage1.Controls.Add(this.label58);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(452, 138);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Details";
            // 
            // ProdTypeTb
            // 
            this.ProdTypeTb.Location = new System.Drawing.Point(170, 25);
            this.ProdTypeTb.Margin = new System.Windows.Forms.Padding(4);
            this.ProdTypeTb.Name = "ProdTypeTb";
            this.ProdTypeTb.Size = new System.Drawing.Size(245, 27);
            this.ProdTypeTb.TabIndex = 32;
            this.ProdTypeTb.Text = "Organisation";
            // 
            // AProdCancelBtn
            // 
            this.AProdCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AProdCancelBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AProdCancelBtn.Location = new System.Drawing.Point(286, 100);
            this.AProdCancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AProdCancelBtn.Name = "AProdCancelBtn";
            this.AProdCancelBtn.Size = new System.Drawing.Size(75, 30);
            this.AProdCancelBtn.TabIndex = 31;
            this.AProdCancelBtn.Text = "Cancel";
            this.AProdCancelBtn.UseVisualStyleBackColor = true;
            this.AProdCancelBtn.Click += new System.EventHandler(this.AProdCancelBtn_Click);
            // 
            // AProdNextBtn
            // 
            this.AProdNextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AProdNextBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AProdNextBtn.Location = new System.Drawing.Point(369, 100);
            this.AProdNextBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AProdNextBtn.Name = "AProdNextBtn";
            this.AProdNextBtn.Size = new System.Drawing.Size(75, 30);
            this.AProdNextBtn.TabIndex = 30;
            this.AProdNextBtn.Text = "Next";
            this.AProdNextBtn.UseVisualStyleBackColor = true;
            this.AProdNextBtn.Click += new System.EventHandler(this.AProdNextBtn_Click);
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(25, 25);
            this.label58.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(100, 19);
            this.label58.TabIndex = 7;
            this.label58.Text = "Product Type: ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.ProdTBackBtn);
            this.tabPage2.Controls.Add(this.ProbTConfirmBtn);
            this.tabPage2.Controls.Add(this.ProdTConfirmLbl);
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
            // ProdTBackBtn
            // 
            this.ProdTBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProdTBackBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdTBackBtn.Location = new System.Drawing.Point(286, 100);
            this.ProdTBackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ProdTBackBtn.Name = "ProdTBackBtn";
            this.ProdTBackBtn.Size = new System.Drawing.Size(75, 30);
            this.ProdTBackBtn.TabIndex = 37;
            this.ProdTBackBtn.Text = "Back";
            this.ProdTBackBtn.UseVisualStyleBackColor = true;
            this.ProdTBackBtn.Click += new System.EventHandler(this.ProdTBackBtn_Click);
            // 
            // ProbTConfirmBtn
            // 
            this.ProbTConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProbTConfirmBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProbTConfirmBtn.Location = new System.Drawing.Point(369, 100);
            this.ProbTConfirmBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ProbTConfirmBtn.Name = "ProbTConfirmBtn";
            this.ProbTConfirmBtn.Size = new System.Drawing.Size(75, 30);
            this.ProbTConfirmBtn.TabIndex = 36;
            this.ProbTConfirmBtn.Text = "Confirm";
            this.ProbTConfirmBtn.UseVisualStyleBackColor = true;
            this.ProbTConfirmBtn.Click += new System.EventHandler(this.ProbTConfirmBtn_Click);
            // 
            // ProdTConfirmLbl
            // 
            this.ProdTConfirmLbl.AutoSize = true;
            this.ProdTConfirmLbl.Location = new System.Drawing.Point(227, 37);
            this.ProdTConfirmLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProdTConfirmLbl.Name = "ProdTConfirmLbl";
            this.ProdTConfirmLbl.Size = new System.Drawing.Size(93, 19);
            this.ProdTConfirmLbl.TabIndex = 33;
            this.ProdTConfirmLbl.Text = "Organisation";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(33, 37);
            this.label91.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(100, 19);
            this.label91.TabIndex = 23;
            this.label91.Text = "Product Type: ";
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
            this.label99.Location = new System.Drawing.Point(21, 28);
            this.label99.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(369, 33);
            this.label99.TabIndex = 1;
            this.label99.Text = "Product Type Successfully Added";
            // 
            // AddProductTypePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 200);
            this.Controls.Add(this.AddProductTypeTC);
            this.Controls.Add(this.TopBarPanel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProductTypePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddProductTypePage";
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBx)).EndInit();
            this.AddProductTypeTC.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Label Userlbl;
        private System.Windows.Forms.PictureBox ClosePicBx;
        private System.Windows.Forms.TabControl AddProductTypeTC;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox ProdTypeTb;
        private System.Windows.Forms.Button AProdCancelBtn;
        private System.Windows.Forms.Button AProdNextBtn;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ProdTBackBtn;
        private System.Windows.Forms.Button ProbTConfirmBtn;
        private System.Windows.Forms.Label ProdTConfirmLbl;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label99;
    }
}