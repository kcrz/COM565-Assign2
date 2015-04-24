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

namespace BioengineeringResearch.Forms
{
    public partial class CCTVForm : Form
    {
        public CCTVForm()
        {
            InitializeComponent();
            timer.Start();
        }

        private void messageTimer_Tick(object sender, EventArgs e)
        {
            currtime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCallPolice_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DataStrings.CONTACTING_POLICE);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            currtime.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }
    }
}
