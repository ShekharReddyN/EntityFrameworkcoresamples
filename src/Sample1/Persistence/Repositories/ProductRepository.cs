using Microsoft.EntityFrameworkCore;
using Sample1.Core.Models;
using Sample1.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample1.Persistence.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public Adventureworks2016Context adventureworks2016Context { get { return Context as Adventureworks2016Context; } }
        public ProductRepository(Adventureworks2016Context context) : base(context)
        {
        }

        public IEnumerable<string> GetProductNames()
        {
            return adventureworks2016Context.Product.ToList().Select(p => $"{p.Name}");
        }
    }
}
