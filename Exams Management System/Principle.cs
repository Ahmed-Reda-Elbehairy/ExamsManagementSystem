using System;
using System.Collections.Generic;
using System.Text;

namespace Exams_Management_System
{
    class Principle
    {
        private String name;
        private String password;
        private static Principle thePrinciple;

        private Principle(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public static Principle createPrinciple(String name , String password)
        {
            if (thePrinciple == null)
            {
                thePrinciple = new Principle(name, password);
            }
            return thePrinciple;
        }

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
    }
}
