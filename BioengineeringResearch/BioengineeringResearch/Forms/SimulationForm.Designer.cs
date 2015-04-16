namespace BioengineeringResearch
{
    partial class SimulationForm
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
            this.getFireLocation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartFire = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStartCF = new System.Windows.Forms.Button();
            this.getFailedDoor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnStartIntr = new System.Windows.Forms.Button();
            this.getIntrDoor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // getFireLocation
            // 
            this.getFireLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.getFireLocation.FormattingEnabled = true;
            this.getFireLocation.Items.AddRange(new object[] {
            "General Administration",
            "Research Support",
            "Corridor A",
            "Corridor B",
            "Corridor C",
            "SRA 1",
            "SRA 2",
            "SRA 3",
            "SRA 4",
            "SRA 5",
            "SRA 6"});
            this.getFireLocation.Location = new System.Drawing.Point(71, 20);
            this.getFireLocation.Name = "getFireLocation";
            this.getFireLocation.Size = new System.Drawing.Size(171, 20);
            this.getFireLocation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Location:";
            // 
            // btnStartFire
            // 
            this.btnStartFire.Location = new System.Drawing.Point(145, 56);
            this.btnStartFire.Name = "btnStartFire";
            this.btnStartFire.Size = new System.Drawing.Size(75, 23);
            this.btnStartFire.TabIndex = 3;
            this.btnStartFire.Text = "Start";
            this.btnStartFire.UseVisualStyleBackColor = true;
            this.btnStartFire.Click += new System.EventHandler(this.btnStartFire_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnStartFire);
            this.groupBox1.Controls.Add(this.getFireLocation);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fire";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(157, 340);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStartCF);
            this.groupBox2.Controls.Add(this.getFailedDoor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cardreader Failure";
            // 
            // btnStartCF
            // 
            this.btnStartCF.Location = new System.Drawing.Point(145, 58);
            this.btnStartCF.Name = "btnStartCF";
            this.btnStartCF.Size = new System.Drawing.Size(75, 23);
            this.btnStartCF.TabIndex = 5;
            this.btnStartCF.Text = "Start";
            this.btnStartCF.UseVisualStyleBackColor = true;
            this.btnStartCF.Click += new System.EventHandler(this.btnStartCF_Click);
            // 
            // getFailedDoor
            // 
            this.getFailedDoor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.getFailedDoor.FormattingEnabled = true;
            this.getFailedDoor.Items.AddRange(new object[] {
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
            this.getFailedDoor.Location = new System.Drawing.Point(99, 20);
            this.getFailedDoor.Name = "getFailedDoor";
            this.getFailedDoor.Size = new System.Drawing.Size(121, 20);
            this.getFailedDoor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Door:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnStartIntr);
            this.groupBox3.Controls.Add(this.getIntrDoor);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 100);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Intruder";
            // 
            // btnStartIntr
            // 
            this.btnStartIntr.Location = new System.Drawing.Point(145, 58);
            this.btnStartIntr.Name = "btnStartIntr";
            this.btnStartIntr.Size = new System.Drawing.Size(75, 23);
            this.btnStartIntr.TabIndex = 5;
            this.btnStartIntr.Text = "Start";
            this.btnStartIntr.UseVisualStyleBackColor = true;
            this.btnStartIntr.Click += new System.EventHandler(this.btnStartIntr_Click);
            // 
            // getIntrDoor
            // 
            this.getIntrDoor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.getIntrDoor.FormattingEnabled = true;
            this.getIntrDoor.Items.AddRange(new object[] {
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
            this.getIntrDoor.Location = new System.Drawing.Point(99, 20);
            this.getIntrDoor.Name = "getIntrDoor";
            this.getIntrDoor.Size = new System.Drawing.Size(121, 20);
            this.getIntrDoor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Door:";
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 382);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Name = "SimulationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox getFireLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartFire;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox getFailedDoor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartCF;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStartIntr;
        private System.Windows.Forms.ComboBox getIntrDoor;
        private System.Windows.Forms.Label label3;


    }
}