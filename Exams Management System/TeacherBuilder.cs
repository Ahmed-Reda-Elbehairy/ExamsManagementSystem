using System;
using System.Collections.Generic;
using System.Text;

namespace Exams_Management_System
{
    class TeacherBuilder
    {
        Teacher constructionObject = new Teacher();
       public void buildFirstName(String name) {
            constructionObject.FirstName = name;
        }
        public void buildLastName(String name)
        {
            constructionObject.LastName = name;
        }
        public void buildUserName(String name)
        {
            constructionObject.UserName = name;
        }
        public void buildPassword(String pass)
        {
            constructionObject.Password = pass;
        }
        public void buildSalary(float salary)
        {
            constructionObject.Salary = salary;
        }
        public void buildSubject(String subject)
        {
            constructionObject.Subject = subject;
        }
        public void buildAge(int age)
        {
            constructionObject.Age = age;
        }
        public Teacher Builder() {
            return constructionObject;
        }


    }
}
