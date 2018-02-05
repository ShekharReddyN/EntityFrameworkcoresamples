using Microsoft.EntityFrameworkCore;
using Sample1.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample1.Persistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;
        public Repository(DbContext context)
        {
            Context = context;
        }
        public IEnumerable<TEntity> GetAllRecords()
        {
           return Context.Set<TEntity>().ToList();
        }
    }
}
