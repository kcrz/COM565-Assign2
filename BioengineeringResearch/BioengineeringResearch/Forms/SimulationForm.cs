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
    public partial class SimulationForm : Form
    {
        public SimulationForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStartFire_Click(object sender, EventArgs e)
        {
            /*Combobox item index
             *0 General Administration
             *1 Research Support
             *2 Corridor A
             *3 Corridor B
             *4 Corridor C
             *5 SRA 1
             *6 SRA 2
             *7 SRA 3
             *8 SRA 4
             *9 SRA 5
             *10SRA 6
             */
            MessageBox.Show(getFireLocation.Text + " is on fire!!!", "Simulator");
        }

    }
}
