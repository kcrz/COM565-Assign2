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
            this.Activated += new EventHandler(this.MainForm_Activated);
            this.Load += new EventHandler(this.MainForm_Load);
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            // login and logout buttons
            if (!isLogin)
            {
                btn_login.Enabled = true;
                btn_logout.Enabled = false;
            }
            else
            {
                btn_login.Enabled = false;
                btn_logout.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form CardReader = new CardReader();
            CardReader.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (isLogin)
            {
                isLogin = false;
                btn_login.Enabled = true;
                btn_logout.Enabled = false;
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!isLogin)
            {
                btn_add.Enabled = false;
                btn_remove.Enabled = false;
                btn_update.Enabled = false;
                btn_search.Enabled = false;
            }
            else 
            {
                btn_add.Enabled = true;
                btn_remove.Enabled = true;
                btn_update.Enabled = true;
                btn_search.Enabled = true;
            }
        }
    }
}
