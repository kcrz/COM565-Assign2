﻿namespace BioengineeringResearch.Forms
{
    partial class ManageForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.listviewPerson = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columFname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAccessLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbLastName = new System.Windows.Forms.RadioButton();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.rbFirstName = new System.Windows.Forms.RadioButton();
            this.rdoLastName = new System.Windows.Forms.RadioButton();
            this.rdoId = new System.Windows.Forms.RadioButton();
            this.rdoFirstName = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSrchPerson = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeltPerson = new System.Windows.Forms.Button();
            this.listViewHist = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.txtPasserId = new System.Windows.Forms.TextBox();
            this.btnSrchHistBy = new System.Windows.Forms.Button();
            this.chkBxPasserId = new System.Windows.Forms.CheckBox();
            this.chkboxTime = new System.Windows.Forms.CheckBox();
            this.dropDownDoor = new System.Windows.Forms.ComboBox();
            this.chkboxDoor = new System.Windows.Forms.CheckBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.chkboxDate = new System.Windows.Forms.CheckBox();
            this.btnShowAllHist = new System.Windows.Forms.Button();
            this.btnShowAllVist = new System.Windows.Forms.Button();
            this.btnShowAllEmp = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.txtLogStatus = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(637, 586);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listviewPerson
            // 
            this.listviewPerson.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columFname,
            this.columnLname,
            this.columnAccessLevel,
            this.columnPosition,
            this.columnCompany,
            this.columnEmail});
            this.listviewPerson.Location = new System.Drawing.Point(12, 81);
            this.listviewPerson.Name = "listviewPerson";
            this.listviewPerson.Size = new System.Drawing.Size(700, 170);
            this.listviewPerson.TabIndex = 5;
            this.listviewPerson.UseCompatibleStateImageBehavior = false;
            this.listviewPerson.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 61;
            // 
            // columFname
            // 
            this.columFname.Text = "First name";
            this.columFname.Width = 100;
            // 
            // columnLname
            // 
            this.columnLname.Text = "Last name";
            this.columnLname.Width = 100;
            // 
            // columnAccessLevel
            // 
            this.columnAccessLevel.Text = "Access level";
            this.columnAccessLevel.Width = 73;
            // 
            // columnPosition
            // 
            this.columnPosition.Text = "Position";
            this.columnPosition.Width = 98;
            // 
            // columnCompany
            // 
            this.columnCompany.Text = "Company";
            this.columnCompany.Width = 106;
            // 
            // columnEmail
            // 
            this.columnEmail.Text = "Email";
            this.columnEmail.Width = 154;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnSrchPerson);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 63);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Person By";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbLastName);
            this.panel1.Controls.Add(this.rbID);
            this.panel1.Controls.Add(this.rbFirstName);
            this.panel1.Controls.Add(this.rdoLastName);
            this.panel1.Controls.Add(this.rdoId);
            this.panel1.Controls.Add(this.rdoFirstName);
            this.panel1.Location = new System.Drawing.Point(6, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 26);
            this.panel1.TabIndex = 9;
            // 
            // rbLastName
            // 
            this.rbLastName.AutoSize = true;
            this.rbLastName.Location = new System.Drawing.Point(165, 3);
            this.rbLastName.Name = "rbLastName";
            this.rbLastName.Size = new System.Drawing.Size(77, 16);
            this.rbLastName.TabIndex = 2;
            this.rbLastName.TabStop = true;
            this.rbLastName.Text = "Last name";
            this.rbLastName.UseVisualStyleBackColor = true;
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.Checked = true;
            this.rbID.Location = new System.Drawing.Point(3, 3);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(35, 16);
            this.rbID.TabIndex = 0;
            this.rbID.TabStop = true;
            this.rbID.Text = "ID";
            this.rbID.UseVisualStyleBackColor = true;
            // 
            // rbFirstName
            // 
            this.rbFirstName.AutoSize = true;
            this.rbFirstName.Location = new System.Drawing.Point(59, 3);
            this.rbFirstName.Name = "rbFirstName";
            this.rbFirstName.Size = new System.Drawing.Size(83, 16);
            this.rbFirstName.TabIndex = 1;
            this.rbFirstName.TabStop = true;
            this.rbFirstName.Text = "First name";
            this.rbFirstName.UseVisualStyleBackColor = true;
            // 
            // rdoLastName
            // 
            this.rdoLastName.AutoSize = true;
            this.rdoLastName.Location = new System.Drawing.Point(165, 3);
            this.rdoLastName.Name = "rdoLastName";
            this.rdoLastName.Size = new System.Drawing.Size(77, 16);
            this.rdoLastName.TabIndex = 2;
            this.rdoLastName.TabStop = true;
            this.rdoLastName.Text = "Last name";
            this.rdoLastName.UseVisualStyleBackColor = true;
            // 
            // rdoId
            // 
            this.rdoId.AutoSize = true;
            this.rdoId.Checked = true;
            this.rdoId.Location = new System.Drawing.Point(3, 3);
            this.rdoId.Name = "rdoId";
            this.rdoId.Size = new System.Drawing.Size(35, 16);
            this.rdoId.TabIndex = 0;
            this.rdoId.TabStop = true;
            this.rdoId.Text = "ID";
            this.rdoId.UseVisualStyleBackColor = true;
            // 
            // rdoFirstName
            // 
            this.rdoFirstName.AutoSize = true;
            this.rdoFirstName.Location = new System.Drawing.Point(59, 3);
            this.rdoFirstName.Name = "rdoFirstName";
            this.rdoFirstName.Size = new System.Drawing.Size(83, 16);
            this.rdoFirstName.TabIndex = 1;
            this.rdoFirstName.TabStop = true;
            this.rdoFirstName.Text = "First name";
            this.rdoFirstName.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(260, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(234, 21);
            this.txtSearch.TabIndex = 7;
            // 
            // btnSrchPerson
            // 
            this.btnSrchPerson.Location = new System.Drawing.Point(500, 21);
            this.btnSrchPerson.Name = "btnSrchPerson";
            this.btnSrchPerson.Size = new System.Drawing.Size(75, 23);
            this.btnSrchPerson.TabIndex = 8;
            this.btnSrchPerson.Text = "Search";
            this.btnSrchPerson.UseVisualStyleBackColor = true;
            this.btnSrchPerson.Click += new System.EventHandler(this.btnSrchPerson_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(637, 254);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Person";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeltPerson
            // 
            this.btnDeltPerson.Location = new System.Drawing.Point(538, 254);
            this.btnDeltPerson.Name = "btnDeltPerson";
            this.btnDeltPerson.Size = new System.Drawing.Size(75, 23);
            this.btnDeltPerson.TabIndex = 10;
            this.btnDeltPerson.Text = "Delete";
            this.btnDeltPerson.UseVisualStyleBackColor = true;
            this.btnDeltPerson.Click += new System.EventHandler(this.btnDeltPerson_Click);
            // 
            // listViewHist
            // 
            this.listViewHist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listViewHist.Location = new System.Drawing.Point(12, 379);
            this.listViewHist.Name = "listViewHist";
            this.listViewHist.Size = new System.Drawing.Size(700, 200);
            this.listViewHist.TabIndex = 11;
            this.listViewHist.UseCompatibleStateImageBehavior = false;
            this.listViewHist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Access date";
            this.columnHeader7.Width = 134;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Door location";
            this.columnHeader8.Width = 119;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Person ID";
            this.columnHeader9.Width = 171;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "First name";
            this.columnHeader10.Width = 148;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Last name";
            this.columnHeader11.Width = 142;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.timePicker);
            this.groupBox2.Controls.Add(this.txtPasserId);
            this.groupBox2.Controls.Add(this.btnSrchHistBy);
            this.groupBox2.Controls.Add(this.chkBxPasserId);
            this.groupBox2.Controls.Add(this.chkboxTime);
            this.groupBox2.Controls.Add(this.dropDownDoor);
            this.groupBox2.Controls.Add(this.chkboxDoor);
            this.groupBox2.Controls.Add(this.datePicker);
            this.groupBox2.Controls.Add(this.chkboxDate);
            this.groupBox2.Location = new System.Drawing.Point(12, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 90);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search History";
            // 
            // timePicker
            // 
            this.timePicker.Enabled = false;
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(183, 54);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(87, 21);
            this.timePicker.TabIndex = 11;
            this.timePicker.Value = new System.DateTime(2015, 4, 17, 22, 20, 20, 0);
            // 
            // txtPasserId
            // 
            this.txtPasserId.Enabled = false;
            this.txtPasserId.Location = new System.Drawing.Point(500, 25);
            this.txtPasserId.Name = "txtPasserId";
            this.txtPasserId.Size = new System.Drawing.Size(148, 21);
            this.txtPasserId.TabIndex = 9;
            // 
            // btnSrchHistBy
            // 
            this.btnSrchHistBy.Location = new System.Drawing.Point(21, 20);
            this.btnSrchHistBy.Name = "btnSrchHistBy";
            this.btnSrchHistBy.Size = new System.Drawing.Size(75, 23);
            this.btnSrchHistBy.TabIndex = 10;
            this.btnSrchHistBy.Text = "Search By";
            this.btnSrchHistBy.UseVisualStyleBackColor = true;
            this.btnSrchHistBy.Click += new System.EventHandler(this.btnSrchHistBy_Click);
            // 
            // chkBxPasserId
            // 
            this.chkBxPasserId.AutoSize = true;
            this.chkBxPasserId.Location = new System.Drawing.Point(402, 25);
            this.chkBxPasserId.Name = "chkBxPasserId";
            this.chkBxPasserId.Size = new System.Drawing.Size(84, 16);
            this.chkBxPasserId.TabIndex = 8;
            this.chkBxPasserId.Text = "Passer ID:";
            this.chkBxPasserId.UseVisualStyleBackColor = true;
            this.chkBxPasserId.CheckedChanged += new System.EventHandler(this.chkBxPasserId_CheckedChanged);
            // 
            // chkboxTime
            // 
            this.chkboxTime.AutoSize = true;
            this.chkboxTime.Location = new System.Drawing.Point(123, 56);
            this.chkboxTime.Name = "chkboxTime";
            this.chkboxTime.Size = new System.Drawing.Size(54, 16);
            this.chkboxTime.TabIndex = 6;
            this.chkboxTime.Text = "Time:";
            this.chkboxTime.UseVisualStyleBackColor = true;
            this.chkboxTime.CheckedChanged += new System.EventHandler(this.chkboxTime_CheckedChanged);
            // 
            // dropDownDoor
            // 
            this.dropDownDoor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownDoor.Enabled = false;
            this.dropDownDoor.FormattingEnabled = true;
            this.dropDownDoor.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "A6",
            "A7",
            "A8",
            "B1",
            "B2",
            "B3",
            "C1",
            "C2",
            "C3",
            "C4",
            "C5",
            "C6",
            "C7",
            "C8"});
            this.dropDownDoor.Location = new System.Drawing.Point(566, 54);
            this.dropDownDoor.Name = "dropDownDoor";
            this.dropDownDoor.Size = new System.Drawing.Size(82, 20);
            this.dropDownDoor.TabIndex = 5;
            // 
            // chkboxDoor
            // 
            this.chkboxDoor.AutoSize = true;
            this.chkboxDoor.Location = new System.Drawing.Point(402, 54);
            this.chkboxDoor.Name = "chkboxDoor";
            this.chkboxDoor.Size = new System.Drawing.Size(108, 16);
            this.chkboxDoor.TabIndex = 2;
            this.chkboxDoor.Text = "Door location:";
            this.chkboxDoor.UseVisualStyleBackColor = true;
            this.chkboxDoor.CheckedChanged += new System.EventHandler(this.chkboxDoor_CheckedChanged);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(183, 22);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 21);
            this.datePicker.TabIndex = 1;
            // 
            // chkboxDate
            // 
            this.chkboxDate.AutoSize = true;
            this.chkboxDate.Checked = true;
            this.chkboxDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxDate.Location = new System.Drawing.Point(123, 25);
            this.chkboxDate.Name = "chkboxDate";
            this.chkboxDate.Size = new System.Drawing.Size(54, 16);
            this.chkboxDate.TabIndex = 0;
            this.chkboxDate.Text = "Date:";
            this.chkboxDate.UseVisualStyleBackColor = true;
            this.chkboxDate.CheckedChanged += new System.EventHandler(this.chkboxDate_CheckedChanged);
            // 
            // btnShowAllHist
            // 
            this.btnShowAllHist.Location = new System.Drawing.Point(12, 585);
            this.btnShowAllHist.Name = "btnShowAllHist";
            this.btnShowAllHist.Size = new System.Drawing.Size(145, 23);
            this.btnShowAllHist.TabIndex = 15;
            this.btnShowAllHist.Text = "Show All History";
            this.btnShowAllHist.UseVisualStyleBackColor = true;
            this.btnShowAllHist.Click += new System.EventHandler(this.btnShowAllHist_Click);
            // 
            // btnShowAllVist
            // 
            this.btnShowAllVist.Location = new System.Drawing.Point(13, 254);
            this.btnShowAllVist.Name = "btnShowAllVist";
            this.btnShowAllVist.Size = new System.Drawing.Size(148, 23);
            this.btnShowAllVist.TabIndex = 0;
            this.btnShowAllVist.Text = "Show All Visitors";
            this.btnShowAllVist.UseVisualStyleBackColor = true;
            this.btnShowAllVist.Click += new System.EventHandler(this.btnShowAllVist_Click);
            // 
            // btnShowAllEmp
            // 
            this.btnShowAllEmp.Location = new System.Drawing.Point(167, 254);
            this.btnShowAllEmp.Name = "btnShowAllEmp";
            this.btnShowAllEmp.Size = new System.Drawing.Size(148, 23);
            this.btnShowAllEmp.TabIndex = 1;
            this.btnShowAllEmp.Text = "Show All Employees";
            this.btnShowAllEmp.UseVisualStyleBackColor = true;
            this.btnShowAllEmp.Click += new System.EventHandler(this.btnShowAllEmp_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(321, 254);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(148, 23);
            this.btnShowAll.TabIndex = 2;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // txtLogStatus
            // 
            this.txtLogStatus.Enabled = false;
            this.txtLogStatus.Location = new System.Drawing.Point(458, 587);
            this.txtLogStatus.Name = "txtLogStatus";
            this.txtLogStatus.Size = new System.Drawing.Size(173, 21);
            this.txtLogStatus.TabIndex = 16;
            this.txtLogStatus.Text = "Your Status:";
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 621);
            this.ControlBox = false;
            this.Controls.Add(this.txtLogStatus);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnShowAllEmp);
            this.Controls.Add(this.btnShowAllHist);
            this.Controls.Add(this.btnShowAllVist);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listViewHist);
            this.Controls.Add(this.btnDeltPerson);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listviewPerson);
            this.Controls.Add(this.btnExit);
            this.Name = "ManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView listviewPerson;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columFname;
        private System.Windows.Forms.ColumnHeader columnLname;
        private System.Windows.Forms.ColumnHeader columnPosition;
        private System.Windows.Forms.ColumnHeader columnEmail;
        private System.Windows.Forms.ColumnHeader columnAccessLevel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLastName;
        private System.Windows.Forms.RadioButton rbFirstName;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.RadioButton rdoLastName;
        private System.Windows.Forms.RadioButton rdoFirstName;
        private System.Windows.Forms.RadioButton rdoId;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSrchPerson;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeltPerson;
        private System.Windows.Forms.ListView listViewHist;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkboxDoor;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.CheckBox chkboxDate;
        private System.Windows.Forms.ComboBox dropDownDoor;
        private System.Windows.Forms.TextBox txtPasserId;
        private System.Windows.Forms.CheckBox chkBxPasserId;
        private System.Windows.Forms.CheckBox chkboxTime;
        private System.Windows.Forms.Button btnSrchHistBy;
        private System.Windows.Forms.Button btnShowAllHist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowAllVist;
        private System.Windows.Forms.Button btnShowAllEmp;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox txtLogStatus;
        private System.Windows.Forms.ColumnHeader columnCompany;
        private System.Windows.Forms.DateTimePicker timePicker;
    }
}