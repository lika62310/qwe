using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Tracing;

namespace Persistens
{
    public class DataHandler
    {
        public string DataFileName { get; }

        public DataHandler(string dataFileName)
        {
            DataFileName = dataFileName;
        }

        public void SavePerson(Person person)
        {
            StreamWriter sw = new StreamWriter(DataFileName);
            sw.WriteLine(person.MakeTitle());
            sw.Close();
        }

        public Person LoadPerson()
        {
            StreamReader sr = new StreamReader(DataFileName);
            string line = sr.ReadLine();
            string[] words = line.Split(';');
            Person person = new Person(words[0], DateTime.Parse(words[1]), double.Parse(words[2]), bool.Parse(words[3]), int.Parse(words[4]));
            sr.Close();
            return person;
        }

        public void SavePersons(Person[] persons)
        {
            StreamWriter sw = new StreamWriter(DataFileName);
            for (int i = 0; i < persons.Length; i++)
            {
                sw.WriteLine(persons[i].MakeTitle());
            }
            sw.Close();
        }

        public Person[] LoadPersons()
        {
            StreamReader sr = new StreamReader(DataFileName);
            string line;
            line = sr.ReadLine();
            string[] words = line.Split(';');
            Person[] persons = new Person[100];
            int i = 0;
            while (line != null)
            {
                words = line.Split(';');
                persons[i] = new Person(words[0], DateTime.Parse(words[1]), double.Parse(words[2]), bool.Parse(words[3]), int.Parse(words[4]));
                line = sr.ReadLine();
                i++;
            }
            sr.Close();
            return persons;
        }

        //public void SavePerson (Person person)
        //{
        //    string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        //    using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, DataFileName)))
        //    {
        //        outputFile.WriteLine(person.MakeTitle());
        //    }
        //    Console.WriteLine(person.MakeTitle() + "1");

        //}
    }
}
