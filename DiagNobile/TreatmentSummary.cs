using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace DiagNobile
{
    public partial class TreatmentSummary : MetroFramework.Forms.MetroForm
    {
        public String idPatient;
        public String idTreatment;
        public String userId;
        MyDiagNobileFunctions functions = new MyDiagNobileFunctions();
        public TreatmentSummary(String idPatient, String userId)
        {
            InitializeComponent();
            this.idPatient = idPatient;
            this.userId = userId;
            String perm = functions.GetPermission(userId);
            if (perm.Equals("אחות"))
            {
                metroButton13.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
            }
            else
            {
                metroButton13.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }
            DataTable tblAuthors = functions.GetAllPatientDetails(idPatient);
            ViewDetails(idPatient, tblAuthors);
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            String nowDate = DateTime.Now.ToString();
            //ViewFindings viewFindings = new ViewFindings(idTreatment, DiagnosisNameTextBox.Text);
        }


        //function to display details of patient
        private void ViewDetails(String idP, DataTable data)
        {
            DataTable tblAuthors = functions.GetAllPatientDetails(idPatient);
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10}",
                drCurrent["FirstName"].ToString(),
                drCurrent["LastName"].ToString(),
                drCurrent["DateBirth"].ToString(),
                drCurrent["ChronicDiseases"].ToString(),
                drCurrent["Sensitivity"].ToString(),
                drCurrent["TreatmentNum"].ToString(),
                drCurrent["NurseId"].ToString(),
                drCurrent["BodyTemperature"].ToString(),
                drCurrent["systolicBloodPressuree"].ToString(),
                drCurrent["diastolicBloodPressuree"].ToString(),
                drCurrent["pulse"].ToString());
            }
            Console.ReadLine();
            String firstName = Convert.ToString(tblAuthors.Rows[0]["FirstName"]);
            String lastName = Convert.ToString(tblAuthors.Rows[0]["LastName"]);
            String DateBirth = Convert.ToString(tblAuthors.Rows[0]["DateBirth"]);
            String chronicDiseases = Convert.ToString(tblAuthors.Rows[0]["ChronicDiseases"]);
            String sensitivity = Convert.ToString(tblAuthors.Rows[0]["Sensitivity"]);
            String age = functions.GetAge(idPatient);
            String treatmentNum = Convert.ToString(tblAuthors.Rows[0]["TreatmentNum"]);
            String NurseId = Convert.ToString(tblAuthors.Rows[0]["NurseId"]);
            String bodyTemperature = Convert.ToString(tblAuthors.Rows[0]["BodyTemperature"]);
            String systolicBloodPressuree = Convert.ToString(tblAuthors.Rows[0]["systolicBloodPressuree"]);
            String diastolicBloodPressuree = Convert.ToString(tblAuthors.Rows[0]["diastolicBloodPressuree"]);
            String pulse = Convert.ToString(tblAuthors.Rows[0]["pulse"]);


            metroTextBox7.Text = idPatient;
            metroTextBox5.Text = firstName;
            metroTextBox4.Text = lastName;
            metroTextBox2.Text = chronicDiseases;
            metroTextBox1.Text = sensitivity;
            idTreatment = treatmentNum;
            if (functions.GetTreatmentStatus(idTreatment).Equals("בהמתנה לרופא חוזר"))
            {
                functions.InsertTimeValue(idTreatment,"רופא חוזר");
                functions.UpdateTreatmentStatus(idTreatment, "בדיקת רופא חוזר");
            }

            NurseNameTextBox.Text = functions.GetNameUser(NurseId);
            TemperatureTextBox.Text = bodyTemperature;
            SystolicTextBox.Text = systolicBloodPressuree;
            DiastolicTextBox.Text = diastolicBloodPressuree;
            PulseTextBox.Text = pulse;
            DOB.Text = DateBirth;
            metroTextBox3.Text = age;
            ViewSymptoms();
            if (functions.GetPrimaryDiagnosisId(idTreatment).Length != 0)
            {
                DiagnosisNameTextBox.Text = functions.GetNameDiagnosis(functions.GetPrimaryDiagnosisId(idTreatment));
            }
            if (functions.CheckDiagnosisSecondaryExistsForPatients(idTreatment))
            {
                metroTextBox8.Text = functions.GetNameDiagnosis(functions.GetSecondaryDiagnosisId(idTreatment));
            }
            if (functions.CheckPatientMedicinesExists(idPatient))
            {
                DataTable td = functions.GetPatientMedications(idPatient);
                foreach (DataRow datarow in td.Rows)
                {
                    String name = functions.GetNameMedication(Convert.ToString(datarow["MedicationNum"]));
                    var item1 = new ListViewItem(new[] { name, Convert.ToString(datarow["Dosage"]) });
                    metroListView5.Items.Add(item1);
                }
            }
            if (functions.CheckTreatmentsTestTrackingExists(idTreatment))
            {
                DataTable td = functions.GetTreatmentsTestTracking(idTreatment);
                foreach (DataRow datarow in td.Rows)
                {
                    String name = functions.GetNameTest(Convert.ToString(datarow["TestNum"]));
                    var item1 = new ListViewItem(new[] { name, Convert.ToString(datarow["Frequency"]) });
                    metroListView2.Items.Add(item1);
                }
            }
            if (functions.CheckTestsTreatmentsExists(idTreatment))
            {
                DataTable td = functions.GetTestsTreatments(idTreatment, functions.GetPrimaryDiagnosisId(idTreatment));
                foreach (DataRow datarow in td.Rows)
                {
                    String name = functions.GetNameTest(Convert.ToString(datarow["TestNum"]));
                    String type = Convert.ToString(datarow["type"]).ToString().Trim();
                    var item1 = new ListViewItem(new[] { name, Convert.ToString(datarow["TestNum"]) });

                    if (type.Equals("דימות"))
                    {
                        metroListView1.Items.Add(item1);
                    }
                    if (type.Equals("בדיקות"))
                    {
                        metroListView4.Items.Add(item1);
                    }
                    if (type.Equals("התערבות"))
                    {
                        metroListView3.Items.Add(item1);
                    }
                }
                if (functions.CheckDiagnosisSecondaryExistsForPatients(idTreatment))
                {
                    DataTable td1 = functions.GetTestsTreatments(idTreatment, functions.GetSecondaryDiagnosisId(idTreatment));
                    foreach (DataRow datarow in td1.Rows)
                    {
                        String name = functions.GetNameTest(Convert.ToString(datarow["TestNum"]));
                        String type = Convert.ToString(datarow["type"]).ToString().Trim();
                        var item1 = new ListViewItem(new[] { name, Convert.ToString(datarow["TestNum"]) });

                        if (type.Equals("דימות"))
                        {
                            metroListView1.Items.Add(item1);
                        }
                        if (type.Equals("בדיקות"))
                        {
                            metroListView4.Items.Add(item1);
                        }
                        if (type.Equals("התערבות"))
                        {
                            metroListView3.Items.Add(item1);
                        }
                    }
                }
                
            }
        }

        //function to view symptoms of patient
        private void ViewSymptoms()
        {
            DataTable dt = functions.GetAllSymptomsByTreatment(idTreatment);
            foreach (DataRow datarow in dt.Rows)
            {
                int n = metroGrid1.Rows.Add();
                metroGrid1.Rows[n].Cells[0].Value = functions.GetSymptomName(Convert.ToString(datarow["SymptomNum"]));
                metroGrid1.Rows[n].Cells[1].Value = Convert.ToString(datarow["side"]);
                metroGrid1.Rows[n].Cells[2].Value = Convert.ToString(datarow["type"]);
            }
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            DiagnosticPatientSummary diagnostic = new DiagnosticPatientSummary(idTreatment, DiagnosisNameTextBox.Text);
            diagnostic.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            DiagnosticPatientSummary diagnostic = new DiagnosticPatientSummary(idTreatment, metroTextBox8.Text);
            diagnostic.Show();
        }

        private void metroButton13_Click(object sender, EventArgs e)
        {
            if (metroPanel1.Visible == true)
            {
                metroPanel1.Visible = false;
                metroPanel1.SendToBack();
            }
            else
            {
                metroPanel1.Visible = true;
                metroPanel1.BringToFront();
                if (functions.CheckTimeValueExists(idTreatment, "כללי")){
                    metroTextBox11.Text = functions.GetReceptionTime(idTreatment, "כללי");
                }              
                metroTextBox6.Text = Convert.ToString(functions.getExpectedCompletion(idTreatment)) + " דקות";

            }
        }

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

        private void NurseIcon_Click(object sender, EventArgs e)
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

        private void ShowHoverText(object sender, EventArgs e)
        {
            if (pictureBox4.Visible == true)
            {
                ToolTip tt = new ToolTip();
                tt.SetToolTip(this.pictureBox4, "החלף משתמש");
            }
            else if (pictureBox5.Visible == true)
            {
                ToolTip ttt = new ToolTip();
                ttt.SetToolTip(this.pictureBox5, "החלף משתמש");
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            CloseTreatmentProcess close = new CloseTreatmentProcess(idTreatment,idPatient);
            close.Show();
        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            if (functions.GetTreatmentStatus(idTreatment).Equals("בדיקת רופא"))
            {
                functions.UpdateTimeValue(idTreatment, "רופא");
                functions.UpdateTreatmentStatus(idTreatment, "בהמתנה לבדיקות נוספות");
            }
            else if (functions.GetTreatmentStatus(idTreatment).Equals("בדיקת רופא חוזר"))
            {
                functions.UpdateTimeValue(idTreatment, "רופא חוזר");
                functions.DeletePatientFromListDoctor(idPatient);
            }
            PatientsList list = new PatientsList(userId);
            this.Close();
            list.Show();
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            if (functions.GetTreatmentStatus(idTreatment).Equals("בדיקת רופא חוזר"))
            {
                functions.UpdateTimeValue(idTreatment, "רופא חוזר");
            }
            else
            {
                functions.UpdateTimeValue(idTreatment, "רופא");

            }
            CloseTreatmentProcess close = new CloseTreatmentProcess(idTreatment,idPatient);
            this.Close();
            close.Show();
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            PatientTreatmentStatus patientTreatmentStatus = new PatientTreatmentStatus(idTreatment, idPatient);
            patientTreatmentStatus.Show();
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            PatientMedicalRecord record = new PatientMedicalRecord(idPatient, userId);
            record.Show();
        }

        private void TreatmentSummary_Load(object sender, EventArgs e)
        {
           metroLabel10.Text = DateTime.Now.ToShortDateString();
           metroLabel11.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
