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

        public MainForm()
        {
            InitializeComponent();
            //this.Activated += new EventHandler(this.MainForm_Activated);
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
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (isLogin)
            {
                //isLogin = false;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!isLogin)
            {
                Form LogForm = new LogForm();
                LogForm.Show();

                //isLogin = true;
            }
        }

        private void btn_Sim_Click(object sender, EventArgs e)
        {
            Form simForm = new SimulationForm();
            simForm.Show();
        }

        private void btnDoorA2_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void btnDoorA3_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void btnDoorA4_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void btnDoorA5_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void btnDoorA6_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void btnDoorA7_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void btnDoorA8_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void btnDoorA9_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void btnDoorB1_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void btnDoorB2_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void btnDoorC1_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void btnDoorC2_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void btnDoorC3_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void btnDoorC4_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void btnDoorC5_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void btnDoorC6_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void btnDoorC7_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void btnDoorC8_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void btnDoorPortal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Bioengineering Research Ltd.", "Welcome");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Form addform = new AddForm();
            addform.Show();
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            Form modifyform = new ModifyForm();
            modifyform.Show();
        }

    }
}
