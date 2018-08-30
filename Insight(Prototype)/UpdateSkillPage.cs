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
    public partial class UpdateSkillPage : Form
    {
        string USkill = "";
        int SkillID;
        public UpdateSkillPage()
        {
            InitializeComponent();
        }

        private void label58_Click(object sender, EventArgs e)
        {

        }

        private void USCancelBtn_Click(object sender, EventArgs e)
        {
            Form Home = new HomeScreen();
            Home.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            USLbl.Hide();
            USTb.Show();
            this.Hide();
        }

        private void USUpdateBtn_Click(object sender, EventArgs e)
        {
            USkill = USTb.Text;
            if(USkill == "")
            {
                MessageBox.Show("Please enter a valid Skill.");
            }
            else
            {
                USConfirmLbl.Text = USkill;
                UpdateSkillTab.SelectedIndex = 1;
            }
        }

        private void USBackBtn_Click(object sender, EventArgs e)
        {
            UpdateSkillTab.SelectedIndex = 0;
        }

        private void USConfirmBtn_Click(object sender, EventArgs e)
        {
            Skill InsightSkill = new Skill();

            InsightSkill.SkillID = SkillID;
            InsightSkill.SkillDescription = USkill;

            using(InsightEntities db = new InsightEntities())
            {
               
            }
        }
    }
}
