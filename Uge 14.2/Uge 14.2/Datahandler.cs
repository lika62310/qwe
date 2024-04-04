using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Tracing;

namespace Uge_14._2
{
    public class DataHandler
    {
        public string DataFileName { get; }

        public DataHandler(string dataFileName)
        {
            DataFileName = dataFileName;
        }

        public void SavePerson(Student student)
        {
            StreamWriter sw = new StreamWriter(DataFileName);
            sw.WriteLine(student.MakeTitle());
            sw.Close();
        }

        public Student LoadStudent()
        {
            StreamReader sr = new StreamReader(DataFileName);
            string line = sr.ReadLine();
            string[] words = line.Split(';');
            Student student = new Student(words[0], int.Parse(words[2]));
            sr.Close();
            return student;
        }

        public void SaveStudents(Student[] students)
        {
            StreamWriter sw = new StreamWriter(DataFileName);
            for (int i = 0; i < 84; i++)
            {
                sw.WriteLine(students[i].MakeTitle());
            }
            sw.Close();
        }

        public Student[] ReadStudents()
        {
            Student[] students = new Student[100];
            string line;
            try
            {
                StreamReader sr = new StreamReader(DataFileName);
                line = sr.ReadLine();
                int i = 0;

                while (line != null)
                {
                    string[] parts = line.Split(',');
                    string fullName = parts[0];
                    int groupNumber = int.Parse(parts[1]);
                    students[i] = new Student(fullName, groupNumber);
                    line = sr.ReadLine();
                    i++;
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fejl!" + ex.Message);
            }
            return students;
        }

        public Student[] LoadStudents()
        {
            StreamReader sr = new StreamReader(DataFileName);
            string line;
            line = sr.ReadLine();
            string[] words = line.Split(',');
            Student[] students = new Student[100];
            int i = 1;
            while (line != null)
            {
                words = line.Split(',');
                students[i - 1] = new Student(words[0], int.Parse(words[1]));
                line = sr.ReadLine();
                i++;
            }
            sr.Close();
            return students;

        }

    }
}
