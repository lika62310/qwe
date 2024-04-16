//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Disaheim
//{
//    public class Utility
//    {
//        public double GetValueOfBook(Book book)
//        {
//            return book.Price;
//        }
//        public double GetValueOfAmulet(Amulet amulet)
//        {
//            switch (amulet.Quality)
//            {
//                case Level.low:
//                    return 12.5;
//                    break;
//                case Level.medium:
//                    return 20.0;
//                    break;
//                case Level.high:
//                    return 27.5;
//                    break;
//            }
//            return 1;
//        }

//        public double GetValueOfCourse(Course course)
//        {
//            if (course.DurationInMinutes % 60 == 0)
//            {
//                return ((course.DurationInMinutes / 60)) * 875.00;
//            }
//            else
//            {
//                return ((course.DurationInMinutes / 60)+1) * 875.00;
//            }
//        }
//    }
//}
