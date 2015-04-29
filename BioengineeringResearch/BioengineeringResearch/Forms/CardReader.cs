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
    /// <summary>
    /// Card readere form to simulate card access terminal
    /// Author: Kenneth Cruz, Kaiyang Zhou
    /// 30 Apr 2015
    /// </summary>
    public partial class CardReader : Form
    {
        private static int invalidEnter = 0;
        System.Threading.Timer _timeoutTimer;
        private string doorName = null;

        public CardReader(string dN)
        {
            InitializeComponent();
            doorName = dN;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = DataStrings.EMPTY_STRING;
            txtPIN.Text = DataStrings.EMPTY_STRING;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //another form of simulating a card reader failure
            if (txtID.Text.Equals(DataStrings.CARD_READER_SIM_ID))
            {
                MessageBox.Show(DataStrings.DOOR + doorName.ToUpper() + DataStrings.CARD_READER_FAILURE, DataStrings.ALERT);
            }
            //another form of simulating intruder in a door
            else if (txtID.Text.Equals(DataStrings.DOOR_INTRUDER_SIM))
            {
                MessageBox.Show(DataStrings.DOOR + doorName.ToUpper() + DataStrings.INTRUDER_DETECTED, DataStrings.ALERT);
            }
            //normal flow of process
            else
            {
                if (txtID.Text.Equals(DataStrings.EMPTY_STRING) || txtPIN.Text.Equals(DataStrings.EMPTY_STRING))
                {
                    // either the textbox is blank
                    MessageBox.Show(DataStrings.INVALID_ID, DataStrings.ALERT, MessageBoxButtons.OK);
                }
                else
                {
                    //Check if user login/pass matches
                    if (DataOps.checkLogin(txtID.Text, txtPIN.Text))
                    {
                        //Check if user have clearance to open door
                        if (DataOps.grantAccess(txtID.Text, doorName.ToUpper()))
                        {
                            // the user is authorized                 
                            _timeoutTimer = new System.Threading.Timer(OnTimerElapsed, null,
                                10000, System.Threading.Timeout.Infinite); // timeout is 10s
                            MessageBox.Show(doorName + DataStrings.DOOR_OPEN_NOTICE, DataStrings.INFORMATION, MessageBoxButtons.OK);

                            // save the history
                            if (!DataOps.createNewAccessHistoryEntry(txtID.Text, doorName))
                            {
                                MessageBox.Show("save failed");
                            }

                            this.Close();
                        }
                        else
                        {
                            string message = DataStrings.DOOR + doorName + DataStrings.HYPHEN + DataStrings.UNAUTHORISED_ACCESS + DataStrings.NEWLINE + DataStrings.ACCESS_DENIED;

                            MessageBox.Show(message, DataStrings.ALERT, MessageBoxButtons.OK);

                            invalidEnter++; // invalid attempt increases

                            // check if the invalid attempts are more than 3 times
                            if (invalidEnter == 3)
                            {
                                MessageBox.Show(DataStrings.DOOR_MULTIPLE_INVALID_ATTEMPT, DataStrings.ALERT, MessageBoxButtons.OK);
                                this.Close();
                            }
                            //this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show(DataStrings.INVALID_LOGIN_CREDENTIAL, DataStrings.ALERT, MessageBoxButtons.OK);

                        invalidEnter++; // invalid attempt increases

                        // check if the invalid attempts are more than 3 times
                        if (invalidEnter == 3)
                        {
                            MessageBox.Show(DataStrings.DOOR_MULTIPLE_INVALID_ATTEMPT, DataStrings.ALERT, MessageBoxButtons.OK);
                            this.Close();
                        }
                    }
                }
            }


        }

        private void OnTimerElapsed(object state)
        {
            IntPtr mbWnd = FindWindow(null, DataStrings.INFORMATION);
            if (mbWnd != IntPtr.Zero)
                SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            _timeoutTimer.Dispose();
        }

        const int WM_CLOSE = 0x0010;
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);


    }
}
