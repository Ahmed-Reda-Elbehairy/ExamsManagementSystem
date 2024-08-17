using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exams_Management_System
{
    public partial class View_Teachers_Form : Form
    {
        public View_Teachers_Form()
        {
            InitializeComponent();
        }

        private void View_Teachers_Form_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            foreach (var val in School.TeacherList)
            {
                teachersDataGridView.Rows.Add(val.FirstName,val.LastName,val.Salary,val.Subject,val.Age,val.UserName,val.Password);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            School.writeData();
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PrincipleForm obj = new PrincipleForm();
            this.Hide();
            obj.Show();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void teachersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
