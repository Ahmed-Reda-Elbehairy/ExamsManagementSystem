using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exams_Management_System
{
    public partial class PrincipleForm : Form
    {
        public PrincipleForm()
        {
            InitializeComponent();

        }

        private void addTeacherBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        bool checkNum(String Text)
        {
            return (Text[0] > '0' && Text[0] < '9' && Text[1] > '0' && Text[1] < '9');
        }

        public bool salaryIsNum(String salary)
        {
            return float.TryParse(salary, out float salaryValue);
        }
        public bool ageIsNum(String age)
        {
            return int.TryParse(age, out int ageValue);
        }
        private void addTeacherToListBtn_Click(object sender, EventArgs e)
        {
            bool ageNum = ageIsNum(Age.Text);
            bool salaryNum = salaryIsNum(Salary.Text);
            bool unique = true;
            for (int i = 0; i < School.TeacherList.Count; i++)
            {
                if (School.TeacherList[i].UserName == userName.Text)
                {
                    MessageBox.Show("User Name is already taken");
                    unique = false;
                    
                }
            }
            if (isAddFilled())
            {
                if (unique)
                {
                    if (salaryNum)
                    {
                        if (ageNum)
                        {
                            TeacherBuilder Builder = new TeacherBuilder();
                            Builder.buildFirstName(Fname.Text);
                            Builder.buildLastName(Lname.Text);
                            Builder.buildAge(int.Parse(Age.Text));
                            Builder.buildSalary(float.Parse(Salary.Text));
                            Builder.buildSubject(Subject.Text);
                            Builder.buildUserName(userName.Text);
                            Builder.buildPassword(Password.Text);
                            Teacher obj = Builder.Builder();
                            School.TeacherList.Add(obj);
                            MessageBox.Show("Added Successfully");
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

        private void BtnExitPrinciple_Click(object sender, EventArgs e)
        {
            School.writeData();
            Application.Exit();
        }

        private void PrincipleForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;

        }
        public bool isAddFilled()
        {
            return (Fname.Text != "" && Lname.Text != "" && Age.Text != "" && Salary.Text != "" && Subject.Text != "" && userName.Text != "" && Password.Text != "");
        }
        public bool isShowFilled()
        {
            return (firstNameEdit.Text != "" && lastNameEdit.Text != "" && userNameEdit.Text != "" && subjectEdit.Text != "");
        }
        public bool isDeleteFilled()
        {
            return (firstNameDelete.Text != "" && lastNameDelete.Text != "" && userNameDelete.Text != "" && subjectDelete.Text != "");
        }


        private void edtTeacherBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void btnGetTeacher_Click(object sender, EventArgs e)
        {
            
            bool found = false;
            for (int i = 0; i < School.TeacherList.Count; i++)
            {
                if (School.TeacherList[i].FirstName == firstNameEdit.Text && School.TeacherList[i].LastName == lastNameEdit.Text && School.TeacherList[i].UserName == userNameEdit.Text && School.TeacherList[i].Subject == subjectEdit.Text)
                {
                    found = true;
                    break;
                }
            }
            if (isShowFilled())
            {
                if (found)
                {
                    this.Hide();
                    Update_teacher_form obj = new Update_teacher_form();
                    obj.setFirstName(firstNameEdit.Text);
                    obj.setLastName(lastNameEdit.Text);
                    obj.setUserName(userNameEdit.Text);
                    obj.setSubject(subjectEdit.Text);
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("Teacher Not Found!");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }

        private void teacherDeleteBtn_Click(object sender, EventArgs e)
        {
            bool found = false;
            for (int i = 0; i < School.TeacherList.Count; i++)
            {
                if (School.TeacherList[i].FirstName == firstNameDelete.Text && School.TeacherList[i].LastName == lastNameDelete.Text && School.TeacherList[i].UserName == userNameDelete.Text && School.TeacherList[i].Subject == subjectDelete.Text)
                {
                    found = true;
                    break;
                }
            }
            if (isDeleteFilled())
            {
                if (found)
                {
                    for (int i = 0; i < School.TeacherList.Count; i++)
                    {
                        if (School.TeacherList[i].FirstName == firstNameDelete.Text && School.TeacherList[i].LastName == lastNameDelete.Text && School.TeacherList[i].UserName == userNameDelete.Text && School.TeacherList[i].Subject == subjectDelete.Text)
                        {

                            School.TeacherList.RemoveAt(i);
                            break;
                        }
                    }
                    MessageBox.Show("Deleted Successfully");

                }
                else
                {
                    MessageBox.Show("Invalid teacher");

                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void viewTeachersBtn_Click(object sender, EventArgs e)
        {
            View_Teachers_Form obj = new View_Teachers_Form();
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

        private void viewStudentsBtn_Click(object sender, EventArgs e)
        {
            View_Students_Form obj = new View_Students_Form();
            this.Hide();
            obj.Show();
        }

        private void btnViewExams_Click(object sender, EventArgs e)
        {
            View_Exams_Form obj = new View_Exams_Form();
            this.Hide();
            obj.Show();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Student obj = new Add_Student();
            obj.Show();

        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            Create_Schedule_Form obj = new Create_Schedule_Form();
            this.Hide();
            obj.Show();
        }

        private void btnViewNotes_Click(object sender, EventArgs e)
        {
            principleNotes obj = new principleNotes();
            obj.Show();
            this.Hide();
        }
    }
}
