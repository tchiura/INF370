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
    public partial class DeleteEquipmentPage : Form
    {
        public DeleteEquipmentPage()
        {
            InitializeComponent();
        }

        private void DeleteEquipmentPage_Load(object sender, EventArgs e)
        {

        }

        private void QEqCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DEqBtn_Click(object sender, EventArgs e)
        {
            //Are we going to delete a certain quantity of of equipment or all of them?
            using (InsightEntities db = new InsightEntities())
            {
                var Eq = db.Equipments.SingleOrDefault(x => x.EquipmentID == 2);
                if(Eq != null)
                {
                    if(Eq.EquipmentQuantity > 0)
                    {
                        MessageBox.Show(this,"Are you sure you want to delete this equipment which still exist in the database","Warning",MessageBoxButtons.YesNo);

                        //if(Yes)
                        {
                            db.Equipments.Remove(Eq);
                            db.SaveChanges();
                        }
                        //else
                        //{
                        //    //Cannot delete
                        //}
                    }
                }
            }
        }
    }
}
