using BioengineeringResearch.DataOperations;
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
            string caption = DataStrings.FIRE_SIMULATOR;

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
                    message = DataStrings.WARNING + getFireLocation.Text + DataStrings.IS_ON_FIRE + DataStrings.NEWLINE + DataStrings.FIRE_GEN_ADMIN;
                    MessageBox.Show(message, caption);
                    break;

                case 1: // Research Support
                    message = DataStrings.WARNING + getFireLocation.Text + DataStrings.IS_ON_FIRE + DataStrings.NEWLINE + DataStrings.FIRE_RESEARCH_SUPP;
                    MessageBox.Show(message, caption);
                    break;

                case 2: // Corridor A
                    message = DataStrings.WARNING + getFireLocation.Text + DataStrings.IS_ON_FIRE + DataStrings.NEWLINE + DataStrings.FIRE_CORRIDOR_A;
                    MessageBox.Show(message, caption);
                    break;

                case 3: // Corridor B
                    message = DataStrings.WARNING + getFireLocation.Text + DataStrings.IS_ON_FIRE + DataStrings.NEWLINE + DataStrings.FIRE_CORRIDOR_B;
                    MessageBox.Show(message, caption);
                    break;

                case 4: // Corridor C
                    message = DataStrings.WARNING + getFireLocation.Text + DataStrings.IS_ON_FIRE + DataStrings.NEWLINE + DataStrings.FIRE_CORRIDOR_C;
                    MessageBox.Show(message, caption);
                    break;

                case 5: // SRA 1
                    message = DataStrings.WARNING + getFireLocation.Text + DataStrings.IS_ON_FIRE + DataStrings.NEWLINE + DataStrings.FIRE_SRA_1;
                    MessageBox.Show(message, caption);
                    break;

                case 6: // SRA 2
                    message = DataStrings.WARNING + getFireLocation.Text + DataStrings.IS_ON_FIRE + DataStrings.NEWLINE + DataStrings.FIRE_SRA_2;
                    MessageBox.Show(message, caption);
                    break;

                case 7: // SRA 3
                    message = DataStrings.WARNING + getFireLocation.Text + DataStrings.IS_ON_FIRE + DataStrings.NEWLINE + DataStrings.FIRE_SRA_3;
                    MessageBox.Show(message, caption);
                    break;

                case 8: // SRA 4
                    message = DataStrings.WARNING + getFireLocation.Text + DataStrings.IS_ON_FIRE + DataStrings.NEWLINE + DataStrings.FIRE_SRA_4;
                    MessageBox.Show(message, caption);
                    break;

                case 9: // SRA 5
                    message = DataStrings.WARNING + getFireLocation.Text + DataStrings.IS_ON_FIRE + DataStrings.NEWLINE + DataStrings.FIRE_SRA_5;
                    MessageBox.Show(message, caption);
                    break;

                case 10: // SRA 6
                    message = DataStrings.WARNING + getFireLocation.Text + DataStrings.IS_ON_FIRE + DataStrings.NEWLINE + DataStrings.FIRE_SRA_6;
                    MessageBox.Show(message, caption);
                    break;
                default:
                    MessageBox.Show(DataStrings.FIRE_SELECT_LOCATION, DataStrings.INFORMATION);
                    break;
            }
        }

        private void btnStartCF_Click(object sender, EventArgs e) // start cardreader failure simulation
        {
            if (getFailedDoor.Text.Equals(DataStrings.EMPTY_STRING))
            {
                MessageBox.Show(DataStrings.SELECT_CARD_READER_SIMUL, DataStrings.ALERT);
            }
            else 
            {
                MessageBox.Show(DataStrings.DOOR + getFailedDoor.Text + DataStrings.CARD_READER_FAILURE, DataStrings.ALERT);
            }
        }

        private void btnStartIntr_Click(object sender, EventArgs e) // start intrusion simulation
        {
            if (getIntrDoor.Text.Equals(DataStrings.EMPTY_STRING))
            {
                MessageBox.Show(DataStrings.INTRUDER_SELECT_LOCATION, DataStrings.ALERT);
            }
            else
            {
                MessageBox.Show(DataStrings.DOOR + getIntrDoor.Text + DataStrings.INTRUDER_DETECTED, DataStrings.ALERT);
            }
        }

    }
}
