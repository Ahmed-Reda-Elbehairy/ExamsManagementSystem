using System;
using System.Collections.Generic;
using System.Text;

namespace Exams_Management_System
{
    class Student_Course_Grade
    {
        private string course;
        private Student student;
        private float grade;

      

        public Student_Course_Grade(string course, Student student, float grade)
        {
            this.course = course;
            this.student = student;
            this.grade = grade;
        }
        public string Course { get => course; set => course = value; }
        public float Grade { get => grade; set => grade = value; }
        internal Student Student { get => student; set => student = value; }
    }

}
