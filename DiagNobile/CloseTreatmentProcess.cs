using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable CS0105 // The using directive for 'Microsoft.Reporting.WinForms' appeared previously in this namespace
using Microsoft.Reporting.WinForms;
#pragma warning restore CS0105 // The using directive for 'Microsoft.Reporting.WinForms' appeared previously in this namespace

namespace DiagNobile
{
    public partial class CloseTreatmentProcess : MetroFramework.Forms.MetroForm
    {
        String tretmentNum;
        String patientId;
        String doctorId;
        MyDiagNobileFunctions functions = new MyDiagNobileFunctions();
        public CloseTreatmentProcess(String idTretment,String idPatient)
        {
            InitializeComponent();
            tretmentNum = idTretment;
            patientId = idPatient;
            
            DataTable tblAuthors = functions.GetAllPatientDetails(patientId);
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
            DataTable tbl = functions.GetTreatmentDetails(tretmentNum);
            foreach (DataRow drCurrent in tbl.Rows)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}",
               drCurrent["NurseId"].ToString(),
               drCurrent["DoctorId"].ToString(),
               drCurrent["BodyTemperature"].ToString(),
               drCurrent["systolicBloodPressuree"].ToString(),
               drCurrent["diastolicBloodPressuree"].ToString(),
               drCurrent["pulse"].ToString(),
               drCurrent["PrimaryDiagnosisId"].ToString(),
               drCurrent["SecondaryDiagnosisId"].ToString());
            }
            Console.ReadLine();
            String NurseId = Convert.ToString(tblAuthors.Rows[0]["NurseId"]);
            doctorId = Convert.ToString(tblAuthors.Rows[0]["DoctorId"]);
            String bodyTemperature = Convert.ToString(tblAuthors.Rows[0]["BodyTemperature"]);
            String systolicBloodPressuree = Convert.ToString(tblAuthors.Rows[0]["systolicBloodPressuree"]);
            String diastolicBloodPressuree = Convert.ToString(tblAuthors.Rows[0]["diastolicBloodPressuree"]);
            String pulse = Convert.ToString(tblAuthors.Rows[0]["pulse"]);
            String primaryDiagnosisId = Convert.ToString(tblAuthors.Rows[0]["PrimaryDiagnosisId"]);
            String secondaryDiagnosisId = Convert.ToString(tblAuthors.Rows[0]["SecondaryDiagnosisId"]);


            id.Text = idPatient;
            first.Text = firstName + " " + lastName;
            cronic.Text = chronicDiseases;
            sens.Text = sensitivity;
            nurse.Text = functions.GetNameUser(NurseId);
            DoctorTreatNameLabel.Text = functions.GetNameUser(doctorId);
            Temperature.Text = bodyTemperature;
            BloodPressure.Text = systolicBloodPressuree;
            BloodPressure1.Text = diastolicBloodPressuree;
            Pulse.Text = pulse;
            ViewSymptoms();

            if (primaryDiagnosisId.Length!=0)
            {
                DiagnosisNameTextBox.Text = functions.GetNameDiagnosis(primaryDiagnosisId);
            }
            else
            {
                DiagnosisNameTextBox.Text = "ללא";
            }
            if (secondaryDiagnosisId.Length!=0)
            {
                Diagnosis.Text = functions.GetNameDiagnosis(secondaryDiagnosisId);
            }
            else
            {
                Diagnosis.Text = "ללא";
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
            if (functions.CheckTreatmentsTestTrackingExists(tretmentNum))
            {
                DataTable td = functions.GetTreatmentsTestTracking(tretmentNum);
                foreach (DataRow datarow in td.Rows)
                {
                    String name = functions.GetNameTest(Convert.ToString(datarow["TestNum"]));
                    var item1 = new ListViewItem(new[] { name, Convert.ToString(datarow["Frequency"]) });
                    metroListView2.Items.Add(item1);
                }
            }

        }
        //function to view symptoms of patient
        private void ViewSymptoms()
        {
            DataTable dt = functions.GetAllSymptomsByTreatment(tretmentNum);
            foreach (DataRow datarow in dt.Rows)
            {
                int n = metroGrid1.Rows.Add();
                metroGrid1.Rows[n].Cells[0].Value = functions.GetSymptomName(Convert.ToString(datarow["SymptomNum"]));
                metroGrid1.Rows[n].Cells[1].Value = Convert.ToString(datarow["side"]);
                metroGrid1.Rows[n].Cells[2].Value = Convert.ToString(datarow["type"]);
            }
        }


        private void CloseTreatmentProcess_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToShortDateString();
            TimeLabel.Text = DateTime.Now.ToShortTimeString();
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
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox1, "החלף משתמש");
        }      

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (functions.CheckTimeValueExists(tretmentNum, "כללי"))
            {
                functions.UpdateTimeValue(tretmentNum, "כללי");
            }
            functions.UpdateTreatmentStatus(tretmentNum, "שוחרר");

            functions.DeletePatientFromListDoctor(patientId);
            PatientsList patientsList = new PatientsList(doctorId);
            this.Close();
            patientsList.Show();
        }

        //Bitmap bmp;
        private void PrintReportButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
            //printDocument1.Print();
            /**
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Width, this.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
            **/


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap img = new Bitmap(this.Width, this.Height);
            //define which is to print
            this.DrawToBitmap(img, new Rectangle(0, 0, this.Width, this.Height));
            Graphics g = e.Graphics;
            g.PageUnit = GraphicsUnit.Display;
            g.DrawImage(img, new RectangleF(0, 0, 850, 750));

            //e.Graphics.DrawImage(bmp,0,0);
            /**LocalReport report = new LocalReport();
            report.ReportEmbeddedResource = ReportSource;
            report.DataSources.Add(myDataSource);
            report.PrintToPrinter();**/

            /**e.Graphics.DrawString("סיכום טיפול עבור :" + id.Text + " , " + first.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(25, 60));
            e.Graphics.DrawString("מחלות כרוניות :" + cronic.Text + "; רגישויות: " + sens.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25,100));
            e.Graphics.DrawString(TemperatureLabel.Text+ " " + Temperature.Text + "; " + BloodPressureLabel.Text +" " + BloodPressure.Text + "; " + metroLabel12.Text + " " + BloodPressure1.Text + "; " + PulseLabel.Text + " " + Pulse.Text + "; ", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 150));
            e.Graphics.DrawString(DiagnosisNameLabel.Text + " " + DiagnosisNameTextBox.Text + "; " + metroLabel13.Text + " " + Diagnosis.Text + "; " , new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 200));
            e.Graphics.DrawString(" תוכנית טיפול :" , new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(25, 250));
            e.Graphics.DrawString(" בדיקות :" + metroTextBox1.Text + "; " , new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 300));
            e.Graphics.DrawString(" תרופות :" + medic.Text + "; ", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 350));
    **/
        }

        private void printDocument1_QueryPageSettings(object sender, System.Drawing.Printing.QueryPageSettingsEventArgs e)
        {

        }
    }
}
