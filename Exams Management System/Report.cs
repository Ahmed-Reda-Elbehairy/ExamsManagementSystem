using System;
using System.Collections.Generic;
using System.Text;

namespace Exams_Management_System
{
    class Report
    {
        private Exam studentExam;
        private string studentName;
        private float grade;

        public string StudentName { get => studentName; set => studentName = value; }
        public float Grade { get => grade; set => grade = value; }
        internal Exam StudentExam { get => studentExam; set => studentExam = value; }

        public Report(Exam studentExam, string studentName, float grade)
        {
            this.studentExam = studentExam;
            this.studentName = studentName;
            this.grade = grade;
        }
    }
}
