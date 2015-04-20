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
using BioengineeringResearch.Functions;
using BioengineeringResearch.DataOperations;
using BioengineeringResearch.Models;

namespace BioengineeringResearch.Forms
{
    public partial class ManageForm : Form
    {
        /* login status
         * 1 Admin
         * 2 Receptionist
         * 3 Normal
         */
        private int loginStatus = 0;

        private List<Employee> employeeList;
        private List<Visitor> visitorList;
        private List<DisplayedHistory> displayedHistoryList;
        private ListViewItem listViewItem;

        public ManageForm(int Status)
        {
            InitializeComponent();
            loginStatus = Status;
            switch (Status)
            {
                case 1: // 1 Admin
                    txtLogStatus.Text = DataStrings.USER_STATUS + DataStrings.ADMIN_USER;
                    break;
                case 2: // 2 Receptionist
                    txtLogStatus.Text = DataStrings.USER_STATUS + DataStrings.RECEPTIONIST_USER;
                    break;
                case 3: // 3 Normal
                    txtLogStatus.Text = DataStrings.USER_STATUS + DataStrings.NORMAL_USER;
                    break;

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSrchPerson_Click(object sender, EventArgs e)
        {
            //Clear list view for every new search
            listviewPerson.Items.Clear();
            String searchParam = txtSearch.Text;
            //only search if search parameter is not empty or null
            if (searchParam != null || searchParam.Length != 0)
            {
                //check if its by ID, LastName or First Name
                if (rdoId.Checked == true)
                {
                    if (searchParam.ToUpper().StartsWith(DataStrings.EMPLOYEE_TAG))
                    {
                        employeeList = new List<Employee>();
                        employeeList.Add(DataOps.searchEmployeeDbById(searchParam));

                        foreach (Employee em in employeeList)
                        {
                            if (em != null)
                            {
                                //Create string array containing column data
                                string[] dataRow = { em.EmployeeId, em.FirstName, em.LastName, Convert.ToString(em.AccessLevel), em.Position, "", em.Email };
                                //create list view item using striny array
                                listViewItem = new ListViewItem(dataRow);
                                //add tpo list view
                                listviewPerson.Items.Add(listViewItem);
                            }
                            //if there are no items in listviewPerson
                            //means there are no values found
                            if (listviewPerson.Items.Count == 0)
                            {
                                MessageBox.Show(DataStrings.NO_PERSON_FOUND, DataStrings.SEARCH_RESULT);
                            }
                        }
                    }
                    else if (searchParam.ToUpper().StartsWith(DataStrings.VISITOR_TAG))
                    {
                        visitorList = new List<Visitor>();
                        visitorList.Add(DataOps.searchVisitorDbById(searchParam));

                        foreach (Visitor vt in visitorList)
                        {
                            if (vt != null)
                            {
                                //Create string array containing column data
                                string[] dataRow = { vt.VisitorId, vt.FirstName, vt.LastName, Convert.ToString(vt.AccessLevel), "", vt.Company, vt.Email };
                                //create list view item using striny array
                                listViewItem = new ListViewItem(dataRow);
                                //add tpo list view
                                listviewPerson.Items.Add(listViewItem);
                            }
                        }
                    }
                    else { MessageBox.Show(DataStrings.INVALID_ID, DataStrings.ALERT); }

                }
                else if (rdoLastName.Checked == true)
                {
                    employeeList = DataOps.searchEmployeeByName(searchParam, true);
                    visitorList = DataOps.searchVisitorByName(searchParam, true);

                    foreach (Employee em in employeeList)
                    {
                        //Create string array containing column data
                        string[] dataRow = { em.EmployeeId, em.FirstName, em.LastName, Convert.ToString(em.AccessLevel), em.Position, "", em.Email };
                        //create list view item using striny array
                        listViewItem = new ListViewItem(dataRow);
                        //add tpo list view
                        listviewPerson.Items.Add(listViewItem);
                    }

                    foreach (Visitor vt in visitorList)
                    {
                        //Create string array containing column data
                        string[] dataRow = { vt.VisitorId, vt.FirstName, vt.LastName, Convert.ToString(vt.AccessLevel), "", vt.Company, vt.Email };
                        //create list view item using striny array
                        listViewItem = new ListViewItem(dataRow);
                        //add tpo list view
                        listviewPerson.Items.Add(listViewItem);
                    }
                    //if there are no items in listviewPerson
                    //means there are no values found
                    if (listviewPerson.Items.Count == 0)
                    {
                        MessageBox.Show(DataStrings.NO_PERSON_FOUND, DataStrings.SEARCH_RESULT);
                    }
                }
                else if (rdoFirstName.Checked == true)
                {
                    employeeList = DataOps.searchEmployeeByName(searchParam, false);
                    visitorList = DataOps.searchVisitorByName(searchParam, false);

                    foreach (Employee em in employeeList)
                    {
                        //Create string array containing column data
                        string[] dataRow = { em.EmployeeId, em.FirstName, em.LastName, Convert.ToString(em.AccessLevel), em.Position, "", em.Email };
                        //create list view item using striny array
                        listViewItem = new ListViewItem(dataRow);
                        //add tpo list view
                        listviewPerson.Items.Add(listViewItem);
                    }

                    foreach (Visitor vt in visitorList)
                    {
                        //Create string array containing column data
                        string[] dataRow = { vt.VisitorId, vt.FirstName, vt.LastName, Convert.ToString(vt.AccessLevel), "", vt.Company, vt.Email };
                        //create list view item using striny array
                        listViewItem = new ListViewItem(dataRow);
                        //add tpo list view
                        listviewPerson.Items.Add(listViewItem);
                    }
                    //if there are no items in listviewPerson
                    //means there are no values found
                    if (listviewPerson.Items.Count == 0)
                    {
                        MessageBox.Show(DataStrings.NO_PERSON_FOUND, DataStrings.SEARCH_RESULT);
                    }

                }
            }
            else
            {
                //clear list view if search param is null or empty
                listviewPerson.Items.Clear();
            }
        }

        private void btnShowAllVist_Click(object sender, EventArgs e)
        {
            //clear existing items in list view
            listviewPerson.Items.Clear();

            visitorList = DataOps.getAllVisitors();
            if (visitorList.Count != 0)
            {
                foreach (Visitor vt in visitorList)
                {
                    //Create string array containing column data
                    string[] dataRow = { vt.VisitorId, vt.FirstName, vt.LastName, Convert.ToString(vt.AccessLevel), "", vt.Company, vt.Email };
                    //create list view item using striny array
                    listViewItem = new ListViewItem(dataRow);
                    //add tpo list view
                    listviewPerson.Items.Add(listViewItem);
                }
            }
            else
            {
                MessageBox.Show(DataStrings.NO_VISITORS_FOUND, DataStrings.ALERT); 
            }
        }

        private void btnShowAllEmp_Click(object sender, EventArgs e)
        {
            //clear existing items in list view
            listviewPerson.Items.Clear();

            employeeList = DataOps.getAllEmployees();
            if (employeeList.Count != 0)
            {
                foreach (Employee em in employeeList)
                {
                    //Create string array containing column data
                    string[] dataRow = { em.EmployeeId, em.FirstName, em.LastName, Convert.ToString(em.AccessLevel), em.Position, "", em.Email };
                    //create list view item using striny array
                    listViewItem = new ListViewItem(dataRow);
                    //add tpo list view
                    listviewPerson.Items.Add(listViewItem);
                }

            }
            else
            {
                MessageBox.Show(DataStrings.NO_EMPLOYEES_FOUND, DataStrings.ALERT);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            //clear existing items in list view
            listviewPerson.Items.Clear();

            employeeList = DataOps.getAllEmployees();
            visitorList = DataOps.getAllVisitors();

            if (employeeList.Count != 0)
            {
                foreach (Employee em in employeeList)
                {
                    //Create string array containing column data
                    string[] dataRow = { em.EmployeeId, em.FirstName, em.LastName, Convert.ToString(em.AccessLevel), em.Position, "", em.Email };
                    //create list view item using striny array
                    listViewItem = new ListViewItem(dataRow);
                    //add tpo list view
                    listviewPerson.Items.Add(listViewItem);
                }
            }

            if (visitorList.Count != 0)
            {
                foreach (Visitor vt in visitorList)
                {
                    //Create string array containing column data
                    string[] dataRow = { vt.VisitorId, vt.FirstName, vt.LastName, Convert.ToString(vt.AccessLevel), "", vt.Company, vt.Email };
                    //create list view item using striny array
                    listViewItem = new ListViewItem(dataRow);
                    //add tpo list view
                    listviewPerson.Items.Add(listViewItem);
                }
            }

            //if nothing has beend added to listview show message box
            if (listviewPerson.Items.Count == 0)
            {
                MessageBox.Show(DataStrings.NO_ITEM_FOUND, DataStrings.ALERT);
            }
        }

        private void btnDeltPerson_Click(object sender, EventArgs e)
        {
            if (listviewPerson.SelectedItems.Count != 0)
            {
                // delete the selected item by database operation
            }
            else
            {
                MessageBox.Show(DataStrings.SELECT_ITEM_DELETION, DataStrings.ALERT);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(loginStatus);
            addForm.ShowDialog();
        }

        private void btnShowAllHist_Click(object sender, EventArgs e)
        {
            listViewHist.Items.Clear();
            displayedHistoryList = DataOps.getAllEmployeeAccessHistory();
            foreach(DisplayedHistory dhl in displayedHistoryList)
            {
                if (dhl != null)
                {
                    string[] dataRow = { dhl.DateTimeStamp.ToString(), dhl.DoorName, dhl.EmployeeId, dhl.LastName, dhl.FirstName };
                    listViewItem = new ListViewItem(dataRow);
                    listViewHist.Items.Add(listViewItem);
                }
            }


            displayedHistoryList = DataOps.getAllVisitorAccessHistory();
            foreach (DisplayedHistory dhl in displayedHistoryList)
            {
                if(dhl!=null)
                {
                    string[] dataRow = { dhl.DateTimeStamp.ToString(), dhl.DoorName, dhl.VisitorId, dhl.LastName, dhl.FirstName };
                    listViewItem = new ListViewItem(dataRow);
                    listViewHist.Items.Add(listViewItem);
                }
            }

            if (listViewHist.Items.Count == 0)
            {
                MessageBox.Show(DataStrings.NO_ITEM_FOUND, DataStrings.ALERT);
            }
        }

        private void btnSrchHistBy_Click(object sender, EventArgs e)
        {
            DateTime dateSelected;
            DateTime timeSelected;
            string personId;
            string doorName;
            //Check if an option is selected
            if (chkboxDate.Checked || chkboxDoor.Checked || chkboxTime.Checked || chkBxPasserId.Checked)
            {
                //All options selected
                if (datePicker.Enabled && timePicker.Enabled && txtPasserId.Enabled && dropDownDoor.Enabled)
                { 
                    //Check if ID is valid
                    if (DataUtils.isUserIdValid(txtPasserId.Text))
                    {


                    }
                    else
                    {
                        MessageBox.Show(DataStrings.INVALID_ID,DataStrings.ALERT);
                    }
                }
            }
            else
            {
                MessageBox.Show(DataStrings.TICK_AN_OPTION, DataStrings.ALERT);
            }
        }

        private void chkboxDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxDate.Checked)
            {
                datePicker.Enabled = true;
            }
            else {
                datePicker.Enabled = false;
            }
        }

        private void chkboxTime_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxTime.Checked)
            {
                timePicker.Enabled = true;
            }
            else
            {
                timePicker.Enabled = false;
            }
        }

        private void chkBxPasserId_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxPasserId.Checked)
            {
                txtPasserId.Enabled = true;
            }
            else
            {
                txtPasserId.Enabled = false;
            }
        }

        private void chkboxDoor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxDoor.Checked)
            {
                dropDownDoor.Enabled = true;
            }
            else
            {
                dropDownDoor.Enabled = false;
            }
        }
    }
}
