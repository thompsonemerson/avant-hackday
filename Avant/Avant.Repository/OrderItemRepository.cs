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
    public class OrderItemRepository : EFRepository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(DbContext context) : base(context) { }
    }
}
