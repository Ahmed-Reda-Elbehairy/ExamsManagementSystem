using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exams_Management_System
{
    public partial class Update_teacher_form : Form
    {
        private String oldUserName;
        private int teacherIndex = 0;
        public Update_teacher_form()
        {
            InitializeComponent();
        }
        public void setFirstName(string name)
        {
            firstName.Text = name;
        }
        public void setLastName(string name)
        {
            lastName.Text = name;
        }
        public void setUserName(string name)
        {
            userName.Text = name;
        }
        public void setSubject(String name)
        {
            Subject.Text = name;
        }

        private void Update_teacher_form_Load(object sender, EventArgs e)
        {
             oldUserName = userName.Text;


            this.ControlBox = false;
            for (int i = 0; i < School.TeacherList.Count; i++)
            {
                if (School.TeacherList[i].FirstName == firstName.Text && School.TeacherList[i].LastName == lastName.Text && School.TeacherList[i].UserName == userName.Text && School.TeacherList[i].Subject == Subject.Text)
                {
                    Salary.Text = School.TeacherList[i].Salary.ToString();
                    Age.Text = School.TeacherList[i].Age.ToString();
                    Password.Text = School.TeacherList[i].Password;
                    teacherIndex = i;
                    break;
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            School.writeData();
            Application.Exit();

        }
        public bool salaryIsNum(String salary)
        {
            return float.TryParse(salary, out float salaryValue);
        }
        public bool ageIsNum(String age)
        {
            return int.TryParse(age, out int ageValue);
        }
        public bool isFilled()
        {
          return (firstName.Text != "" && lastName.Text != "" && Age.Text != "" && Salary.Text != "" && Subject.Text != "" && userName.Text != "" && Password.Text != "");
        }
        private void updateTeacherBtn_Click(object sender, EventArgs e)
        {
            bool ageNum = ageIsNum(Age.Text);
            bool salaryNum = salaryIsNum(Salary.Text);
            bool unique = true;
            for (int i = 0; i < School.TeacherList.Count; i++)
            {
                if (School.TeacherList[i].UserName == userName.Text && oldUserName!=userName.Text)
                {
                    MessageBox.Show("User Name is already taken");
                    unique = false;

                }
            }
            if (isFilled())
            {
                if (unique)
                {
                    if (salaryNum)
                    {
                        if (ageNum)
                        {

                            School.TeacherList[teacherIndex].Salary = int.Parse(Salary.Text);
                            School.TeacherList[teacherIndex].Age = int.Parse(Age.Text);
                            School.TeacherList[teacherIndex].Password = Password.Text;
                            School.TeacherList[teacherIndex].FirstName = firstName.Text;
                            School.TeacherList[teacherIndex].LastName = lastName.Text;
                            School.TeacherList[teacherIndex].Subject = Subject.Text;
                            School.TeacherList[teacherIndex].UserName = userName.Text;
                            School.TeacherList[teacherIndex].Password = Password.Text;
                            MessageBox.Show("Updated Succefully");
                        }
                        else
                        {
                            MessageBox.Show("Please enter a number in the age field");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a number in the salary field");
                    }
                }
            }
            else 
            {
                MessageBox.Show("Please fill all the fields");
            }

        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
