using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avant.Model
{
    public class Customer
    {
        public Customer()
        {
            CustomerCoupons = new HashSet<CustomerCoupon>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        [StringLength(250)]
        public string Email { get; set; }

        [Required]
        [StringLength(500)]
        public string Address { get; set; }

        [Required]
        [StringLength(80)]
        public string Password { get; set; }
        
        public virtual ICollection<CustomerCoupon> CustomerCoupons { get; set; }
        
        public virtual ICollection<Order> Orders { get; set; }
    }
}
