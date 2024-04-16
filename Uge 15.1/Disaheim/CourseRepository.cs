using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Disaheim
{
    public class CourseRepository
    {
        Utility utility = new Utility();
        public List<Course> courses = new List<Course>();
        public void AddCourse(Course course)
        {

            courses.Add(course);
        }
        public Course GetCourse(string name)
        {
            Course course1 = null;
            foreach (Course course in courses)
            {
                if (course.Name == name)
                    course1 = course;
            }
            return course1;

        }

        public double GetTotalValue()
        {
            double value = 0;
            foreach (Course course in courses)
            {
                value += utility.GetValueOfCourse(course);
            }
            return value;
        }
    }
}