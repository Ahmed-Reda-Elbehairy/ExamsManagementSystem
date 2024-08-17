using System;
using System.Collections.Generic;
using System.Text;

namespace Exams_Management_System
{
    abstract class Notification
    {
        private String msg;

        protected Notification(string msg)
        {
            this.Msg = msg;
        }

        public string Msg { get => msg; set => msg = value; }
    }
}
