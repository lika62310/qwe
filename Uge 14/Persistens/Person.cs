using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistens
{
    public class Person
    {
        public string Name { get; set; }
        public new DateTime BirthDate { get; set; }
        public double Height { get; set; }
        public bool IsMarried { get; set; }
        public int NoOfChildren {  get; set; }

        public Person(string name, DateTime birthDate, double height, bool isMarried, int noOfChilden) 
        { 
            Name = name;
            BirthDate = birthDate;
            Height = height;
            IsMarried = isMarried;
            NoOfChildren = noOfChilden;
        }

        //Overloaded constructor
        public Person(string name, DateTime birthDate, double height, bool isMarried, 0
        {

        }
        public string MakeTitle()
        {
            string str = $"{Name};{BirthDate};{Height};{IsMarried};{NoOfChildren}";
            return str;
        }
    }
}
