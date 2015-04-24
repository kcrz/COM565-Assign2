using BioengineeringResearch.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioengineeringResearch.Forms;
using BioengineeringResearch.DataOperations;

namespace BioengineeringResearch
{
    public partial class MainForm : Form
    {
        /* login status
         * 0 logout
         * 1 Admin
         * 2 Receptionist
         * 3 Normal
         */
        private int loginStatus = 0;
        private Size defaultSize = new Size(900, 510);
        private Size sizeSimulator = new Size(900, 655);

        public MainForm()
        {
            InitializeComponent();
            this.Size = defaultSize;

            //Set data directory for the database
            AppDomain.CurrentDomain.SetData(DataStrings.DATA_DIRECTORY, Application.StartupPath);

            this.Activated += new EventHandler(this.MainForm_Activated);
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            updateForm();
        }

        private void updateForm()
        {
            /* login status
             * 0 logout
             * 1 Admin
             * 2 Receptionist
             */
            switch (loginStatus)
            {
                case 0:
                    // Menue items
                    btnManage.Enabled = false;
                    btnSimulator.Enabled = false;
                    btnCCTV.Enabled = false;

                    // log buttons
                    btn_login.Enabled = true;
                    btn_logout.Enabled = false;

                    txtLogStatus.Text = DataStrings.NOT_LOGGED_IN;
                    break;
                case 1:
                    // Menue items
                    btnManage.Enabled = true;
                    btnSimulator.Enabled = true;
                    btnCCTV.Enabled = true;

                    // log buttons
                    btn_login.Enabled = false;
                    btn_logout.Enabled = true;

                    txtLogStatus.Text = DataStrings.ADMIN_USER;
                    break;
                case 2:
                    // Menue items
                    btnManage.Enabled = true;
                    btnCCTV.Enabled = true;

                    // log buttons
                    btn_login.Enabled = false;
                    btn_logout.Enabled = true;

                    txtLogStatus.Text = DataStrings.RECEPTIONIST_USER;
                    break;
                default:
                    // Menue items
                    btnManage.Enabled = true;
                    btnSimulator.Enabled = false;
                    btnCCTV.Enabled = false;

                    // log buttons
                    btn_login.Enabled = false;
                    btn_logout.Enabled = true;

                    txtLogStatus.Text = DataStrings.NORMAL_USER;
                    break;
            }
        }

        private void btnDoorA1_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader(btnDoorA1.Text);
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            LogForm logForm = new LogForm();
            DialogResult result = logForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                loginStatus = logForm.loginStatus;
                updateForm();
            }
        }

        private void btnDoorA2_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader(btnDoorA2.Text);
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorA3_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader(btnDoorA3.Text);
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorA4_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader(btnDoorA4.Text);
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorA5_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader(btnDoorA5.Text);
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorA6_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader(btnDoorA6.Text);
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorA7_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader(btnDoorA7.Text);
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorA8_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader(btnDoorA8.Text);
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorB1_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader(btnDoorB1.Text);
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorB2_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader(btnDoorB2.Text);
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorB3_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader(btnDoorB3.Text);
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorC1_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader(btnDoorC1.Text);
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorC2_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader(btnDoorC2.Text);
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorC3_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader(btnDoorC3.Text);
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorC4_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader(btnDoorC4.Text);
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorC5_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader(btnDoorC5.Text);
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorC6_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader(btnDoorC6.Text);
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorC7_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader(btnDoorC7.Text);
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorC8_Click(object sender, EventArgs e)
        {
            CardReader cardreader = new CardReader(btnDoorC8.Text);
            DialogResult result = cardreader.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open this door
            }
        }

        private void btnDoorPortal_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DataStrings.WELCOME_MSG, DataStrings.WELCOME);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(DataStrings.LOGOUT_MSG, DataStrings.INFORMATION, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                loginStatus = 0;
                updateForm();
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            ManageForm manageForm = new ManageForm(loginStatus);
            manageForm.ShowDialog();
        }

        private void btnSimulator_Click(object sender, EventArgs e)
        {
            grpBxSimulation.Enabled = true;
            grpBxSimulation.Visible = true;
            btnSimulator.Enabled = false;
            this.Size = sizeSimulator;
            this.CenterToScreen();
        }

        private void btnCCTV_Click(object sender, EventArgs e)
        {
            CCTVForm cctvForm = new CCTVForm();
            cctvForm.ShowDialog();
        }

        private void btnCloseSim_Click(object sender, EventArgs e)
        {
            grpBxSimulation.Enabled = false;
            grpBxSimulation.Visible = false;
            btnSimulator.Enabled = true;
            this.Size = defaultSize;
            this.CenterToScreen();
        }

        private void btnStartFire_Click(object sender, EventArgs e)
        {
            fireEventSimulation();
        }

        private void btnStartCF_Click(object sender, EventArgs e)
        {
            cardReaderFailureSimution();
        }

        private void btnStartIntr_Click(object sender, EventArgs e)
        {
            intruderSimulation();
        }

        private void fireEventSimulation()
        {
            int index = cmbFireLoc.SelectedIndex;
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
                    lblFireGenAdmin.Visible = true;
                    message = DataStrings.WARNING + cmbFireLoc.Text + DataStrings.IS_ON_FIRE + DataStrings.NEWLINE + DataStrings.FIRE_GEN_ADMIN;
                    MessageBox.Show(message, caption);
                    disableFireLabels();                    
                    break;

                case 1: // Research Support
                    lblFireResearchSupport.Visible = true;
                    message = DataStrings.WARNING + cmbFireLoc.Text + DataStrings.IS_ON_FIRE + DataStrings.NEWLINE + DataStrings.FIRE_RESEARCH_SUPP;
                    MessageBox.Show(message, caption);
                    disableFireLabels();
                    break;

                case 2: // Corridor A
                    lblFireCorrA_1.Visible = true;
                    lblFireCorrA_2.Visible = true;
                    message = DataStrings.WARNING + cmbFireLoc.Text + DataStrings.IS_ON_FIRE + DataStrings.NEWLINE + DataStrings.FIRE_CORRIDOR_A;
                    MessageBox.Show(message, caption);
                    disableFireLabels();
                    break;

                case 3: // Corridor B
                    lblFireCorrB_1.Visible = true;
                    lblFireCorrB_2.Visible = true;
                    message = DataStrings.WARNING + cmbFireLoc.Text + DataStrings.IS_ON_FIRE + DataStrings.NEWLINE + DataStrings.FIRE_CORRIDOR_B;
                    MessageBox.Show(message, caption);
                    disableFireLabels();
                    break;

                case 4: // Corridor C
                    lblFireCorrC_1.Visible = true;
                    lblFireCorrC_2.Visible = true;
                    message = DataStrings.WARNING + cmbFireLoc.Text + DataStrings.IS_ON_FIRE + DataStrings.NEWLINE + DataStrings.FIRE_CORRIDOR_C;
                    MessageBox.Show(message, caption);
                    disableFireLabels();
                    break;

                case 5: // SRA 1
                    lblFireSRA1.Visible = true;
                    message = DataStrings.WARNING + cmbFireLoc.Text + DataStrings.IS_ON_FIRE + DataStrings.NEWLINE + DataStrings.FIRE_SRA_1;
                    MessageBox.Show(message, caption);
                    disableFireLabels();
                    break;

                case 6: // SRA 2
                    lblFireSRA2.Visible = true;
                    message = DataStrings.WARNING + cmbFireLoc.Text + DataStrings.IS_ON_FIRE + DataStrings.NEWLINE + DataStrings.FIRE_SRA_2;
                    MessageBox.Show(message, caption);
                    disableFireLabels();
                    break;

                case 7: // SRA 3
                    lblFireSRA3.Visible = true;
                    message = DataStrings.WARNING + cmbFireLoc.Text + DataStrings.IS_ON_FIRE + DataStrings.NEWLINE + DataStrings.FIRE_SRA_3;
                    MessageBox.Show(message, caption);
                    disableFireLabels();
                    break;

                case 8: // SRA 4
                    lblFireSRA4.Visible = true;
                    message = DataStrings.WARNING + cmbFireLoc.Text + DataStrings.IS_ON_FIRE + DataStrings.NEWLINE + DataStrings.FIRE_SRA_4;
                    MessageBox.Show(message, caption);
                    disableFireLabels();
                    break;

                case 9: // SRA 5
                    lblFireSRA5.Visible = true;
                    message = DataStrings.WARNING + cmbFireLoc.Text + DataStrings.IS_ON_FIRE + DataStrings.NEWLINE + DataStrings.FIRE_SRA_5;
                    MessageBox.Show(message, caption);
                    disableFireLabels();
                    break;

                case 10: // SRA 6
                    lblFireSRA6.Visible = true;
                    message = DataStrings.WARNING + cmbFireLoc.Text + DataStrings.IS_ON_FIRE + DataStrings.NEWLINE + DataStrings.FIRE_SRA_6;
                    MessageBox.Show(message, caption);
                    disableFireLabels();
                    break;
                default:
                    MessageBox.Show(DataStrings.FIRE_SELECT_LOCATION, DataStrings.INFORMATION);
                    break;
            }
        }

        private void cardReaderFailureSimution()
        {
            if (cmbReaderFailure.Text.Equals(DataStrings.EMPTY_STRING))
            {
                MessageBox.Show(DataStrings.SELECT_CARD_READER_SIMUL, DataStrings.ALERT);
            }
            else
            {
                MessageBox.Show(DataStrings.DOOR + cmbReaderFailure.Text + DataStrings.CARD_READER_FAILURE, DataStrings.ALERT);
            }
        }

        private void intruderSimulation()
        {
            if (cmbIntruderDoor.Text.Equals(DataStrings.EMPTY_STRING))
            {
                MessageBox.Show(DataStrings.INTRUDER_SELECT_LOCATION, DataStrings.ALERT);
            }
            else
            {
                MessageBox.Show(DataStrings.DOOR + cmbIntruderDoor.Text + DataStrings.INTRUDER_DETECTED, DataStrings.ALERT);
            }
        }

        private void disableFireLabels()
        {
            lblFireCorrA_1.Visible = false;
            lblFireCorrA_2.Visible = false;
            lblFireCorrB_1.Visible = false;
            lblFireCorrB_2.Visible = false;
            lblFireCorrC_1.Visible = false;
            lblFireCorrC_2.Visible = false;
            lblFireGenAdmin.Visible = false;
            lblFireMainEntrance.Visible = false;
            lblFireResearchSupport.Visible = false;
            lblFireSRA1.Visible = false;
            lblFireSRA2.Visible = false;
            lblFireSRA3.Visible = false;
            lblFireSRA4.Visible = false;
            lblFireSRA5.Visible = false;
            lblFireSRA6.Visible = false;
        }
    }
}
