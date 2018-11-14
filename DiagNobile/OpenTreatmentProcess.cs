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
using System.Collections;

namespace DiagNobile
{
    public partial class OpenTreatmentProcess : MetroFramework.Forms.MetroForm
    {
        private String idPatient;
        private String idNurse;
        private String idTreatment;
        private String numQ;

        private MyDiagNobileFunctions functions = new MyDiagNobileFunctions();
                public OpenTreatmentProcess(String idN, String idP, String numQue)
        {
            InitializeComponent();
            CheckedListBoxSymptoms_view();
            idNurse = idN;
            idPatient = idP;
            numQ = numQue;
            ViewPatientDetails();

        }

        //function to display patient details
        private void ViewPatientDetails()
        {
            DataTable tblAuthors = functions.GetFirstPatientDetails(idPatient);
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0} {1} {2} {3}",
                drCurrent["FirstName"].ToString(),
                drCurrent["LastName"].ToString(),
                drCurrent["ChronicDiseases"].ToString(),
                drCurrent["Sensitivity"].ToString());


            }
            Console.ReadLine();
            String firstName = Convert.ToString(tblAuthors.Rows[0]["FirstName"]);
            String lastName = Convert.ToString(tblAuthors.Rows[0]["LastName"]);
            String chronicDiseases = Convert.ToString(tblAuthors.Rows[0]["ChronicDiseases"]);
            String sensitivity = Convert.ToString(tblAuthors.Rows[0]["Sensitivity"]);
            String age = functions.GetAge(idPatient);

            PatientIdInput.Text = idPatient;
            PatientFullNameTextBox.Text = firstName + " " + lastName;
            AgeTextBox.Text = age;
            EnterChronicDieseasTextBox.Text = chronicDiseases;
            InsertSensitivityTextBox.Text = sensitivity;
            idTreatment = functions.GetTreatmentNum(idPatient);
            ViewTreatmentDetails();
            if (!functions.CheckTimeValueExists(idTreatment, "אחות"))
            {
                functions.InsertTimeValue(idTreatment, "אחות");
            }
            if (functions.GetTreatmentStatus(idTreatment).Equals("בהמתנה לאחות"))
            {
                functions.UpdateTreatmentStatus(idTreatment, "בדיקת אחות");
            }
            if (functions.CheckExsistSymptomsTretmentInsert(idTreatment))
            {
                ViewComplains();
            }
            DataTable dt = functions.GetAllDcotors();
            foreach (DataRow datarow in dt.Rows)
            {
                metroComboBox1.Items.Add(datarow["LastName"]);
            }
        }

        //function to see details of treatment
        private void ViewTreatmentDetails()
        {
            DataTable tblAuthors = functions.GetTreatmentDetails(idTreatment);
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0} {1} {2} {3}",
                drCurrent["BodyTemperature"].ToString(),
                drCurrent["systolicBloodPressuree"].ToString(),
                 drCurrent["diastolicBloodPressuree"].ToString(),
                drCurrent["pulse"].ToString());
            }
            Console.ReadLine();
            String BodyTemperature = Convert.ToString(tblAuthors.Rows[0]["BodyTemperature"]);
            String systolicBloodPressuree = Convert.ToString(tblAuthors.Rows[0]["systolicBloodPressuree"]);
            String diastolicBloodPressuree = Convert.ToString(tblAuthors.Rows[0]["diastolicBloodPressuree"]);
            String pulse = Convert.ToString(tblAuthors.Rows[0]["pulse"]);

            TemperatureTextBox.Text = BodyTemperature;
            BloodPressureTextBox.Text = systolicBloodPressuree;
            metroTextBox1.Text = diastolicBloodPressuree;
            PulseTextBox.Text = pulse;
            ViewComplains();
        }
        private void EndButton_Click(object sender, EventArgs e)
        {
            if (functions.GetTreatmentStatus(idTreatment).Equals("בהמתנה לבדיקות נוספות"))
            {
                if (!functions.CheckPatientExistsInListDoctor(idPatient))
                {
                    functions.InsertPatientsForTretmentDoctor(idPatient, numQ);
                }
                functions.UpdateTreatmentStatus(idTreatment, "בהמתנה לרופא חוזר");
                PatientsList list = new PatientsList(idNurse);
                list.Show();
                this.Close();             

            }
            else
            {
                if (!functions.CheckedTreatmentDoctorExists(idTreatment))
                {
                    if (metroComboBox1.Text.Length == 0)
                    {
                        MessageBox.Show("לא התבצע שיוך לרופא");
                    }
                    else
                    {
                        String id = functions.GetIdUserByLastName(metroComboBox1.Text);
                        functions.UpdateTreatmentDoctor(idTreatment, id);
                        MessageBox.Show(" המטופל שויך בהצלחה לדוקטור " + metroComboBox1.Text);

                        PatientsList list = new PatientsList(idNurse);
                        this.Hide();
                        list.Show();
                    }
                }

                if (functions.CheckTimeValueExists(idTreatment, "אחות"))
                {
                    functions.UpdateTimeValue(idTreatment, "אחות");
                }
                if (!functions.CheckPatientExistsInListDoctor(idPatient))
                {
                    functions.InsertPatientsForTretmentDoctor(idPatient, numQ);
                }
                if (functions.GetTreatmentStatus(idTreatment).Equals("בדיקת אחות"))
                {
                    functions.UpdateTreatmentStatus(idTreatment, "בהמתנה לרופא");
                }
            }           

        }

        private void OpenTreatmentProcess_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToShortDateString();
            TimeLabel.Text = DateTime.Now.ToShortTimeString();

        }
        //get all symptoms in list
        private void CheckedListBoxSymptoms_view()
        {
            DataTable dt = functions.GetAllSymptoms();
            foreach (DataRow datarow in dt.Rows)
            {
                CheckedSymptomsListBox.Items.Add(datarow["SymptomDescription"]);
            }
        }

        private void PatientIdLabel_Click(object sender, EventArgs e)
        {
            //לייבל של תעודת זהות המטופל
        }
        /**
        private void UpdateTreatmentData_Click(object sender, EventArgs e)
        {
            functions.UpdateTreatmentData(TemperatureTextBox.Text, BloodPressureTextBox.Text, PulseTextBox.Text, idTreatment);
            
        }
        
        private void UpdateSymptomsButton_Click(object sender, EventArgs e)
        {
            //כפתור עדכן סימפטומים
            foreach (object itemChecked in CheckedSymptomsListBox.CheckedItems)
            {
                string symptomName = (String)itemChecked;
                functions.InsertNewSymptomByTreatment(symptomName, idTreatment);
            }
        }
    **/

        //function to update initial findings
        private void UpdateInitialFindingsButton_Click(object sender, EventArgs e)
        {
            if (TemperatureTextBox.Text.Length == 0)
            {
                MessageBox.Show("לא הוזנה טמפרטורת גוף");
            }
            else if (BloodPressureTextBox.Text.Length == 0)
            {
                MessageBox.Show("לא הוזן לחץ דם סיסטולי");
            }
            else if (metroTextBox1.Text.Length == 0)
            {
                MessageBox.Show("לא הוזן לחץ דם דיאסטולי");
            }
            else if (PulseTextBox.Text.Length == 0)
            {
                MessageBox.Show("לא הוזן דופק");
            }
            else
            {
                functions.UpdateInitialFindings(TemperatureTextBox.Text, BloodPressureTextBox.Text, metroTextBox1.Text, PulseTextBox.Text, idTreatment);
                MessageBox.Show("הסימנים עודכנו בהצלחה");
            }
        }

        //כפתור עדכן רגישויות
        private void UpdateSensitivityButton_Click(object sender, EventArgs e)
        {
            if (InsertSensitivityTextBox.Text.Length == 0)
            {
                MessageBox.Show("לא הוזנה רגישות");

            }
            else
            {
            functions.UpdateSensitivity(InsertSensitivityTextBox.Text, idPatient);
                MessageBox.Show("הרגישות עודכנה בהצלחה");

            }
        }
        //כפתור עדכן מחלות כרוניות
        private void UpdateChronicDiseasesButton_Click(object sender, EventArgs e)
        {
            if (EnterChronicDieseasTextBox.Text.Length == 0)
            {
                MessageBox.Show("לא הוזנה מחלה");

            }
            else
            {
                functions.UpdateChronicDiseases(EnterChronicDieseasTextBox.Text, idPatient);
                MessageBox.Show("המחלה עודכנה בהצלחה");
            }
           
        }

        //see complaints of patient
        private void ViewComplains()
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

        //add symptom to complaints of patient to treatment
        private void UpdateSymptomsButton_Click(object sender, EventArgs e)
        {
            if (CheckedSymptomsListBox.Text.Length == 0)
            {
                MessageBox.Show("לא נבחרה תלונה");
            }
            else if (TypeListBox.SelectedIndex==-1)
            {
                MessageBox.Show("לא נבחר סוג התלונה");
            }
            else if (SideListBox.SelectedIndex == -1)
            {

                MessageBox.Show("לא נבחר צד לתלונה");
            }
            else
            {
                int n = metroGrid1.Rows.Add();
                metroGrid1.Rows[n].Cells[0].Value = CheckedSymptomsListBox.Text;
                metroGrid1.Rows[n].Cells[1].Value = TypeListBox.SelectedItem.ToString();
                metroGrid1.Rows[n].Cells[2].Value = SideListBox.SelectedItem.ToString();
                functions.InsertNewSymptomByTreatment(this.idTreatment, CheckedSymptomsListBox.Text, SideListBox.SelectedItem.ToString(), TypeListBox.SelectedItem.ToString());
                TypeListBox.ClearSelected();
                TypeListBox.SelectedIndex = -1;    
                SideListBox.ClearSelected();
                SideListBox.SelectedIndex = -1;
                CheckedSymptomsListBox.SelectedIndex = -1;
            }
        }

        //enter to table
        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (this.metroGrid1.SelectedRows.Count > 0)
            {
                String sym = this.metroGrid1.SelectedRows[0].Cells[0].Value.ToString();
                String type = this.metroGrid1.SelectedRows[0].Cells[1].Value.ToString();
                String side = this.metroGrid1.SelectedRows[0].Cells[2].Value.ToString();
                metroGrid1.Rows.RemoveAt(this.metroGrid1.SelectedRows[0].Index);

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
                metroTextBox4.Text = functions.GetReceptionTime(idTreatment, "כללי");
                DateTime dateValue = DateTime.Now;
                metroTextBox4.Text = Convert.ToString(functions.getExpectedCompletion(idTreatment))+ " דקות";
            }
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
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox4, "החלף משתמש");
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            PatientMedicalRecord patientMedical = new PatientMedicalRecord(idPatient,idNurse);
            patientMedical.Show();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            PatientTreatmentStatus patientTreatmentStatus = new PatientTreatmentStatus(idTreatment, idPatient);
            patientTreatmentStatus.Show();
        }

        private void AgeTextBox_Click(object sender, EventArgs e)
        {
        }
    }
}
