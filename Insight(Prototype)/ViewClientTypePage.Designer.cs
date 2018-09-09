namespace Insight_Prototype_
{
    partial class ViewClientTypePage
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
            this.ViewClientTypePanel = new System.Windows.Forms.Panel();
            this.label102 = new System.Windows.Forms.Label();
            this.button111 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button112 = new System.Windows.Forms.Button();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.button113 = new System.Windows.Forms.Button();
            this.button114 = new System.Windows.Forms.Button();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.VCTypeDgv = new System.Windows.Forms.DataGridView();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.MinimisePicBx = new System.Windows.Forms.PictureBox();
            this.ClosePicBx = new System.Windows.Forms.PictureBox();
            this.TopBarPanel.SuspendLayout();
            this.ViewClientTypePanel.SuspendLayout();
            this.panel10.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VCTypeDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimisePicBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBx)).BeginInit();
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
            this.TopBarPanel.TabIndex = 25;
            // 
            // Userlbl
            // 
            this.Userlbl.AutoSize = true;
            this.Userlbl.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.Userlbl.Location = new System.Drawing.Point(3, 2);
            this.Userlbl.Name = "Userlbl";
            this.Userlbl.Size = new System.Drawing.Size(142, 23);
            this.Userlbl.TabIndex = 0;
            this.Userlbl.Text = "View Client Type";
            // 
            // ViewClientTypePanel
            // 
            this.ViewClientTypePanel.Controls.Add(this.label102);
            this.ViewClientTypePanel.Controls.Add(this.button111);
            this.ViewClientTypePanel.Controls.Add(this.panel10);
            this.ViewClientTypePanel.Controls.Add(this.textBox27);
            this.ViewClientTypePanel.Controls.Add(this.VCTypeDgv);
            this.ViewClientTypePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewClientTypePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(109)))), ((int)(((byte)(251)))));
            this.ViewClientTypePanel.Location = new System.Drawing.Point(0, 29);
            this.ViewClientTypePanel.Name = "ViewClientTypePanel";
            this.ViewClientTypePanel.Size = new System.Drawing.Size(1067, 629);
            this.ViewClientTypePanel.TabIndex = 26;
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(15, 14);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(52, 19);
            this.label102.TabIndex = 4;
            this.label102.Text = "Search";
            // 
            // button111
            // 
            this.button111.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button111.Location = new System.Drawing.Point(297, 36);
            this.button111.Name = "button111";
            this.button111.Size = new System.Drawing.Size(140, 27);
            this.button111.TabIndex = 3;
            this.button111.Text = "Search";
            this.button111.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel10.Controls.Add(this.button112);
            this.panel10.Controls.Add(this.tableLayoutPanel19);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(923, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(144, 629);
            this.panel10.TabIndex = 2;
            // 
            // button112
            // 
            this.button112.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button112.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button112.Location = new System.Drawing.Point(0, 570);
            this.button112.Name = "button112";
            this.button112.Size = new System.Drawing.Size(144, 59);
            this.button112.TabIndex = 3;
            this.button112.Text = "Back";
            this.button112.UseVisualStyleBackColor = true;
            this.button112.Click += new System.EventHandler(this.button112_Click);
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.ColumnCount = 1;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.Controls.Add(this.button113, 0, 0);
            this.tableLayoutPanel19.Controls.Add(this.button114, 0, 1);
            this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel19.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 4;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(144, 264);
            this.tableLayoutPanel19.TabIndex = 0;
            // 
            // button113
            // 
            this.button113.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button113.Location = new System.Drawing.Point(3, 3);
            this.button113.Name = "button113";
            this.button113.Size = new System.Drawing.Size(138, 56);
            this.button113.TabIndex = 0;
            this.button113.Text = "Delete Client Type";
            this.button113.UseVisualStyleBackColor = true;
            this.button113.Click += new System.EventHandler(this.button113_Click);
            // 
            // button114
            // 
            this.button114.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button114.Location = new System.Drawing.Point(3, 65);
            this.button114.Name = "button114";
            this.button114.Size = new System.Drawing.Size(138, 56);
            this.button114.TabIndex = 2;
            this.button114.Text = "Update Client Type";
            this.button114.UseVisualStyleBackColor = true;
            this.button114.Click += new System.EventHandler(this.button114_Click);
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(12, 36);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(265, 27);
            this.textBox27.TabIndex = 1;
            // 
            // VCTypeDgv
            // 
            this.VCTypeDgv.BackgroundColor = System.Drawing.Color.White;
            this.VCTypeDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VCTypeDgv.Location = new System.Drawing.Point(12, 75);
            this.VCTypeDgv.Name = "VCTypeDgv";
            this.VCTypeDgv.Size = new System.Drawing.Size(885, 585);
            this.VCTypeDgv.TabIndex = 0;
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
            // ViewClientTypePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(this.ViewClientTypePanel);
            this.Controls.Add(this.TopBarPanel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewClientTypePage";
            this.Text = "ViewClientTypePage";
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            this.ViewClientTypePanel.ResumeLayout(false);
            this.ViewClientTypePanel.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.tableLayoutPanel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VCTypeDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimisePicBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.Label Userlbl;
        private System.Windows.Forms.PictureBox MinimisePicBx;
        private System.Windows.Forms.PictureBox ClosePicBx;
        private System.Windows.Forms.Panel ViewClientTypePanel;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Button button111;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button112;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        private System.Windows.Forms.Button button113;
        private System.Windows.Forms.Button button114;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.DataGridView VCTypeDgv;
    }
}