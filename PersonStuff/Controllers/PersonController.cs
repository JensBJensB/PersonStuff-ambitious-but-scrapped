using Microsoft.AspNetCore.Mvc;
using PersonStuff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonStuff.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public IActionResult Index()
        {
            PeopleViewModel peopleViewModel = new PeopleViewModel();
            peopleViewModel.Persons = _personRepository.AllPersons;
            return View(peopleViewModel);
        }

        [HttpPost]
        public IActionResult Index(string SearchString)
        {
            PeopleViewModel peopleViewModel = new PeopleViewModel();
            foreach (Person p in _personRepository.AllPersons)
            {
                if (p.Name.ToLower().Contains(SearchString) || p.City.ToLower().Contains(SearchString))
                {
                    peopleViewModel.Persons.Add(p);
                }
            }
            return View(peopleViewModel);
        }
    }
}



