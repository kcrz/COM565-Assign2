﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioengineeringResearch.Models;
using BioengineeringResearch.DataOperations;

namespace BioengineeringResearch.Functions
{
    /// <summary>
    /// Add Form for adding new users
    /// Author: Kenneth Cruz, Kaiyang Zhou
    /// 30 Apr 2015
    /// </summary>
    public partial class AddForm : Form
    {
        Employee employee = new Employee();
        Visitor visitor = new Visitor();

        public AddForm(int Status)
        {
            InitializeComponent();

            /* login status
             * 1 Admin
             * 2 Receptionist
             * 3 Normal
             */
            switch (Status)
            {
                case 1:
                    this.Text = DataStrings.ADD_FORM_ADMIN_STATUS;
                    break;
                case 2:
                    this.Text = DataStrings.ADD_FORM_RECEPTIONIST_STATUS;
                    radiobtn_emp.Enabled = false;
                    break;
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearAllFormFields()
        {
            //clear all fields
            add_FirstName.Text = DataStrings.EMPTY_STRING;
            add_LastName.Text = DataStrings.EMPTY_STRING;
            add_PIN.Text = DataStrings.EMPTY_STRING;
            add_ConPIN.Text = DataStrings.EMPTY_STRING;
            add_AccessLevel.SelectedIndex = 0;
            add_ExpiredDate.Value = DateTime.Now;
            add_Position.Text = DataStrings.EMPTY_STRING;
            add_Department.Text = DataStrings.EMPTY_STRING;
            add_Company.Text = DataStrings.EMPTY_STRING;
            add_Phone.Text = DataStrings.EMPTY_STRING;
            add_Email.Text = DataStrings.EMPTY_STRING;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Check if all fields are populated
            if (add_FirstName.Text != DataStrings.EMPTY_STRING && add_LastName.Text != DataStrings.EMPTY_STRING && add_PIN.Text != DataStrings.EMPTY_STRING && add_AccessLevel.SelectedIndex >= 0
                        && add_ExpiredDate.Value > DateTime.Now && add_Position.Text != DataStrings.EMPTY_STRING && add_Phone.Text != DataStrings.EMPTY_STRING && add_Email.Text != DataStrings.EMPTY_STRING)
            {
                DateTime currentDate = DateTime.Today.Date;
                if (add_PIN.Text.Equals(add_ConPIN.Text)) // check if the two PINs are the same
                {
                    if (radiobtn_emp.Checked == true) // add Employee
                    {
                        Employee employee = new Employee();
                        employee.FirstName = add_FirstName.Text;
                        employee.LastName = add_LastName.Text;
                        employee.PIN = Convert.ToInt32(add_PIN.Text);
                        employee.AccessLevel = Convert.ToInt32(add_AccessLevel.SelectedItem);
                        employee.AccessGrantedDate = currentDate;
                        employee.AuthorizedUntilDate = add_ExpiredDate.Value.Date;
                        employee.Position = add_Position.Text;
                        employee.Department = add_Department.Text;
                        employee.Company = add_Company.Text;
                        employee.Phone = add_Phone.Text;
                        employee.Email = add_Email.Text;

                        if (!DataOps.addEmployee(employee))
                        {
                            MessageBox.Show(DataStrings.FAILED_TO_ADD_EMPLOYEE, DataStrings.INFORMATION);
                        }
                        else
                        {
                            MessageBox.Show(DataStrings.YOUR_NEW_ID + employee.EmployeeId, DataStrings.INFORMATION);
                            //clear all fields
                            clearAllFormFields();
                        }
                    }
                    else if (radiobtn_vis.Checked == true) // add Visitor
                    {
                        Visitor visitor = new Visitor();
                        visitor.FirstName = add_FirstName.Text;
                        visitor.LastName = add_LastName.Text;
                        visitor.PIN = Convert.ToInt32(add_PIN.Text);
                        visitor.AccessLevel = Convert.ToInt32(add_AccessLevel.SelectedItem);
                        visitor.AccessGrantedDate = currentDate;
                        visitor.AuthorizedUntilDate = add_ExpiredDate.Value.Date;
                        visitor.Position = add_Position.Text;
                        visitor.Department = add_Department.Text;
                        visitor.Company = add_Company.Text;
                        visitor.Phone = add_Phone.Text;
                        visitor.Email = add_Email.Text;

                        if (!DataOps.addVisitor(visitor))
                        {
                            MessageBox.Show(DataStrings.FAILED_TO_ADD_VISITOR);
                        }
                        else
                        {
                            MessageBox.Show(DataStrings.YOUR_NEW_ID + visitor.VisitorId, DataStrings.INFORMATION);
                            //clear all fields
                            clearAllFormFields();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(DataStrings.PIN_DOES_NOT_MATCH, DataStrings.ALERT);

                    // clear the text in PIN and ConPIN
                    add_PIN.Text = DataStrings.EMPTY_STRING;
                    add_ConPIN.Text = DataStrings.EMPTY_STRING;
                }
            }
            else
            {
                MessageBox.Show(DataStrings.ADD_UPDATE_FORM_FIELD_CHECK, DataStrings.ALERT);
            }


        }
    }
}
