using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avant.Model
{
    public class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int CustomerId { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        public virtual Customer Customer { get; set; }
        
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
