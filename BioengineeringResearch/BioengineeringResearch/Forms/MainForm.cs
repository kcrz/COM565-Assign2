using BioengineeringResearch.Functions;
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

namespace BioengineeringResearch
{
    public partial class MainForm : Form
    {
        /* login status
         * 0 logout
         * 1 Admin
         * 2 Receptionist
         * 3 Normal
         */
        private int loginStatus = 0;

        public MainForm()
        {
            InitializeComponent();

            //Set data directory for the database
            AppDomain.CurrentDomain.SetData("DataDirectory", Application.StartupPath);

            this.Activated += new EventHandler(this.MainForm_Activated);
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            updateForm();
        }

        private void updateForm()
        {
            /* login status
             * 0 logout
             * 1 Admin
             * 2 Receptionist
             */
            switch (loginStatus)
            {
                case 0:
                    // Menue items
                    btnManage.Enabled = false;
                    btnSimulator.Enabled = false;
                    btnCCTV.Enabled = false;

                    // log buttons
                    btn_login.Enabled = true;
                    btn_logout.Enabled = false;

                    txtLogStatus.Text = " Your Status: Logout";
                    break;
                case 1:
                    // Menue items
                    btnManage.Enabled = true;
                    btnSimulator.Enabled = true;
                    btnCCTV.Enabled = true;

                    // log buttons
                    btn_login.Enabled = false;
                    btn_logout.Enabled = true;

                    txtLogStatus.Text = " Your Status: Admin";
                    break;
                case 2:
                    // Menue items
                    btnManage.Enabled = true;
                    btnSimulator.Enabled = true;
                    btnCCTV.Enabled = true;

                    // log buttons
                    btn_login.Enabled = false;
                    btn_logout.Enabled = true;

                    txtLogStatus.Text = " Your Status: Receptionist";
                    break;
                case 3:
                    // Menue items
                    btnManage.Enabled = true;
                    btnSimulator.Enabled = false;
                    btnCCTV.Enabled = false;

                    // log buttons
                    btn_login.Enabled = false;
                    btn_logout.Enabled = true;

                    txtLogStatus.Text = " Your Status: Normal";
                    break;
            }
        }

        private void btnDoorA1_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader();
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            LogForm logForm = new LogForm();
            DialogResult result = logForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                loginStatus = logForm.loginStatus;
                updateForm();
            }
        }

        private void btnDoorA2_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader();
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorA3_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader();
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorA4_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader();
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorA5_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader();
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorA6_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader();
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorA7_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader();
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorA8_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader();
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorA9_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader();
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorB1_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader();
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorB2_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader();
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorC1_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader();
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorC2_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader();
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorC3_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader();
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorC4_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader();
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorC5_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader();
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorC6_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader();
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorC7_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader();
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorC8_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader();
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorPortal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Bioengineering Research Ltd.", "Welcome");
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to logout?", "Tip", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                loginStatus = 0;
                updateForm();
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            ManageForm manageForm = new ManageForm(loginStatus);
            manageForm.ShowDialog();
        }

        private void btnSimulator_Click(object sender, EventArgs e)
        {
            SimulationForm simulator = new SimulationForm();
            simulator.ShowDialog();
        }

        private void btnCCTV_Click(object sender, EventArgs e)
        {
            CCTVForm cctvForm = new CCTVForm();
            cctvForm.ShowDialog();
        }

    }
}
