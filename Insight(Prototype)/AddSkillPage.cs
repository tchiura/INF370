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
    public partial class AddSkillPage : Form
    {
        string Skill = "";
        public AddSkillPage()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ASNextBtn_Click(object sender, EventArgs e)
        {

            Skill = SkillTb.Text;
            if (Skill == "")
            {
                MessageBox.Show("Please enter a valid Skill.");
            }
            else
            {
                ASConfirmLbl.Text = Skill;
                AddSkillTab.SelectedIndex = 1;
            }
        }

        private void ASCancelBtn_Click(object sender, EventArgs e)
        {
            Form Home = new HomeScreen();
            Home.Show();
            this.Show();
        }

        private void ASBackBtn_Click(object sender, EventArgs e)
        {
            AddSkillTab.SelectedIndex = 0;
        }

        private void ASConfirmBtn_Click(object sender, EventArgs e)
        {
            Skill InsightSkill = new Skill();

            InsightSkill.SkillDescription = Skill;

            using (InsightEntities db = new InsightEntities())
            {
                db.Skills.Add(InsightSkill);
                db.SaveChanges();
                AddSkillTab.SelectedIndex = 2;
            }
        }
    }
}
