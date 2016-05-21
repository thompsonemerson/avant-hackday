namespace Avant.Model.Teste
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Coupon")]
    public partial class Coupon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerCoupon> CustomerCoupons { get; set; }
    }
}
