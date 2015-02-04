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
    class ReadWriteFile
    {
        // delcaring the file path
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + Path.DirectorySeparatorChar + "DBSDataBase.csv";

        public void CreateFile()
        {
            Console.WriteLine("\nA new DBS Person file is now being created in your My Documents folder.");
            string content = "Person Type,Name,Phone Number,Email,Status,Student ID,Salary,Subjects Taught";
            File.WriteAllText(filePath, content + Environment.NewLine);
        }

        // method to write out student to file
        public void WriteStudentToFile(string name, string phone, string email, string status, string id)
        {
            // streamwriter class is used to write to file
            StreamWriter sw = File.AppendText(filePath);
            // instanciating the student class
            Student stu = new Student(name, phone, email, status, id);
            sw.Write(stu.ToString() + Environment.NewLine);
            sw.Close();
        }

        // method to write out teacher to file
        public void WriteTeacherToFile(string name, string phone, string email, string salary, string subject)
        {
            // streamwriter class is used to write to file
            StreamWriter sw = File.AppendText(filePath);
            // instanciating the student class
            Teacher tea = new Teacher(name, phone, email, salary, subject);
            sw.Write(tea.ToString() + Environment.NewLine);
            sw.Close();
        }
    }
}
