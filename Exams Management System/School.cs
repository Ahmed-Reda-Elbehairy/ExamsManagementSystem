using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Exams_Management_System
{
    class School
    {
        private static Principle thePrinciple;
        private static List<Teacher> teacherList = new List<Teacher>();
        private static List<Student> studentList = new List<Student>();
        private static List<Exam> examsList = new List<Exam>();
        private static List<TimeTable> tablesList = new List<TimeTable>();
        private static List<Student_Course_Grade> gradesList = new List<Student_Course_Grade>();
        private static List<Report> reports = new List<Report>();
        private static List<Assignment> assignments = new List<Assignment>();
        private static List<Notification> notificationsList = new List<Notification>();
        private static List<Note> Notes = new List<Note>();
        internal static Principle ThePrinciple { get => thePrinciple; set => thePrinciple = value; }
        internal static List<Teacher> TeacherList { get => teacherList; set => teacherList = value; }
        internal static List<Student> StudentList { get => studentList; set => studentList = value; }
        internal static List<Exam> ExamsList { get => examsList; set => examsList = value; }
        internal static List<TimeTable> TablesList { get => tablesList; set => tablesList = value; }
        internal static List<Student_Course_Grade> GradesList { get => gradesList; set => gradesList = value; }
        internal static List<Report> Reports { get => reports; set => reports = value; }
        internal static List<Assignment> Assignments { get => assignments; set => assignments = value; }
        internal static List<Notification> NotificationsList { get => notificationsList; set => notificationsList = value; }
        internal static List<Note> Notes1 { get => Notes; set => Notes = value; }

        private static string WorkingDirectory = Environment.CurrentDirectory;
        private static string ProjectDirectory = Directory.GetParent(WorkingDirectory).Parent.Parent.FullName;

        public static void readData()
        {

            StreamReader principleReader = new StreamReader(ProjectDirectory + @"\Principle.txt");
            string principleLine = principleReader.ReadLine();

            while (principleLine != null)
            {

                string[] SplitData = principleLine.Split('-');
                thePrinciple = Principle.createPrinciple(SplitData[0], SplitData[1]);
                School.ThePrinciple = thePrinciple;
                principleLine = principleReader.ReadLine();
            }

            principleReader.Close();

            StreamReader teacherReader = new StreamReader(ProjectDirectory + @"\Teachers.txt");
            string teacherLine = teacherReader.ReadLine();
            while (teacherLine != null)
            {

                string[] SplitData = teacherLine.Split('-');
                TeacherBuilder Builder = new TeacherBuilder();
                Builder.buildFirstName(SplitData[0]);
                Builder.buildLastName(SplitData[1]);
                Builder.buildAge(int.Parse(SplitData[2]));
                Builder.buildSalary(float.Parse(SplitData[3]));
                Builder.buildSubject(SplitData[4]);
                Builder.buildUserName(SplitData[5]);
                Builder.buildPassword(SplitData[6]);
                Teacher obj = Builder.Builder();
                School.TeacherList.Add(obj);

                teacherLine = teacherReader.ReadLine();
            }

            teacherReader.Close();
            StreamReader studentReader = new StreamReader(ProjectDirectory + @"\Students.txt");
            string studentLine = studentReader.ReadLine();

            while (studentLine != null)
            {

                string[] SplitData = studentLine.Split('-');
                Student student = new Student(SplitData[0], SplitData[1], int.Parse(SplitData[2]));
                School.StudentList.Add(student);
                studentLine = studentReader.ReadLine();
            }

            studentReader.Close();
            StreamReader examsReader = new StreamReader(ProjectDirectory + @"\Exams.txt");
            string examsLine = examsReader.ReadLine();

            while (examsLine != null)
            {

                string[] SplitData = examsLine.Split('-');
                int day = int.Parse(SplitData[3]);
                int month = int.Parse(SplitData[4]);
                int year = int.Parse(SplitData[5]);
                DateTime date = new DateTime(year, month, day);

                Exam exam = new Exam(SplitData[0], SplitData[1], SplitData[2], date);
                School.ExamsList.Add(exam);
                examsLine = examsReader.ReadLine();
            }

            examsReader.Close();

            StreamReader gradesReader = new StreamReader(ProjectDirectory + @"\studentCourseGrade.txt");
            string gradesLine = gradesReader.ReadLine();

            while (gradesLine != null)
            {

                string[] SplitData = gradesLine.Split('-');

                Student obj = new Student(SplitData[1],SplitData[2],int.Parse(SplitData[3]));
                Student_Course_Grade gradeObj = new Student_Course_Grade(SplitData[0], obj, float.Parse(SplitData[4]));
                School.GradesList.Add(gradeObj);
                gradesLine = gradesReader.ReadLine();
            }

            gradesReader.Close();

            StreamReader reportsReader = new StreamReader(ProjectDirectory + @"\Reports.txt");
            string reportsLine = reportsReader.ReadLine();

            while (reportsLine != null)
            {

                string[] SplitData = reportsLine.Split('-');
                DateTime obj = new DateTime(int.Parse(SplitData[5]), int.Parse(SplitData[4]), int.Parse(SplitData[3]));
                Exam examObj = new Exam(SplitData[0], SplitData[1], SplitData[3],obj);
                Report newReport = new Report(examObj, SplitData[6], float.Parse(SplitData[7]));
                School.Reports.Add(newReport);
                reportsLine = reportsReader.ReadLine();
            }

            reportsReader.Close();

            StreamReader assReader = new StreamReader(ProjectDirectory + @"\Assignments.txt");
            string assLine = assReader.ReadLine();

            while (assLine != null)
            {

                string[] SplitData = assLine.Split('-');
                Assignment assObj = new Assignment(int.Parse(SplitData[0]), SplitData[1], int.Parse(SplitData[2]));
                School.Assignments.Add(assObj);
                assLine = assReader.ReadLine();
            }

            assReader.Close();

            StreamReader notReader = new StreamReader(ProjectDirectory + @"\Notifications.txt");
            string notLine = notReader.ReadLine();

            while (notLine != null)
            {

                Notification not = new SMSNotification(notLine);
                School.NotificationsList.Add(not);
                notLine = notReader.ReadLine();
            }

            notReader.Close();

            StreamReader notesReader = new StreamReader(ProjectDirectory + @"\Notes.txt");
            string notesLine = notesReader.ReadLine();

            while (notesLine != null)
            {

                string[] SplitData = notesLine.Split('-');
                Note obj = new Note(SplitData[0], SplitData[1]);
                School.Notes1.Add(obj);
                notesLine = notesReader.ReadLine();
            }

            notesReader.Close();
        }


        public static void writeData()
        {

            StreamWriter PrincipleWriter = new StreamWriter(ProjectDirectory + @"\Principle.txt");
            PrincipleWriter.Flush();
            PrincipleWriter.WriteLine(School.ThePrinciple.Name + '-' + School.ThePrinciple.Password);
            PrincipleWriter.Close();

            StreamWriter TeachersWriter = new StreamWriter(ProjectDirectory + @"\Teachers.txt");
            TeachersWriter.Flush();
            for (int i = 0; i < School.TeacherList.Count; i++)
            {
                TeachersWriter.WriteLine(School.TeacherList[i].FirstName + '-' + School.TeacherList[i].LastName + '-' + School.TeacherList[i].Age.ToString() + '-' + School.TeacherList[i].Salary.ToString() + '-' + School.TeacherList[i].Subject + '-' + School.TeacherList[i].UserName + '-' + School.TeacherList[i].Password);
            }
            TeachersWriter.Close();

            StreamWriter StudentWriter = new StreamWriter(ProjectDirectory + @"\Students.txt");
            StudentWriter.Flush();
            for (int i = 0; i < School.StudentList.Count; i++)
            {
                StudentWriter.WriteLine(School.StudentList[i].UserName + '-' + School.StudentList[i].Password + '-' + School.StudentList[i].Level.ToString());
            }
            StudentWriter.Close();

            StreamWriter ExamsWriter = new StreamWriter(ProjectDirectory + @"\Exams.txt");
            ExamsWriter.Flush();
            for (int i = 0; i < School.ExamsList.Count; i++)
            {

                ExamsWriter.WriteLine(School.ExamsList[i].Level + '-' + School.ExamsList[i].Type + '-' + School.ExamsList[i].Course + '-' + School.ExamsList[i].Date.Day + '-' + School.ExamsList[i].Date.Month + '-' + School.ExamsList[i].Date.Year);
            }
            ExamsWriter.Close();

            StreamWriter TablesWriter = new StreamWriter(ProjectDirectory + @"\Tables.txt");
            TablesWriter.Flush();
            for (int i = 0; i < School.tablesList.Count; i++)
            {
                TablesWriter.WriteLine(School.tablesList[i].Level + '-' );
                foreach (var val in School.tablesList[i].Sunday)
                {
                    TablesWriter.Write(val.Key + '-' + val.Value + '-');

                }
                TablesWriter.WriteLine();
                foreach (var val in School.tablesList[i].Monday)
                {
                    TablesWriter.Write(val.Key + '-' + val.Value + '-');

                }
                TablesWriter.WriteLine();
                foreach (var val in School.tablesList[i].Tuesday)
                {
                    TablesWriter.Write(val.Key + '-' + val.Value + '-');

                }
                TablesWriter.WriteLine();
                foreach (var val in School.tablesList[i].Wednesday)
                {
                    TablesWriter.Write(val.Key + '-' + val.Value + '-');

                }
                TablesWriter.WriteLine();
                foreach (var val in School.tablesList[i].Thursday)
                {
                    TablesWriter.Write(val.Key + '-' + val.Value);

                }
              
            }
            TablesWriter.Close();

            StreamWriter gradesWriter = new StreamWriter(ProjectDirectory + @"\studentCourseGrade.txt");
            gradesWriter.Flush();
            for (int i = 0; i < School.GradesList.Count; i++)
            {
                gradesWriter.WriteLine(School.GradesList[i].Course + '-' + School.GradesList[i].Student.UserName + '-' + School.GradesList[i].Student.Password + '-' + School.GradesList[i].Student.Level + '-' + School.GradesList[i].Grade.ToString());
            }
            gradesWriter.Close();

            StreamWriter reportsWriter = new StreamWriter(ProjectDirectory + @"\Reports.txt");
            reportsWriter.Flush();
            for (int i = 0; i < School.Reports.Count; i++)
            {
                reportsWriter.WriteLine(School.Reports[i].StudentExam.Level + '-' + School.Reports[i].StudentExam.Type + '-' + School.Reports[i].StudentExam.Course + '-' + School.Reports[i].StudentExam.Date.Day + '-' + School.Reports[i].StudentExam.Date.Month + '-' + School.Reports[i].StudentExam.Date.Year + '-' + School.Reports[i].StudentName + '-' + School.Reports[i].Grade.ToString());
            }
            reportsWriter.Close();


            StreamWriter assWriter = new StreamWriter(ProjectDirectory + @"\Assignments.txt");
            assWriter.Flush();
            for (int i = 0; i < School.Assignments.Count; i++)
            {
                assWriter.WriteLine(School.Assignments[i].Level.ToString()+'-'+ School.Assignments[i].Course + '-' + School.Assignments[i].Marks.ToString());
            }
            assWriter.Close();

            StreamWriter notWriter = new StreamWriter(ProjectDirectory + @"\Notifications.txt");
            notWriter.Flush();
            for (int i = 0; i < School.NotificationsList.Count; i++)
            {
                notWriter.WriteLine(School.NotificationsList[i].Msg);
            }
            notWriter.Close();

            StreamWriter notesWriter = new StreamWriter(ProjectDirectory + @"\Notes.txt");
            notesWriter.Flush();
            for (int i = 0; i < School.Notes1.Count; i++)
            {
                notesWriter.WriteLine(School.Notes1[i].Msg + '-' + School.Notes1[i].Student);
            }
            notesWriter.Close();
        }
    }
}

