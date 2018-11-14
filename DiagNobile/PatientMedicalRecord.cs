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
    public partial class PatientMedicalRecord : MetroFramework.Forms.MetroForm
    {
        private String idPatient;
        String UserId;
        String Perm;
        private MyDiagNobileFunctions functions = new MyDiagNobileFunctions();
        public PatientMedicalRecord()
        {
            InitializeComponent();
        }
        public PatientMedicalRecord(String idP,String userId)
        {
            InitializeComponent();
            idPatient = idP;
            UserId = userId;
            Perm = functions.GetPermission(UserId);
            if (Perm.Equals("אחות"))
            {
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
            }
            else
            {
                pictureBox5.Visible = true;
                pictureBox4.Visible = false;
            }
            ShowDataByPatient();
        }

        private void PatientStatus_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToShortDateString();
            TimeLabel.Text = DateTime.Now.ToShortTimeString();
        }

        //function to display patient first details
        private void ShowDataByPatient()
        {
            DataTable tblAuthors = functions.GetFirstPatientDetails(idPatient);
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} ",
                drCurrent["FirstName"].ToString(),
                drCurrent["LastName"].ToString(),
                drCurrent["DateBirth"].ToString(),
                drCurrent["ChronicDiseases"].ToString(),
                drCurrent["Sensitivity"].ToString());

            }
            Console.ReadLine();
            String firstName = Convert.ToString(tblAuthors.Rows[0]["FirstName"]);
            String lastName = Convert.ToString(tblAuthors.Rows[0]["LastName"]);
            String DateBirth = Convert.ToString(tblAuthors.Rows[0]["DateBirth"]);
            String chronicDiseases = Convert.ToString(tblAuthors.Rows[0]["ChronicDiseases"]);
            String sensitivity = Convert.ToString(tblAuthors.Rows[0]["Sensitivity"]);
            String age = functions.GetAge(idPatient);

            IdTextBox.Text = idPatient;
            FirstNameTextBox.Text = firstName;
            LastNameTextBox.Text = lastName;
            ChronicDiseasesTextBox.Text = chronicDiseases;
            SensitivityTextBox.Text = sensitivity;
            DOB.Text = DateBirth;
            AgeTextBox.Text = age;
            DataTable tblTests = functions.GetTestsList(idPatient);
            metroGrid1.DataSource = tblTests;

        }
        
        //validator of input id
        private void ViewDataButton_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text == null)
            {
                MessageBox.Show("לא הוכנס מספר תעודת זהות");
            }
            else if (IdTextBox.Text.Length != 9)
            {
                MessageBox.Show("יש להכניס מספר בעל 9 ספרות");
            }
            else
            {
                idPatient = IdTextBox.Text;
                ShowDataByPatient();
            }
        }

        //close form
        private void metroButton10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //function to display current treatment
        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (functions.CheckTretmentOpen(idPatient)){
                String t = functions.GetTreatmentNum(idPatient);
                this.Close();
                TreatmentSummary diagnostic = new TreatmentSummary(idPatient, UserId);
                diagnostic.Show();                       
            }
            else
            {
                if (IdTextBox.Text.Length == 0)
                {
                    MessageBox.Show("לא נבחר מטופל");
                }
                else
                {
                MessageBox.Show("המטופל אינו מטופל במחלקה");
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (groupBox2.Visible == false)
            {
                if (metroGrid1.SelectedRows.Count > 0)
                {
                    groupBox2.Visible = true;
                    button1.Text = "סגור עדכון תוצאות";
                    int selectedrowindex = metroGrid1.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = metroGrid1.Rows[selectedrowindex];

                    num.Text = Convert.ToString(selectedRow.Cells["testNumDataGridViewTextBoxColumn"].Value);
                    name.Text = functions.GetNameTest(num.Text);
                    testNum.Text = Convert.ToString(selectedRow.Cells["Column1"].Value);
                }


            }
            else
            {
                groupBox2.Visible = false;
                button1.Text = "עדכון תוצאות";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            functions.UpdateTestTreatment(testNum.Text, dateTimePicker1.Text, metroTextBox1.Text);
            DataTable tblTests = functions.GetTestsList(idPatient);
            metroGrid1.DataSource = tblTests;
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = metroGrid1.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = metroGrid1.Rows[selectedrowindex];

            num.Text = Convert.ToString(selectedRow.Cells["testNumDataGridViewTextBoxColumn"].Value);
            name.Text = functions.GetNameTest(num.Text);
            testNum.Text = Convert.ToString(selectedRow.Cells["Column1"].Value);
        }
    }
}

