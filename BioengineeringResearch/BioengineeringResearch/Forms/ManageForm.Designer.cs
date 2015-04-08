namespace BioengineeringResearch.Functions
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.listviewPerson = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
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
            this.chkboxDate = new System.Windows.Forms.CheckBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.chkboxDoor = new System.Windows.Forms.CheckBox();
            this.txtDoor = new System.Windows.Forms.ComboBox();
            this.chkboxID = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.chkboxFirstName = new System.Windows.Forms.CheckBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnSrchHistBy = new System.Windows.Forms.Button();
            this.btnDeltHist = new System.Windows.Forms.Button();
            this.btnShowAllHist = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowAllVist = new System.Windows.Forms.Button();
            this.btnShowAllEmp = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(637, 585);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Logout";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // listviewPerson
            // 
            this.listviewPerson.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listviewPerson.Location = new System.Drawing.Point(12, 81);
            this.listviewPerson.Name = "listviewPerson";
            this.listviewPerson.Size = new System.Drawing.Size(700, 170);
            this.listviewPerson.TabIndex = 5;
            this.listviewPerson.UseCompatibleStateImageBehavior = false;
            this.listviewPerson.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First name";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last name";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Position";
            this.columnHeader4.Width = 98;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Email";
            this.columnHeader5.Width = 154;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Access level";
            this.columnHeader6.Width = 98;
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
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(165, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Last name";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(59, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "First name";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(35, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ID";
            this.radioButton1.UseVisualStyleBackColor = true;
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
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(640, 257);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Person";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDeltPerson
            // 
            this.btnDeltPerson.Location = new System.Drawing.Point(539, 257);
            this.btnDeltPerson.Name = "btnDeltPerson";
            this.btnDeltPerson.Size = new System.Drawing.Size(75, 23);
            this.btnDeltPerson.TabIndex = 10;
            this.btnDeltPerson.Text = "Delete";
            this.btnDeltPerson.UseVisualStyleBackColor = true;
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
            this.groupBox2.Controls.Add(this.txtFirstName);
            this.groupBox2.Controls.Add(this.btnSrchHistBy);
            this.groupBox2.Controls.Add(this.chkboxFirstName);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.chkboxID);
            this.groupBox2.Controls.Add(this.txtDoor);
            this.groupBox2.Controls.Add(this.chkboxDoor);
            this.groupBox2.Controls.Add(this.txtDate);
            this.groupBox2.Controls.Add(this.chkboxDate);
            this.groupBox2.Location = new System.Drawing.Point(12, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 90);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search History";
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
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(183, 22);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(200, 21);
            this.txtDate.TabIndex = 1;
            // 
            // chkboxDoor
            // 
            this.chkboxDoor.AutoSize = true;
            this.chkboxDoor.Location = new System.Drawing.Point(397, 25);
            this.chkboxDoor.Name = "chkboxDoor";
            this.chkboxDoor.Size = new System.Drawing.Size(108, 16);
            this.chkboxDoor.TabIndex = 2;
            this.chkboxDoor.Text = "Door location:";
            this.chkboxDoor.UseVisualStyleBackColor = true;
            // 
            // txtDoor
            // 
            this.txtDoor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDoor.FormattingEnabled = true;
            this.txtDoor.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "A6",
            "A7",
            "A8",
            "A9",
            "B1",
            "B2",
            "C1",
            "C2",
            "C3",
            "C4",
            "C5",
            "C6",
            "C7",
            "C8"});
            this.txtDoor.Location = new System.Drawing.Point(511, 23);
            this.txtDoor.Name = "txtDoor";
            this.txtDoor.Size = new System.Drawing.Size(121, 20);
            this.txtDoor.TabIndex = 5;
            // 
            // chkboxID
            // 
            this.chkboxID.AutoSize = true;
            this.chkboxID.Location = new System.Drawing.Point(123, 56);
            this.chkboxID.Name = "chkboxID";
            this.chkboxID.Size = new System.Drawing.Size(84, 16);
            this.chkboxID.TabIndex = 6;
            this.chkboxID.Text = "Passer ID:";
            this.chkboxID.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(213, 54);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(170, 21);
            this.txtID.TabIndex = 7;
            // 
            // chkboxFirstName
            // 
            this.chkboxFirstName.AutoSize = true;
            this.chkboxFirstName.Location = new System.Drawing.Point(397, 56);
            this.chkboxFirstName.Name = "chkboxFirstName";
            this.chkboxFirstName.Size = new System.Drawing.Size(96, 16);
            this.chkboxFirstName.TabIndex = 8;
            this.chkboxFirstName.Text = "Passer name:";
            this.chkboxFirstName.UseVisualStyleBackColor = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(511, 54);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(121, 21);
            this.txtFirstName.TabIndex = 9;
            // 
            // btnSrchHistBy
            // 
            this.btnSrchHistBy.Location = new System.Drawing.Point(21, 20);
            this.btnSrchHistBy.Name = "btnSrchHistBy";
            this.btnSrchHistBy.Size = new System.Drawing.Size(75, 23);
            this.btnSrchHistBy.TabIndex = 10;
            this.btnSrchHistBy.Text = "Search By";
            this.btnSrchHistBy.UseVisualStyleBackColor = true;
            // 
            // btnDeltHist
            // 
            this.btnDeltHist.Location = new System.Drawing.Point(174, 585);
            this.btnDeltHist.Name = "btnDeltHist";
            this.btnDeltHist.Size = new System.Drawing.Size(75, 23);
            this.btnDeltHist.TabIndex = 14;
            this.btnDeltHist.Text = "Delete";
            this.btnDeltHist.UseVisualStyleBackColor = true;
            // 
            // btnShowAllHist
            // 
            this.btnShowAllHist.Location = new System.Drawing.Point(12, 585);
            this.btnShowAllHist.Name = "btnShowAllHist";
            this.btnShowAllHist.Size = new System.Drawing.Size(145, 23);
            this.btnShowAllHist.TabIndex = 15;
            this.btnShowAllHist.Text = "Show All History";
            this.btnShowAllHist.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Location = new System.Drawing.Point(6, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 26);
            this.panel1.TabIndex = 9;
            // 
            // btnShowAllVist
            // 
            this.btnShowAllVist.Location = new System.Drawing.Point(13, 254);
            this.btnShowAllVist.Name = "btnShowAllVist";
            this.btnShowAllVist.Size = new System.Drawing.Size(148, 23);
            this.btnShowAllVist.TabIndex = 0;
            this.btnShowAllVist.Text = "Show All Visitors";
            this.btnShowAllVist.UseVisualStyleBackColor = true;
            // 
            // btnShowAllEmp
            // 
            this.btnShowAllEmp.Location = new System.Drawing.Point(167, 254);
            this.btnShowAllEmp.Name = "btnShowAllEmp";
            this.btnShowAllEmp.Size = new System.Drawing.Size(148, 23);
            this.btnShowAllEmp.TabIndex = 1;
            this.btnShowAllEmp.Text = "Show All Employees";
            this.btnShowAllEmp.UseVisualStyleBackColor = true;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(321, 254);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(148, 23);
            this.btnShowAll.TabIndex = 2;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 621);
            this.ControlBox = false;
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnShowAllEmp);
            this.Controls.Add(this.btnShowAllHist);
            this.Controls.Add(this.btnShowAllVist);
            this.Controls.Add(this.btnDeltHist);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listViewHist);
            this.Controls.Add(this.btnDeltPerson);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listviewPerson);
            this.Controls.Add(this.btnCancel);
            this.Name = "ManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView listviewPerson;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
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
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.CheckBox chkboxDate;
        private System.Windows.Forms.ComboBox txtDoor;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.CheckBox chkboxFirstName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox chkboxID;
        private System.Windows.Forms.Button btnSrchHistBy;
        private System.Windows.Forms.Button btnDeltHist;
        private System.Windows.Forms.Button btnShowAllHist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowAllVist;
        private System.Windows.Forms.Button btnShowAllEmp;
        private System.Windows.Forms.Button btnShowAll;
    }
}