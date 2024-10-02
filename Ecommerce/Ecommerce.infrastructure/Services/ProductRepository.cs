using Ecommerce.application.Repository;
using Ecommerce.Domain;
using Ecommerce.infrastructure.Presistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.infrastructure.Services
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DBContextApplication context) : base(context)
        {
        }
    }
}
