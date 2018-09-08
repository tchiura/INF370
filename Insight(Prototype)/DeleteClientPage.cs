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
    public partial class DeleteClientPage : Form
    {
        public DeleteClientPage()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete this client?", "Delete", MessageBoxButtons.YesNo);
            //MessageBoxButtons.YesNo =;
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void DeleteClientDetailsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button15_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show("Are you sure you want to delete this client?", "Delete", MessageBoxButtons.YesNo);
            //MessageBoxButtons.YesNo =;
            using (InsightEntities db = new InsightEntities())
            {
                var C = db.Clients.SingleOrDefault(x => x.ClientID == 1);

                if(C != null)
                {
                    db.Clients.Remove(C);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("We were not able to delete this client");
                }
            }
        }
    }
}
