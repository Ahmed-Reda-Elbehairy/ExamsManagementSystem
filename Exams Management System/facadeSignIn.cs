using System;
using System.Collections.Generic;
using System.Text;

namespace Exams_Management_System
{
    class facadeSignIn
    {


        private bool found;
        private int index;

        public bool Found { get => found; set => found = value; }
        public int Index { get => index; set => index = value; }

        public string signIn(string userName, string password)
        {
            for (int i = 0; i < School.TeacherList.Count; i++)
            {
                if (userName == School.TeacherList[i].UserName && password == School.TeacherList[i].Password)
                {
                    Found = true;
                    return  "Teacher";
                    
                }
            }
            if (userName == School.ThePrinciple.Name && password == School.ThePrinciple.Password)
            {
               
                Found = true;
                return "Principle";
               

            }
            for (int i = 0; i < School.StudentList.Count; i++)
            {
                if (userName == School.StudentList[i].UserName && password == School.StudentList[i].Password)
                {
                    index = i;
                    Found = true;
                    return  "Student";
                    
                }
            }


            return "NotFound";
            
        }

        public void goToForm(string userName,string password) 
        {
            string type = signIn(userName, password);
            if (type == "Teacher")
            {
                TeacherForm obj = new TeacherForm();
                obj.Show();
            }
            else if (type == "Principle")
            {
                PrincipleForm obj = new PrincipleForm();
                obj.Show();
            }
            else if (type == "Student")
            {

                Student_Form obj = new Student_Form();
                obj.Index = Index; 
                obj.Show();
            }
            else
            {
                Found = false;
            }
        }
    }
}
