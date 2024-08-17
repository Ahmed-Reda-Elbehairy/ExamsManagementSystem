using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exams_Management_System
{
    public partial class Student_Form : Form
    {
        private int index;

        public int Index { get => index; set => index = value; }

        public Student_Form()
        {
            InitializeComponent();
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

        private void Student_Form_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            examsDataGridView.Visible = false;
            gradesDataGridView.Visible = false;
            assignmentDataGridView.Visible = false;
        }

        private void btnShowExams_Click(object sender, EventArgs e)
        {
            gradesDataGridView.Visible = false;
            examsDataGridView.Visible = true;
            assignmentDataGridView.Visible = false;

            for (int i = 0; i < School.ExamsList.Count; i++)
            {
                if (int.Parse(School.ExamsList[i].Level) == School.StudentList[Index].Level)
                {

                    string formattedDate = School.ExamsList[i].Date.ToString("dd-MM-yyyy");
                    examsDataGridView.Rows.Add(School.ExamsList[i].Course, School.ExamsList[i].Type, formattedDate);

                }
            }
        }

        private void btnShowGrades_Click(object sender, EventArgs e)
        {
            examsDataGridView.Visible = false;
            gradesDataGridView.Visible = true;
            assignmentDataGridView.Visible = false;
            for (int i = 0; i < School.Reports.Count; i++)
            {
                if (School.Reports[i].StudentName == School.StudentList[Index].UserName)
                {
                    string formattedDate = School.Reports[i].StudentExam.Date.ToString("dd-MM-yyyy");
                    gradesDataGridView.Rows.Add(School.Reports[i].Grade, School.Reports[i].StudentExam.Type, formattedDate);
                }
            }

        }

        private void btnWriteNote_Click(object sender, EventArgs e)
        {
            Note_Form obj = new Note_Form();
            this.Hide();
            obj.Name1 = School.StudentList[Index].UserName;
            obj.Show();

        }

        private void btnShowAssignments_Click(object sender, EventArgs e)
        {
            assignmentDataGridView.Visible = true;
            examsDataGridView.Visible = false;
            gradesDataGridView.Visible = false;
            for (int i = 0; i < School.Assignments.Count; i++)
            {
                if (School.Assignments[i].Level == School.StudentList[Index].Level)
                {


                    assignmentDataGridView.Rows.Add(School.Assignments[i].Course, School.Assignments[i].Marks);

                }
            }
        }
    }
}
