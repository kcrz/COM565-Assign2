using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioengineeringResearch.Forms;
using BioengineeringResearch.Functions;

namespace BioengineeringResearch.Forms
{
    public partial class ManageForm : Form
    {
        /* login status
         * 1 Admin
         * 2 Receptionist
         * 3 Normal
         */
        private int loginStatus = 0;

        public ManageForm(int Status)
        {
            InitializeComponent();
            loginStatus = Status;
            switch (Status)
            {
                case 1: // 1 Admin
                    txtLogStatus.Text = "Your Status: Admin";
                    break;
                case 2: // 2 Receptionist
                    txtLogStatus.Text = "Your Status: Receptionist";
                    break;
                case 3: // 3 Normal
                    txtLogStatus.Text = "Your Status: Normal";
                    break;

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSrchPerson_Click(object sender, EventArgs e)
        {
            if (rbID.Checked == true)
            {

            }
            else if (rbFirstName.Checked == true)
            {

            }
            else if (rbLastName.Checked == true)
            {

            }
        }

        private void btnShowAllVist_Click(object sender, EventArgs e)
        {

        }

        private void btnShowAllEmp_Click(object sender, EventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {

        }

        private void btnDeltPerson_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(loginStatus);
            addForm.ShowDialog();
        }
    }
}
