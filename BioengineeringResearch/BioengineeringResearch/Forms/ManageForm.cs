using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioengineeringResearch.Forms
{
    public partial class ManageForm : Form
    {
        /* login status
         * 1 Admin
         * 2 Receptionist
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
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
