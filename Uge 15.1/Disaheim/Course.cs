using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course
    {
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }

        public Course(string name)
        {
            Name = name;
        }

        public Course(string name, int durationInMinutes)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
        }


        public override string ToString() 
        {
            string s = $"Name: {Name}, Duration in Minutes: {DurationInMinutes}";
            return s;
        }
    }
}
