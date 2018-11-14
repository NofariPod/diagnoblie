using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DiagNobile
{
    public partial class PatientDiagnosis : MetroFramework.Forms.MetroForm
    {

        private String idDoctor;
        private String idPatient;
        private MyDiagNobileFunctions functions = new MyDiagNobileFunctions();
        private String idTreatment;

        public PatientDiagnosis(String idD, String idP)
        {
            InitializeComponent();
            idDoctor = idD;
            idPatient = idP;
            ShowDetailsPatient();
            idTreatment = functions.GetTreatmentNum(idPatient);
            String TreatmentStatus = functions.GetTreatmentStatus(idTreatment);
            if (TreatmentStatus.Equals("בהמתנה לבדיקות נוספות"))
            {
                if (!functions.CheckTimeValueExists(idTreatment, "רופא חוזר"))
                {
                    functions.InsertTimeValue(idTreatment, "רופא חוזר");
                }
                functions.UpdateTreatmentStatus(idTreatment, "בדיקת רופא חוזר");
            }
            else
            {
                if (!functions.CheckTimeValueExists(idTreatment, "רופא"))
                {
                    functions.InsertTimeValue(idTreatment, "רופא");
                }
                functions.UpdateTreatmentStatus(idTreatment, "בדיקת רופא");
            }

        }

        private void PatientDiagnosis_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToShortDateString();
            TimeLabel.Text = DateTime.Now.ToShortTimeString();
        }

        //function to display patient details
        private void ShowDetailsPatient()
        {
            DataTable tblAuthors = functions.GetAllPatientDetails(idPatient);
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12}",
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
                drCurrent["pulse"].ToString(),
                drCurrent["PrimaryDiagnosisId"].ToString(),
                drCurrent["SecondaryDiagnosisId"].ToString());
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
            String primaryDiagnosisId = Convert.ToString(tblAuthors.Rows[0]["PrimaryDiagnosisId"]);
            String secondaryDiagnosisId = Convert.ToString(tblAuthors.Rows[0]["SecondaryDiagnosisId"]);



            IdTextBox.Text = idPatient;
            FirstNameTextBox.Text = firstName;
            LastNameTextBox.Text = lastName;
            ChronicDiseasesTextBox.Text = chronicDiseases;
            SensitivityTextBox.Text = sensitivity;
            idTreatment = treatmentNum;
            NurseNameTextBox.Text = functions.GetNameUser(NurseId);
            TemperatureTextBox.Text = bodyTemperature;
            SystolicTextBox.Text = systolicBloodPressuree;
            DiastolicTextBox.Text = diastolicBloodPressuree;
            PulseTextBox.Text = pulse;
            DOB.Text = DateBirth;
            AgeTextBox.Text = age;
            ViewSymptoms();
            ViewDiagnosis();
            if (primaryDiagnosisId.Length != 0)
            {
                metroComboBox1.PromptText =functions.GetNameDiagnosis(primaryDiagnosisId);
            }
            if (secondaryDiagnosisId.Length != 0)
            {
                metroComboBox2.PromptText = functions.GetNameDiagnosis(secondaryDiagnosisId);
            }
        }

        //function to display all symptoms of patient
        private void ViewSymptoms()
        {
            DataTable dt = functions.GetAllSymptomsByTreatment(idTreatment);
            foreach (DataRow datarow in dt.Rows)
            {
                int n = metroGrid1.Rows.Add();
                metroGrid1.Rows[n].Cells[0].Value = functions.GetSymptomName(Convert.ToString(datarow["SymptomNum"]));
                metroGrid1.Rows[n].Cells[1].Value = Convert.ToString(datarow["type"]);
                metroGrid1.Rows[n].Cells[2].Value = Convert.ToString(datarow["side"]);
            }
        }

        //function to display the diagnosis of patient
        private void ViewDiagnosis()
        {
            DataTable dt = functions.GetAllDiagnosis();
            foreach (DataRow datarow in dt.Rows)
            {
                metroComboBox1.Items.Add(Convert.ToString(datarow["name"]));
                metroComboBox2.Items.Add(Convert.ToString(datarow["name"]));
            }
        }

        //choose diagnosis from list
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (functions.CheckDiagnosisPrimaryExistsForPatients(idTreatment))
            {
                if (functions.CheckDiagnosisSecondaryExistsForPatients(idTreatment))
                {
                    DiagnosticTest diagnosticTest = new DiagnosticTest(idTreatment, metroComboBox1.PromptText);
                    diagnosticTest.Show();
                    this.Close();
                }
                else
                {
                    DialogResult dialog = MessageBox.Show(" להמשיך לבדיקה ללא הזנת אבחנה מבדלת לחץ אישור להזנת אבחנה מבדלת לחץ ביטול", "לא הוזנה אבחנה מבדלת", MessageBoxButtons.OKCancel);
                    if (dialog == DialogResult.OK)
                    {

                        DiagnosticTest diagnosticTest = new DiagnosticTest(idTreatment, metroComboBox1.PromptText);
                        diagnosticTest.Show();
                        this.Close();
                    }
                }
                    
                
            }
            else
            {
                if (metroComboBox1.Text.Length == 0)
                {
                    MessageBox.Show(" לא נבחרה אבחנה רפואית");
                }
                else
                {
                    functions.SaveDiagnosisPrimary(idTreatment, metroComboBox1.Text);
                    if (metroComboBox2.SelectedIndex != -1)
                    {
                        functions.SaveDiagnosisSecondary(idTreatment, metroComboBox2.Text);
                        DiagnosticTest diagnosticTest = new DiagnosticTest(idTreatment, metroComboBox1.Text);
                        diagnosticTest.Show();
                        this.Close();

                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show(" להמשיך לבדיקה ללא הזנת אבחנה מבדלת לחץ אישור להזנת אבחנה מבדלת לחץ ביטול", "לא הוזנה אבחנה מבדלת", MessageBoxButtons.OKCancel);
                        if (dialog == DialogResult.OK)
                        {

                            DiagnosticTest diagnosticTest = new DiagnosticTest(idTreatment, metroComboBox1.Text);
                            diagnosticTest.Show();
                            this.Close();
                        }

                    }
                }
            
                
            }
        }

        //function to update initial findings
        private void UpdateInitialFindingsButton_Click(object sender, EventArgs e)
        {
            if (TemperatureTextBox.Text.Length == 0)
            {
                MessageBox.Show("לא הוזנה טמפרטורת גוף");
            }
            else if (SystolicTextBox.Text.Length == 0)
            {
                MessageBox.Show("לא הוזן לחץ דם סיסטולי");
            }
            else if (DiastolicTextBox.Text.Length == 0)
            {
                MessageBox.Show("לא הוזן לחץ דם דיאסטולי");
            }
            else if (PulseTextBox.Text.Length == 0)
            {
                MessageBox.Show("לא הוזן דופק");
            }
            else
            {
                functions.UpdateInitialFindings(TemperatureTextBox.Text, SystolicTextBox.Text, DiastolicTextBox.Text, PulseTextBox.Text, idTreatment);
                MessageBox.Show("הסימנים עודכנו בהצלחה");
            }

        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            if (metroPanel1.Visible == true)
            {
                metroPanel1.Visible = false;
            }
            else
            {
                metroPanel1.Visible = true;
                if (functions.CheckTimeValueExists(idTreatment, "כללי"))
                {
                    metroTextBox4.Text = functions.GetReceptionTime(idTreatment, "כללי");
                }
                DateTime dateValue = DateTime.Now;               
                metroTextBox3.Text = Convert.ToString(functions.getExpectedCompletion(idTreatment)) + " דקות";
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
            this.Hide();
            UserEntry user = new UserEntry();
            user.Show();
        }

        private void ShowHoverText(object sender, EventArgs e)
        {
            ToolTip ttt = new ToolTip();
            ttt.SetToolTip(this.pictureBox5, "החלף משתמש");
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            PatientMedicalRecord patient = new PatientMedicalRecord(idPatient,idDoctor);
            patient.Show();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            PatientTreatmentStatus patientTreatmentStatus = new PatientTreatmentStatus(idTreatment, idPatient);
            patientTreatmentStatus.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (functions.CheckDiagnosisPrimaryExistsForPatients(idTreatment))
            {
                if (functions.CheckDiagnosisSecondaryExistsForPatients(idTreatment))
                {
                    DiagnosticTest diagnosticTest = new DiagnosticTest(idTreatment, metroComboBox2.PromptText);
                    diagnosticTest.Show();
                    this.Close();
                }
                else
                {
                    if (metroComboBox2.Text.Length == 0)
                    {
                        MessageBox.Show(" לא נבחרה אבחנה רפואית");
                    }
                    else
                    {
                        DiagnosticTest diagnosticTest = new DiagnosticTest(idTreatment, metroComboBox2.Text);
                        diagnosticTest.Show();
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("לא נבחרה אבחנה עיקרית");
            }
        }
    }
}

