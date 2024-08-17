using System;
using System.Collections.Generic;
using System.Text;

namespace Exams_Management_System
{
    class Note
    {
        private string msg;
        private string student;

        public Note(string msg, string student)
        {
            this.msg = msg;
            this.student = student;
        }

        public string Msg { get => msg; set => msg = value; }
        public string Student { get => student; set => student = value; }
    }
}
