using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioengineeringResearch.DataOperations;

namespace BioengineeringResearch
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bool loginYes = false;

            if (textID.Text.Equals("") || textPIN.Text.Equals(""))
            {
                MessageBox.Show("Please input correct ID or PIN", "Tip", MessageBoxButtons.OK);
            }
            else
            {
                loginYes = DataOps.checkLogin(textID.Text, textPIN.Text);
                
                if (loginYes)
                {
                    MessageBox.Show("Yes", "Tip", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Invalid ID or PIN", "Tip", MessageBoxButtons.OK);
                }
            }
        }
    }
}
