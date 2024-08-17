using System;
using System.Collections.Generic;
using System.Text;

namespace Exams_Management_System
{
    class Assignment
    {
        private int level;
        private string course;
        private int marks;

        public int Level { get => level; set => level = value; }
        public string Course { get => course; set => course = value; }
        public int Marks { get => marks; set => marks = value; }

        public Assignment(int level, string course, int marks)
        {
            this.level = level;
            this.course = course;
            this.marks = marks;
        }
    }
}
