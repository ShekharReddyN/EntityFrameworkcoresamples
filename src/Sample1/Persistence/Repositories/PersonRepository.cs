using Microsoft.EntityFrameworkCore;
using Sample1.Core.Models;
using Sample1.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample1.Persistence.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public Adventureworks2016Context adventureworks2016Context { get { return Context as Adventureworks2016Context; } }
        public PersonRepository(Adventureworks2016Context context) : base(context)
        {
        }

        public IEnumerable<string> GetPersonNames()
        {
            return adventureworks2016Context.Person.ToList().Select(p => $"{p.FirstName} {p.MiddleName} {p.LastName}");
        }
    }
}
