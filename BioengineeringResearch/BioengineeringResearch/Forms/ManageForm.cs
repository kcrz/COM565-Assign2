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
                    //disable update feature for receptionist
                    btnUpdateUser.Enabled = false;
                    break;
                case 3: // 3 Normal
                    txtLogStatus.Text = DataStrings.USER_STATUS + DataStrings.NORMAL_USER;
                    //disable add and delete for normal users
                    btnAdd.Enabled = false;
                    btnExportHistory.Enabled = false;
                    btnExportPerson.Enabled = false;
                    btnUpdateUser.Enabled = false;
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
                                string[] dataRow = { em.EmployeeId, em.FirstName, em.LastName, Convert.ToString(em.AccessLevel), em.AccessGrantedDate.ToShortDateString(), em.AuthorizedUntilDate.ToShortDateString(), em.Position, em.Department, em.Company, em.Phone, em.Email };
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
                                string[] dataRow = { vt.VisitorId, vt.FirstName, vt.LastName, Convert.ToString(vt.AccessLevel), vt.AccessGrantedDate.ToShortDateString(), vt.AuthorizedUntilDate.ToShortDateString(), vt.Position, vt.Department, vt.Company, vt.Phone, vt.Email };
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
                        string[] dataRow = { em.EmployeeId, em.FirstName, em.LastName, Convert.ToString(em.AccessLevel), em.AccessGrantedDate.ToShortDateString(), em.AuthorizedUntilDate.ToShortDateString(), em.Position, em.Department, em.Company, em.Phone, em.Email };
                        //create list view item using striny array
                        listViewItem = new ListViewItem(dataRow);
                        //add tpo list view
                        listviewPerson.Items.Add(listViewItem);
                    }

                    foreach (Visitor vt in visitorList)
                    {
                        //Create string array containing column data
                        string[] dataRow = { vt.VisitorId, vt.FirstName, vt.LastName, Convert.ToString(vt.AccessLevel), vt.AccessGrantedDate.ToShortDateString(), vt.AuthorizedUntilDate.ToShortDateString(), vt.Position, vt.Department, vt.Company, vt.Phone, vt.Email };
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
                        string[] dataRow = { em.EmployeeId, em.FirstName, em.LastName, Convert.ToString(em.AccessLevel), em.AccessGrantedDate.ToShortDateString(), em.AuthorizedUntilDate.ToShortDateString(), em.Position, em.Department, em.Company, em.Phone, em.Email };
                        //create list view item using striny array
                        listViewItem = new ListViewItem(dataRow);
                        //add tpo list view
                        listviewPerson.Items.Add(listViewItem);
                    }

                    foreach (Visitor vt in visitorList)
                    {
                        //Create string array containing column data
                        string[] dataRow = { vt.VisitorId, vt.FirstName, vt.LastName, Convert.ToString(vt.AccessLevel), vt.AccessGrantedDate.ToShortDateString(), vt.AuthorizedUntilDate.ToShortDateString(), vt.Position, vt.Department, vt.Company, vt.Phone, vt.Email };
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
                    string[] dataRow = { vt.VisitorId, vt.FirstName, vt.LastName, Convert.ToString(vt.AccessLevel), vt.AccessGrantedDate.ToShortDateString(), vt.AuthorizedUntilDate.ToShortDateString(), vt.Position, vt.Department, vt.Company, vt.Phone, vt.Email };
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
                    string[] dataRow = { em.EmployeeId, em.FirstName, em.LastName, Convert.ToString(em.AccessLevel), em.AccessGrantedDate.ToShortDateString(), em.AuthorizedUntilDate.ToShortDateString(), em.Position, em.Department, em.Company, em.Phone, em.Email };
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
                    string[] dataRow = { em.EmployeeId, em.FirstName, em.LastName, Convert.ToString(em.AccessLevel), em.AccessGrantedDate.ToShortDateString(), em.AuthorizedUntilDate.ToShortDateString(), em.Position, em.Department, em.Company, em.Phone, em.Email };
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
                    string[] dataRow = { vt.VisitorId, vt.FirstName, vt.LastName, Convert.ToString(vt.AccessLevel), vt.AccessGrantedDate.ToShortDateString(), vt.AuthorizedUntilDate.ToShortDateString(), vt.Position, vt.Department, vt.Company, vt.Phone, vt.Email };
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(loginStatus);
            addForm.ShowDialog();
        }

        private void displayToHistoryListView(List<DisplayedHistory> historyList, bool isEmployee)
        {
            //Employee
            if (isEmployee)
            {
                foreach (DisplayedHistory dhl in historyList)
                {
                    if (dhl != null)
                    {
                        string[] dataRow = { dhl.DateStamp.ToShortDateString(), dhl.TimeStamp.ToString(), dhl.DoorName, dhl.EmployeeId, dhl.FirstName, dhl.LastName, Convert.ToString(dhl.AccessLevel) };
                        listViewItem = new ListViewItem(dataRow);
                        listViewHist.Items.Add(listViewItem);
                    }
                }
            }
            //Visitor
            else
            {
                foreach (DisplayedHistory dhl in historyList)
                {
                    if (dhl != null)
                    {
                        string[] dataRow = { dhl.DateStamp.ToShortDateString(), dhl.TimeStamp.ToString(), dhl.DoorName, dhl.VisitorId, dhl.FirstName, dhl.LastName, Convert.ToString(dhl.AccessLevel) };
                        listViewItem = new ListViewItem(dataRow);
                        listViewHist.Items.Add(listViewItem);
                    }
                }
            }
        }

        private void checkHistoryListCount()
        {
            if (listViewHist.Items.Count == 0)
            {
                MessageBox.Show(DataStrings.NO_ITEM_FOUND, DataStrings.ALERT);
            }
        }

        private void btnShowAllHist_Click(object sender, EventArgs e)
        {
            listViewHist.Items.Clear();
            displayToHistoryListView(DataOps.getAllEmployeeAccessHistory(), true);
            displayToHistoryListView(DataOps.getAllVisitorAccessHistory(), false);

            if (listViewHist.Items.Count == 0)
            {
                MessageBox.Show(DataStrings.NO_ITEM_FOUND, DataStrings.ALERT);
            }
        }



        private void btnSrchHistBy_Click(object sender, EventArgs e)
        {
            listViewHist.Items.Clear();
            DateTime searchDate;
            TimeSpan searchTime;
            string searchId;
            string searchDoor;

            if (rdoHistoryDate.Checked || rdoHistoryDoor.Checked || rdoHistoryPasserId.Checked || rdoHistoryTime.Checked)
            {
                if (rdoHistoryDate.Checked)
                {
                    searchDate = datePicker.Value.Date;
                    displayToHistoryListView(DataOps.searchAccessHistoryByDate(searchDate, true), true);
                    displayToHistoryListView(DataOps.searchAccessHistoryByDate(searchDate, false), false);
                    checkHistoryListCount();
                }
                else if (rdoHistoryTime.Checked)
                {
                    searchTime = timePicker.Value.TimeOfDay;
                    displayToHistoryListView(DataOps.searchAccessHistoryByTime(searchTime, true), true);
                    displayToHistoryListView(DataOps.searchAccessHistoryByTime(searchTime, false), false);
                    checkHistoryListCount();
                }
                else if (rdoHistoryPasserId.Checked)
                {
                    searchId = txtPasserId.Text.ToUpper();
                    if (DataUtils.isUserIdValid(searchId))
                    {
                        if (DataUtils.isUserIdEmployee(searchId))
                        {
                            displayToHistoryListView(DataOps.searchAccessHistoryByUserId(searchId), true);
                            checkHistoryListCount();
                        }
                        else if (DataUtils.isUserIdVisitor(searchId))
                        {
                            displayToHistoryListView(DataOps.searchAccessHistoryByUserId(searchId), false);
                            checkHistoryListCount();
                        }
                    }
                    else
                    {
                        MessageBox.Show(DataStrings.INVALID_ID, DataStrings.ALERT);
                    }
                }
                else if (rdoHistoryDoor.Checked)
                {
                    searchDoor = dropDownDoor.Text;
                    displayToHistoryListView(DataOps.searchAccessHistoryByDoor(searchDoor, true), true);
                    displayToHistoryListView(DataOps.searchAccessHistoryByDoor(searchDoor, false), false);
                    checkHistoryListCount();
                }
            }
            else
            {
                MessageBox.Show(DataStrings.SELECT_HISTORY_SEARCH_OPTION, DataStrings.ALERT);
            }



        }

        private void rdoHistoryDate_CheckedChanged(object sender, EventArgs e)
        {
            datePicker.Enabled = true;
            timePicker.Enabled = false;
            txtPasserId.Enabled = false;
            dropDownDoor.Enabled = false;
        }

        private void rdoHistoryTime_CheckedChanged(object sender, EventArgs e)
        {
            datePicker.Enabled = false;
            timePicker.Enabled = true;
            txtPasserId.Enabled = false;
            dropDownDoor.Enabled = false;
        }

        private void rdoHistoryPasserId_CheckedChanged(object sender, EventArgs e)
        {
            datePicker.Enabled = false;
            timePicker.Enabled = false;
            txtPasserId.Enabled = true;
            dropDownDoor.Enabled = false;

        }

        private void rdoHistoryDoor_CheckedChanged(object sender, EventArgs e)
        {
            datePicker.Enabled = false;
            timePicker.Enabled = false;
            txtPasserId.Enabled = false;
            dropDownDoor.Enabled = true;

        }

        private void btnExportHistory_Click(object sender, EventArgs e)
        {
            if (listViewHist.Items.Count != 0)
            {
                SaveFileDialog sfd = new SaveFileDialog
            {
                Title = DataStrings.EXPORT_TITLE,
                FileName = DataStrings.EXPORT_HISTORY_FILENAME,
                Filter = DataStrings.EXPORT__FILTER,
                FilterIndex = 0,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string[] headers = listViewHist.Columns
                           .OfType<ColumnHeader>()
                           .Select(header => header.Text.Trim())
                           .ToArray();

                    string[][] items = listViewHist.Items
                                .OfType<ListViewItem>()
                                .Select(lvi => lvi.SubItems
                                    .OfType<ListViewItem.ListViewSubItem>()
                                    .Select(si => si.Text).ToArray()).ToArray();

                    string table = string.Join(",", headers) + Environment.NewLine;
                    foreach (string[] a in items)
                    {
                        //a = a_loopVariable;
                        table += string.Join(",", a) + Environment.NewLine;
                    }
                    table = table.TrimEnd('\r', '\n');
                    System.IO.File.WriteAllText(sfd.FileName, table);
                }
            }
            else
            {
                MessageBox.Show(DataStrings.NO_ITEM_TO_EXPORT, DataStrings.ALERT);
            }
        }

        private void btnExportPerson_Click(object sender, EventArgs e)
        {
            if (listviewPerson.Items.Count != 0)
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Title = DataStrings.EXPORT_TITLE,
                    FileName = DataStrings.EXPORT_PEOPLE_FILENAME,
                    Filter = DataStrings.EXPORT__FILTER,
                    FilterIndex = 0,
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                };


                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string[] headers = listviewPerson.Columns
                               .OfType<ColumnHeader>()
                               .Select(header => header.Text.Trim())
                               .ToArray();

                    string[][] items = listviewPerson.Items
                                .OfType<ListViewItem>()
                                .Select(lvi => lvi.SubItems
                                    .OfType<ListViewItem.ListViewSubItem>()
                                    .Select(si => si.Text).ToArray()).ToArray();

                    string table = string.Join(",", headers) + Environment.NewLine;
                    foreach (string[] a in items)
                    {
                        //a = a_loopVariable;
                        table += string.Join(",", a) + Environment.NewLine;
                    }
                    table = table.TrimEnd('\r', '\n');
                    System.IO.File.WriteAllText(sfd.FileName, table);
                }

            }
            else
            {
                MessageBox.Show(DataStrings.NO_ITEM_TO_EXPORT, DataStrings.ALERT);
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            String userId;
            if (listviewPerson.SelectedItems.Count != 0)
            {
                userId = listviewPerson.SelectedItems[0].SubItems[0].Text;
                if (DataUtils.isUserIdEmployee(userId))
                {
                    //Employee
                    Employee emp = DataOps.searchEmployeeDbById(userId);
                    if (emp != null)
                    {
                        UpdateForm updateForm = new UpdateForm(emp);
                        updateForm.ShowDialog();
                    }
                }
                else
                {
                    //Visitor
                    Visitor visitor = DataOps.searchVisitorDbById(userId);
                    if (visitor != null)
                    {
                        UpdateForm updateForm = new UpdateForm(visitor);
                        updateForm.ShowDialog();
                    }

                }
            }
            else
            {
                MessageBox.Show(DataStrings.SELECT_UPDATE_ITEM, DataStrings.INFORMATION);
            }
        }
    }
}
