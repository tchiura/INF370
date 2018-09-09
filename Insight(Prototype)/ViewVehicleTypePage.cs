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
    public partial class ViewVehicleTypePage : Form
    {
        private int vTypeID;
        public int VT
        {
            get { return vTypeID; }
            set { vTypeID = value; }
        }

        public int VTypeID { get => vTypeID; set => vTypeID = value; }

        public ViewVehicleTypePage()
        {
            InitializeComponent();
        }

        private void ViewVehicleTypePage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insightDataSet.VehicleType' table. You can move, or remove it, as needed.
            this.vehicleTypeTableAdapter.Fill(this.insightDataSet.VehicleType);

        }

        private void button192_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UVTypeBtn_Click(object sender, EventArgs e)
        {
            Form UVT = new UpdateVehicleTypePage();
            UVT.ShowDialog();
        }

        private void DVTypeBtn_Click(object sender, EventArgs e)
        {
            Form DVType = new DeleteVehicleTypePage();
            DVType.ShowDialog();
        }

        private void VehicleTypeDgv_SelectionChanged(object sender, EventArgs e)
        {
            int Ind = VehicleTypeDgv.CurrentCell.RowIndex;

            VTypeID = Convert.ToInt32(VehicleTypeDgv.Rows[Ind].Cells["VehicleTypeID"].Value);
            //int PRI = EmpDGv.CurrentCell.RowIndex;

            //eid = Convert.ToInt32(EmpDGv.Rows[PRI].Cells["EmployeeID"].Value.ToString());
        }
    }
}
