using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exams_Management_System
{
    public partial class View_Students_Form : Form
    {
        public View_Students_Form()
        {
            InitializeComponent();
        }

        private void View_Students_Form_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            foreach (var val in School.StudentList)
            {
                studentsDataGridView.Rows.Add(val.UserName, val.Password, val.Level);
            }
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
    }
}

