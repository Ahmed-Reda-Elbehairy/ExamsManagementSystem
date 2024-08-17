using System;
using System.Collections.Generic;
using System.Text;

namespace Exams_Management_System
{
    class TimeTable
    {
        private string level;
        private List<KeyValuePair<string, string>> sunday;
        private List<KeyValuePair<string, string>> monday;
        private List<KeyValuePair<string, string>> tuesday;
        private List<KeyValuePair<string, string>> wednesday;
        private List<KeyValuePair<string, string>> thursday;

        public TimeTable(string level, List<KeyValuePair<string, string>> sunday, List<KeyValuePair<string, string>> monday, List<KeyValuePair<string, string>> tuesday, List<KeyValuePair<string, string>> wednesday, List<KeyValuePair<string, string>> thursday)
        {
            this.level = level;
            this.sunday = sunday;
            this.monday = monday;
            this.tuesday = tuesday;
            this.wednesday = wednesday;
            this.thursday = thursday;
        }

        public string Level { get => level; set => level = value; }
        public List<KeyValuePair<string, string>> Sunday { get => sunday; set => sunday = value; }
        public List<KeyValuePair<string, string>> Monday { get => monday; set => monday = value; }
        public List<KeyValuePair<string, string>> Tuesday { get => tuesday; set => tuesday = value; }
        public List<KeyValuePair<string, string>> Wednesday { get => wednesday; set => wednesday = value; }
        public List<KeyValuePair<string, string>> Thursday { get => thursday; set => thursday = value; }
    }
}
