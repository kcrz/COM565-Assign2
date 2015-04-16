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
        string _caption = "Door Tip";
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
            txtID.Text = "";
            txtPIN.Text = "";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool loginYes = false;

            if (txtID.Text.Equals("") || txtPIN.Text.Equals(""))
            {
                // either the textbox is blank
                MessageBox.Show("Please input correct ID or PIN", "Tip", MessageBoxButtons.OK);
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
                    MessageBox.Show(doorName + " is open successfully, after 5s door will be close.", _caption);

                    // save the history

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid ID or PIN !!!", "Tip", MessageBoxButtons.OK);

                    invalidEnter++; // invalid attempt increases

                    // check if the invalid attempts are more than 3 times
                    if (invalidEnter == 3)
                    {
                        MessageBox.Show("Multiple invalid attempts. Disabling door !!!", "Tip", MessageBoxButtons.OK);
                        this.Close();
                    }
                }
            }
        }

        private void OnTimerElapsed(object state)
        {
            IntPtr mbWnd = FindWindow(null, _caption);
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
