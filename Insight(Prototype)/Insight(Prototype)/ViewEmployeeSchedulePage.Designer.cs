namespace Insight_Prototype_
{
    partial class ViewEmployeeSchedulePage
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
            this.MinimisePicBx = new System.Windows.Forms.PictureBox();
            this.ClosePicBx = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimisePicBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.TopBarPanel.Controls.Add(this.Userlbl);
            this.TopBarPanel.Controls.Add(this.MinimisePicBx);
            this.TopBarPanel.Controls.Add(this.ClosePicBx);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(1284, 29);
            this.TopBarPanel.TabIndex = 1;
            // 
            // Userlbl
            // 
            this.Userlbl.AutoSize = true;
            this.Userlbl.Font = new System.Drawing.Font("Calibri", 12F);
            this.Userlbl.Location = new System.Drawing.Point(12, 6);
            this.Userlbl.Name = "Userlbl";
            this.Userlbl.Size = new System.Drawing.Size(75, 19);
            this.Userlbl.TabIndex = 0;
            this.Userlbl.Text = "Username";
            // 
            // MinimisePicBx
            // 
            this.MinimisePicBx.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimisePicBx.Image = global::Insight_Prototype_.Properties.Resources.Minus_32px;
            this.MinimisePicBx.Location = new System.Drawing.Point(1228, 0);
            this.MinimisePicBx.Name = "MinimisePicBx";
            this.MinimisePicBx.Size = new System.Drawing.Size(28, 29);
            this.MinimisePicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MinimisePicBx.TabIndex = 1;
            this.MinimisePicBx.TabStop = false;
            // 
            // ClosePicBx
            // 
            this.ClosePicBx.Dock = System.Windows.Forms.DockStyle.Right;
            this.ClosePicBx.Image = global::Insight_Prototype_.Properties.Resources.Shutdown_32px;
            this.ClosePicBx.Location = new System.Drawing.Point(1256, 0);
            this.ClosePicBx.Name = "ClosePicBx";
            this.ClosePicBx.Size = new System.Drawing.Size(28, 29);
            this.ClosePicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ClosePicBx.TabIndex = 0;
            this.ClosePicBx.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EID});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1284, 632);
            this.dataGridView1.TabIndex = 2;
            // 
            // EID
            // 
            this.EID.HeaderText = "ID";
            this.EID.Name = "EID";
            // 
            // ViewEmployeeSchedulePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TopBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewEmployeeSchedulePage";
            this.Text = "ViewEmployeeSchedulePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimisePicBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Label Userlbl;
        private System.Windows.Forms.PictureBox MinimisePicBx;
        private System.Windows.Forms.PictureBox ClosePicBx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EID;
    }
}