using System;
using System.Collections.Generic;
using System.Text;

namespace Sample1.Core.Repositories
{
   public interface IRepository<TEntity> where TEntity : class
    {
       IEnumerable<TEntity> GetAllRecords();
    }
}
