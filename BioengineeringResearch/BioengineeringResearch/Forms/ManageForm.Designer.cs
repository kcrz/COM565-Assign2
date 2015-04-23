namespace BioengineeringResearch.Forms
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
            this.columnAccessGrantedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAuthorisedUntilDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoLastName = new System.Windows.Forms.RadioButton();
            this.rdoId = new System.Windows.Forms.RadioButton();
            this.rdoFirstName = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSrchPerson = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listViewHist = new System.Windows.Forms.ListView();
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDoor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClearanceLvl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoHistoryDoor = new System.Windows.Forms.RadioButton();
            this.rdoHistoryPasserId = new System.Windows.Forms.RadioButton();
            this.rdoHistoryTime = new System.Windows.Forms.RadioButton();
            this.rdoHistoryDate = new System.Windows.Forms.RadioButton();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSrchHistBy = new System.Windows.Forms.Button();
            this.txtPasserId = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.dropDownDoor = new System.Windows.Forms.ComboBox();
            this.btnShowAllHist = new System.Windows.Forms.Button();
            this.btnShowAllVist = new System.Windows.Forms.Button();
            this.btnShowAllEmp = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.txtLogStatus = new System.Windows.Forms.TextBox();
            this.btnExportHistory = new System.Windows.Forms.Button();
            this.btnExportPerson = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(637, 635);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 21;
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
            this.columnAccessGrantedDate,
            this.columnAuthorisedUntilDate,
            this.columnPosition,
            this.columnDepartment,
            this.columnCompany,
            this.columnEmail,
            this.columnPhone});
            this.listviewPerson.Location = new System.Drawing.Point(12, 85);
            this.listviewPerson.Name = "listviewPerson";
            this.listviewPerson.Size = new System.Drawing.Size(700, 184);
            this.listviewPerson.TabIndex = 5;
            this.listviewPerson.UseCompatibleStateImageBehavior = false;
            this.listviewPerson.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columFname
            // 
            this.columFname.Text = "First name";
            this.columFname.Width = 80;
            // 
            // columnLname
            // 
            this.columnLname.Text = "Last name";
            this.columnLname.Width = 90;
            // 
            // columnAccessLevel
            // 
            this.columnAccessLevel.Text = "Access level";
            this.columnAccessLevel.Width = 75;
            // 
            // columnAccessGrantedDate
            // 
            this.columnAccessGrantedDate.Text = "Access Granted Date";
            this.columnAccessGrantedDate.Width = 125;
            // 
            // columnAuthorisedUntilDate
            // 
            this.columnAuthorisedUntilDate.Text = "Access Valid Until";
            this.columnAuthorisedUntilDate.Width = 100;
            // 
            // columnPosition
            // 
            this.columnPosition.Text = "Position";
            this.columnPosition.Width = 80;
            // 
            // columnDepartment
            // 
            this.columnDepartment.Text = "Department";
            this.columnDepartment.Width = 80;
            // 
            // columnCompany
            // 
            this.columnCompany.Text = "Company";
            this.columnCompany.Width = 80;
            // 
            // columnEmail
            // 
            this.columnEmail.Text = "Email";
            this.columnEmail.Width = 80;
            // 
            // columnPhone
            // 
            this.columnPhone.Text = "Phone";
            this.columnPhone.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnSrchPerson);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Person By";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rdoLastName);
            this.panel1.Controls.Add(this.rdoId);
            this.panel1.Controls.Add(this.rdoFirstName);
            this.panel1.Location = new System.Drawing.Point(6, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 28);
            this.panel1.TabIndex = 9;
            // 
            // rdoLastName
            // 
            this.rdoLastName.AutoSize = true;
            this.rdoLastName.Location = new System.Drawing.Point(165, 3);
            this.rdoLastName.Name = "rdoLastName";
            this.rdoLastName.Size = new System.Drawing.Size(74, 17);
            this.rdoLastName.TabIndex = 3;
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
            this.rdoId.Size = new System.Drawing.Size(36, 17);
            this.rdoId.TabIndex = 1;
            this.rdoId.TabStop = true;
            this.rdoId.Text = "ID";
            this.rdoId.UseVisualStyleBackColor = true;
            // 
            // rdoFirstName
            // 
            this.rdoFirstName.AutoSize = true;
            this.rdoFirstName.Location = new System.Drawing.Point(59, 3);
            this.rdoFirstName.Name = "rdoFirstName";
            this.rdoFirstName.Size = new System.Drawing.Size(73, 17);
            this.rdoFirstName.TabIndex = 2;
            this.rdoFirstName.TabStop = true;
            this.rdoFirstName.Text = "First name";
            this.rdoFirstName.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(260, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(234, 20);
            this.txtSearch.TabIndex = 4;
            // 
            // btnSrchPerson
            // 
            this.btnSrchPerson.Location = new System.Drawing.Point(500, 23);
            this.btnSrchPerson.Name = "btnSrchPerson";
            this.btnSrchPerson.Size = new System.Drawing.Size(75, 25);
            this.btnSrchPerson.TabIndex = 5;
            this.btnSrchPerson.Text = "Search";
            this.btnSrchPerson.UseVisualStyleBackColor = true;
            this.btnSrchPerson.Click += new System.EventHandler(this.btnSrchPerson_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(637, 275);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Person";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listViewHist
            // 
            this.listViewHist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDate,
            this.colTime,
            this.colDoor,
            this.colId,
            this.colFName,
            this.colLName,
            this.colClearanceLvl});
            this.listViewHist.Location = new System.Drawing.Point(12, 411);
            this.listViewHist.Name = "listViewHist";
            this.listViewHist.Size = new System.Drawing.Size(700, 216);
            this.listViewHist.TabIndex = 11;
            this.listViewHist.UseCompatibleStateImageBehavior = false;
            this.listViewHist.View = System.Windows.Forms.View.Details;
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.Width = 91;
            // 
            // colTime
            // 
            this.colTime.Text = "Time";
            // 
            // colDoor
            // 
            this.colDoor.Text = "Door";
            this.colDoor.Width = 77;
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 73;
            // 
            // colFName
            // 
            this.colFName.Text = "First Name";
            this.colFName.Width = 109;
            // 
            // colLName
            // 
            this.colLName.Text = "Last Name";
            this.colLName.Width = 142;
            // 
            // colClearanceLvl
            // 
            this.colClearanceLvl.Text = "Clearance Level";
            this.colClearanceLvl.Width = 101;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoHistoryDoor);
            this.groupBox2.Controls.Add(this.rdoHistoryPasserId);
            this.groupBox2.Controls.Add(this.rdoHistoryTime);
            this.groupBox2.Controls.Add(this.rdoHistoryDate);
            this.groupBox2.Controls.Add(this.timePicker);
            this.groupBox2.Controls.Add(this.btnSrchHistBy);
            this.groupBox2.Controls.Add(this.txtPasserId);
            this.groupBox2.Controls.Add(this.datePicker);
            this.groupBox2.Controls.Add(this.dropDownDoor);
            this.groupBox2.Location = new System.Drawing.Point(12, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 98);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search History";
            // 
            // rdoHistoryDoor
            // 
            this.rdoHistoryDoor.AutoSize = true;
            this.rdoHistoryDoor.Location = new System.Drawing.Point(455, 57);
            this.rdoHistoryDoor.Name = "rdoHistoryDoor";
            this.rdoHistoryDoor.Size = new System.Drawing.Size(51, 17);
            this.rdoHistoryDoor.TabIndex = 18;
            this.rdoHistoryDoor.TabStop = true;
            this.rdoHistoryDoor.Text = "Door:";
            this.rdoHistoryDoor.UseVisualStyleBackColor = true;
            this.rdoHistoryDoor.CheckedChanged += new System.EventHandler(this.rdoHistoryDoor_CheckedChanged);
            // 
            // rdoHistoryPasserId
            // 
            this.rdoHistoryPasserId.AutoSize = true;
            this.rdoHistoryPasserId.Location = new System.Drawing.Point(455, 22);
            this.rdoHistoryPasserId.Name = "rdoHistoryPasserId";
            this.rdoHistoryPasserId.Size = new System.Drawing.Size(64, 17);
            this.rdoHistoryPasserId.TabIndex = 14;
            this.rdoHistoryPasserId.TabStop = true;
            this.rdoHistoryPasserId.Text = "User ID:";
            this.rdoHistoryPasserId.UseVisualStyleBackColor = true;
            this.rdoHistoryPasserId.CheckedChanged += new System.EventHandler(this.rdoHistoryPasserId_CheckedChanged);
            // 
            // rdoHistoryTime
            // 
            this.rdoHistoryTime.AutoSize = true;
            this.rdoHistoryTime.Location = new System.Drawing.Point(149, 58);
            this.rdoHistoryTime.Name = "rdoHistoryTime";
            this.rdoHistoryTime.Size = new System.Drawing.Size(51, 17);
            this.rdoHistoryTime.TabIndex = 16;
            this.rdoHistoryTime.TabStop = true;
            this.rdoHistoryTime.Text = "Time:";
            this.rdoHistoryTime.UseVisualStyleBackColor = true;
            this.rdoHistoryTime.CheckedChanged += new System.EventHandler(this.rdoHistoryTime_CheckedChanged);
            // 
            // rdoHistoryDate
            // 
            this.rdoHistoryDate.AutoSize = true;
            this.rdoHistoryDate.Location = new System.Drawing.Point(149, 18);
            this.rdoHistoryDate.Name = "rdoHistoryDate";
            this.rdoHistoryDate.Size = new System.Drawing.Size(51, 17);
            this.rdoHistoryDate.TabIndex = 12;
            this.rdoHistoryDate.TabStop = true;
            this.rdoHistoryDate.Text = "Date:";
            this.rdoHistoryDate.UseVisualStyleBackColor = true;
            this.rdoHistoryDate.CheckedChanged += new System.EventHandler(this.rdoHistoryDate_CheckedChanged);
            // 
            // timePicker
            // 
            this.timePicker.Enabled = false;
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(206, 54);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(87, 20);
            this.timePicker.TabIndex = 17;
            this.timePicker.Value = new System.DateTime(2015, 4, 17, 22, 20, 20, 0);
            // 
            // btnSrchHistBy
            // 
            this.btnSrchHistBy.Location = new System.Drawing.Point(21, 22);
            this.btnSrchHistBy.Name = "btnSrchHistBy";
            this.btnSrchHistBy.Size = new System.Drawing.Size(75, 25);
            this.btnSrchHistBy.TabIndex = 11;
            this.btnSrchHistBy.Text = "Search By";
            this.btnSrchHistBy.UseVisualStyleBackColor = true;
            this.btnSrchHistBy.Click += new System.EventHandler(this.btnSrchHistBy_Click);
            // 
            // txtPasserId
            // 
            this.txtPasserId.Enabled = false;
            this.txtPasserId.Location = new System.Drawing.Point(523, 22);
            this.txtPasserId.Name = "txtPasserId";
            this.txtPasserId.Size = new System.Drawing.Size(148, 20);
            this.txtPasserId.TabIndex = 15;
            // 
            // datePicker
            // 
            this.datePicker.Enabled = false;
            this.datePicker.Location = new System.Drawing.Point(206, 19);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 13;
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
            this.dropDownDoor.Location = new System.Drawing.Point(589, 54);
            this.dropDownDoor.Name = "dropDownDoor";
            this.dropDownDoor.Size = new System.Drawing.Size(82, 21);
            this.dropDownDoor.TabIndex = 19;
            // 
            // btnShowAllHist
            // 
            this.btnShowAllHist.Location = new System.Drawing.Point(12, 634);
            this.btnShowAllHist.Name = "btnShowAllHist";
            this.btnShowAllHist.Size = new System.Drawing.Size(145, 25);
            this.btnShowAllHist.TabIndex = 20;
            this.btnShowAllHist.Text = "Show All History";
            this.btnShowAllHist.UseVisualStyleBackColor = true;
            this.btnShowAllHist.Click += new System.EventHandler(this.btnShowAllHist_Click);
            // 
            // btnShowAllVist
            // 
            this.btnShowAllVist.Location = new System.Drawing.Point(13, 275);
            this.btnShowAllVist.Name = "btnShowAllVist";
            this.btnShowAllVist.Size = new System.Drawing.Size(148, 25);
            this.btnShowAllVist.TabIndex = 6;
            this.btnShowAllVist.Text = "Show All Visitors";
            this.btnShowAllVist.UseVisualStyleBackColor = true;
            this.btnShowAllVist.Click += new System.EventHandler(this.btnShowAllVist_Click);
            // 
            // btnShowAllEmp
            // 
            this.btnShowAllEmp.Location = new System.Drawing.Point(167, 275);
            this.btnShowAllEmp.Name = "btnShowAllEmp";
            this.btnShowAllEmp.Size = new System.Drawing.Size(148, 25);
            this.btnShowAllEmp.TabIndex = 7;
            this.btnShowAllEmp.Text = "Show All Employees";
            this.btnShowAllEmp.UseVisualStyleBackColor = true;
            this.btnShowAllEmp.Click += new System.EventHandler(this.btnShowAllEmp_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(321, 275);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(148, 25);
            this.btnShowAll.TabIndex = 8;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // txtLogStatus
            // 
            this.txtLogStatus.Enabled = false;
            this.txtLogStatus.Location = new System.Drawing.Point(458, 636);
            this.txtLogStatus.Name = "txtLogStatus";
            this.txtLogStatus.Size = new System.Drawing.Size(173, 20);
            this.txtLogStatus.TabIndex = 0;
            this.txtLogStatus.Text = "Your Status:";
            // 
            // btnExportHistory
            // 
            this.btnExportHistory.Location = new System.Drawing.Point(161, 634);
            this.btnExportHistory.Name = "btnExportHistory";
            this.btnExportHistory.Size = new System.Drawing.Size(103, 25);
            this.btnExportHistory.TabIndex = 22;
            this.btnExportHistory.Text = "Export History";
            this.btnExportHistory.UseVisualStyleBackColor = true;
            this.btnExportHistory.Click += new System.EventHandler(this.btnExportHistory_Click);
            // 
            // btnExportPerson
            // 
            this.btnExportPerson.Location = new System.Drawing.Point(475, 275);
            this.btnExportPerson.Name = "btnExportPerson";
            this.btnExportPerson.Size = new System.Drawing.Size(112, 25);
            this.btnExportPerson.TabIndex = 23;
            this.btnExportPerson.Text = "Export Person Data";
            this.btnExportPerson.UseVisualStyleBackColor = true;
            this.btnExportPerson.Click += new System.EventHandler(this.btnExportPerson_Click);
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 673);
            this.ControlBox = false;
            this.Controls.Add(this.btnExportPerson);
            this.Controls.Add(this.btnExportHistory);
            this.Controls.Add(this.txtLogStatus);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnShowAllEmp);
            this.Controls.Add(this.btnShowAllHist);
            this.Controls.Add(this.btnShowAllVist);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listViewHist);
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
        private System.Windows.Forms.RadioButton rdoLastName;
        private System.Windows.Forms.RadioButton rdoFirstName;
        private System.Windows.Forms.RadioButton rdoId;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSrchPerson;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView listViewHist;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colDoor;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colFName;
        private System.Windows.Forms.ColumnHeader colLName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox dropDownDoor;
        private System.Windows.Forms.TextBox txtPasserId;
        private System.Windows.Forms.Button btnSrchHistBy;
        private System.Windows.Forms.Button btnShowAllHist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowAllVist;
        private System.Windows.Forms.Button btnShowAllEmp;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox txtLogStatus;
        private System.Windows.Forms.ColumnHeader columnCompany;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.ColumnHeader columnAccessGrantedDate;
        private System.Windows.Forms.ColumnHeader columnAuthorisedUntilDate;
        private System.Windows.Forms.ColumnHeader columnDepartment;
        private System.Windows.Forms.ColumnHeader columnPhone;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.ColumnHeader colClearanceLvl;
        private System.Windows.Forms.RadioButton rdoHistoryDoor;
        private System.Windows.Forms.RadioButton rdoHistoryPasserId;
        private System.Windows.Forms.RadioButton rdoHistoryTime;
        private System.Windows.Forms.RadioButton rdoHistoryDate;
        private System.Windows.Forms.Button btnExportHistory;
        private System.Windows.Forms.Button btnExportPerson;
    }
}