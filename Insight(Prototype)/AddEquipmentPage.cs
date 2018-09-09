using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Insight_Prototype_
{
    public partial class AddEquipmentPage : Form
    {
        Globals G = new Globals();



        string EqDescr = "";
        string EqType = "";
        int EqQuantity = 0;
        public AddEquipmentPage()
        {
            InitializeComponent();
        }

        private void AddEquipmentPage_Load(object sender, EventArgs e)
        {

            SqlConnection H = new SqlConnection(G.myConn);
            // TODO: This line of code loads data into the 'insightDataSet.EquipmentType' table. You can move, or remove it, as needed.
            this.equipmentTypeTableAdapter.Fill(this.insightDataSet.EquipmentType);

        }

        private void button184_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //If Quantity is 0, are you trying to add a new item?
        //If
        private void AEqNextBtn_Click(object sender, EventArgs e)
        {
            EqDescr = AEqDecripTb.Text;
            EqType = AEqTypeCmb.Text;
            //EqCondi = AEqConditionCmb.Text;
            EqQuantity = Convert.ToInt32(AEqQuantityUD.Value);

            if (EqDescr == "" || EqType == "" && EqQuantity == 0)
            {
                MessageBox.Show("Please enter valid values.");
            }
            else
            if (EqQuantity == 0)
            {
                MessageBox.Show(this, "Quantity is zero, Are you adding a new equipment item?", "New Equipment", MessageBoxButtons.YesNo);
                //Yes Condition: Add as new
                //No Condition: Message - Please enter a quantity
            }
            else
            {
                AEqDescripLbl.Text = EqDescr;
                AEqTypeLbl.Text = EqType;
                AEqQuantityLbl.Text = Convert.ToString(EqQuantity);
                AddEquipmentTab.SelectedIndex = 1;
            }
        }

        private void AEqConfirmBtn_Click(object sender, EventArgs e)
        {
            Equipment InsightEquipment = new Equipment();

            InsightEquipment.EquipmentDescription = EqDescr;
            InsightEquipment.EquipmentQuantity = EqQuantity;

            using (InsightEntities db = new InsightEntities())
            {
                var Ty = db.EquipmentTypes.SingleOrDefault(x => x.EquipmentTypeDescription == EqType);
                InsightEquipment.EquipmentTypeID = Ty.EquipmentTypeID;
                db.Equipments.Add(InsightEquipment);
                db.SaveChanges();
            }

                AddEquipmentTab.SelectedIndex = 2;
        }

        private void AEqBackBtn_Click(object sender, EventArgs e)
        {
            AddEquipmentTab.SelectedIndex = 0;
        }
    }
}
