using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insight_Prototype_
{
    public partial class InSight_Load : Form
    {
        public InSight_Load()
        {
            InitializeComponent();
        }

        private void InSight_Load_Load(object sender, EventArgs e)
        {
            timer1.Start();
            WinAPI.AnimateWindow(this.Handle, 2000, WinAPI.BLEND);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.PerformStep();
            //progressBar1.MarqueeAnimationSpeed = 200;
            if(progressBar1.Value == 100)
            {
                Form f3 = new GenerateProjectQuotationPage();
                f3.Show();
                this.Hide();
                timer1.Stop();
            }

        }
    }
}
