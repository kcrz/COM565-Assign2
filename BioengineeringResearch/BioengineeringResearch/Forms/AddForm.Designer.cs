﻿namespace BioengineeringResearch.Functions
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.add_ConPIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add_Position = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.add_Company = new System.Windows.Forms.TextBox();
            this.container = new System.Windows.Forms.Panel();
            this.radiobtn_emp = new System.Windows.Forms.RadioButton();
            this.radiobtn_vis = new System.Windows.Forms.RadioButton();
            this.add_Email = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.add_Phone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.add_ExpiredDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.add_AccessLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.add_PIN = new System.Windows.Forms.TextBox();
            this.add_LastName = new System.Windows.Forms.TextBox();
            this.add_FirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.add_ConPIN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.add_Position);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.add_Company);
            this.panel1.Controls.Add(this.container);
            this.panel1.Controls.Add(this.add_Email);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.add_Phone);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.add_ExpiredDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.add_AccessLevel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.add_PIN);
            this.panel1.Controls.Add(this.add_LastName);
            this.panel1.Controls.Add(this.add_FirstName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 446);
            this.panel1.TabIndex = 0;
            // 
            // add_ConPIN
            // 
            this.add_ConPIN.Location = new System.Drawing.Point(112, 184);
            this.add_ConPIN.Name = "add_ConPIN";
            this.add_ConPIN.PasswordChar = '*';
            this.add_ConPIN.Size = new System.Drawing.Size(232, 20);
            this.add_ConPIN.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Confirm PIN:";
            // 
            // add_Position
            // 
            this.add_Position.FormattingEnabled = true;
            this.add_Position.Items.AddRange(new object[] {
            "Admin",
            "Receptionist",
            "Normal"});
            this.add_Position.Location = new System.Drawing.Point(112, 295);
            this.add_Position.Name = "add_Position";
            this.add_Position.Size = new System.Drawing.Size(232, 21);
            this.add_Position.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Company:";
            // 
            // add_Company
            // 
            this.add_Company.Location = new System.Drawing.Point(112, 337);
            this.add_Company.Name = "add_Company";
            this.add_Company.Size = new System.Drawing.Size(232, 20);
            this.add_Company.TabIndex = 9;
            // 
            // container
            // 
            this.container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.container.Controls.Add(this.radiobtn_emp);
            this.container.Controls.Add(this.radiobtn_vis);
            this.container.Location = new System.Drawing.Point(112, 12);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(232, 31);
            this.container.TabIndex = 14;
            // 
            // radiobtn_emp
            // 
            this.radiobtn_emp.AutoSize = true;
            this.radiobtn_emp.Location = new System.Drawing.Point(105, 7);
            this.radiobtn_emp.Name = "radiobtn_emp";
            this.radiobtn_emp.Size = new System.Drawing.Size(71, 17);
            this.radiobtn_emp.TabIndex = 1;
            this.radiobtn_emp.Text = "Employee";
            this.radiobtn_emp.UseVisualStyleBackColor = true;
            this.radiobtn_emp.CheckedChanged += new System.EventHandler(this.radiobtn_emp_CheckedChanged);
            // 
            // radiobtn_vis
            // 
            this.radiobtn_vis.AutoSize = true;
            this.radiobtn_vis.Checked = true;
            this.radiobtn_vis.Location = new System.Drawing.Point(9, 7);
            this.radiobtn_vis.Name = "radiobtn_vis";
            this.radiobtn_vis.Size = new System.Drawing.Size(53, 17);
            this.radiobtn_vis.TabIndex = 0;
            this.radiobtn_vis.TabStop = true;
            this.radiobtn_vis.Text = "Visitor";
            this.radiobtn_vis.UseVisualStyleBackColor = true;
            this.radiobtn_vis.CheckedChanged += new System.EventHandler(this.radiobtn_vis_CheckedChanged);
            // 
            // add_Email
            // 
            this.add_Email.Location = new System.Drawing.Point(112, 414);
            this.add_Email.Name = "add_Email";
            this.add_Email.Size = new System.Drawing.Size(232, 20);
            this.add_Email.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 417);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Email:";
            // 
            // add_Phone
            // 
            this.add_Phone.Location = new System.Drawing.Point(112, 377);
            this.add_Phone.Name = "add_Phone";
            this.add_Phone.Size = new System.Drawing.Size(232, 20);
            this.add_Phone.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Position:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Identity:";
            // 
            // add_ExpiredDate
            // 
            this.add_ExpiredDate.Location = new System.Drawing.Point(139, 258);
            this.add_ExpiredDate.Name = "add_ExpiredDate";
            this.add_ExpiredDate.Size = new System.Drawing.Size(205, 20);
            this.add_ExpiredDate.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "AuthorizedUntilDate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Access Level:";
            // 
            // add_AccessLevel
            // 
            this.add_AccessLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.add_AccessLevel.FormattingEnabled = true;
            this.add_AccessLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.add_AccessLevel.Location = new System.Drawing.Point(112, 221);
            this.add_AccessLevel.Name = "add_AccessLevel";
            this.add_AccessLevel.Size = new System.Drawing.Size(232, 21);
            this.add_AccessLevel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "PIN:";
            // 
            // add_PIN
            // 
            this.add_PIN.Location = new System.Drawing.Point(112, 146);
            this.add_PIN.Name = "add_PIN";
            this.add_PIN.PasswordChar = '*';
            this.add_PIN.Size = new System.Drawing.Size(232, 20);
            this.add_PIN.TabIndex = 4;
            // 
            // add_LastName
            // 
            this.add_LastName.Location = new System.Drawing.Point(112, 104);
            this.add_LastName.Name = "add_LastName";
            this.add_LastName.Size = new System.Drawing.Size(232, 20);
            this.add_LastName.TabIndex = 3;
            // 
            // add_FirstName
            // 
            this.add_FirstName.Location = new System.Drawing.Point(112, 64);
            this.add_FirstName.Name = "add_FirstName";
            this.add_FirstName.Size = new System.Drawing.Size(232, 20);
            this.add_FirstName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First name:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(292, 479);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(199, 479);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 520);
            this.ControlBox = false;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox add_PIN;
        private System.Windows.Forms.TextBox add_LastName;
        private System.Windows.Forms.TextBox add_FirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox add_AccessLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker add_ExpiredDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radiobtn_emp;
        private System.Windows.Forms.RadioButton radiobtn_vis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox add_Email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox add_Phone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox add_Company;
        private System.Windows.Forms.ComboBox add_Position;
        private System.Windows.Forms.TextBox add_ConPIN;
        private System.Windows.Forms.Label label1;
    }
}