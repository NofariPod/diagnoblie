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
    public partial class Reports : MetroFramework.Forms.MetroForm
    {
        private MyDiagNobileFunctions functions = new MyDiagNobileFunctions();
        public Reports()
        {
            InitializeComponent();
            timeN.Text = functions.GetTimeAvgt("אחות");
            timeD.Text = functions.GetTimeAvgt("רופא");
            timeA.Text = functions.GetTimeAvgt("כללי");
            DataTable dt = functions.GetStatusPatientByDay();
            foreach (DataRow datarow in dt.Rows)
            {
                int n = metroGrid1.Rows.Add();
                metroGrid1.Rows[n].Cells[0].Value = Convert.ToString(datarow["myDate"]);
                metroGrid1.Rows[n].Cells[1].Value = Convert.ToString(datarow["sumPatientsForDay"]);
            }
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToShortDateString();
            TimeLabel.Text = DateTime.Now.ToShortTimeString();
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
            ToolTip ttt = new ToolTip();
            ttt.SetToolTip(this.pictureBox5, "החלף משתמש");
        }
    }
}
