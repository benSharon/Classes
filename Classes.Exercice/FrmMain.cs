using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes.Exercice.Models;

namespace Classes.Exercice
{
    public partial class FrmMain : Form
    {
        private SchoolData schoolObject = new SchoolData();
        public FrmMain()
        {
            InitializeComponent();
            // TODO: Initialize SchoolData and UI
            InitializeApplication();
        }

        private void cboClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: Display class info with students
            UpdateClassView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // TODO: Display selected student's info
            Student student = schoolObject.GetStudent(lvwStudents.SelectedItems[0].SubItems[0].Text);
            DisplayStudentInfo(student);
            DisplayStudentClasses(student);
            ToggleTextBoxesAndButton();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // TODO: If Text is "Add" => Create student
            List<string> checkedClasses = GetCheckedClasses();
            string studentFullName = txtLastName.Text + ", " + txtFirstName.Text;
            if (btnAdd.Text == "Add")
                schoolObject.CreateStudent(txtFirstName.Text, 
                                           txtLastName.Text, 
                                           txtBirthday.Text, 
                                           checkedClasses);
            // TODO: If Text is "Update" => Edit student
            else if (btnAdd.Text == "Update")
            {
                UpdateStudent(schoolObject.GetStudent(studentFullName), checkedClasses);
            }
            ClearNewStudent();
            UpdateClassView();
        }

        private void InitializeApplication()
        {
            string[] classesNamesList = schoolObject.GetAllClassesText();
            cboClasses.Items.AddRange(classesNamesList);
            chlClasses.Items.AddRange(classesNamesList);
            cboClasses.SelectedIndex = 0;
        }

        private void DisplayStudentInfo(Student student)
        {
            txtLastName.Text = student.LastName;
            txtFirstName.Text = student.FirstName;
            txtBirthday.Text = student.Birthday.ToString();
        }

        private void DisplayStudentClasses(Student student)
        {
            List<Class> studentClasses = schoolObject.GetStudentClasses(student);
            List<string> studentClassesNames = new List<string>();
            foreach (var item in studentClasses)
                studentClassesNames.Add(item.Name);

            for (int i = 0; i < chlClasses.Items.Count; i++)
                if (studentClassesNames.Contains(chlClasses.Items[i].ToString()))
                    chlClasses.SetItemCheckState(i, CheckState.Checked);
                else chlClasses.SetItemCheckState(i, CheckState.Unchecked);
        }

        private List<string> GetCheckedClasses()
        {
            var classes = new List<string>();
            foreach (var item in chlClasses.CheckedItems)
                classes.Add(item.ToString());
            return classes;
        }

        private void AddStudent(List<string> classes)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string birthday = txtBirthday.Text;
            schoolObject.CreateStudent(firstName, lastName, birthday, classes);
        }

        private void ToggleTextBoxesAndButton()
        {
            if (btnAdd.Text == "Add")
            {
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
                txtBirthday.Enabled = false;
                btnAdd.Text = "Update";
            }
            else if (btnAdd.Text == "Update")
            {
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                txtBirthday.Enabled = true;
                btnAdd.Text = "Add";
            }
        }

        private void UpdateStudent(Student student, List<string> classes)
        {
            ToggleTextBoxesAndButton();
            schoolObject.EditStudent(student, classes);
        }

        private void ClearNewStudent()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtBirthday.Clear();
            for (int i = 0; i < chlClasses.Items.Count; i++)
                chlClasses.SetItemCheckState(i, CheckState.Unchecked);
        }

        private void DisplayClassInfo(Class c)
        {
            txtSubject.Text = c.Subject.Name;
            txtTeacher.Text = c.Teacher;
        }

        private void UpdateListView(Class c)
        {
            lvwStudents.Items.Clear();
            foreach (var student in c.Students)
            {
                ListViewItem list = new ListViewItem(student.FullName);
                list.SubItems.Add(student.Age.ToString());
                lvwStudents.Items.Add(list);
            }
            lvwStudents.Sort();
        }

        private void UpdateClassView()
        {
            Class c = schoolObject.GetClass(cboClasses.Text);
            DisplayClassInfo(c);
            UpdateListView(c);
        }
    }
}
