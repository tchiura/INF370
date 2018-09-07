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
        string EquipType = "";
        public AddEquipmentTypePage()
        {
            InitializeComponent();
        }

        private void AEqTCancelBtn_Click(object sender, EventArgs e)
        {
            Form Home = new HomeScreen();
            Home.Show();
            this.Close();
        }

        private void AEqTNextBtn_Click(object sender, EventArgs e)
        {
            EquipType = AEqTypeTb.Text;
            if (EquipType == "")
            {
                MessageBox.Show("Please enter a valid Equipment Type.");
            }
            else
            {
                AEqTConfirmLbl.Text = EquipType;
                AddEquipmentTypeTab.SelectedIndex = 1;
            }
        }

        private void AEqTBackBtn_Click(object sender, EventArgs e)
        {
            AddEquipmentTypeTab.SelectedIndex = 0;
        }

        private void AEqTConfirmBtn_Click(object sender, EventArgs e)
        {
            EquipmentType InsightEquipType = new EquipmentType();

            InsightEquipType.EquipmentTypeDescription = EquipType;

            using (InsightEntities db = new InsightEntities())
            {
                db.EquipmentTypes.Add(InsightEquipType);
                db.SaveChanges();
            }

            AddEquipmentTypeTab.SelectedIndex = 2;
        }
    }
}
