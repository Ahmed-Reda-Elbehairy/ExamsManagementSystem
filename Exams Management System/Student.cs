using System;
using System.Collections.Generic;
using System.Text;

namespace Exams_Management_System
{
    class Student
    {
        private String userName;
        private String password;
        private int level;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int Level { get => level; set => level = value; }

        public Student(string userName, string password, int level)
        {
            this.userName = userName;
            this.password = password;
            this.level = level;
        }
    }
}
