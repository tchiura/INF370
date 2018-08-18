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
    public partial class AddEquipmentTypePage : Form
    {
        public AddEquipmentTypePage()
        {
            InitializeComponent();
        }

        string EquipDescr = "";

        private void ClosePicBx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EquipTCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EquipTNextBtn_Click(object sender, EventArgs e)
        {
            EquipDescr = EquipmentTypeTb.Text;
            if (EquipDescr == "")
            {
                MessageBox.Show("Please Enter an Equipment Type");
            }
            else
            {
                EquipTConfirmLbl.Text = EquipDescr;
                AddEquipmentTypeTC.SelectedTab = AddEquipmentTypeTC.TabPages[1];
            }
        }

        private void EquipTBackBtn_Click(object sender, EventArgs e)
        {
            AddEquipmentTypeTC.SelectedTab = AddEquipmentTypeTC.TabPages[0];
        }

        private void EquipTConfirmBtn_Click(object sender, EventArgs e)
        {
            EquipmentType InsightEquipmentType = new EquipmentType();
            InsightEquipmentType.EquipmentTypeDescription = EquipDescr;

            using (InsightEntities db = new InsightEntities())
            {
                db.EquipmentTypes.Add(InsightEquipmentType);
                db.SaveChanges();
            }

            AddEquipmentTypeTC.SelectedTab = AddEquipmentTypeTC.TabPages[2];
        }

        private void label99_Click(object sender, EventArgs e)
        {

        }
    }
}
