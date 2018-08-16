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
    public partial class AddProjectPage : Form
    {
        public AddProjectPage()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            Form A = new AddProjectConfirmationPage();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            Form A = new AddPhaseConfirmationPage();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form A = new AddJobConfirmationPage();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void AddProjectPage_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
