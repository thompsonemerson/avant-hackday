namespace Avant.Model.Teste
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerCoupon")]
    public partial class CustomerCoupon
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int CouponId { get; set; }

        public virtual Coupon Coupon { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
