using Sample1.Core;
using Sample1.Core.Repositories;
using Sample1.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample1.Persistence
{
    public class UnitOfWork : IUnitOfWork ,IDisposable
    {
        private readonly Adventureworks2016Context _context;
        public UnitOfWork(Adventureworks2016Context  context)
        {
            _context = context;
            Products = new ProductRepository(_context);
            Persons = new PersonRepository(_context);
        }
        public IProductRepository Products { get; private set; }

        public IPersonRepository Persons { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
