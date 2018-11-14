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
    public partial class PatientsList : MetroFramework.Forms.MetroForm
    {
        String UserId;
        String Perm;
        MyDiagNobileFunctions functions = new MyDiagNobileFunctions();


        public PatientsList(String userId)
        {
            InitializeComponent();
            UserId = userId;
            Perm = functions.GetPermission(UserId);

            //check if the current user is nurse than show icon nurse and check patient button will show check patient
            if (Perm.Equals("אחות"))
            {
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                checkPatientButton.Text = "בדיקת מטופל";
            }
            else
            {
                //the current user is doctor than show doctor icon and check patient button will show patient diagnosis
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                metroButton1.Visible = true;
                metroButton3.Visible = true;
                checkPatientButton.Text = "אבחון מטופל";
            }
            viewPatients();
        }

        private void PatientsList_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToShortDateString();
            TimeLabel.Text = DateTime.Now.ToShortTimeString();
        }

        //click on doctor icon will close all open forms and open user entry form to change user
        private void DoctorIcon_Click(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();
            foreach (Form f in Application.OpenForms)
                openForms.Add(f);
            foreach (Form f in openForms)
            {
                if (f.Name != "UserEntry")
                    f.Close();
            }
            UserEntry user = new UserEntry();
            user.Show();
        }


        //function to change user from nurse to different user 
        private void NurseIcon_Click(object sender, EventArgs e)
        {
            //closing all forms that open
            List<Form> openForms = new List<Form>();
            foreach (Form f in Application.OpenForms)
                openForms.Add(f);
            foreach (Form f in openForms)
            {
                if (f.Name != "UserEntry")
                    f.Close();
            }
            UserEntry user = new UserEntry();
            user.Show();
            
        }

        //show text when hover on change user icon
        private void ShowHoverText(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                ToolTip tt = new ToolTip();
                tt.SetToolTip(this.pictureBox1, "החלף משתמש");

            }
            else if (pictureBox2.Visible == true)
            {
                ToolTip ttt = new ToolTip();
                ttt.SetToolTip(this.pictureBox2, "החלף משתמש");

            }
        }

        //function to view patients of current user
        private void viewPatients()
        {
            //patients of nurse
            DataTable dt;
            if (Perm.Equals("אחות"))
            {
                dt = functions.GetPatientsNurse();
                foreach (DataRow datarow in dt.Rows)
                {
                    String status = Convert.ToString(datarow["TreatmentStatus"]).ToString().Trim();
                    if (status.Equals("בהמתנה לאחות") || status.Equals("בהמתנה לבדיקות נוספות") || status.Equals("בדיקת אחות")){
                        int n = PatientsListGrid.Rows.Add();
                        PatientsListGrid.Rows[n].Cells[0].Value = Convert.ToString(datarow["Nun"]);
                        PatientsListGrid.Rows[n].Cells[1].Value = Convert.ToString(datarow["id"]);
                        PatientsListGrid.Rows[n].Cells[2].Value = functions.GetPatientName(Convert.ToString(datarow["id"]));
                    }                    
                }
            }
            else
            {
                //patients of doctor
                dt = functions.GetPatientsDoctor();
                foreach (DataRow datarow in dt.Rows)
                {
                    int n = PatientsListGrid.Rows.Add();
                    PatientsListGrid.Rows[n].Cells[0].Value = Convert.ToString(datarow["num"]);
                    PatientsListGrid.Rows[n].Cells[1].Value = Convert.ToString(datarow["PatientId"]);
                    PatientsListGrid.Rows[n].Cells[2].Value = functions.GetPatientName(Convert.ToString(datarow["PatientId"]));
                }
            }
            
        }

        //function to open new treatment process
        private void checkPatientButton_Click(object sender, EventArgs e)
        {
            String numQ = PatientsListGrid.SelectedRows[0].Cells[0].Value.ToString();
            String id = PatientsListGrid.SelectedRows[0].Cells[1].Value.ToString();
            //if current user is nurse than open treatment process
            if (Perm.Equals("אחות"))
            {
                this.Close();
                OpenTreatmentProcess open = new OpenTreatmentProcess(UserId, id, numQ);
                open.Show();
            }
            else
            {
                //if current user is doctor, open patient diagnosis form
                this.Close();
                PatientDiagnosis patientDiagnosis = new PatientDiagnosis(UserId, id);
                patientDiagnosis.Show();

            }
        }

        //function to open follow up entry
        private void metroButton1_Click(object sender, EventArgs e)
        {
            String id = PatientsListGrid.SelectedRows[0].Cells[1].Value.ToString();
            String idTreatment = functions.GetTreatmentNum(id);
            //if the patient have diagnosis than open follow up entry
            if (functions.CheckTimeValueExists(idTreatment, "רופא"))
            {                
                FollowUpEntry follow = new FollowUpEntry(idTreatment);
                this.Close();
                follow.Show();
            }
            else
            {
                //the patient dont have diagnosis
                MessageBox.Show("אין יכולת לעבור להמשך טיפול ללא בדיקת אבחון");
            }
           
        }

        //function to open treatment summary
        private void metroButton2_Click(object sender, EventArgs e)
        {
            String id = PatientsListGrid.SelectedRows[0].Cells[1].Value.ToString();
            String idTreatment = functions.GetTreatmentNum(id);
            TreatmentSummary close = new TreatmentSummary(id,UserId);
            this.Close();
            close.Show();
        }

        //function to open patient release form
        private void metroButton3_Click(object sender, EventArgs e)
        {
            String id = PatientsListGrid.SelectedRows[0].Cells[1].Value.ToString();
            String idTreatment = functions.GetTreatmentNum(id);
            //if the patient have diagnosis than open patient release
            if (functions.CheckTimeValueExists(idTreatment, "רופא"))
            {
                CloseTreatmentProcess close = new CloseTreatmentProcess(idTreatment, id);
                this.Close();
                close.Show();
            }
            else
            {
                //the patient dont have diagnosis
                MessageBox.Show("אין יכולת לעבור לשחרור ללא בדיקת אבחון");
            }
        }
    }
}
