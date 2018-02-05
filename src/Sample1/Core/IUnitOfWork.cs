using Sample1.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample1.Core
{
    interface IUnitOfWork
    {
        IProductRepository Products { get; }

        IPersonRepository Persons { get; }

        int Complete();
    }
}
