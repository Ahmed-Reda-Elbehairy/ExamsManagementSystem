using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exams_Management_System
{
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            School.writeData();
            Application.Exit();
        }

     

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void btnCreateExam_Click(object sender, EventArgs e)
        {
            bool flag1 = true;
            bool flag2 = true;
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
                School.ExamsList.Add(obj);
                MessageBox.Show("Added Successfully");
            }

        }

        private void viewExam_Click(object sender, EventArgs e)
        {
            Exam_Edit obj = new Exam_Edit();
            obj.setCourse(courseEdit.Text);
            obj.setLevel(levelEdit.Text);
            this.Hide();
            obj.Show();
        }

        private void btnEditExam_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;

        }

        private void btnDeleteExam_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < School.ExamsList.Count; i++)
            {
                if (School.ExamsList[i].Level == levelDelete.Text && School.ExamsList[i].Course == courseDelete.Text)
                {
                    School.ExamsList.RemoveAt(i);
                    break;
                }

            }
            MessageBox.Show("Deleted Successfully");
        }

        private void btnViewGrades_Click(object sender, EventArgs e)
        {
            View_Grades_Form obj = new View_Grades_Form();
            this.Hide();
            obj.Show();
        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            Issue_Report obj = new Issue_Report();
            this.Hide();
            obj.Show();
        }

        private void btnCreateAssignment_Click(object sender, EventArgs e)
        {
            Create_Assignment_Form obj = new Create_Assignment_Form();
            this.Hide();
            obj.Show();
        }

        private void btnSendNotification_Click(object sender, EventArgs e)
        {
            Send_Notification_Form obj = new Send_Notification_Form();
            obj.Show();
            this.Hide();
        }
    }
}
