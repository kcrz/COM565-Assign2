using BioengineeringResearch.DataOperations;
using BioengineeringResearch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioengineeringResearch.Forms
{
    public partial class UpdateForm : Form
    {
        private Employee employee;
        private Visitor visitor;
        private bool isEmployee = false;
        private bool isUpdateSuccess = false;
        public UpdateForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            txtFirstName.Text = employee.FirstName;
            txtLastName.Text = employee.LastName;
            txtPIN.Text = employee.PIN.ToString();
            txtPINconfirm.Text = employee.PIN.ToString();
            cmbAccessLevel.Text = employee.AccessLevel.ToString();
            dtpAuthorizedUntilDate.Value = employee.AuthorizedUntilDate;
            txtPosition.Text = employee.Position;
            txtDepartment.Text = employee.Department;
            txtCompany.Text = employee.Company;
            txtPhone.Text = employee.Phone;
            txtEmail.Text = employee.Email;

            isEmployee = true;

        }

        public UpdateForm(Visitor visitor)
        {
            InitializeComponent();
            this.visitor = visitor;
            txtFirstName.Text = visitor.FirstName;
            txtLastName.Text = visitor.LastName;
            txtPIN.Text = visitor.PIN.ToString();
            txtPINconfirm.Text = visitor.PIN.ToString();
            cmbAccessLevel.Text = visitor.AccessLevel.ToString();
            dtpAuthorizedUntilDate.Value = visitor.AuthorizedUntilDate;
            txtPosition.Text = visitor.Position;
            txtDepartment.Text = visitor.Department;
            txtCompany.Text = visitor.Company;
            txtPhone.Text = visitor.Phone;
            txtEmail.Text = visitor.Email;

            isEmployee = false;
        }

        private bool updateEmployee()
        {
            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            employee.PIN = Convert.ToInt32(txtPIN.Text);
            employee.AccessLevel = Convert.ToInt32(cmbAccessLevel.Text);
            employee.AuthorizedUntilDate = dtpAuthorizedUntilDate.Value;
            employee.Position = txtPosition.Text;
            employee.Department = txtDepartment.Text;
            employee.Company = txtCompany.Text;
            employee.Phone = txtPhone.Text;
            employee.Email = txtEmail.Text;

            return DataOps.update(employee.EmployeeId.ToUpper(), employee);
        }

        private bool updateVisitor()
        {
            visitor.FirstName = txtFirstName.Text;
            visitor.LastName = txtLastName.Text;
            visitor.PIN = Convert.ToInt32(txtPIN.Text);
            visitor.AccessLevel = Convert.ToInt32(cmbAccessLevel.Text);
            visitor.AuthorizedUntilDate = dtpAuthorizedUntilDate.Value;
            visitor.Position = txtPosition.Text;
            visitor.Department = txtDepartment.Text;
            visitor.Company = txtCompany.Text;
            visitor.Phone = txtPhone.Text;
            visitor.Email = txtEmail.Text;

            return DataOps.update(visitor.VisitorId.ToUpper(), visitor);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Check if all fields are populated
            if (txtFirstName.Text != DataStrings.EMPTY_STRING && txtLastName.Text != DataStrings.EMPTY_STRING && txtPIN.Text != DataStrings.EMPTY_STRING && cmbAccessLevel.SelectedIndex >= 0
                        && dtpAuthorizedUntilDate.Value > DateTime.Now && txtPosition.Text != DataStrings.EMPTY_STRING && txtDepartment.Text != DataStrings.EMPTY_STRING && txtCompany.Text != DataStrings.EMPTY_STRING
                        && txtPhone.Text != DataStrings.EMPTY_STRING && txtEmail.Text != DataStrings.EMPTY_STRING)
            {
                // check if the two PINs are the same
                if (txtPIN.Text.Equals(txtPINconfirm.Text))
                {
                    if (isEmployee)
                    {
                        if (updateEmployee())
                        {
                            isUpdateSuccess = true;
                        }
                    }
                    else
                    {
                        if (updateVisitor())
                        {
                            isUpdateSuccess = true;
                        }
                    }

                    if (!isUpdateSuccess)
                    { 
                        //an error has occured during updating
                        MessageBox.Show(DataStrings.FAILED_TO_UPDATE_INFO, DataStrings.INFORMATION);
                    }
                }
                else
                {
                    MessageBox.Show(DataStrings.PIN_DOES_NOT_MATCH, DataStrings.ALERT);

                    // clear the text in PIN and ConPIN
                    txtPIN.Text = DataStrings.EMPTY_STRING;
                    txtPINconfirm.Text = DataStrings.EMPTY_STRING;
                }
            }
            else
            {
                MessageBox.Show(DataStrings.ADD_UPDATE_FORM_FIELD_CHECK, DataStrings.ALERT);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
