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

        private void btnStartFire_Click(object sender, EventArgs e) // start fire simulation
        {
            int index = getFireLocation.SelectedIndex;
            string message = null;
            string caption = "FIRE Simulator";

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
             *10 SRA 6
             */
            switch (index)
            {
                case 0: // General Administration
                    message = "WARNING: " + getFireLocation.Text + " is on FIRE!!! \n Deactivate door: F1, A1, A2, A3, A9";
                    MessageBox.Show(message, caption);
                    break;

                case 1: // Research Support
                    message = "WARNING: " + getFireLocation.Text + " is on FIRE!!! \n Deactivate door: F2, B1, B2";
                    MessageBox.Show(message, caption);
                    break;

                case 2: // Corridor A
                    message = "WARNING: " + getFireLocation.Text + " is on FIRE!!! \n Deactivate door: F1, F3, F4, A1 - A9";
                    MessageBox.Show(message, caption);
                    break;

                case 3: // Corridor B
                    message = "WARNING: " + getFireLocation.Text + " is on FIRE!!! \n Deactivate door: F3, F4";
                    MessageBox.Show(message, caption);
                    break;

                case 4: // Corridor C
                    message = "WARNING: " + getFireLocation.Text + " is on FIRE!!! \n Deactivate door: F3 - F6, C1 - C8";
                    MessageBox.Show(message, caption);
                    break;

                case 5: // SRA 1
                    message = "WARNING: " + getFireLocation.Text + " is on FIRE!!! \n Deactivate door: F3 - F6, C1, C2, C8";
                    MessageBox.Show(message, caption);
                    break;

                case 6: // SRA 2
                    message = "WARNING: " + getFireLocation.Text + " is on FIRE!!! \n Deactivate door: F3 - F6, C1, C7, C8";
                    MessageBox.Show(message, caption);
                    break;

                case 7: // SRA 3
                    message = "WARNING: " + getFireLocation.Text + " is on FIRE!!! \n Deactivate door: F3 - F6, C1, C3, C8";
                    MessageBox.Show(message, caption);
                    break;

                case 8: // SRA 4
                    message = "WARNING: " + getFireLocation.Text + " is on FIRE!!! \n Deactivate door: F3 - F6, C1, C4, C8";
                    MessageBox.Show(message, caption);
                    break;

                case 9: // SRA 5
                    message = "WARNING: " + getFireLocation.Text + " is on FIRE!!! \n Deactivate door: F3 - F6, C1, C5, C8";
                    MessageBox.Show(message, caption);
                    break;

                case 10: // SRA 6
                    message = "WARNING: " + getFireLocation.Text + " is on FIRE!!! \n Deactivate door: F3 - F6, C1, C6, C8";
                    MessageBox.Show(message, caption);
                    break;
                default:
                    MessageBox.Show("Please select a fire location for simulation", "Tip");
                    break;
            }
        }

        private void btnStartCF_Click(object sender, EventArgs e) // start cardreader failure simulation
        {
            if (getFailedDoor.Text.Equals(""))
            {
                MessageBox.Show("Please select a cardreader location for simulation", "Tip");
            }
            else 
            {
                MessageBox.Show("Cardreader of door " + getFailedDoor.Text + " does not work, please fix it", "Tip");
            }
        }

        private void btnStartIntr_Click(object sender, EventArgs e) // start intrusion simulation
        {
            if (getIntrDoor.Text.Equals(""))
            {
                MessageBox.Show("Please select a location for simulation", "Tip");
            }
            else
            {
                MessageBox.Show("Door " + getIntrDoor.Text + " is intruded, WARNING !!!", "Tip");
            }
        }

    }
}
