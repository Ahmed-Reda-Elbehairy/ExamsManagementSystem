using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exams_Management_System
{
    public partial class View_Exams_Form : Form
    {
        public View_Exams_Form()
        {
            InitializeComponent();
        }

        private void extBtn_Click(object sender, EventArgs e)
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            PrincipleForm obj = new PrincipleForm();
            this.Hide();
            obj.Show();
        }

        private void View_Exams_Form_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            foreach (var val in School.ExamsList)
            {
                viewExamsGridView.Rows.Add(val.Level, val.Type, val.Course, val.Date.Day, val.Date.Month, val.Date.Year);
            }
        }
    }
}
