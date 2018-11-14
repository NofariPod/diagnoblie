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
    public partial class AllPatients : MetroFramework.Forms.MetroForm
    {
        MyDiagNobileFunctions functions = new MyDiagNobileFunctions();
        String idUser;
        String typeUser;
        public AllPatients(String id, String type)
        {
            InitializeComponent();
            idUser = id;
            typeUser = type;
            DataTable td = functions.GetPatientsList();
            ViewPatients(td);
            if (typeUser.Equals("אחות"))
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
        }
        private void ViewPatientsByType()
        {
            if (typeUser.Equals("אחות"))
            {

                DataTable td = functions.GetPatientsListByNurse(idUser);
                ViewPatients(td);
            }
            if (typeUser.Equals("רופא")) {
                DataTable td = functions.GetPatientsListByDoctor(idUser);
                ViewPatients(td);
            }
            
        }


        private void AllPatients_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToShortDateString();
            TimeLabel.Text = DateTime.Now.ToShortTimeString();
            // TODO: This line of code loads data into the 'diagnobile_DatabaseDataSet.Patients' table. You can move, or remove it, as needed.
        }

        //view all patients list
        private void ViewPatients(DataTable dt)
        {
            AllPatientsGrid.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = AllPatientsGrid.Rows.Add();
                AllPatientsGrid.Rows[n].Cells[0].Value = Convert.ToString(item["PatientId"]); 
                AllPatientsGrid.Rows[n].Cells[1].Value = Convert.ToString(item["FirstName"]);
                AllPatientsGrid.Rows[n].Cells[2].Value = Convert.ToString(item["LastName"]);
                if (functions.CheckTimeValueExists(Convert.ToString(item["TreatmentNum"]), "כללי"))
                {
                    AllPatientsGrid.Rows[n].Cells[3].Value = 
                        functions.GetReceptionTime(Convert.ToString(item["TreatmentNum"]), "כללי");
                }
                AllPatientsGrid.Rows[n].Cells[4].Value = Convert.ToString(item["TreatmentStatus"]);
            }
            ReleasedPatientsSum.Text = functions.GetSumPatientsStatusRelease();
            PatientsInTreatmentSum.Text = functions.GetSumPatientsStatusInTherapy();
            ReceivedPatientsSum.Text = functions.GetSumPatientsStatusReception();
        }

        //function to filter patient by inserted id
        private void FilterPatientButton_Click(object sender, EventArgs e)
        {
            //check if text box is empty || id != 9
            if (EnterIdTextBox.Text == null || EnterIdTextBox.Text.Length != 9)
            {
                MessageBox.Show("יש להקליד מספר בעל 9 ספרות");
            }
            else
            {
                //show patient status
                DataTable dt = functions.GetPatientStatus(EnterIdTextBox.Text);
                ViewPatients(dt);
            }
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ViewPatientsByType();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DataTable td = functions.GetPatientsList();
            ViewPatients(td);
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
            if (pictureBox1.Visible == true)
            {
                ToolTip tt = new ToolTip();
                tt.SetToolTip(this.pictureBox1, "החלף משתמש");

            }
            else if (pictureBox2.Visible == true)
            {
                ToolTip ttt = new ToolTip();
                ttt.SetToolTip(this.pictureBox2, "החלף משתמש");
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            functions.EmptyLooseTreatments();
            ViewPatientsByType();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (AllPatientsGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = AllPatientsGrid.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = AllPatientsGrid.Rows[selectedrowindex];

                
                String numT = functions.GetNumTreatmentById(Convert.ToString(selectedRow.Cells[0].Value));
                String myId = Convert.ToString(selectedRow.Cells[0].Value);
                PatientTreatmentStatus status = new PatientTreatmentStatus(numT, myId);
                status.Show();
            }
            else
            {
                MessageBox.Show("לא בחרת מטופל");
            }


        }
    }
}
