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
        public bool isLogin = false;
        public const int STATUS_Employee = 1;
        public const int STATUS_Visitor = 2;
        public int loginStatus = 0;

        public MainForm()
        {
            InitializeComponent();
            this.Activated += new EventHandler(this.MainForm_Activated);
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (!isLogin)
            {
                //login and logout buttons
                btn_login.Enabled = true;
                btn_logout.Enabled = false;

                //function buttons and simulation
                btn_add.Enabled = false;
                btn_modify.Enabled = false;
                btn_Sim.Enabled = false;
            }
            else
            {
                //login and logout buttons
                btn_login.Enabled = false;
                btn_logout.Enabled = true;

                //function buttons and simulation
                btn_add.Enabled = true;
                btn_modify.Enabled = true;
                btn_Sim.Enabled = true;
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

                }
                else // logout no
                {

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
                LogForm LogForm = new LogForm();
                DialogResult result = LogForm.ShowDialog();

                switch (result)
                {
                    case DialogResult.OK:
                        
                        //btn_login.Enabled = false;
                        //btn_add.Enabled = true;
                        //btn_modify.Enabled = true;
                        
                        isLogin = true;
                        
                        
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
            AddForm addform = new AddForm();
            addform.ShowDialog();
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            ModifyForm modifyform = new ModifyForm();
            modifyform.ShowDialog();
        }

    }
}
