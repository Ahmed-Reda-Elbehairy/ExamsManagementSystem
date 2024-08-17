using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exams_Management_System
{
    public partial class Create_Assignment_Form : Form
    {
        public Create_Assignment_Form()
        {
            InitializeComponent();
        }

        private void Create_Assignment_Form_Load(object sender, EventArgs e)
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

        private void btnCreateAssignment_Click(object sender, EventArgs e)
        {
            Assignment assignmentObject = new Assignment(int.Parse(Level.Text), Course.Text, int.Parse(Grade.Text));
            School.Assignments.Add(assignmentObject);
            MessageBox.Show("Assignment Created Successfully");
        }

        private void Create_Assignment_Form_Load_1(object sender, EventArgs e)
        {
            this.ControlBox= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeacherForm obj = new TeacherForm();
            this.Hide();
            obj.Show();
        }
    }
}

