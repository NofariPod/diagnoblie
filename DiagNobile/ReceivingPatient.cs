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
    public partial class ReceivingPatient : MetroFramework.Forms.MetroForm
    {
        MyDiagNobileFunctions functions = new MyDiagNobileFunctions();
        String UserId;
        public ReceivingPatient(String userId)
        {
            InitializeComponent();
            UserId = userId;
        }

        private void ReceivingPatient_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToShortDateString();
            TimeLabel.Text = DateTime.Now.ToShortTimeString();
        }

        private void PatientIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void PatientIdInput_Click(object sender, EventArgs e)
        {

        }

        private void PatientFullNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void PatientFullNameTextBox_Click(object sender, EventArgs e)
        {

        }

        private void ViewDataButton_Click(object sender, EventArgs e)
        {
            if (functions.CheckPatientExists(PatientIdInput.Text))
            {
                functions.OpenNewTretmentOnSystem(PatientIdInput.Text, UserId);
                String IdTreatment = functions.GetTreatmentNum(PatientIdInput.Text);
                if (!functions.CheckTimeValueExists(IdTreatment, "כללי"))
                {
                    functions.InsertTimeValue(IdTreatment, "כללי");
                }
                if (!functions.CheckIfPatientsExistsInListNurse(PatientIdInput.Text))
                {
                    functions.InsertPatientsForTretmentNurse(PatientIdInput.Text);
                }
                functions.UpdateTreatmentStatus(IdTreatment, "בהמתנה לאחות");
                MessageBox.Show("הלקוח התקבל בהצלחה");
                this.Close();
            }
            else
            {
                MessageBox.Show(" הלקוח אינו קיים במערכת, יש להכניס פרטים ראשוניים ולאחר מכן לקבל");
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (functions.CheckPatientExists(PatientIdInput.Text))
            {
                MessageBox.Show("הלקוח קיים במערכת  - נדרש להזין רק תעודת זהות");

                
            }
            else
            {
                if (PatientFirstNameTextBox.Text.Length == 0 || PatientLastNameTextBox.Text.Length == 0 
                    || DOB.Value.Date > DateTime.Today)
                {
                    if (PatientFirstNameTextBox.Text.Length == 0)
                    {
                        MessageBox.Show("יש להכניס שם פרטי תקין");

                    }
                    else if (PatientLastNameTextBox.Text.Length == 0)
                    {
                        MessageBox.Show("יש להכניס שם משפחה תקין");
                    }
                    else
                    {
                        MessageBox.Show("יש להכניס תאריך תקין");
                    }
                }
                else
                {
                    MessageBox.Show("הפרטים שהכנסת הם: " + "\n" 
                        + "מספר תעודת זהות " + PatientIdInput.Text + "\n"
                        + "שם פרטי " + PatientFirstNameTextBox.Text + "\n"
                        + "שם משפחה " + PatientLastNameTextBox.Text + "\n" 
                        + "תאריך לידה " + DOB.Text);
                    functions.InsertNewPatient(PatientIdInput.Text, PatientFirstNameTextBox.Text, 
                        PatientLastNameTextBox.Text, DOB.Text);

                    functions.OpenNewTretmentOnSystem(PatientIdInput.Text, UserId);
                    String IdTreatment = functions.GetTreatmentNum(PatientIdInput.Text);
                    if (!functions.CheckTimeValueExists(IdTreatment, "כללי"))
                    {
                        functions.InsertTimeValue(IdTreatment, "כללי");
                    }
                    if (!functions.CheckIfPatientsExistsInListNurse(PatientIdInput.Text))
                    {
                        functions.InsertPatientsForTretmentNurse(PatientIdInput.Text);
                    }
                    functions.UpdateTreatmentStatus(IdTreatment, "בהמתנה לאחות");
                    MessageBox.Show("הלקוח רשום במערכת והתקבל בהצלחה");
                    this.Close();
                }
            }
        }

        private void DOB_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
