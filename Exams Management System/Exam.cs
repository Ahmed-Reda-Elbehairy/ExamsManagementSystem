using System;
using System.Collections.Generic;
using System.Text;

namespace Exams_Management_System
{
    class Exam
    {
        private String level;
        private String type;
        private String course;
        DateTime date = new DateTime();

        public string Level { get => level; set => level = value; }
        public string Type { get => type; set => type = value; }
        public string Course { get => course; set => course = value; }
        public DateTime Date { get => date; set => date = value; }

        public Exam(string level, string type, string course, DateTime date)
        {
            this.level = level;
            this.type = type;
            this.course = course;
            this.date = date;
        }
    }
}
