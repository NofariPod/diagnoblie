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
    public partial class WorkStation : MetroFramework.Forms.MetroForm
    {
        private int childFormNumber = 0;

        public WorkStation()
        {
            InitializeComponent();
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

        private void OpenTreatment(object sender, EventArgs e)
        {
            this.Hide();
            OpenTreatmentProcess open = new OpenTreatmentProcess();
            open.Show();
        }

        private void PatientStatus(object sender, EventArgs e)
        {
            this.Hide();
            PatientStatus patient = new PatientStatus();
            patient.Show();

        }

        private void EnterFindings(object sender, EventArgs e)
        {
            this.Hide();
            EnteringFindings enterFindings = new EnteringFindings();
            enterFindings.Show();

        }

        private void EnterFollowUp(object sender, EventArgs e)
        {
            this.Hide();
            FollowUpEntry followUpEntry = new FollowUpEntry();
            followUpEntry.Show();
        }

        private void EnterDiagnosis(object sender, EventArgs e)
        {
            this.Hide();
            EnterTheDiagnostic enterTheDiagnostic = new EnterTheDiagnostic();
            enterTheDiagnostic.Show();
        }

        private void SeeExaminators(object sender, EventArgs e)
        {
            this.Hide();
            MedicalExaminators examinators = new MedicalExaminators();
            examinators.Show();
        }

        private void CloseTreatment(object sender, EventArgs e)
        {
            this.Hide();
            CloseTreatmentProcess close = new CloseTreatmentProcess();
            close.Show();
        }

        private void AllPatients(object sender, EventArgs e)
        {
            this.Hide();
            AllPatients allPatients = new AllPatients();
            allPatients.Show();
        }

        private void Reports(object sender, EventArgs e)
        {
            this.Hide();
            Reports reports = new Reports();
            reports.Show();
        }

        private void ChangeUser(object sender, EventArgs e)
        {
            this.Hide();
            UserEntry user = new UserEntry();
            user.Show();
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
