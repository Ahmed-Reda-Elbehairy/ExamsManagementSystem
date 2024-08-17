using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exams_Management_System
{
    public partial class Add_Student : Form
    {
        public Add_Student()
        {
            InitializeComponent();
        }
        bool isFilled()
        {
            return (userName.Text != "" && Password.Text != "" && Level.Text != "");
        }
        public bool levelIsNum(String level)
        {
            return int.TryParse(level, out int levelValue);
        }
        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            if (isFilled())
            {
                if (levelIsNum(Level.Text))
                {
                    Student student = new Student(userName.Text, Password.Text, int.Parse(Level.Text));
                    School.StudentList.Add(student);
                    MessageBox.Show("Added Successfully");
                }
                else
                {
                    MessageBox.Show("Please enter a number in the level field");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }

        private void Add_Student_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void BtnExitPrinciple_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            PrincipleForm obj = new PrincipleForm();
            this.Hide();
            obj.Show();
        }
    }
}
