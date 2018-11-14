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
    public partial class NurseWorkStation : MetroFramework.Forms.MetroForm
    {
        private int childFormNumber = 0;
        private String idNurse;
        private MyDiagNobileFunctions functions = new MyDiagNobileFunctions();
        public NurseWorkStation(String id)
        {
            InitializeComponent();
            idNurse = id;
            CurrentUserNameLabel.Text = "שלום " + functions.GetNameUser(idNurse) + ",";
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

        
        //get the patient status
        private void PatientStatus(object sender, EventArgs e)
        {
            this.Hide();
            PatientMedicalRecord patient = new PatientMedicalRecord();
            patient.Show();

        }
        
        /**private void EnterDiagnosis(object sender, EventArgs e)
        {
            this.Hide();
            EnterTheDiagnostic enterTheDiagnostic = new EnterTheDiagnostic();
            enterTheDiagnostic.Show();
        }**/

        //exit from program
        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NurseWorkStation_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToShortDateString();
            TimeLabel.Text = DateTime.Now.ToShortTimeString();
        }

        //get patient medical record
        private void SpecificPatientStatusTile_Click(object sender, EventArgs e)
        {
            PatientMedicalRecord patientStatus = new PatientMedicalRecord();
            patientStatus.Show();
        }

        //get patient status
        private void PatientsStatusTile_Click(object sender, EventArgs e)
        {
            AllPatients all = new AllPatients(idNurse,"אחות");
            all.Show();
        }

        //get to see medical examinators
        private void SeeExaminatorsTile5_Click(object sender, EventArgs e)
        {
            MedicalExaminators medicalExaminators = new MedicalExaminators(idNurse);
            medicalExaminators.Show();
        }

        //open new treatment
        private void OpenTreatmentTile_Click(object sender, EventArgs e)
        {
            PatientsList patientsList = new PatientsList(idNurse);
            patientsList.Show();
            //OpenTreatmentProcess openTreatmentProcess = new OpenTreatmentProcess(idNurse);
            //openTreatmentProcess.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ReceivingPatient receiving = new ReceivingPatient(idNurse);
            receiving.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
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

        private void CurrentUserNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
