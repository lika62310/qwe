using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course : IValuable
    {
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }
        public double CourseHourValue { get; set; } = 875.0;

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
        public double GetValue(Course course)
        {
            if (course.DurationInMinutes % 60 == 0)
            {
                return ((course.DurationInMinutes / 60)) * CourseHourValue;
            }
            else
            {
                return ((course.DurationInMinutes / 60) + 1) * CourseHourValue;
            }
        }
    }
}
