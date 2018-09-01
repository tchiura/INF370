namespace Insight_Prototype_
{
    partial class DeleteVehiclePage
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
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.Userlbl = new System.Windows.Forms.Label();
            this.MinimisePicBx = new System.Windows.Forms.PictureBox();
            this.ClosePicBx = new System.Windows.Forms.PictureBox();
            this.TopBarPanel.SuspendLayout();
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
            this.TopBarPanel.Size = new System.Drawing.Size(1284, 30);
            this.TopBarPanel.TabIndex = 60;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox14.Image = global::Insight_Prototype_.Properties.Resources.Minus_100px;
            this.pictureBox14.Location = new System.Drawing.Point(1200, 0);
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
            this.Userlbl.Size = new System.Drawing.Size(126, 23);
            this.Userlbl.TabIndex = 0;
            this.Userlbl.Text = "Delete Vehicle";
            // 
            // MinimisePicBx
            // 
            this.MinimisePicBx.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimisePicBx.Image = global::Insight_Prototype_.Properties.Resources.Minus_100px;
            this.MinimisePicBx.Location = new System.Drawing.Point(1228, 0);
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
            this.ClosePicBx.Location = new System.Drawing.Point(1256, 0);
            this.ClosePicBx.Name = "ClosePicBx";
            this.ClosePicBx.Size = new System.Drawing.Size(28, 30);
            this.ClosePicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClosePicBx.TabIndex = 0;
            this.ClosePicBx.TabStop = false;
            // 
            // DeleteVehiclePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.TopBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteVehiclePage";
            this.Text = "DeleteVehiclePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
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
    }
}