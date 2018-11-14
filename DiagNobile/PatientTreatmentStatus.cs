using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagNobile
{
    public partial class PatientTreatmentStatus : MetroFramework.Forms.MetroForm
    {
        private String idTretment;
        private String idPatient;
        private MyDiagNobileFunctions functions = new MyDiagNobileFunctions();
        public PatientTreatmentStatus(String idTretment, String idPatient)
        {
            InitializeComponent();
            this.idTretment = idTretment;
            this.idPatient = idPatient;
            String name = functions.GetPatientName(idPatient);
            metroLabel9.Text = idPatient;
            metroLabel11.Text = name;
            metroLabel13.Text = functions.GetReceptionTime(idTretment, "כללי");
            String status = functions.GetTreatmentStatus(idTretment);
            metroLabel15.Text = status;

            metroLabel17.Text = Convert.ToString(functions.GetTimeTreatmentSummery(idTretment, "כללי"));
            DateTime dateValue = DateTime.Now;
            metroLabel14.Text = Convert.ToString(functions.getExpectedCompletion(idTretment));
            metroLabel16.Text = "30 דקות";

            if (status.Equals("בהמתנה לאחות"))
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
            }
            else if (status.Equals("בדיקת אחות"))
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                viewTimeNurse();
            }
            else if (status.Equals("בהמתנה לרופא"))
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                viewTimeNurse();
            }
            else if (status.Equals("בדיקת רופא"))
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox4.Visible = false;
                viewTimeNurse();
                viewTimeDoctor();
            }
            else if (status.Equals("בהמתנה לבדיקות נוספות"))
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                viewTimeNurse();
                viewTimeDoctor();
            }
            else if (status.Equals("בהמתנה לרופא חוזר"))
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                viewTimeNurse();
                viewTimeDoctor();
            }
            else if (status.Equals("בדיקת רופא חוזר"))
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = true;
                viewTimeNurse();
                viewTimeDoctor();
                
            }
            else
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                viewTimeNurse();
                viewTimeDoctor();
                viewTimeDoctorRec();
            }
        }
        private void viewTimeNurse()
        {
            try
            {
                if (functions.CheckTimeValueExists(idTretment, "אחות"))
                {
                    DataTable dt = functions.GetTreatmentStatusData(idTretment, "אחות");
                    foreach (DataRow datarow in dt.Rows)
                    {
                        DateTime res = Convert.ToDateTime(datarow["Reception"]);
                        DateTime rel = Convert.ToDateTime(datarow["Release"]);
                        if (rel != null)
                        {
                            NurseActualTextBox.Text = Convert.ToString(datarow["actualDuration"]);
                            NurseSummaryTextBox.Text = getSummeryTest(functions.GetTimeTreatmentSummery(idTretment, "אחות"));
                        }
                        NurseStatusTextBox.Text = res.ToShortTimeString();
                        NurseEstimatedTextBox.Text = Convert.ToString(datarow["estimatedDuration"]);
                    }
                }
            }
            catch
            {

            }
            
        }
        private void viewTimeDoctor()
        {
            try
            {
                if (functions.CheckTimeValueExists(idTretment, "רופא"))
                {
                    DataTable dt = functions.GetTreatmentStatusData(idTretment, "רופא");
                    foreach (DataRow datarow in dt.Rows)
                    {
                        DateTime res = Convert.ToDateTime(datarow["Reception"]);
                        DateTime rel = Convert.ToDateTime(datarow["Release"]);
                        if (rel != null)
                        {
                            DoctorActualTextBox.Text = Convert.ToString(datarow["actualDuration"]);
                            DoctorSummaryTextBox.Text = getSummeryTest(functions.GetTimeTreatmentSummery(idTretment, "רופא"));
                        }
                        DoctorStatusTextBox.Text = res.ToShortTimeString();
                        DoctorEstimatedTextBox.Text = Convert.ToString(datarow["estimatedDuration"]);

                    }
                }
            }
            catch
            {

            }
            

        }
        private void viewTimeDoctorRec()
        {
            if (functions.CheckTimeValueExists(idTretment, "רופא חוזר"))
            {
                DataTable dt = functions.GetTreatmentStatusData(idTretment, "רופא חוזר");
                foreach (DataRow datarow in dt.Rows)
                {
                    DateTime res = Convert.ToDateTime(datarow["Reception"]);                    
                    DateTime rel = Convert.ToDateTime(datarow["Release"]);
                    if (rel != null)
                    {
                        DocFindActualTextBox.Text = Convert.ToString(datarow["actualDuration"]);
                        DocFindSummaryTextBox.Text = getSummeryTest(functions.GetTimeTreatmentSummery(idTretment, "רופא חוזר"));
                    }
                    DocFindStatusTextBox.Text = res.ToShortTimeString();
                    DocFindEstimatedTextBox.Text = Convert.ToString(datarow["estimatedDuration"]);

                }
            }

        }

        private String getSummeryTest(int e)
        {
            if (e == 0)
            {
                return "אין פער";
            }
            else if (e > 0)
            {
                return " עיכוב של"+Math.Abs(e) +" דקות" ;
            }
            else
            {
                return " חיסכון של" + Math.Abs(e) + " דקות";
            }
        }

        private void PatientTreatmentStatus_Load(object sender, EventArgs e)
        {
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoctorIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserEntry user = new UserEntry();
            user.Show();
        }

        private void NurseIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserEntry user = new UserEntry();
            user.Show();
        }

        

        private void PatientTreatmentStatus_Load_1(object sender, EventArgs e)
        {

        }
    }
}
