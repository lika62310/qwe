using System;
using System.Collections.Generic;
using System.Text;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels
{
    public class MainViewModel
    {
        private PersonRepository personRepo = new PersonRepository();
        public List<PersonViewModel> PersonsVM { get; set; } = new List<PersonViewModel>();

        // Implement the rest of this MainViewModel class below to 
        // establish the foundation for data binding !
        public MainViewModel()

        {
            List<Person> persons = personRepo.GetAll(); 
            foreach (Person person in persons)
            {
               // PersonViewModel PersonView = new PersonViewModel(person);
                PersonsVM.Add(new PersonViewModel(person));
            }
        }
    }
}
