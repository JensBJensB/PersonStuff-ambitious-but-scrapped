using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonStuff.Models
{
    public interface IPersonRepository
    {
        List<Person> AllPersons { get; }
        //Person GetPersonById(int personId);
    }
}
