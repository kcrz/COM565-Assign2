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
            if (textID.Text.Equals(DataStrings.EMPTY_STRING) || textPIN.Text.Equals(DataStrings.EMPTY_STRING))
            {
                // either the textbox is blank
                MessageBox.Show(DataStrings.INVALID_ID_PIN, DataStrings.ALERT, MessageBoxButtons.OK);
            }
            else
            {
                if (DataUtils.isUserIdVisitor(textID.Text.ToUpper()))
                {
                    //Visitors cannot log in
                    MessageBox.Show(DataStrings.VISITORS_NO_LOGIN, DataStrings.ALERT, MessageBoxButtons.OK);
                }
                else 
                {
                    if (DataOps.checkLogin(textID.Text.ToUpper(), textPIN.Text))
                    {
                        // login successfully
                        MessageBox.Show(DataStrings.LOGIN_OK, DataStrings.INFORMATION, MessageBoxButtons.OK);
                        string position = DataOps.getEmployeePosition(textID.Text);
                        //string position = "Admin"; //for debug
                        /* login status
                         * 1 Admin
                         * 2 Receptionist
                         * 3 Normal
                         */
                        switch (position)
                        {
                            case DataStrings.ADMIN_USER:
                                loginStatus = 1;
                                break;
                            case DataStrings.RECEPTIONIST_USER:
                                loginStatus = 2;
                                break;
                            case DataStrings.NORMAL_USER:
                                loginStatus = 3;
                                break;
                            default:
                                loginStatus = 3;
                                break;
                        }
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    { // login failed
                        MessageBox.Show(DataStrings.INVALID_LOGIN_CREDENTIAL, DataStrings.ALERT, MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}
