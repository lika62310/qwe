using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {

        public double LowQualityValue { get; set; } = 12.5;
        public double MediumQualityValue { get; set; } = 20.0;
        public double HighQualityValue { get; set; } = 27.5;
        public double CourseHourValue { get; set; } = 875.0;



        //public double GetValueOfBook(Book book)
        //{
        //    return book.Price;
        //}
        //public double GetValueOfAmulet(Amulet amulet)
        //{
        //    switch (amulet.Quality)
        //    {
        //        case Level.low:
        //            return 12.5;
        //            break;
        //        case Level.medium:
        //            return 20.0;
        //            break;
        //        case Level.high:
        //            return 27.5;
        //            break;
        //    }
        //    return 1;
        //}

        public double GetValueOfMerchandise(Merchandise merchandise)
        {
            double price = 0;
            if (merchandise is Book)
            {
                Book book = (Book)merchandise;
                price = book.Price;
            }
            else if (merchandise is Amulet)
            {
                Amulet amulet = (Amulet)merchandise;
                switch (amulet.Quality)
                {
                    case Level.low:
                        price = LowQualityValue;
                        break;
                    case Level.medium:
                        price = MediumQualityValue;
                        break;
                    case Level.high:
                        price = HighQualityValue;
                        break;
                }
            }
            return price;
        }

        public double GetValueOfCourse(Course course)
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
