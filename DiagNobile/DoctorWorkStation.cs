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
    public partial class DoctorWorkStation : MetroFramework.Forms.MetroForm
    {
        private int childFormNumber = 0;
        private String idDoctor;
        private MyDiagNobileFunctions functions = new MyDiagNobileFunctions();
        public DoctorWorkStation(String idD)
        {
            InitializeComponent();
            idDoctor = idD;
            CurrentUserNameLabel.Text = "שלום " + functions.GetNameUser(idDoctor) + ",";

        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        //entry to another user
        private void ChangeUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserEntry user = new UserEntry();
            user.Show();
        }

        //exit from program
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //get to patient medical record
        private void SpecificPatientStatusTile_Click(object sender, EventArgs e)
        {
            PatientMedicalRecord patient = new PatientMedicalRecord();
            patient.Show();
        }

        //get to patient history treatments
        private void PatientHistoryTile_Click(object sender, EventArgs e)
        {
            PatientMedicalRecord patientStatus = new PatientMedicalRecord();
            patientStatus.Show();
        }

        //get to see patient diagnosis
        private void TestExaminatorsTile_Click(object sender, EventArgs e)
        {
            PatientsList patientsList = new PatientsList(idDoctor);
            patientsList.Show();
            //PatientDiagnosis enterFindings = new PatientDiagnosis(idDoctor);
            //enterFindings.Show();
        }
        /**private void DiagnosticTile_Click(object sender, EventArgs e)
        {
            EnterTheDiagnostic enterTheDiagnostic = new EnterTheDiagnostic();
            enterTheDiagnostic.Show();
        }**/
        
        //get to medical examinators
        private void SeeExaminatorsTile5_Click(object sender, EventArgs e)
        {
            MedicalExaminators examinators = new MedicalExaminators(idDoctor);
            examinators.Show();
        }

        //get to status of patient
        private void PatientsStatusTile_Click(object sender, EventArgs e)
        {
            AllPatients allPatients = new AllPatients(idDoctor,"רופא");
            allPatients.Show();
        }

        //get to reports
        private void ReportsTile_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
        }

        private void DoctorWorkStation_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToShortDateString();
            TimeLabel.Text = DateTime.Now.ToShortTimeString();
        }

        private void CurrentUserNameLabel_Click(object sender, EventArgs e)
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

        private void ShowHoverText(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox5, "החלף משתמש");

        }
    }
}
