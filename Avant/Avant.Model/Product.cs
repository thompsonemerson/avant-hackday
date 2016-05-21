using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avant.Model
{
    public class Product
    {
        public Product()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }

        public int Category { get; set; }

        [Required]
        [StringLength(120)]
        public string Name { get; set; }

        [StringLength(5000)]
        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal? PromitionalPrice { get; set; }

        public bool? Highlight { get; set; }

        [Required]
        [StringLength(800)]
        public string PhotoUrl { get; set; }

        public decimal Stock { get; set; }
        
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
