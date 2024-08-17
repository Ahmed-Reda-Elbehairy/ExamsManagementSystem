using System;
using System.Collections.Generic;
using System.Text;

namespace Exams_Management_System
{
    class Teacher
    {
        private String firstName;
        private String lastName;
        private float salary;
        private String subject;
        private int age;
        private String userName;
        private String password;
        
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public float Salary { get => salary; set => salary = value; }
        public string Subject { get => subject; set => subject = value; }
        public int Age { get => age; set => age = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
    }
}
