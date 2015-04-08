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

namespace BioengineeringResearch
{
    public partial class MainForm : Form
    {
        // initialize variables
        //private bool isLogin = false;
        private bool isLogin = true; // for debugging

        /* login status
         * 1 Admin
         * 2 Receptionist
         */
        protected int loginStatus = 0;

        public MainForm()
        {
            InitializeComponent();

            //Set data directory for the database
            AppDomain.CurrentDomain.SetData("DataDirectory", Application.StartupPath);

            this.Activated += new EventHandler(this.MainForm_Activated);
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            updateMainForm();
        }

        private void updateMainForm() // this function is to refresh the form items
        {
            if (!isLogin) // login status is false
            {
                // login and logout buttons
                btn_login.Enabled = true;
                btn_logout.Enabled = false;

                // function buttons and simulation
                btn_add.Enabled = false;
                btn_search.Enabled = false;
                btn_Sim.Enabled = false;
            }
            else // login status is true
            {
                // updata login and logout buttons
                btn_login.Enabled = false;
                btn_logout.Enabled = true;

                // update function buttons and simulation
                btn_add.Enabled = true;
                btn_search.Enabled = true;
                btn_Sim.Enabled = true;
            }

            // update title
                if (loginStatus != 0)
                {
                    switch (loginStatus)
                    {
                        case 1:
                            this.Text = "Bioengineering Research Ltd.   Login Status: Admin.";
                            break;
                        case 2:
                            this.Text = "Bioengineering Research Ltd.   Login Status: Receptionist.";
                            break;
                    }
                }
                else
                {
                    this.Text = "Bioengineering Research Ltd.   Login Status: Logout.";
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

        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (isLogin)
            {
                DialogResult result = MessageBox.Show("Do you really want to logout?", "Tip", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) // logout yes
                {
                    isLogin = false;
                    loginStatus = 0;
                    updateMainForm();
                }
            }
            else
            {
                MessageBox.Show("Please login", "Tip");
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!isLogin)
            {
                LogForm logForm = new LogForm();
                DialogResult result = logForm.ShowDialog();

                switch (result)
                {
                    case DialogResult.OK:
                        isLogin = true;
                        loginStatus = logForm.loginStatus; // obtain login user status
                        //MessageBox.Show(loginStatus.ToString());
                        updateMainForm();   
                        break;
                    case DialogResult.Cancel:         
                        isLogin = false;
                        break;
                }
            }
        }

        private void btn_Sim_Click(object sender, EventArgs e)
        {
            SimulationForm simForm = new SimulationForm();
            simForm.ShowDialog();
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddForm addform = new AddForm(loginStatus);
            addform.ShowDialog();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            ModifyForm modifyform = new ModifyForm();
            modifyform.ShowDialog();
        }

    }
}
