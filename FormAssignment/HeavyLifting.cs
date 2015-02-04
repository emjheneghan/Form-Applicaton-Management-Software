// Student: Emma Jane Heneghan
// Student Number: 10204278

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FormAssignment
{
    class HeavyLifting
    {
        // delcaring the file path
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + Path.DirectorySeparatorChar + "DBSDataBase.csv";

        // instancating the teacher and student lists
        static List<Student> stu = new List<Student>();
        static List<Teacher> tea = new List<Teacher>();

        // instancating the ReadWriteFile Class
        ReadWriteFile rwf = new ReadWriteFile();
        
        // the DEMO test code
        public void CreateTestPeople()
        {
            // streamwriter class is used to put labels in CSV file
            StreamWriter sw = File.AppendText(filePath);
            sw.WriteLine("Teacher,EMMA SMITH,0878956231,emma.smith@dbs.ie,,,30000,Political Science");
            sw.WriteLine("Student,TOM JONES,0861234123,tom.jone@dbs.ie,POSTGRAD,12345678");
            sw.WriteLine("Teacher,TOM JONES,0861234123,tom.jone@dbs.ie,,,30000,Computer Science");
            sw.WriteLine("Student,EMMA SMITH,0854567895,emma.smith@dbs.ie,UNDERGRAD,78945632");
            sw.Close();

            // want to write this information to the Student and Teacher Lists
            CreateLists();
        }

        // method to read CSV file to lists
        public void CreateLists()
        {
            // Open the file to read from
            string[] readText = File.ReadAllLines(filePath);

            // create a two dimensional array to hold all the information
            int numRows = readText.Length;
            int numColumns = 8;
            string[,] csvData = new string[numRows, numColumns];

            // populating the 2d array with data from csvData
            for (int i = 0; i < numRows; i++)
            {
                string[] newArray = readText[i].Split(',');
                int j = 0;
                foreach (string n in newArray)
                {
                    csvData[i, j] = n;
                    j++;
                }
            }

            for (int i = 0; i < numRows; i++)
            {
                // add info to student list
                if (csvData[i, 0] == "Student")
                {
                    // instancating the student class
                    Student testS = new Student(csvData[i, 1], csvData[i, 2], csvData[i, 3], csvData[i, 4], csvData[i, 5]);

                    // add student to the student list
                    stu.Add(testS);
                }
                // add info to teacher list
                if (csvData[i, 0] == "Teacher")
                {
                    // instancating the Teacher Class
                    Teacher testT = new Teacher(csvData[i, 1], csvData[i, 2], csvData[i, 3], csvData[i, 6], csvData[i, 7]);

                    // add Teacher to the teacher class
                    tea.Add(testT);
                }
            }
        }
           
        // method to add Student
        public void AddStudent(string name, string phone, string email, string status, string id)
        {
            // instancating the student class
            Student newS = new Student(name, phone, email, status, id);

            // add student to the student list
            stu.Add(newS);

            // write out the student information to the file
            rwf.WriteStudentToFile(name, phone, email, status, id);
        }

        // method to add Teacher
        public void AddTeacher(string name, string phone, string email, string salary, string subject)
        {
            // instancating the Teacher Class
            Teacher newT = new Teacher(name, phone, email, salary, subject);

            // add Teacher to the teacher class
            tea.Add(newT);

            // write out the teacher information to the file
            rwf.WriteTeacherToFile(name, phone, email, salary, subject);
        }

        // method to return Student List
        public List<Student> PassStudentList()
        {
            return stu;
        }

        // method to return Teacher List
        public List<Teacher> PassTeacherList()
        {
            return tea;
        }
    }
}
