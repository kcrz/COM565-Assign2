using System;
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
                    this.Text = "AddForm. Your authority: Admin.";
                    break;
                case 2:
                    this.Text = "AddForm. Your authority: Receptionist.";
                    radiobtn_emp.Visible = false;
                    add_Position.Enabled = false;
                    break;
            }

            this.Activated += new EventHandler(this.AddForm_Activated);
        }

        private void AddForm_Activated(object sender, EventArgs e)
        {
            // refresh items status
            // radiobutton
            if (radiobtn_vis.Checked == true)
            {
                add_Position.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radiobtn_emp_CheckedChanged(object sender, EventArgs e)
        {
            add_Position.Enabled = true;
            add_Company.Enabled = false;
        }

        private void radiobtn_vis_CheckedChanged(object sender, EventArgs e)
        {
            add_Position.Enabled = false;
            add_Company.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (add_PIN.Text.Equals(add_ConPIN.Text)) // check if the two PINs are the same
            {
                if (radiobtn_emp.Checked == true) // add Employee
                {
                    Employee employee = new Employee();
                    employee.FirstName = add_FirstName.Text;
                    employee.LastName = add_LastName.Text;
                    employee.PIN = Convert.ToInt32(add_PIN.Text);
                    employee.AuthorizedUntilDate = add_ExpiredDate.Value;
                    employee.Position = add_Position.Text;
                    employee.Phone = add_Phone.Text;
                    employee.Email = add_Email.Text;

                    if (!DataOps.addEmployee(employee))
                    {
                        MessageBox.Show("Failed to add ...");
                    }
                }
                else if (radiobtn_vis.Checked == true) // add Visitor
                {
                    Visitor visitor = new Visitor();
                    visitor.FirstName = add_FirstName.Text;
                    visitor.LastName = add_LastName.Text;
                    visitor.PIN = Convert.ToInt32(add_PIN.Text);
                    visitor.AuthorizedUntilDate = add_ExpiredDate.Value;
                    visitor.Company = add_Company.Text;
                    visitor.Phone = add_Phone.Text;
                    visitor.Email = add_Email.Text;

                    if (!DataOps.addVisitor(visitor))
                    {
                        MessageBox.Show("Failed to add ...");
                    }
                }
            }
            else
            {
                MessageBox.Show("PIN should be the same as the Confirm PIN");

                // clear the text in PIN and ConPIN
                add_PIN.Text = "";
                add_ConPIN.Text = "";
            }
        }
    }
}
