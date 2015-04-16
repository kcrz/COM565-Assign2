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
                    txtLogStatus.Text = "Your Status: Admin";
                    break;
                case 2: // 2 Receptionist
                    txtLogStatus.Text = "Your Status: Receptionist";
                    break;
                case 3: // 3 Normal
                    txtLogStatus.Text = "Your Status: Normal";
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
                                MessageBox.Show("No Person found", "Search Result");
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
                    else { MessageBox.Show("Invalid id", "Alert"); }

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
                        MessageBox.Show("No Person found", "Search Result");
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
                        MessageBox.Show("No Person found", "Search Result");
                    }

                }
            }
            else
            {
                //clear list view if search param is null or empty
                listviewPerson.Items.Clear();
            }

        }
    }
}
