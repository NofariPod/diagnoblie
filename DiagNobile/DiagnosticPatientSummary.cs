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
    public partial class DiagnosticPatientSummary : MetroFramework.Forms.MetroForm
    {
        String nameDiagnosis;
        String numTreatment;
        String partBody;
        String organ;
        String view;
        MyDiagNobileFunctions functions = new MyDiagNobileFunctions();


        public DiagnosticPatientSummary(String numTreatment, String diagnosis)
        {
            InitializeComponent();
            this.numTreatment = numTreatment;
            nameDiagnosis = diagnosis;
            ShowDetailsDiagnosis();
        }

        //function to display details of the diagnosis
        private void ShowDetailsDiagnosis()
        {
            metroTextBox1.Text = nameDiagnosis;
            
            DataTable dt = functions.GetPartBodyForCheckPatient(nameDiagnosis);
            foreach (DataRow datarow in dt.Rows)
            {
                //metroComboBox1.Items.Add(Convert.ToString(datarow["PartBody"]));
                partBody = Convert.ToString(datarow["PartBody"]);
            }

            DataTable dt1 = functions.GetOrgansForCheckPatient(nameDiagnosis, partBody);
            foreach (DataRow datarow in dt1.Rows)
            {
                // metroComboBox2.Items.Add(functions.GetOrganName(Convert.ToString(datarow["IdOrgan"])));
                organ = functions.GetOrganName(Convert.ToString(datarow["IdOrgan"]));
            }

            DataTable dt2 = functions.GetViewsForCheckPatient(nameDiagnosis, partBody, organ);
            foreach (DataRow datarow in dt2.Rows)
            {
                view = Convert.ToString(datarow["viewOrgan"]);
            }

            String responze = functions.GetFeedingFindingGeneral(numTreatment,functions.GetNumDiagnosis(nameDiagnosis), "כללי");
            metroTextBox3.Text = partBody;
            metroTextBox4.Text = organ;
            metroTextBox5.Text = view;
            metroTextBox2.Text = responze;
            viewFeedingFidings(metroGrid1, "צפייה");
            viewFeedingFidings(metroGrid1, "האזנה");
            viewFeedingFidings(metroGrid1, "נקישה");
            viewFeedingFidingsTouching(metroGrid1, "מישוש");
        }

        //function to choose parts of body
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //enter part of body
            String part = this.metroComboBox1.SelectedItem.ToString();

            //get organs to check by part of body 
            DataTable dt = functions.GetOrgansForCheckPatient(nameDiagnosis, part);
            foreach (DataRow datarow in dt.Rows)
            {
                metroComboBox2.Items.Add(functions.GetOrganName(Convert.ToString(datarow["IdOrgan"])));
            }
        }
        //function to choose organs

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String part = this.metroComboBox1.SelectedItem.ToString();
            String organ = this.metroComboBox2.SelectedItem.ToString();
            DataTable dt = functions.GetViewsForCheckPatient(nameDiagnosis, part, organ);
            foreach (DataRow datarow in dt.Rows)
            {
                metroComboBox4.Items.Add(Convert.ToString(datarow["viewOrgan"]));
            }
        }

        //function to choose view 
        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            String part = this.metroComboBox1.SelectedItem.ToString();
            String organ = this.metroComboBox2.SelectedItem.ToString();
            String view = this.metroComboBox4.SelectedItem.ToString();
            String responze = functions.GetFeedingFindingGeneral(numTreatment, functions.GetNumDiagnosis(nameDiagnosis), "כללי");
            metroTextBox2.Text = responze;
            viewFeedingFidings(metroGrid1, "צפייה");
            viewFeedingFidings(metroGrid1, "האזנה");
            viewFeedingFidings(metroGrid1, "נקישה");
            viewFeedingFidingsTouching(metroGrid1, "מישוש");
        }
        private void viewFeedingFidings(DataGridView dataGrid, String principle)
        {
            DataTable dt = functions.GetFeedingFindingsNames(numTreatment, functions.GetNumDiagnosis(nameDiagnosis), principle);
            foreach (DataRow datarow in dt.Rows) {
                int n = dataGrid.Rows.Add();
                dataGrid.Rows[n].Cells[0].Value = principle;
                dataGrid.Rows[n].Cells[1].Value = Convert.ToString(datarow["name"]);
                DataTable dt1 = functions.GetFeedingFindingsResponseBySide(numTreatment, functions.GetNumDiagnosis(nameDiagnosis), principle, Convert.ToString(datarow["name"]));
                foreach (DataRow datarow1 in dt1.Rows)
                {
                    String side = Convert.ToString(datarow1["side"]).ToString().Trim();
                    if (side.Equals("|<"))
                    {
                        dataGrid.Rows[n].Cells[3].Value = Convert.ToString(datarow1["response"]);
                    }
                    else if (side.Equals("||"))
                    {
                        dataGrid.Rows[n].Cells[4].Value = Convert.ToString(datarow1["response"]);
                    }
                    else
                    {
                        dataGrid.Rows[n].Cells[5].Value = Convert.ToString(datarow1["response"]);
                    }
                }
            }
        }
        private void viewFeedingFidingsTouching(DataGridView dataGrid, String principle)
        {
            DataTable dt = functions.GetFeedingFindingsNames(numTreatment, functions.GetNumDiagnosis(nameDiagnosis), principle);
            foreach (DataRow datarow in dt.Rows)
            {
                int n = dataGrid.Rows.Add();
                dataGrid.Rows[n].Cells[0].Value = principle;
                dataGrid.Rows[n].Cells[1].Value = Convert.ToString(datarow["name"]);
                dataGrid.Rows[n].Cells[2].Value = Convert.ToString(datarow["subFindings"]);
                DataTable dt1 = functions.GetFeedingFindingsTResponseBySide(numTreatment, functions.GetNumDiagnosis(nameDiagnosis), principle, Convert.ToString(datarow["name"]), Convert.ToString(datarow["subFindings"]));
                foreach (DataRow datarow1 in dt1.Rows)
                {
                    String side = Convert.ToString(datarow1["side"]).ToString().Trim();
                    if (side.Equals("|<"))
                    {
                        dataGrid.Rows[n].Cells[3].Value = Convert.ToString(datarow1["response"]);
                    }
                    else if (side.Equals("||"))
                    {
                        dataGrid.Rows[n].Cells[4].Value = Convert.ToString(datarow1["response"]);
                    }
                    else
                    {
                        dataGrid.Rows[n].Cells[5].Value = Convert.ToString(datarow1["response"]);
                    }
                }

            }
        }


        private void DiagnosticPatientSummary_Load(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToShortTimeString();
            DateLabel.Text = DateTime.Now.ToShortDateString();

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

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
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox1, "החלף משתמש");

            //ToolTip ttt = new ToolTip();
            //tt.SetToolTip(this.pictureBox2, "החלף משתמש");

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}

