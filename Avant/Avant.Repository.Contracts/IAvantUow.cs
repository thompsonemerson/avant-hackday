using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avant.Repository.Contracts
{
    public interface IAvantUow
    {
        void Commit();

        ICouponRepository Coupons { get; }

        ICustomerCouponRepository CustomerCoupons { get; }

        ICustomerRepository Customers { get; }

        IOrderItemRepository OrderItems { get; }

        IOrderRepository Orders { get; }

        IProductRepository Products { get; }
    }
}
