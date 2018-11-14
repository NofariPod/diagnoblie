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
    public partial class AdminPage : MetroFramework.Forms.MetroForm
    {
        MyDiagNobileFunctions functions = new MyDiagNobileFunctions();

        public AdminPage()
        {
            InitializeComponent();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

            DateLabel.Text = DateTime.Now.ToShortDateString();
            TimeLabel.Text = DateTime.Now.ToShortTimeString();
            ViewDataSourceList();
        } 

        //function to save inserted finding
        private void SaveFinding()
        {
            //check if finding exists
            if (functions.CheckFindingExists(metroTextBoxName.Text, metroComboBoxprinciple.Text, 
                metroComboBoxArea.Text, metroComboBox10.Text))
            {
                //the finding is exists
                MessageBox.Show("הממצא קיים במערכת");
            }
            else
            {
                //insert finding
                functions.InsertFinding(metroTextBoxName.Text, metroComboBoxprinciple.Text, 
                    metroComboBoxArea.Text, metroComboBox10.Text);
                String idF = functions.GetFindingNum(metroTextBoxName.Text, metroComboBoxprinciple.Text, 
                    metroComboBoxArea.Text, metroComboBox10.Text);
                if ((metroTextBox1.Text.Length > 0) && (!functions.CheckFindingOptionExists(idF, 
                    metroTextBox1.Text)))
                {
                    functions.InsertOptionFinding(idF, metroTextBox1.Text);
                }
                if ((metroTextBox2.Text.Length > 0) && (!functions.CheckFindingOptionExists(idF, 
                    metroTextBox2.Text)))
                {
                    functions.InsertOptionFinding(idF, metroTextBox2.Text);
                }
                if ((metroTextBox3.Text.Length > 0) && (!functions.CheckFindingOptionExists(idF, 
                    metroTextBox3.Text)))
                {
                    functions.InsertOptionFinding(idF, metroTextBox3.Text);
                }
                if ((metroTextBox4.Text.Length > 0) && (!functions.CheckFindingOptionExists(idF, 
                    metroTextBox4.Text)))
                {
                    functions.InsertOptionFinding(idF, metroTextBox4.Text);
                }
                if ((metroTextBox5.Text.Length > 0) && (!functions.CheckFindingOptionExists(idF, 
                    metroTextBox5.Text)))
                {
                    functions.InsertOptionFinding(idF, metroTextBox5.Text);
                }
                if ((metroTextBox6.Text.Length > 0) && (!functions.CheckFindingOptionExists(idF, 
                    metroTextBox6.Text)))
                {
                    functions.InsertOptionFinding(idF, metroTextBox6.Text);
                }
                MessageBox.Show("הממצא נכנס למערכת");
                metroTextBox1.Clear();
                metroTextBox2.Clear();
                metroTextBox3.Clear();
                metroTextBox4.Clear();
                metroTextBox5.Clear();
                metroTextBox6.Clear();
            }
        }

        //function to insert touching finding
        private void SaveFindingTouching()
        {
            if (functions.CheckFindingTouchingExists(metroComboBox2.Text, metroComboBoxprinciple.Text, 
                metroTextBox8.ToString(), metroComboBoxArea.Text, metroComboBox10.Text))
            {
                String idF = functions.GetFindingTouchingNum(metroComboBox2.Text, 
                    metroComboBoxprinciple.Text, metroTextBox8.Text, metroComboBoxArea.Text, 
                    metroComboBox10.Text);
                InsertOptionsFidingsTouching(idF);
            }
            else
            {
                functions.InsertFindingTouching(metroComboBox2.Text, metroComboBoxprinciple.Text, 
                    metroTextBox8.Text, metroComboBoxArea.Text, metroComboBox10.Text);
                String idF = functions.GetFindingTouchingNum(metroComboBox2.Text, 
                    metroComboBoxprinciple.Text, metroTextBox8.Text, metroComboBoxArea.Text, 
                    metroComboBox10.Text);
                InsertOptionsFidingsTouching(idF);
            }
        }

        //function to insert options to touching finding
        private void InsertOptionsFidingsTouching(String idF)
        {
            //check if text box is empty & option to touching finding exists
            if ((metroTextBox1.Text.Length > 0) && (!functions.CheckFindingOptionExists(idF, 
                metroTextBox1.Text)))
            {
                //insert option
                functions.InsertOptionFinding(idF, metroTextBox1.Text);
            }
            if ((metroTextBox2.Text.Length > 0) && (!functions.CheckFindingOptionExists(idF, 
                metroTextBox2.Text)))
            {
                functions.InsertOptionFinding(idF, metroTextBox2.Text);
            }
            if ((metroTextBox3.Text.Length > 0) && (!functions.CheckFindingOptionExists(idF, 
                metroTextBox3.Text)))
            {
                functions.InsertOptionFinding(idF, metroTextBox3.Text);
            }
            if ((metroTextBox4.Text.Length > 0) && (!functions.CheckFindingOptionExists(idF, 
                metroTextBox4.Text)))
            {
                functions.InsertOptionFinding(idF, metroTextBox4.Text);
            }
            if ((metroTextBox5.Text.Length > 0) && (!functions.CheckFindingOptionExists(idF, 
                metroTextBox5.Text)))
            {
                functions.InsertOptionFinding(idF, metroTextBox5.Text);
            }
            if ((metroTextBox6.Text.Length > 0) && (!functions.CheckFindingOptionExists(idF, 
                metroTextBox6.Text)))
            {
                functions.InsertOptionFinding(idF, metroTextBox6.Text);
            }
            MessageBox.Show("הממצא נכנס למערכת");
            metroTextBox1.Clear();
            metroTextBox2.Clear();
            metroTextBox3.Clear();
            metroTextBox4.Clear();
            metroTextBox5.Clear();
            metroTextBox6.Clear();
        }

        //function to add diagnostic test by side 
        private void InsertBySide(DataGridView dataGrid)
        {
            Object selectedItemDiagnosis = metroComboBox3.SelectedItem;
            Object selectedItemPartBody = metroComboBox4.SelectedItem;
            Object selectedItemOrgan = metroComboBox5.SelectedItem;
            Object selectedItemView = metroComboBox6.SelectedItem;
            Object selectedItemSide = metroComboBox7.SelectedItem;

            //check if test num exists
            if (!functions.CheckTestNumExists(selectedItemDiagnosis.ToString(), 
                selectedItemOrgan.ToString(), selectedItemView.ToString(), selectedItemSide.ToString()))
            {
                functions.InsertDiagnosisOrgans(selectedItemDiagnosis.ToString(), 
                    selectedItemOrgan.ToString(), selectedItemView.ToString(), selectedItemSide.ToString());
            }
            String numTest = functions.GetTestNum(selectedItemDiagnosis.ToString(), 
                selectedItemOrgan.ToString(), selectedItemView.ToString(), selectedItemSide.ToString());
            Object selectedItemPrinciple = metroComboBox8.SelectedItem;
            var selectedRows = 
                dataGrid.SelectedRows.OfType<DataGridViewRow>().Where(row => !row.IsNewRow).ToArray();

            foreach (var row in selectedRows)
            {
                String id = row.Cells[0].Value.ToString();
                functions.InsertOrganFindings(numTest, selectedItemPrinciple.ToString(), id);
            }
            dataGrid.ClearSelection();
        }

        //function to insert all tests to the table
        private void InsertAllTests(DataGridView dataGrid)
        {
            Object selectedItemDiagnosis = metroComboBox3.SelectedItem;
            Object selectedItemPartBody = metroComboBox4.SelectedItem;
            Object selectedItemOrgan = metroComboBox5.SelectedItem;
            Object selectedItemView = metroComboBox6.SelectedItem;
            Object selectedItemSide = metroComboBox7.SelectedItem;
            for (int i = 1; i < 4; ++i)
            {
                if (!functions.CheckTestNumExists(selectedItemDiagnosis.ToString(), 
                    selectedItemOrgan.ToString(), selectedItemView.ToString(), 
                    metroComboBox7.Items[i].ToString()))
                {
                    functions.InsertDiagnosisOrgans(selectedItemDiagnosis.ToString(), 
                        selectedItemOrgan.ToString(), selectedItemView.ToString(), 
                        metroComboBox7.Items[i].ToString());
                }
                String numTest = functions.GetTestNum(selectedItemDiagnosis.ToString(), 
                    selectedItemOrgan.ToString(), selectedItemView.ToString(), 
                    metroComboBox7.Items[i].ToString());
                Object selectedItemPrinciple = metroComboBox8.SelectedItem;
                var selectedRows = 
                    dataGrid.SelectedRows.OfType<DataGridViewRow>().Where(row => !row.IsNewRow).ToArray();

                foreach (var row in selectedRows)
                {
                    String id = row.Cells[0].Value.ToString();
                    functions.InsertOrganFindings(numTest, selectedItemPrinciple.ToString(), id);
                }
            }
            dataGrid.ClearSelection();
        }
        //function to insert all tests to the table
        private void InsertJustSidewaysTests(DataGridView dataGrid)
        {
            Object selectedItemDiagnosis = metroComboBox3.SelectedItem;
            Object selectedItemPartBody = metroComboBox4.SelectedItem;
            Object selectedItemOrgan = metroComboBox5.SelectedItem;
            Object selectedItemView = metroComboBox6.SelectedItem;
            //insert side left
            if (!functions.CheckTestNumExists(selectedItemDiagnosis.ToString(), 
                selectedItemOrgan.ToString(), selectedItemView.ToString(), ">|"))
            {
                functions.InsertDiagnosisOrgans(selectedItemDiagnosis.ToString(), 
                    selectedItemOrgan.ToString(), selectedItemView.ToString(), ">|");
            }
            String numTest = functions.GetTestNum(selectedItemDiagnosis.ToString(), 
                selectedItemOrgan.ToString(), selectedItemView.ToString(), ">|");
            //insert side right
            if (!functions.CheckTestNumExists(selectedItemDiagnosis.ToString(), 
                selectedItemOrgan.ToString(), selectedItemView.ToString(), "|<"))
            {
                functions.InsertDiagnosisOrgans(selectedItemDiagnosis.ToString(), 
                    selectedItemOrgan.ToString(), selectedItemView.ToString(), "|<");
            }
            String numTestR = functions.GetTestNum(selectedItemDiagnosis.ToString(), 
                selectedItemOrgan.ToString(), selectedItemView.ToString(), "|<");
            Object selectedItemPrinciple = metroComboBox8.SelectedItem;
            var selectedRows = 
                dataGrid.SelectedRows.OfType<DataGridViewRow>().Where(row => !row.IsNewRow).ToArray();

            foreach (var row in selectedRows)
            {
                String id = row.Cells[0].Value.ToString();
                functions.InsertOrganFindings(numTest, selectedItemPrinciple.ToString(), id);
                functions.InsertOrganFindings(numTestR, selectedItemPrinciple.ToString(), id);

            }
            dataGrid.ClearSelection();
        }
        //button to insert new organ to check
        private void AddOrgan_Click(object sender, EventArgs e)
        {
            if (functions.CheckOrganExists(OrganNameTextBox.Text))
            {
                MessageBox.Show("האיבר קיים במערכת");
            }
            else
            {
                functions.InsertOrgan(OrganNameTextBox.Text, BodyPartTextBox.Text);
                MessageBox.Show("האיבר נכנס בהצלחה למערכת");
            }
        }

        //function to view all data in table
        private void ViewDataSourceList()
        {
            DataTable dt = functions.GetAllDiagnosis();
            foreach (DataRow datarow in dt.Rows)
            {
                metroComboBox3.Items.Add(Convert.ToString(datarow["name"]));
                metroComboBox11.Items.Add(Convert.ToString(datarow["name"]));
                metroComboBox10.Items.Add(Convert.ToString(datarow["name"]));
            }
            DataTable dt1 = functions.GetAllPartBody();
            foreach (DataRow datarow in dt1.Rows)
            {
                metroComboBox4.Items.Add(Convert.ToString(datarow["PartBody"]));
            }   
        }

        private void ChangeUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserEntry user = new UserEntry();
            user.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChangeUser_Click(object sender, EventArgs e)
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
        }

        private void AddMedicineButton_Click(object sender, EventArgs e)
        {
            if (functions.CheckMedicationExists(MedicineTextBox.Text))
            {
                MessageBox.Show("התרופה כבר קיימת במערכת");
            }
            else
            {
                functions.InsertMedication(MedicineTextBox.Text);
                MessageBox.Show("התרופה עודכנה במערכת");
            }
        }

        private void AddTestButton_Click(object sender, EventArgs e)
        {
            if (functions.CheckTestExists(TestNameTextBox.Text, metroComboBox9.Text))
            {
                MessageBox.Show("הבדיקה כבר קיימת במערכת");
            }
            else
            {
                functions.InsertTest(TestNameTextBox.Text, metroComboBox9.Text);
                MessageBox.Show("הבדיקה עודכנה במערכת");
            }
        }
        
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroComboBox11.Text.Length == 0)
            {
                MessageBox.Show("לא נבחרה אבחנה");
            }
            else
            {
                String idDiagnosis = functions.GetNumDiagnosis(metroComboBox11.Text);
                //insert Imaging Tests
                ListView.SelectedListViewItemCollection imaging = this.metroListView1.SelectedItems;
                foreach (ListViewItem item in imaging)
                {
                    if (!functions.CheckDiagnosisTestExists(idDiagnosis,
                        functions.GetIdTest(item.SubItems[0].Text), "דימות"))
                    {
                        functions.InsertDiagnosisTests(idDiagnosis, 
                            functions.GetIdTest(item.SubItems[0].Text), "דימות");
                    }
                }

                //insert Laboratory Tests
                ListView.SelectedListViewItemCollection Laboratory = this.metroListView4.SelectedItems;
                foreach (ListViewItem item in Laboratory)
                {
                    if (!functions.CheckDiagnosisTestExists(idDiagnosis, 
                        functions.GetIdTest(item.SubItems[0].Text), "בדיקות"))
                    {
                        functions.InsertDiagnosisTests(idDiagnosis, 
                            functions.GetIdTest(item.SubItems[0].Text), "בדיקות");
                    }
                }
                             
                //insert intervention Tests
                ListView.SelectedListViewItemCollection intervention = this.metroListView3.SelectedItems;
                foreach (ListViewItem item in intervention)
                {
                    if (!functions.CheckDiagnosisTestExists(idDiagnosis, 
                        functions.GetIdTest(item.SubItems[0].Text), "התערבות"))
                    {
                        functions.InsertDiagnosisTests(idDiagnosis, 
                            functions.GetIdTest(item.SubItems[0].Text), "התערבות");
                    }
                }
                //insert Tracking Tests
                ListView.SelectedListViewItemCollection Tracking = this.metroListView2.SelectedItems;
                foreach (ListViewItem item in Tracking)
                {
                    if (!functions.CheckDiagnosisTestExists(idDiagnosis, 
                        functions.GetIdTest(item.SubItems[0].Text), "מעקב"))
                    {
                        functions.InsertDiagnosisTests(idDiagnosis, 
                            functions.GetIdTest(item.SubItems[0].Text), "מעקב");
                    }
                }
                //insert Medications
                ListView.SelectedListViewItemCollection Medicines = this.metroListView5.SelectedItems;
                foreach (ListViewItem item in Medicines)
                {
                    if (!functions.CheckDiagnosisMedicinesExists(idDiagnosis, 
                        functions.GetIdMedication(item.SubItems[0].Text)))
                    {
                        functions.InsertDiagnosisMedication(idDiagnosis, 
                            functions.GetIdMedication(item.SubItems[0].Text));
                    }
                }

                MessageBox.Show("התוכנית הוזנה בהצלחה");
                metroListView1.SelectedItems.Clear();
                metroListView2.SelectedItems.Clear();
                metroListView3.SelectedItems.Clear();
                metroListView4.SelectedItems.Clear();
                metroListView5.SelectedItems.Clear();
            }

        }

        private void AddSymptom_Click_1(object sender, EventArgs e)
        {
            Object selectedItemPrinciple = metroComboBoxprinciple.SelectedItem;

            if (metroComboBoxprinciple.SelectedIndex == 3)
            {
                SaveFindingTouching();
            }
            else
            {
                SaveFinding();
            }
        }

        private void Add_Click_1(object sender, EventArgs e)
        {
            if (metroComboBox7.SelectedIndex == 0)
            {
                if (metroComboBox8.SelectedIndex == 3)
                {
                    InsertAllTests(metroGrid2);
                }
                else
                {
                    InsertAllTests(metroGrid1);
                }

            }
            else if (metroComboBox7.SelectedIndex == 5)
            {
                if (metroComboBox8.SelectedIndex == 3)
                {
                    InsertJustSidewaysTests(metroGrid2);
                }
                else
                {
                    InsertJustSidewaysTests(metroGrid1);
                }
            }
            else
            {
                if (metroComboBox8.SelectedIndex == 3)
                {
                    InsertBySide(metroGrid2);
                }
                else
                {
                    InsertBySide(metroGrid1);
                }
            }
        }

        private void AddSym_Click(object sender, EventArgs e)
        {
            //check if the symptom already exists
            if (functions.CheckSymptomExists(metroTextBox17.Text))
            {
                //the symptom exists
                MessageBox.Show("הסימפטום קיים במערכת");
            }
            else
            {
                //insert symptom
                functions.InsertSymptom(metroTextBox17.Text);
            }
        }
        //function to reset password
        private void UpdatePassword_Click_1(object sender, EventArgs e)
        {
            //check if 2 password that inserted are equals
            if (PasswordAgainTextBox.Text.Equals(NewPasswordTextBox.Text))
            {
                functions.ResetPassword(IdTextBox.Text, PasswordAgainTextBox.Text);
            }
            else
            {
                //the passwords doesn't match
                MessageBox.Show("הסיסמאות אינן תואמות");
            }
        }
        private void NewUserButton_Click_1(object sender, EventArgs e)
        {
            //add new user - add button
            if (PassTextBox.Text.Equals(PassAgainTextBox.Text))
            {
                //functions.InsertUser(NewIdTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text, PermissionTextBox.Text, PassTextBox.Text);
            }
            else
            {
                //passwords doesn't match
                MessageBox.Show("הסיסמאות אינן תואמות");
            }
        }
        //function to add new diagnosis
        private void AddDiag_Click_1(object sender, EventArgs e)
        {
            //check if the diagnosis already exists
            if (functions.CheckDiagnosisExists(diagnosidNameTextBox.Text))
            {
                //the diagnosis exists
                MessageBox.Show("האבחנה קיימת במערכת");
            }
            else
            {
                //insert diagnosis
                functions.InsertDiagnosis(diagnosidNameTextBox.Text, metroTextBox7.Text);
            }
        }
        //view textBox by principle
        private void metroComboBoxprinciple_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBoxprinciple.SelectedIndex == 3)
            {
                metroLabel1.Visible = false;
                metroTextBoxName.Visible = false;
                metroLabel11.Visible = true;
                metroTextBox8.Visible = true;
                metroLabel16.Visible = true;
                metroComboBox2.Visible = true;
            }
            else
            {
                metroLabel1.Visible = true;
                metroTextBoxName.Visible = true;
                metroLabel11.Visible = false;
                metroTextBox8.Visible = false;
                metroComboBox2.Visible = false;
                metroLabel16.Visible = false;
            }
        }

        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            String part = this.metroComboBox4.SelectedItem.ToString();
            DataTable dt = functions.GetOrganByPartBody(part);
            foreach (DataRow datarow in dt.Rows)
            {
                metroComboBox5.Items.Add(Convert.ToString(datarow["OrganDescription"]));
            }
        }
        //view fidings
        private void metroComboBox8_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            metroGrid1.Rows.Clear();
            String area = metroComboBox7.Text;
            Object selectedItem = metroComboBox8.SelectedItem;
            DataTable dt = functions.GetFindingByPrinciple(selectedItem.ToString(), metroComboBox3.Text);
            if (metroComboBox8.SelectedIndex == 3)
            {
                metroGrid2.Visible = true;
                metroGrid1.Visible = false;
                foreach (DataRow datarow in dt.Rows)
                {
                    if (area.Equals("ימין") || area.Equals("שמאל"))
                    {
                        if (datarow["Area"].Equals("צדדי") || datarow["Area"].Equals("הכל"))
                        {
                            int n = metroGrid2.Rows.Add();
                            metroGrid2.Rows[n].Cells[0].Value = Convert.ToString(datarow["Id"]);
                            metroGrid2.Rows[n].Cells[1].Value = Convert.ToString(datarow["name"]);
                            metroGrid2.Rows[n].Cells[2].Value = Convert.ToString(datarow["subFindings"]);
                            DataTable dt1 = functions.GetOptionsFinding(Convert.ToString(datarow["Id"]));
                            int i = 3;
                            foreach (DataRow datarow1 in dt1.Rows)
                            {
                                metroGrid2.Rows[n].Cells[i].Value = Convert.ToString(datarow1["OptionFinding"]);
                                ++i;
                            }
                        }
                    }
                    if (area.Equals("אמצע"))
                    {
                        if (datarow["Area"].Equals("אמצע") || datarow["Area"].Equals("הכל"))
                        {
                            int n = metroGrid2.Rows.Add();
                            metroGrid2.Rows[n].Cells[0].Value = Convert.ToString(datarow["Id"]);
                            metroGrid2.Rows[n].Cells[1].Value = Convert.ToString(datarow["name"]);
                            metroGrid2.Rows[n].Cells[2].Value = Convert.ToString(datarow["subFindings"]);
                            DataTable dt1 = functions.GetOptionsFinding(Convert.ToString(datarow["Id"]));
                            int i = 3;
                            foreach (DataRow datarow1 in dt1.Rows)
                            {
                                metroGrid2.Rows[n].Cells[i].Value = Convert.ToString(datarow1["OptionFinding"]);
                                ++i;
                            }
                        }
                    }
                    else
                    {
                        int n = metroGrid2.Rows.Add();
                        metroGrid2.Rows[n].Cells[0].Value = Convert.ToString(datarow["Id"]);
                        metroGrid2.Rows[n].Cells[1].Value = Convert.ToString(datarow["name"]);
                        metroGrid2.Rows[n].Cells[2].Value = Convert.ToString(datarow["subFindings"]);
                        DataTable dt1 = functions.GetOptionsFinding(Convert.ToString(datarow["Id"]));
                        int i = 3;
                        foreach (DataRow datarow1 in dt1.Rows)
                        {
                            metroGrid2.Rows[n].Cells[i].Value = Convert.ToString(datarow1["OptionFinding"]);
                            ++i;
                        }
                    }
                }
            }
            else
            {
                metroGrid2.Visible = false;
                metroGrid1.Visible = true;
                foreach (DataRow datarow in dt.Rows)
                {
                    int n = metroGrid1.Rows.Add();
                    metroGrid1.Rows[n].Cells[0].Value = Convert.ToString(datarow["Id"]);
                    metroGrid1.Rows[n].Cells[1].Value = Convert.ToString(datarow["name"]);
                    metroGrid2.Rows[n].Cells[2].Value = Convert.ToString(datarow["subFindings"]);
                    DataTable dt1 = functions.GetOptionsFinding(Convert.ToString(datarow["Id"]));
                    int i = 3;
                    foreach (DataRow datarow1 in dt1.Rows)
                    {
                        metroGrid1.Rows[n].Cells[i].Value = Convert.ToString(datarow1["OptionFinding"]);
                        ++i;
                    }
                }
            }
        }

        private void metroComboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroListView1.Items.Clear();
            metroListView2.Items.Clear();
            metroListView3.Items.Clear();
            metroListView4.Items.Clear();
            metroListView5.Items.Clear();
            //get the test in the system
            DataTable dtT = functions.GetAllTests();
            foreach (DataRow datarow in dtT.Rows)
            {
                //view test in tracking tests
                var item1 = new ListViewItem(new[] { Convert.ToString(datarow["name"]), Convert.ToString(datarow["typeTest"]) });
                metroListView2.Items.Add(item1);
            }
            foreach (DataRow datarow in dtT.Rows)
            {
                //view test in intervention tests
                var item1 = new ListViewItem(new[] { Convert.ToString(datarow["name"]), Convert.ToString(datarow["typeTest"]) });
                metroListView3.Items.Add(item1);
            }
            //get the lab test in the system and view in window tests
            DataTable dtTt = functions.GetTestsByType("מעבדה");
            foreach (DataRow datarow in dtTt.Rows)
            {
                metroListView4.Items.Add(Convert.ToString(datarow["name"]));
            }
            //get the imaging test in the system and view in window tests
            DataTable dtTd = functions.GetTestsByType("דימות");
            foreach (DataRow datarow in dtTd.Rows)
            {
                metroListView1.Items.Add(Convert.ToString(datarow["name"]));
            }
            //get the Medicines test in the system and view in window Medicines
            DataTable dtM = functions.GetAllMedicines();
            foreach (DataRow datarow in dtM.Rows)
            {
                metroListView5.Items.Add(Convert.ToString(datarow["name"]));

            }
        }

        private void metroComboBoxArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
