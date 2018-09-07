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
    public partial class AddPhaseConfirmationPage : Form
    {

        string PhaseDescr = "";
        DateTime PhaseSDate;
        DateTime PhaseEDate;
        string PhaseTy = "";
        int ProjID = 0;
        string PhaseStat = "";
        public AddPhaseConfirmationPage()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ProjectPhase InsightProPhase = new ProjectPhase();

            InsightProPhase.ProjectPhaseDescription = PhaseDescr;
            InsightProPhase.ProjectPhaseEndDate = PhaseEDate;
            InsightProPhase.ProjectPhaseStartDate = PhaseSDate;
            InsightProPhase.ProjectID = ProjID;

            using (InsightEntities db = new InsightEntities())
            {
                var Ty = db.ProjectPhaseTypes.SingleOrDefault(x => x.ProjectPhaseTypeDescription == PhaseTy);
                var Stat = db.ProjectPhaseStatus.SingleOrDefault(x => x.ProjectPhaseStatusDescription == PhaseStat);
                InsightProPhase.ProjectPhaseTypeID = Ty.ProjectPhaseTypeID;
                InsightProPhase.ProjectPhaseStatusID = Stat.ProjectPhaseStatusID;

                db.ProjectPhases.Add(InsightProPhase);
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
