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
    public partial class MedicalExaminators : MetroFramework.Forms.MetroForm
    {
        private MyDiagNobileFunctions Functions = new MyDiagNobileFunctions();
        private String userId;
        public MedicalExaminators(String UserId)
        {
            InitializeComponent();
            userId = UserId;
            viewData();
        }
        public MedicalExaminators(String idP, String UserId)
        {
            InitializeComponent();
            userId = UserId;
            viewData();
        }

        private void MedicalExaminators_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToShortDateString();
            TimeLabel.Text = DateTime.Now.ToShortTimeString();
        }
        private void viewData()
        {
            String perm = Functions.GetPermission(userId);
            if (perm.Equals("אחות"))
            {
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                DataTable td = Functions.GetAllTestsTretmentsForNurse();
                ViewTests(td);
            }
            else
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                DataTable td = Functions.GetAllTestsTretmentsByDoctor(userId);
                ViewTests(td);
                ConfirmTesting.Visible = true;
                ConfirmTests.Visible = true;
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //display all tests
        private void ViewTests(DataTable dt)
        {
            metroGrid1.DataSource = dt;
        }

        //filter tests by patient
        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text==null || textBox3.Text.Length != 9)
            {
                MessageBox.Show("יש להקליד מספר בעל 9 ספרות");
            }
            else
            {
                DataTable dt = Functions.GetTestsList(textBox3.Text);
                ViewTests(dt);
            }            
        }       

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var rows = metroGrid1.Rows.OfType<DataGridViewRow>().Where(row => !row.IsNewRow).ToArray();

            foreach (var row in rows)
            {
                Functions.ConfrimTest(row.Cells[6].Value.ToString(), userId);
            }
            DataTable td = Functions.GetAllTestsTretmentsByDoctor(userId);
            ViewTests(td);
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

        private void ConfirmTesting_Click(object sender, EventArgs e)
        {
            var selectedRows = metroGrid1.SelectedRows.OfType<DataGridViewRow>().Where(row => !row.IsNewRow).ToArray();
            
            foreach (var row in selectedRows)
            {
                Functions.ConfrimTest(row.Cells[6].Value.ToString(),userId);
            }
            metroGrid1.ClearSelection();
            DataTable td = Functions.GetAllTestsTretmentsByDoctor(userId);
            ViewTests(td);
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            viewData();
        }
    }
}
