using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avant.Model
{
    public class Coupon
    {
        public Coupon()
        {
            CustomerCoupons = new HashSet<CustomerCoupon>();
        }

        public int Id { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(80)]
        public string Number { get; set; }

        public DateTime ExpirationDate { get; set; }

        public decimal DiscountPercentage { get; set; }
        
        public virtual ICollection<CustomerCoupon> CustomerCoupons { get; set; }
    }
}
