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
using BioengineeringResearch.Forms;

namespace BioengineeringResearch
{
    public partial class LogForm : Form
    {
        /* login status
         * 1 Admin
         * 2 Receptionist
         * 3 Normal
         */
        public int loginStatus = 0;

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
                // either the textbox is blank
                MessageBox.Show("Please input correct ID or PIN", "Tip", MessageBoxButtons.OK);
            }
            else
            {
                loginYes = DataOps.checkLogin(textID.Text, textPIN.Text);
                //loginYes = true; // for debugging

                if (loginYes)
                {
                    // login successfully
                    MessageBox.Show("Login successfully", "Tip", MessageBoxButtons.OK);
                    string position = DataOps.getEmployeePosition(textID.Text);

                    /* login status
                     * 1 Admin
                     * 2 Receptionist
                     * 3 Normal
                     */
                    switch (position)
                    {
                        case "Admin":
                            loginStatus = 1;
                            break;
                        case "Receptionist":
                            loginStatus = 2;
                            break;
                        case "Normal":
                            loginStatus = 3;
                            break;
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // login failed
                    MessageBox.Show("Invalid ID or PIN", "Tip", MessageBoxButtons.OK);
                }
            }
        }
    }
}
