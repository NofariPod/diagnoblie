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
    public partial class FollowUpEntry : MetroFramework.Forms.MetroForm
    {
        public String idTreatment;
        String patientId;
        String doctorId;
        MyDiagNobileFunctions functions = new MyDiagNobileFunctions();

        public FollowUpEntry(String idTretment)
        {
            InitializeComponent();
            this.idTreatment = idTretment;
            showData();
        }
        public FollowUpEntry()
        {
            InitializeComponent();
        }        
        private void FollowUpEntry_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToShortDateString();
            TimeLabel.Text = DateTime.Now.ToShortTimeString();
        }
        private void showData()
        {
            DataTable tblAuthors = functions.GetTreatmentDetails(idTreatment);
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0} {1} {2} {3} ",
                drCurrent["PatientId"].ToString(),
                drCurrent["DoctorId"].ToString(),
                drCurrent["PrimaryDiagnosisId"].ToString(),
                drCurrent["SecondaryDiagnosisId"].ToString());

            }
            Console.ReadLine();
            patientId = Convert.ToString(tblAuthors.Rows[0]["PatientId"]);
            doctorId = Convert.ToString(tblAuthors.Rows[0]["DoctorId"]);
            String primaryDiagnosisId = Convert.ToString(tblAuthors.Rows[0]["PrimaryDiagnosisId"]);
            String secondaryDiagnosisId = Convert.ToString(tblAuthors.Rows[0]["SecondaryDiagnosisId"]);

            DataTable table = functions.GetAllPatientDetails(patientId);
            foreach (DataRow drCurrent in table.Rows)
            {
                Console.WriteLine("{0} {1} ",
                drCurrent["FirstName"].ToString(),
                drCurrent["LastName"].ToString());
            }
            Console.ReadLine();
            String firstName = Convert.ToString(table.Rows[0]["FirstName"]);
            String lastName = Convert.ToString(table.Rows[0]["LastName"]);
            InputTaz.Text = patientId;
            metroTextBox5.Text = firstName;
            metroTextBox4.Text = lastName;
            if (primaryDiagnosisId.Length != 0)
            {
                DiagnosisNameTextBox.Text = functions.GetNameDiagnosis(primaryDiagnosisId);
                DataTable dtT = functions.GetAllDiagnosisTest(primaryDiagnosisId);
                foreach (DataRow datarow in dtT.Rows)
                {
                    String type = Convert.ToString(datarow["type"]).ToString().Trim();
                    String name = functions.GetNameTest(Convert.ToString(datarow["IdTest"]));
                    if (type.Equals("דימות"))
                    {
                        metroListView1.Items.Add(name);
                    }
                    if (type.Equals("בדיקות"))
                    {
                        metroListView3.Items.Add(name);
                    }
                    if (type.Equals("התערבות"))
                    {
                        metroListView2.Items.Add(name);
                    }
                    if (type.Equals("מעקב"))
                    {
                        int n = metroGrid1.Rows.Add();
                        metroGrid1.Rows[n].Cells[0].Value = name;
                    }
                }
                DataTable dtM = functions.GetAllDiagnosisMedication(primaryDiagnosisId);
                foreach (DataRow datarow in dtM.Rows)
                {
                    int n = metroGrid2.Rows.Add();
                    String name = functions.GetNameMedication(Convert.ToString(datarow["MedicationNum"]));
                    metroGrid2.Rows[n].Cells[0].Value = name;
                }
            }
            else
            {
                DiagnosisNameTextBox.Text = "לא הוזנה אבחנה עיקרית";
            }
            if (secondaryDiagnosisId.Length != 0)
            {
                metroTextBox8.Text = functions.GetNameDiagnosis(secondaryDiagnosisId);
                DataTable dtT = functions.GetAllDiagnosisTest(secondaryDiagnosisId);
                foreach (DataRow datarow in dtT.Rows)
                {
                    String type = Convert.ToString(datarow["type"]).ToString().Trim();
                    String name = functions.GetNameTest(Convert.ToString(datarow["IdTest"]));
                    if (type.Equals("דימות"))
                    {
                        metroListView1.Items.Add(name);
                    }
                    if (type.Equals("בדיקות"))
                    {
                        metroListView3.Items.Add(name);
                    }
                    if (type.Equals("התערבות"))
                    {
                        metroListView2.Items.Add(name);
                    }
                    if (type.Equals("מעקב"))
                    {
                        int n = metroGrid1.Rows.Add();
                        metroGrid1.Rows[n].Cells[0].Value = name;
                    }

                }
                DataTable dtM = functions.GetAllDiagnosisMedication(secondaryDiagnosisId);
                foreach (DataRow datarow in dtM.Rows)
                {
                    int n = metroGrid2.Rows.Add();
                    String name = functions.GetNameMedication(Convert.ToString(datarow["MedicationNum"]));
                    metroGrid2.Rows[n].Cells[0].Value = name;
                }
            }
            else
            {
                metroTextBox8.Text = "לא הוזנה אבחנה מבדלת";
            }
        }         
        private void metroButton4_Click(object sender, EventArgs e)
        {
            
            var medicinesRows = metroGrid2.Rows.OfType<DataGridViewRow>().Where(row => !row.IsNewRow).ToArray();
            foreach (var row in medicinesRows)
            {
                functions.InsertTreatmentsMedication(patientId, row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
            }
            metroGrid2.ClearSelection();
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
                metroTextBox1.Text = functions.GetReceptionTime(idTreatment, "כללי");                
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

        private void ShowHoverText(object sender, EventArgs e)
        {
            ToolTip ttt = new ToolTip();
            ttt.SetToolTip(this.pictureBox5, "החלף משתמש");
        }

        private void metroButton4_Click_1(object sender, EventArgs e)
        {
            //insert Imaging Tests
            ListView.SelectedListViewItemCollection Imaging = this.metroListView1.SelectedItems;
            foreach (ListViewItem item in Imaging)
            {
                String test = item.SubItems[0].Text;
                if (!functions.CheckTestsTreatmentsExists(idTreatment, patientId, test, doctorId))
                {
                    functions.InsertTestsTreatments(idTreatment, patientId, test, doctorId);
                }
            }
            MessageBox.Show("הבדיקות נכנסו למערכת");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var selectedRows = metroGrid2.SelectedRows.OfType<DataGridViewRow>().Where(row => !row.IsNewRow).ToArray();
            foreach (var row in selectedRows)
            {
                if (row.Cells[1].Value==null)
                {
                    MessageBox.Show("לא ביצעת הזנה של מינון לתרופה " + row.Cells[0].Value.ToString());
                    break;
                }
                else
                {
                    if (!functions.CheckPatientMedicinesExists(patientId, row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString()))
                    {
                        functions.InsertTreatmentsMedication(patientId, row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                    }
                }
            }           
            MessageBox.Show("התרופות נכנסו למערכת");
            metroGrid2.ClearSelection();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection tracking = this.metroListView2.SelectedItems;
            foreach (ListViewItem item in tracking)
            {
                if (!functions.CheckTestsTreatmentsExists(idTreatment, patientId, item.SubItems[0].Text, doctorId))
                {
                    functions.InsertTestsTreatments(idTreatment, patientId, item.SubItems[0].Text, doctorId);
                }
            }
            MessageBox.Show("הבדיקות נכנסו למערכת");

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection Tests = this.metroListView3.SelectedItems;
            foreach (ListViewItem item in Tests)
            {
                if (!functions.CheckTestsTreatmentsExists(idTreatment, patientId, item.SubItems[0].Text, doctorId))
                {
                    functions.InsertTestsTreatments(idTreatment, patientId, item.SubItems[0].Text, doctorId);
                }
            }
            MessageBox.Show("הבדיקות נכנסו למערכת");
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            var selectedRows = metroGrid1.SelectedRows.OfType<DataGridViewRow>().Where(row => !row.IsNewRow).ToArray();
            try
            {
                foreach (var row in selectedRows)
                {
                    String freq = " כל " + row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString();
                    if (!functions.CheckTreatmentsTestTrackingExists(idTreatment, patientId, row.Cells[0].Value.ToString(), freq))
                    {
                        functions.InsertTreatmentsTestTracking(idTreatment, patientId, row.Cells[0].Value.ToString(), freq);
                    }
                }
                MessageBox.Show("הבדיקות נכנסו למערכת");
                metroGrid1.ClearSelection();
            }
            catch
            {

            }
            
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            PatientMedicalRecord patientMedicalRecord = new PatientMedicalRecord(patientId,doctorId);
            patientMedicalRecord.Show();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            if (!functions.CheckIfPatientsExistsInListNurse(patientId))
            {
                functions.InsertPatientsForTretmentNurse(patientId);
            }
            if (functions.CheckTimeValueExists(idTreatment, "רופא"))
            {
                functions.UpdateTimeValue(idTreatment, "רופא");
            }
            TreatmentSummary treatment = new TreatmentSummary(patientId, doctorId);
            this.Close();
            treatment.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (DiagnosisNameTextBox.Text.Length != 0 || !DiagnosisNameTextBox.Text.Equals("לא הוזנה אבחנה"))
            {
                DiagnosticPatientSummary summary = new DiagnosticPatientSummary(idTreatment, DiagnosisNameTextBox.Text);
                summary.Show();
            }
            else
            {
                MessageBox.Show("לא הוזנה אבחנה");
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (metroTextBox8.Text.Length != 0 || !metroTextBox8.Text.Equals("לא הוזנה אבחנה"))
            {
                DiagnosticPatientSummary summary = new DiagnosticPatientSummary(idTreatment, metroTextBox8.Text);
                summary.Show();
            }
            else
            {
                MessageBox.Show("לא הוזנה אבחנה");
            }
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            PatientTreatmentStatus patientTreatmentStatus = new PatientTreatmentStatus(idTreatment,patientId);
            patientTreatmentStatus.Show();
            
        }
    }
}

