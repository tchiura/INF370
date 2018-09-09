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
    public partial class ViewEquipmentPage : Form
    {
        private int EqID;

        public int GetEqID
        {
            get { return EqID; }
            set { EqID = value; }
        }

        public ViewEquipmentPage()
        {
            InitializeComponent();
        }

        private void button105_Click(object sender, EventArgs e)
        {
            Form UE = new UpdateEquipmentPage();
            UE.ShowDialog();
        }

        private void button104_Click(object sender, EventArgs e)
        {
            Form DE = new DeleteEquipmentPage();
            DE.ShowDialog();
            //MessageBox??
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form RE = new RemoveEquipmentPage();
            RE.ShowDialog();
        }

        private void button106_Click(object sender, EventArgs e)
        {

            int RID = EQDgv.CurrentCell.RowIndex;

            EqID = Convert.ToInt32(EQDgv.Rows[RID].Cells[0].Value.ToString());

            Console.WriteLine("EID" + EqID);
            Form AE = new AssignEquipmentPage();
            AE.ShowDialog();
        }

        private void button103_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewEquipmentPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insightDataSet.Equipment' table. You can move, or remove it, as needed.
            this.equipmentTableAdapter.Fill(this.insightDataSet.Equipment);

        }

        private void EQDgv_SelectionChanged(object sender, EventArgs e)
        {
            //int RID = EQDgv.CurrentCell.RowIndex;

            //EqID = Convert.ToInt32(EQDgv.Rows[RID].Cells["EquipmentID"].Value.ToString());
        }
    }
}
