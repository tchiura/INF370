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
    public partial class ViewProjectRequestTypePage : Form
    {
        public ViewProjectRequestTypePage()
        {
            InitializeComponent();
        }

        private void ViewProjectRequestTypePage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insightDataSet.ProjectRequestType' table. You can move, or remove it, as needed.
            this.projectRequestTypeTableAdapter.Fill(this.insightDataSet.ProjectRequestType);

        }

        private void DVTypeBtn_Click(object sender, EventArgs e)
        {
            Form DPRT = new DeleteProjectRequestTypePage();
            this.Hide();
            DPRT.ShowDialog();
            this.Show();
        }

        private void UVTypeBtn_Click(object sender, EventArgs e)
        {
            Form UPRT = new UpdateProjectRequestTypePage();
            this.Hide();
            UPRT.ShowDialog();
            this.Show();
        }

        private void VehicleTypeDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DVTypeBtn.Enabled = true;
            UVTypeBtn.Enabled = true;
        }

        private void button192_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
