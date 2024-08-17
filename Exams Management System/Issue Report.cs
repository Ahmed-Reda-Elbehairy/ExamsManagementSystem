using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exams_Management_System
{
    public partial class Issue_Report : Form
    {
        public Issue_Report()
        {
            InitializeComponent();
        }

        private void Issue_Report_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            School.writeData();
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void createStudentCourseGrade()
        {
            Student obj = null;
            for (int i = 0; i < School.StudentList.Count; i++)
            {
                if (School.StudentList[i].UserName == userName.Text)
                {
                    obj = School.StudentList[i];
                }
            }
            Student_Course_Grade gradeObject = new Student_Course_Grade(Course.Text, obj, float.Parse(Grade.Text));
            School.GradesList.Add(gradeObject);
        }
        private void btnIssueReport_Click(object sender, EventArgs e)
        {
            bool flag1 = true;
            bool flag2 = true;
            bool found = false;
            DateTime dateObj = DateTime.Now;
            try
            {

                dateObj = new DateTime(DateTime.Now.Year, int.Parse(Month.Text), int.Parse(Day.Text));

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for month and day.");
                flag1 = false;
            }

            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please enter valid values for month and day.");
                flag2 = false;
            }

            if (flag1 && flag2)
            {
                Exam obj = new Exam(Level.Text, typeComboBox.SelectedItem.ToString(), Course.Text, dateObj);
                for (int i = 0; i < School.StudentList.Count; i++)
                {
                    if (School.StudentList[i].UserName == userName.Text)
                    {
                        found = true;
                    }
                }
                if (found)
                {
                    Report report = new Report(obj, userName.Text, float.Parse(Grade.Text));
                    School.Reports.Add(report);
                    MessageBox.Show("Reported Successfully");
                    createStudentCourseGrade();
                }
                else
                {
                    MessageBox.Show("Student Not Found!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeacherForm obj = new TeacherForm();
            this.Hide();
            obj.Show();
        }
    }
}
