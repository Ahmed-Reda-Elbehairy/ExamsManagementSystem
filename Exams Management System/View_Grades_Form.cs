using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exams_Management_System
{
    public partial class View_Grades_Form : Form
    {
        public View_Grades_Form()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void extBtn_Click(object sender, EventArgs e)
        {
            School.writeData();
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            TeacherForm obj = new TeacherForm ();
            this.Hide();
            obj.Show();
        }

        private void View_Grades_Form_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            foreach (var val in School.GradesList)
            {
                gradesDataGridView.Rows.Add(val.Course, val.Student.UserName, val.Student.Level, val.Grade);
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
