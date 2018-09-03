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
    public partial class AddEquipmentPage : Form
    {

        string EqDescr = "";
        string EqType = "";
        string EqCondi = "";
        int EqQuantity = 0;
        public AddEquipmentPage()
        {
            InitializeComponent();
        }

        private void AddEquipmentPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insightDataSet.EquipmentType' table. You can move, or remove it, as needed.
            this.equipmentTypeTableAdapter.Fill(this.insightDataSet.EquipmentType);

        }

        private void button184_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AEqNextBtn_Click(object sender, EventArgs e)
        {
            EqDescr = AEqDecripTb.Text;
            EqType = AEqTypeCmb.Text;
            EqCondi = AEqConditionCmb.Text;
            EqQuantity = Convert.ToInt32(AEqQuantityUD.Value);

            if (EqDescr == "" || EqType == "" || EqCondi == "" || EqQuantity == 0) 
            {
                MessageBox.Show("Please enter valid values.");
            }
            else
            {
                AEqDescripLbl.Text = EqDescr;
                AEqTypeLbl.Text = EqType;
                AEqConditionLbl.Text = EqCondi;
                AEqQuantityLbl.Text = Convert.ToString(EqQuantity);
                AddEquipmentTab.SelectedIndex = 1;
            }
        }

        private void AEqConfirmBtn_Click(object sender, EventArgs e)
        {
            Equipment InsightEquipment = new Equipment();

            InsightEquipment.EquipmentDescription = EqDescr;
            //InsightEquipment.EquipmentType = EqType;
            InsightEquipment.EquipmentQuantity = EqQuantity;
            //InsightEquipment.EquipmentType = 


            AddEquipmentTab.SelectedIndex = 2;
        }

        private void AEqBackBtn_Click(object sender, EventArgs e)
        {
            AddEquipmentTab.SelectedIndex = 0;
        }
    }
}
