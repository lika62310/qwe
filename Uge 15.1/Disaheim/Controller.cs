using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        public ValuableRepository ValuableRepo { get; set;}

        //public List<Book> Books;
        //public List<Amulet> Amulets;
        //public List<Course> Courses;

        public Controller()
        {
            //Books = new List<Book>();
            //    Amulets = new List<Amulet>();
            //    Courses = new List<Course>();
            ValuableRepo = new ValuableRepository();
        }

        public void AddToList(IValuable valuable)
        {
            ValuableRepo.AddValuable(valuable); 
        }

        ////public void AddToList(Book book)
        ////{
        ////    Books.Add(book);
        ////}

        //public void AddToList(Amulet amulet)
        //{
        //    Amulets.Add(amulet);
        //}

        //public void AddToList(Course course)
        //{
        //    Courses.Add(course);
        //}
    }
}
