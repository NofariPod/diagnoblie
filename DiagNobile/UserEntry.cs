using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;



namespace DiagNobile
{
    public partial class UserEntry : MetroFramework.Forms.MetroForm
    {
        MyDiagNobileFunctions functions = new MyDiagNobileFunctions();

        public UserEntry()
        {
            InitializeComponent();    
        }
       
        private void UserEntry_Load(object sender, EventArgs e)
        {

        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IdInput_Click(object sender, EventArgs e)
        {

        }

        private void PasswordInput_Click(object sender, EventArgs e)
        {

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            try
            {
                SignIn();
            }

            catch
            {
                //SignIn();
                MessageBox.Show("not correct");
            }

            /**this.Hide();
            DoctorWorkStation doctorWorkStation = new DoctorWorkStation(LoginInputId.Text);
            doctorWorkStation.Show();
            //SignIn();**/
        }

        private void SignIn()
        {
            if (functions.CheckedUser(LoginInputId.Text))
            {
               
                if (functions.CheckedUser(LoginInputId.Text,LoginInputPass.Text))
                {
                    String permission = functions.GetPermission(LoginInputId.Text);
                    if (permission.Equals("רופא"))
                    {
                        this.Hide();
                        DoctorWorkStation doctorWorkStation = new DoctorWorkStation(LoginInputId.Text);
                        doctorWorkStation.Show();
                    }
                    else if (permission.Equals("אחות"))
                    {
                        this.Hide();
                        NurseWorkStation nurseWorkStation = new NurseWorkStation(LoginInputId.Text);
                        nurseWorkStation.Show();
                    }
                    else if (permission.Equals("אדמיניסטרטור"))
                    {
                        this.Hide();
                        AdminPage adminPage = new AdminPage();
                        adminPage.Show();
                    }
                }
                else
                {
                    MessageBox.Show("מס' תעודת זהות או סיסמא אינם נכונים");
                }
            }
            else
            {
                MessageBox.Show("המשתמש אינו קיים במערכת");
            }
           
        }
        private void IdInputBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void IdBox_Click(object sender, EventArgs e) { }

        private void Id(object sender, EventArgs e)
        {

        }
    }   
}
