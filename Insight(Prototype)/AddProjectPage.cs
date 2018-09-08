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
    public partial class AddProjectPage : Form
    {
        public AddProjectPage()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            Form A = new AddProjectConfirmationPage();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            Form A = new AddPhaseConfirmationPage();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form A = new AddJobConfirmationPage();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void AddProjectPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insightDataSet.JobType' table. You can move, or remove it, as needed.
            this.jobTypeTableAdapter.Fill(this.insightDataSet.JobType);
            // TODO: This line of code loads data into the 'insightDataSet.ProjectPhaseType' table. You can move, or remove it, as needed.
            this.projectPhaseTypeTableAdapter.Fill(this.insightDataSet.ProjectPhaseType);
            phasegb.Enabled = false;
            jobgp.Enabled = false;
        }

        private void ClosePicBx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int sectionCheck = 1;
        int phaseLoop = 0;
        int jobLoop = 0;
        int phaseLoopKeep = 0;
        private void button1_Click_1(object sender, EventArgs e)
        {
            int projectRequestID = 1006;        
            Project InsightProject = new Project();
            ProjectPhase InsightPhase = new ProjectPhase();
            Job InsightJob = new Job();
            bool check = true;

            if (sectionCheck == 1)
            {
                //InsightProject.ProjectDescription = projectDetail.Text;
                //InsightProject.ProjectStartDate = Convert.ToDateTime(startDate.Value.ToString("yyyy/MM/dd"));
                //InsightProject.ProjectEndDate = Convert.ToDateTime(endDate.Value.ToString("yyyy/MM/dd"));
                //InsightProject.ProjectStatusID = 1;
                //InsightProject.ProjectRequestID = projectRequestID;

                //using (InsightEntities db = new InsightEntities())
                //{
                //    db.Projects.Add(InsightProject);
                //    db.SaveChanges();
                //}
                sectionCheck++;
                phaseLoop = Convert.ToInt32(phasenum.Value);
                phasegb.Enabled = true;
            }

            int projectID = InsightProject.ProjectID;

            projectgb.Enabled = false;
            if (phaseLoop >= 0)
            {
                if (sectionCheck == 2)
                {
                    phasegb.Enabled = true;
                    jobgp.Enabled = false;
                    //InsightPhase.ProjectPhaseDescription = phaseDetail.Text;
                    //InsightPhase.ProjectPhaseStartDate = Convert.ToDateTime(phaseStart.Value.ToString("yyyy/MM/dd"));
                    //InsightPhase.ProjectPhaseStartDate = Convert.ToDateTime(phaseEnd.Value.ToString("yyyy/MM/dd"));
                    //InsightPhase.ProjectPhaseStatusID = 1;
                    //InsightPhase.ProjectID = projectID;

                    //using (InsightEntities db = new InsightEntities())
                    //{
                    //    db.ProjectPhases.Add(InsightPhase);
                    //    db.SaveChanges();
                    //}
                }

                if (phaseDetail.Text != "")//bool true
                {
                        sectionCheck++;
                        jobgp.Enabled = true;
                        phasegb.Enabled = false;

                    jobLoop = Convert.ToInt32(jobnum.Value);

                    if (jobLoop >= 0)
                    {
                        if (jobDetail.Text != "")//bool true
                        {
                            if (sectionCheck == 3)
                            {
                                //projectgb.Enabled = false;
                                //jobgp.Enabled = true;
                                //InsightJob.JobDescription = jobDetail.Text;
                                //InsightJob.JobStartDate = Convert.ToDateTime(jobStart.Value.ToString("yyyy/MM/dd"));
                                //InsightJob.JobEndDate = Convert.ToDateTime(jobEnd.Value.ToString("yyyy/MM/dd"));
                                //InsightJob.JobStatusID = 1;

                                //using (InsightEntities db = new InsightEntities())
                                //{
                                //    db.Jobs.Add(InsightJob);
                                //    db.SaveChanges();
                                //}
                                sectionCheck = 2;
                            }

                            if (phaseLoop != 0)
                            {
                                jobgp.Enabled = false;
                                phasegb.Enabled = true;
                            }
                            else
                            {
                                phasegb.Enabled = false;
                            }
                            jobDetail.Clear();
                            jobLoop--;
                            jobnumlbl.Text = jobLoop.ToString();
                        }
                    }
                    phaseLoop--;
                    phasenumlbl.Text = phaseLoop.ToString();
                }
            }
            if (phaseLoop == 0)
            {
                button1.Text = "Done";
            }
        }
    }
}
