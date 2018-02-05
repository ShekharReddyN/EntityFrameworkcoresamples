using Sample1.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample1.Core.Repositories
{
   public interface IPersonRepository : IRepository<Person>
    {
       IEnumerable<string> GetPersonNames();
    }
}
