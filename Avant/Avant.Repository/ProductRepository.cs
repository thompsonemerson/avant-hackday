using Avant.Model;
using Avant.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avant.Repository
{
    public class ProductRepository : EFRepository<Product>, IProductRepository
    {
        public ProductRepository(DbContext context) : base(context) { }
    }
}
