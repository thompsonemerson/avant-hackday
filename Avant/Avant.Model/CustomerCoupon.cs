using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avant.Model
{
    public class CustomerCoupon
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int CouponId { get; set; }

        public virtual Coupon Coupon { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
