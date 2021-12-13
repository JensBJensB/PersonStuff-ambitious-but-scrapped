using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonStuff.Models
{
    public class MockPersonRepository : IPersonRepository
    {
        public List<Person> AllPersons =>
            new List<Person>
    {
                new Person { Name="Duke Nukem", Phone="555-69", City="Shrapnel City"},
                new Person { Name="Illidan Stormrage", Phone="555-666", City="Black Temple"},
                new Person { Name="Doomguy", Phone="555-1337", City="<unknown>"},
    };
    }
}
