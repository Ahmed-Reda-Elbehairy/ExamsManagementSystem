using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exams_Management_System
{
    public partial class Exam_Edit : Form
    {
        int examIdx = 0; 
        public Exam_Edit()
        {
            InitializeComponent();
        }
        public void setLevel(string level)
        {

            Level.Text = level;
        }
      
        public void setCourse(string course)
        {
            Course.Text = course;
        }
        
        private void Exam_Edit_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            for (int i = 0; i < School.ExamsList.Count; i++)
            {
                if (School.ExamsList[i].Level == Level.Text && School.ExamsList[i].Course == Course.Text)
                {
                    examIdx = i;
                    break;
                }
                
            }
            Day.Text = School.ExamsList[examIdx].Date.Day.ToString();
            Month.Text = School.ExamsList[examIdx].Date.Month.ToString();
            typeComboBox.SelectedItem = School.ExamsList[examIdx].Type;

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

        private void btnEditExam_Click(object sender, EventArgs e)
        {
            DateTime updated = new DateTime(DateTime.Now.Year, int.Parse(Month.Text), int.Parse(Day.Text));
            School.ExamsList[examIdx].Date = updated;
            School.ExamsList[examIdx].Level = Level.Text;
            School.ExamsList[examIdx].Course = Course.Text;
            School.ExamsList[examIdx].Type = typeComboBox.SelectedItem.ToString();
            MessageBox.Show("Updated Successfully");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeacherForm obj = new TeacherForm();
            this.Hide();
            obj.Show();

        }
    }
}

