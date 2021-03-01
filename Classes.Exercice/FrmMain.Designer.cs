namespace Classes.Exercice
{
    partial class FrmMain
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
            this.pnlClasses = new System.Windows.Forms.Panel();
            this.lblClass = new System.Windows.Forms.Label();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.lblStudents = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.cboClasses = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lvwStudents = new System.Windows.Forms.ListView();
            this.chFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlStudent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chlClasses = new System.Windows.Forms.CheckedListBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblNewStudent = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.pnlClasses.SuspendLayout();
            this.pnlStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClasses
            // 
            this.pnlClasses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClasses.Controls.Add(this.lblClass);
            this.pnlClasses.Controls.Add(this.txtTeacher);
            this.pnlClasses.Controls.Add(this.lblStudents);
            this.pnlClasses.Controls.Add(this.lblTeacher);
            this.pnlClasses.Controls.Add(this.txtSubject);
            this.pnlClasses.Controls.Add(this.cboClasses);
            this.pnlClasses.Controls.Add(this.lblSubject);
            this.pnlClasses.Controls.Add(this.btnEdit);
            this.pnlClasses.Controls.Add(this.lvwStudents);
            this.pnlClasses.Location = new System.Drawing.Point(16, 15);
            this.pnlClasses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlClasses.Name = "pnlClasses";
            this.pnlClasses.Size = new System.Drawing.Size(477, 524);
            this.pnlClasses.TabIndex = 0;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblClass.Location = new System.Drawing.Point(28, 30);
            this.lblClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(50, 18);
            this.lblClass.TabIndex = 8;
            this.lblClass.Text = "Class:";
            // 
            // txtTeacher
            // 
            this.txtTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTeacher.Location = new System.Drawing.Point(112, 153);
            this.txtTeacher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.ReadOnly = true;
            this.txtTeacher.Size = new System.Drawing.Size(181, 24);
            this.txtTeacher.TabIndex = 7;
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblStudents.Location = new System.Drawing.Point(28, 196);
            this.lblStudents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(70, 18);
            this.lblStudents.TabIndex = 6;
            this.lblStudents.Text = "Students:";
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTeacher.Location = new System.Drawing.Point(28, 155);
            this.lblTeacher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(66, 18);
            this.lblTeacher.TabIndex = 5;
            this.lblTeacher.Text = "Teacher:";
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSubject.Location = new System.Drawing.Point(112, 111);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ReadOnly = true;
            this.txtSubject.Size = new System.Drawing.Size(181, 24);
            this.txtSubject.TabIndex = 4;
            // 
            // cboClasses
            // 
            this.cboClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboClasses.FormattingEnabled = true;
            this.cboClasses.Location = new System.Drawing.Point(32, 57);
            this.cboClasses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboClasses.Name = "cboClasses";
            this.cboClasses.Size = new System.Drawing.Size(389, 26);
            this.cboClasses.TabIndex = 3;
            this.cboClasses.SelectedIndexChanged += new System.EventHandler(this.cboClasses_SelectedIndexChanged);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSubject.Location = new System.Drawing.Point(28, 113);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(61, 18);
            this.lblSubject.TabIndex = 2;
            this.lblSubject.Text = "Subject:";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEdit.Location = new System.Drawing.Point(156, 466);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(165, 39);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lvwStudents
            // 
            this.lvwStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFullName,
            this.chAge});
            this.lvwStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lvwStudents.FullRowSelect = true;
            this.lvwStudents.HideSelection = false;
            this.lvwStudents.Location = new System.Drawing.Point(32, 220);
            this.lvwStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvwStudents.Name = "lvwStudents";
            this.lvwStudents.Size = new System.Drawing.Size(407, 217);
            this.lvwStudents.TabIndex = 0;
            this.lvwStudents.UseCompatibleStateImageBehavior = false;
            this.lvwStudents.View = System.Windows.Forms.View.Details;
            // 
            // chFullName
            // 
            this.chFullName.Text = "Full Name";
            this.chFullName.Width = 212;
            // 
            // chAge
            // 
            this.chAge.Text = "Age";
            this.chAge.Width = 90;
            // 
            // pnlStudent
            // 
            this.pnlStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStudent.Controls.Add(this.label1);
            this.pnlStudent.Controls.Add(this.btnAdd);
            this.pnlStudent.Controls.Add(this.chlClasses);
            this.pnlStudent.Controls.Add(this.txtBirthday);
            this.pnlStudent.Controls.Add(this.lblBirthday);
            this.pnlStudent.Controls.Add(this.txtLastName);
            this.pnlStudent.Controls.Add(this.lblNewStudent);
            this.pnlStudent.Controls.Add(this.lblLastName);
            this.pnlStudent.Controls.Add(this.txtFirstName);
            this.pnlStudent.Controls.Add(this.lblFirstName);
            this.pnlStudent.Location = new System.Drawing.Point(517, 15);
            this.pnlStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlStudent.Name = "pnlStudent";
            this.pnlStudent.Size = new System.Drawing.Size(439, 524);
            this.pnlStudent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(41, 278);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Classes:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAdd.Location = new System.Drawing.Point(148, 466);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 39);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chlClasses
            // 
            this.chlClasses.FormattingEnabled = true;
            this.chlClasses.Location = new System.Drawing.Point(45, 314);
            this.chlClasses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chlClasses.Name = "chlClasses";
            this.chlClasses.Size = new System.Drawing.Size(352, 123);
            this.chlClasses.TabIndex = 15;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtBirthday.Location = new System.Drawing.Point(45, 235);
            this.txtBirthday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(188, 24);
            this.txtBirthday.TabIndex = 14;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblBirthday.Location = new System.Drawing.Point(41, 203);
            this.lblBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(157, 18);
            this.lblBirthday.TabIndex = 13;
            this.lblBirthday.Text = "Birthday (MM/dd/yyyy):";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtLastName.Location = new System.Drawing.Point(45, 160);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(188, 24);
            this.txtLastName.TabIndex = 12;
            // 
            // lblNewStudent
            // 
            this.lblNewStudent.AutoSize = true;
            this.lblNewStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.55F);
            this.lblNewStudent.Location = new System.Drawing.Point(173, 21);
            this.lblNewStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewStudent.Name = "lblNewStudent";
            this.lblNewStudent.Size = new System.Drawing.Size(101, 20);
            this.lblNewStudent.TabIndex = 0;
            this.lblNewStudent.Text = "New Student";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblLastName.Location = new System.Drawing.Point(41, 128);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 18);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtFirstName.Location = new System.Drawing.Point(45, 89);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(188, 24);
            this.txtFirstName.TabIndex = 10;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblFirstName.Location = new System.Drawing.Point(41, 60);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(85, 18);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 554);
            this.Controls.Add(this.pnlStudent);
            this.Controls.Add(this.pnlClasses);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.pnlClasses.ResumeLayout(false);
            this.pnlClasses.PerformLayout();
            this.pnlStudent.ResumeLayout(false);
            this.pnlStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlClasses;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.ComboBox cboClasses;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListView lvwStudents;
        private System.Windows.Forms.Panel pnlStudent;
        private System.Windows.Forms.Label lblNewStudent;
        private System.Windows.Forms.ColumnHeader chFullName;
        private System.Windows.Forms.ColumnHeader chAge;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.CheckedListBox chlClasses;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
    }
}

