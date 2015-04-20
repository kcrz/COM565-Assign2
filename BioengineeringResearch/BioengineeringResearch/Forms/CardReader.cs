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
            bool loginYes = false;

            if (txtID.Text.Equals(DataStrings.EMPTY_STRING) || txtPIN.Text.Equals(DataStrings.EMPTY_STRING))
            {
                // either the textbox is blank
                MessageBox.Show(DataStrings.INVALID_ID, DataStrings.ALERT, MessageBoxButtons.OK);
            }
            else
            {
                loginYes = DataOps.checkLogin(txtID.Text, txtPIN.Text);

                // check if the user is authorized
                if (loginYes)
                {
                    // login successfully                   
                    _timeoutTimer = new System.Threading.Timer(OnTimerElapsed, null, 
                        5000, System.Threading.Timeout.Infinite); // timeout is 5s
                    MessageBox.Show(doorName + DataStrings.DOOR_OPEN_NOTICE, DataStrings.INFORMATION);

                    // save the history
                    /*
                    if (!DataOps.createNewAccessHistoryEntry(txtID.Text, doorName))
                    {
                        MessageBox.Show("save failed");
                    }*/

                    this.Close();
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
