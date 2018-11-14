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
    public partial class DiagnosticTest : MetroFramework.Forms.MetroForm
    {
        private String idTreatment;
        private String diagnosis;
        private String numTest;
        private String partBody;
        private MyDiagNobileFunctions functions = new MyDiagNobileFunctions();
        public DiagnosticTest(String idT, String diagnosis)
        {
            InitializeComponent();
            idTreatment = idT;
            this.diagnosis = diagnosis;
            ShowDetailsDiagnosis();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;

        }
        private void PatientInfoTabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Name.Equals("ObservedTabPage"))
            {
                Observed.Visible = true;
                knock.Visible = false;
                Touching.Visible = false;
                listening.Visible = false;
            }
            if (e.TabPage.Name.Equals("knockTabPage"))
            {
                Observed.Visible = false;
                knock.Visible = true;
                Touching.Visible = false;
                listening.Visible = false;
            }
            if (e.TabPage.Name.Equals("TouchingTabPage"))
            {
                Observed.Visible = false;
                knock.Visible = false;
                Touching.Visible = true;
                listening.Visible = false;
            }
            if (e.TabPage.Name.Equals("listeningTabPage"))
            {
                Observed.Visible = false;
                knock.Visible = false;
                Touching.Visible = false;
                listening.Visible = true;
            }
        }

        //function to show details of diagnosis
        private void ShowDetailsDiagnosis()
        {
            metroTextBox1.Text = diagnosis;
            DataTable dt = functions.GetPartBodyForCheckPatient(diagnosis);
            foreach (DataRow datarow in dt.Rows)
            {
                String partBody = Convert.ToString(datarow["PartBody"]).ToString().Trim();
                if (partBody.Equals("ראש"))
                {
                    head.Visible = true;
                }
                if (partBody.Equals("צוואר"))
                {
                    neck.Visible = true;
                    neck.BringToFront();
                }
                if (partBody.Equals("חזה"))
                {
                    chest.Visible = true;
                }
                if (partBody.Equals("בטן"))
                {
                    stomach.Visible = true;
                }
                if (partBody.Equals("אגן"))
                {
                    basin.Visible = true;
                }
                if (partBody.Equals("יד ימין"))
                {
                    rightHand.Visible = true;
                }
                if (partBody.Equals("יד שמאל"))
                {
                    leftHand.Visible = true;
                }
                if (partBody.Equals("רגל ימין"))
                {
                    rightLeg.Visible = true;
                }
                if (partBody.Equals("רגל שמאל"))
                {
                    leftLeg.Visible = true;
                }
            }
            if (functions.CheckDiagnosisSecondaryExistsForPatients(idTreatment))
            {
                metroTextBox9.Text = 
                    functions.GetNameDiagnosis(functions.GetSecondaryDiagnosisId(idTreatment));
            }
            else
            {
                metroTextBox9.Text = "לא הוזנה אבחנה מבדלת";
            }
        }
        private void EnteringFindingByOrgan5Principles_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToShortDateString();
            TimeLabel.Text = DateTime.Now.ToShortTimeString();
        }
        /**
        private void InsertFinding(String principle, String finding)
        {
            if (viewTextBox.Text == null)
            {
                functions.InsertFindingsTreatmentsNunSide(idTreatment, OrganNameTextBox.Text, partBody, viewTextBox.Text, principle, finding);
            }
            if (viewTextBox.Text == null)
            {
                functions.InsertFindingsTreatments(idTreatment, OrganNameTextBox.Text, partBody, viewTextBox.Text, viewTextBox.Text, principle, finding);
            }
        }
            **/
        private void InsertFindingsButton_Click(object sender, EventArgs e)
        {

        }
        /**
        private void ListViewOrgans_SelectedIndexChanged(object sender, EventArgs e)
        {
            string organName = null;
            organName = ListViewOrgans.SelectedItems[0].SubItems[0].Text;
            OrganNameTextBox.Text = organName;
        }
        **/
        private void RepetativyTextBox_Click(object sender, EventArgs e)
        {

        }

        private void WarnRecomGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void UpdateTreatmentStages_Click(object sender, EventArgs e)
        {
            /** functions.InsertFinding(idTreatment, OrganNameTextBox.Text, partBody, viewTextBox.Text, sideTextBox.Text, "כללי", EnterFindingGeneralTextBox.Text);
             EnterFindingGeneralTextBox.Text = " ";**/
        }

        private void AddGeneralFind_Click_1(object sender, EventArgs e)
        {
            /**EnterFindingGeneralTextBox.Text = " ";**/
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            /**functions.InsertFinding(idTreatment, OrganNameTextBox.Text, partBody, viewTextBox.Text, sideTextBox.Text, "צפייה", EnterFindingObservedTextBox.Text);
            EnterFindingObservedTextBox.Text = " ";**/
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            /**functions.InsertFinding(idTreatment, OrganNameTextBox.Text, partBody, viewTextBox.Text, sideTextBox.Text, "האזנה", EnterFindingListeningTextBox.Text);
            EnterFindingListeningTextBox.Text = " ";**/
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            /**functions.InsertFinding(idTreatment, OrganNameTextBox.Text, partBody, viewTextBox.Text, sideTextBox.Text, "נקישה", EnterFindingKnockTextBox.Text);
            EnterFindingKnockTextBox.Text = " ";**/
        }

        //save all findings to database
        private void metroButton7_Click(object sender, EventArgs e)
        {
            if (checkFidings())
            {
                InsertFidingsToSystem(metroGrid1, "צפייה");
                InsertFidingsToSystem(metroGrid4, "נקישה");
                InsertFidingsToSystem(metroGrid3, "האזנה");
                InsertFidingsToSystem(metroGrid2, "מישוש");              
                MessageBox.Show("הממצאים עודכנו במערכת");
                SideListBox.Items.Remove(SideListBox.SelectedIndex);
            }
            
        }

        //insert findings to database 
        private void InsertFidingsToSystem(DataGridView dataGrid, String principle)
        {
            var fidingsRows = dataGrid.Rows.OfType<DataGridViewRow>().Where(row => !row.IsNewRow).ToArray();
            int i = 0;
            foreach (var row in fidingsRows)
            {
                String id = row.Cells[0].Value.ToString();
                String numRes;
                if (principle.Equals("כללי"))
                {
                    String organ = this.metroComboBox2.SelectedItem.ToString();
                    String view = this.ViewListBox.SelectedItem.ToString();
                    String numT = functions.GetTestNum(diagnosis, organ, view, "כללי");
                    numRes = functions.GetResponseNum(numT, principle, id);
                }
                else
                {
                    numRes = functions.GetResponseNum(numTest, principle, id);
                }

                try
                {
                    if (row.Cells[2].Value.ToString().Length == 0)
                    {
                        MessageBox.Show(" הינך נדרש להזין את הממצא" + principle
                            + " שנמצא בבדיקה בשורה" + row.Index.ToString());
                            i++;
                    }
                    if (functions.CheckFindingsTreatmentsExists(idTreatment, numRes))
                    {
                        MessageBox.Show(" הממצא" + principle + " בשורה"
                            + row.Index.ToString() + " כבר עודכן במערכת ");
                        i++;
                    }
                    else
                    {
                        if (principle.Equals("מישוש"))
                        {
                            functions.InsertFindingsTreatments(idTreatment,
                                numRes, row.Cells[3].Value.ToString());
                        }
                        else
                        {
                            functions.InsertFindingsTreatments(idTreatment,
                                numRes, row.Cells[2].Value.ToString());
                        }

                    }
                }
                catch
                {

                }

            }
            if (principle.Equals("כללי"))
            {
                dataGrid.Enabled = false;
                metroButton2.Enabled = false;
            }
            else
            {
                if (i == 0)
                {
                    dataGrid.Rows.Clear();
                }
            }
        }

        //insert touching findings to database
        private void InsertFindingsTouchingToSystem(DataGridView dataGrid)
        {
            var fidingsRows = 
                dataGrid.Rows.OfType<DataGridViewRow>().Where(row => !row.IsNewRow).ToArray();

            foreach (var row in fidingsRows)
            {
                String id = row.Cells[0].Value.ToString();
                String numRes = functions.GetResponseNum(numTest, "מישוש", id);
                if (row.Cells[2].Value.ToString().Length == 0)
                {
                    MessageBox.Show("לא הזנת האם קיים הממצא");
                }
                else
                {
                    if (!functions.CheckFindingsTreatmentsExists(idTreatment, numRes))
                    {
                        if (row.Cells[2].Value.ToString().Equals("אין"))
                        {
                            functions.InsertFindingsTreatments(idTreatment, 
                                numRes, row.Cells[2].Value.ToString());
                            MessageBox.Show("נבחר שלא קיים");
                        }
                        else
                        {
                            MessageBox.Show(" נבחר שקיים או בספק");
                            functions.InsertFindingsTreatments(idTreatment, 
                                numRes, row.Cells[2].Value.ToString());
                            if (!functions.CheckFindingsTouchingTreatmentsExists(idTreatment, numRes))
                            {
                                functions.InsertFindingsTouchingTreatments(idTreatment, 
                                    numRes, row.Cells[1].Value.ToString(), 
                                    row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), 
                                    row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString());
                                MessageBox.Show("הממצא מישוש נכנס בהצלחה");
                            }
                        }
                    }
                    else {
                        if (!functions.CheckFindingsTouchingTreatmentsExists(idTreatment, numRes))
                        {
                            functions.InsertFindingsTouchingTreatments(idTreatment, numRes, 
                                row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), 
                                row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), 
                                row.Cells[5].Value.ToString());
                            MessageBox.Show("הממצא מישוש נכנס בהצלחה");
                        }
                    }
                }
            }
        }

        private void AddTouchFind_Click(object sender, EventArgs e)
        {

        }

        //function to choose parts of body to check
        private void metroComboBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = functions.GetOrgansForCheckPatient(diagnosis, partBody);
            foreach (DataRow datarow in dt.Rows)
            {
                metroComboBox2.Items.Add(functions.GetOrganName(Convert.ToString(datarow["IdOrgan"])));
            }
        }

        //function to choose organs to check the patient
        private void metroComboBox2_TextChanged(object sender, EventArgs e)
        {
            String organ = this.metroComboBox2.SelectedItem.ToString();
            ViewListBox.Items.Clear();
            DataTable dt = functions.GetViewsForCheckPatient(diagnosis, partBody, organ);
            foreach (DataRow datarow in dt.Rows)
            {
                ViewListBox.Items.Add(Convert.ToString(datarow["viewOrgan"]));
            }
        }

        //function to choose views of body to check
        private void metroComboBox4_TextChanged(object sender, EventArgs e)
        {
        }

        //fucntion to choose side of the body to check
        private void metroComboBox3_TextChanged(object sender, EventArgs e)
        {
            String organ = this.metroComboBox2.SelectedItem.ToString();
            String view = this.ViewListBox.SelectedItem.ToString();
            String side = this.SideListBox.SelectedItem.ToString();
            String numTest = functions.GetTestNum(diagnosis, organ, view, side);
            this.numTest = numTest;
            ViewFidingsbyPrinciple(metroGrid1, "צפייה", numTest);
            ViewFidingsbyPrinciple(metroGrid4, "נקישה", numTest);
            ViewFidingsbyPrinciple(metroGrid3, "האזנה", numTest);
            ViewFidingsbyPrinciple(metroGrid2, "מישוש", numTest);

        }
        private void SetCellComboBoxItems(DataGridView dataGrid, int rowIndex, int colIndex, List<String> itemsToAdd)
        {
            DataGridViewComboBoxCell dgvcbc = 
                (DataGridViewComboBoxCell)dataGrid.Rows[rowIndex].Cells[colIndex];
            // You might pass a boolean to determine whether to clear or not.
            dgvcbc.Items.Clear();
            foreach (String itemToAdd in itemsToAdd)
            {
                dgvcbc.Items.Add(itemToAdd);
            }
        }

        //function to view findings by principle
        private void ViewFidingsbyPrinciple(DataGridView dataGrid, String principle, String numTest)
        {
            //int i = 0;
            dataGrid.Rows.Clear();
            DataTable dt = functions.GetFindingsForCheckPatient(numTest, principle);
            if (principle.Equals("מישוש"))
            {
                foreach (DataRow datarow in dt.Rows)
                {
                    String sub = Convert.ToString(datarow["subFindings"]);
                    String idF = Convert.ToString(datarow["IdFinding"]);
                    int n = dataGrid.Rows.Add();
                    dataGrid.Rows[n].Cells[0].Value = idF;
                    dataGrid.Rows[n].Cells[1].Value = functions.GetFindingName(idF);
                    dataGrid.Rows[n].Cells[2].Value = sub;
                    List<String> options = new List<string>();
                    DataTable dtf = functions.GetOptionsFinding(idF);
                    foreach (DataRow datarow1 in dtf.Rows)
                    {
                        options.Add(Convert.ToString(datarow1["OptionFinding"]));
                        SetCellComboBoxItems(dataGrid, n, 3, options);
                    }
                    /**if (sub.Equals("מיקום"))
                    {
                        
                    }
                    else if (sub.Equals("שטח פנים"))
                    {
                        int n = metroGrid5.Rows.Add();
                        metroGrid5.Rows[n].Cells[0].Value = idF;
                        metroGrid5.Rows[n].Cells[1].Value = functions.GetFindingName(idF);
                        List<String> options = new List<string>();
                        DataTable dtf = functions.GetOptionsFinding(idF);
                        foreach (DataRow datarow1 in dtf.Rows)
                        {
                            options.Add(Convert.ToString(datarow1["OptionFinding"]));
                            setCellComboBoxItems(metroGrid5, n, 3, options);
                        }
                        String idRigidity = functions.getFidingRigidityForCheckPatient(numTest, principle);
                        List<String> options1 = new List<string>();
                        DataTable dtff = functions.GetOptionsFinding(idRigidity);
                        foreach (DataRow datarow1 in dtff.Rows)
                        {
                            options.Add(Convert.ToString(datarow1["OptionFinding"]));
                            setCellComboBoxItems(metroGrid5, n, 4, options);
                        }
                    }   **/
                }
            }
            else
            {
                foreach (DataRow datarow in dt.Rows)
                {
                    String idF = Convert.ToString(datarow["IdFinding"]);
                    int n = dataGrid.Rows.Add();
                    dataGrid.Rows[n].Cells[0].Value = idF;
                    dataGrid.Rows[n].Cells[1].Value = functions.GetFindingName(idF);
                    List<String> options = new List<string>();
                    DataTable dtf = functions.GetOptionsFinding(idF);
                    foreach (DataRow datarow1 in dtf.Rows)
                    {
                        options.Add(Convert.ToString(datarow1["OptionFinding"]));
                        SetCellComboBoxItems(dataGrid, n, 2, options);
                    }

                }
            }

        }

        //check secondary diagnosis
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox9.Text.Length == 0 || (metroTextBox9.Text.Equals("לא הוזנה אבחנה מבדלת")))
            {
                MessageBox.Show(" לא נבחרה אבחנה רפואית");
            }
            else
            {
                DiagnosticTest t = new DiagnosticTest(idTreatment, metroTextBox9.Text);
                t.Show();
                this.Close();
            }
        }

        private void metroTextBox9_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel16_Click(object sender, EventArgs e)
        {

        }

        private void PatientInfoTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            var fidingsRows = metroGrid6.Rows.OfType<DataGridViewRow>().Where(row => !row.IsNewRow).ToArray();

            foreach (var row in fidingsRows)
            {
                if (row.Cells[2].Value.ToString().Length == 0)
                {
                    i++;
                }
            }
            if (i == 0)
            {
                InsertFidingsToSystem(metroGrid6, "כללי");
                MessageBox.Show(" הממצא עודכן בהצלחה");
            }
            else
            {
                MessageBox.Show(" הינך נדרש להזין את כל הממצאים בעקרון כללי");

            }
        }
        

        private void metroButton12_Click(object sender, EventArgs e)
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
                metroTextBox4.Text = functions.GetReceptionTime(idTreatment, "כללי");
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
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox5, "החלף משתמש");

        }       
             

        private void chest_Click(object sender, EventArgs e)
        {
            partBody = "חזה";
            DataTable dt = functions.GetOrgansForCheckPatient(diagnosis, partBody);
            foreach (DataRow datarow in dt.Rows)
            {
                metroComboBox2.Items.Add(functions.GetOrganName(Convert.ToString(datarow["IdOrgan"])));
            }
            chest.Enabled = false;
            chest.BackColor = Color.DimGray;
        }

        private void head_Click(object sender, EventArgs e)
        {
            partBody = "ראש";
            DataTable dt = functions.GetOrgansForCheckPatient(diagnosis, partBody);
            foreach (DataRow datarow in dt.Rows)
            {
                metroComboBox2.Items.Add(functions.GetOrganName(Convert.ToString(datarow["IdOrgan"])));
            }
            head.Enabled = false;
            head.BackColor = Color.DimGray;
        }

        private void neck_Click(object sender, EventArgs e)
        {
            partBody = "צוואר";
            DataTable dt = functions.GetOrgansForCheckPatient(diagnosis, partBody);
            foreach (DataRow datarow in dt.Rows)
            {
                metroComboBox2.Items.Add(functions.GetOrganName(Convert.ToString(datarow["IdOrgan"])));
            }
            neck.Enabled = false;
            neck.BackColor = Color.DimGray;
        }

        private void rightHand_Click(object sender, EventArgs e)
        {
            partBody = "יד ימין";
            DataTable dt = functions.GetOrgansForCheckPatient(diagnosis, partBody);
            foreach (DataRow datarow in dt.Rows)
            {
                metroComboBox2.Items.Add(functions.GetOrganName(Convert.ToString(datarow["IdOrgan"])));
            }
            rightHand.Enabled = false;
            rightHand.BackColor = Color.DimGray;
        }

        private void leftHand_Click(object sender, EventArgs e)
        {
            partBody = "יד שמאל";
            DataTable dt = functions.GetOrgansForCheckPatient(diagnosis, partBody);
            foreach (DataRow datarow in dt.Rows)
            {
                metroComboBox2.Items.Add(functions.GetOrganName(Convert.ToString(datarow["IdOrgan"])));
            }
            leftHand.Enabled = false;
            leftHand.BackColor = Color.DimGray;
        }

        private void stomach_Click(object sender, EventArgs e)
        {
            partBody = "בטן";
            DataTable dt = functions.GetOrgansForCheckPatient(diagnosis, partBody);
            foreach (DataRow datarow in dt.Rows)
            {
                metroComboBox2.Items.Add(functions.GetOrganName(Convert.ToString(datarow["IdOrgan"])));
            }
            stomach.Enabled = false;
            stomach.BackColor = Color.DimGray;
        }

        private void basin_Click(object sender, EventArgs e)
        {
            partBody = "אגן";
            DataTable dt = functions.GetOrgansForCheckPatient(diagnosis, partBody);
            foreach (DataRow datarow in dt.Rows)
            {
                metroComboBox2.Items.Add(functions.GetOrganName(Convert.ToString(datarow["IdOrgan"])));
            }
            basin.Enabled = false;
            basin.BackColor = Color.DimGray;
        }

        private void rightLeg_Click(object sender, EventArgs e)
        {
            partBody = "רגל ימין";
            DataTable dt = functions.GetOrgansForCheckPatient(diagnosis, partBody);
            foreach (DataRow datarow in dt.Rows)
            {
                metroComboBox2.Items.Add(functions.GetOrganName(Convert.ToString(datarow["IdOrgan"])));
            }
            rightLeg.Enabled = false;
            rightLeg.BackColor = Color.DimGray;
        }
        private void leftLeg_Click(object sender, EventArgs e)
        {
            partBody = "רגל שמאל";
            DataTable dt = functions.GetOrgansForCheckPatient(diagnosis, partBody);
            foreach (DataRow datarow in dt.Rows)
            {
                metroComboBox2.Items.Add(functions.GetOrganName(Convert.ToString(datarow["IdOrgan"])));
            }
            leftLeg.Enabled = false;
            leftLeg.BackColor = Color.DimGray;
        }
        private Boolean checkFidings()
        {
            return checkFidingsBeforInsert(metroGrid1, "צפייה") && checkFidingsBeforInsert(metroGrid4, "נקישה") && checkFidingsBeforInsert(metroGrid3, "האזנה") && checkFidingsBeforInsert(metroGrid2,"מישוש");

        }
        private Boolean checkFidingsBeforInsert(DataGridView dataGrid, String principle)
        {
            
            var fidingsRows = dataGrid.Rows.OfType<DataGridViewRow>().Where(row => !row.IsNewRow).ToArray();

            foreach (var row in fidingsRows)
            {
                try
                {
                    if (principle.Equals("מישוש"))
                    {
                        if (row.Cells[3].Value.ToString().Length == 0)
                        {
                            MessageBox.Show("הינך נדרש להזין את כל הממצאים בעקרון" + principle);
                            return false;
                        }
                    }
                    else
                    {
                        if (row.Cells[2].Selected.ToString().Length == 0)
                        {
                            MessageBox.Show("הינך נדרש להזין את כל הממצאים בעקרון" + principle);
                            return false;
                        }
                    }
                }
                catch
                {

                } 
            }
            return true;
            
        }
       
        private void metroButton11_Click(object sender, EventArgs e)
        {
            this.Close();
            FollowUpEntry followUp = new FollowUpEntry(idTreatment);
            followUp.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            PatientTreatmentStatus patientTreatmentStatus = 
                new PatientTreatmentStatus(idTreatment,functions.GetPatientIdByTretment(idTreatment));
            patientTreatmentStatus.Show();
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            PatientMedicalRecord record = 
                new PatientMedicalRecord(functions.GetPatientIdByTretment(idTreatment), 
                functions.GetDoctorIdByTretment(idTreatment));
            record.Show();
        }

        private void ViewListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String organ = this.metroComboBox2.SelectedItem.ToString();
                String view = this.ViewListBox.SelectedItem.ToString();

                String numTest = functions.GetTestNum(diagnosis, organ, view, "כללי");
                ViewFidingsbyPrinciple(metroGrid6, "כללי", numTest);
                DataTable dt = functions.GetSidesForCheckPatient(diagnosis, partBody, organ, view);

                foreach (DataRow datarow in dt.Rows)
                {
                    String side = Convert.ToString(datarow["side"]).ToString().Trim();
                    if (!side.Equals("כללי"))
                    {
                        SideListBox.Items.Add(side);                       
                    }
                }
               
            }
            catch
            {

            }
        }

        private void SideListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String organ = this.metroComboBox2.SelectedItem.ToString();
            String view = this.ViewListBox.SelectedItem.ToString();
            String side = this.SideListBox.SelectedItem.ToString();
            
            String numTest = functions.GetTestNum(diagnosis, organ, view, side);
            this.numTest = numTest;
            ViewFidingsbyPrinciple(metroGrid1, "צפייה", numTest);
            ViewFidingsbyPrinciple(metroGrid4, "נקישה", numTest);
            ViewFidingsbyPrinciple(metroGrid3, "האזנה", numTest);
            ViewFidingsbyPrinciple(metroGrid2, "מישוש", numTest);
        }

    }
}
