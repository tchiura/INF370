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
    public partial class DeleteEquipmentTypePage : Form
    {
        public DeleteEquipmentTypePage()
        {
            InitializeComponent();
        }

        private void DEqTCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DEqTDeleteBtn_Click(object sender, EventArgs e)
        {
            using(InsightEntities db = new InsightEntities())
            {
                var EqType = db.EquipmentTypes.SingleOrDefault(x => x.EquipmentTypeID == 2);

                if(EqType != null)
                {
                    db.EquipmentTypes.Remove(EqType);
                    db.SaveChanges();
                }
            }
        }
    }
}
