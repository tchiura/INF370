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
    public partial class RemoveEquipmentPage : Form
    {
        int EqID;
        string ECond = "";
        public RemoveEquipmentPage()
        {
            InitializeComponent();
        }

        private void QEqCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DEqBtn_Click(object sender, EventArgs e)
        {
            ECond = CondTb.Text;

            if (ECond != "")
            {
                RemovedEquipment InsightREq = new RemovedEquipment();

                using (InsightEntities db = new InsightEntities())
                {
                    var Eq = db.Equipments.SingleOrDefault(x => x.EquipmentID == EqID);
                    InsightREq.EquipmentID = Eq.EquipmentID;
                    InsightREq.RemovedEquipmenedDescription = Eq.EquipmentDescription;
                    InsightREq.RemovedEquipmentCondition = ECond;
                    Eq.EquipmentQuantity = Eq.EquipmentQuantity - 1;
                    db.RemovedEquipments.Add(InsightREq);
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid condition/reason for removal");
            }
        }
    }
}
