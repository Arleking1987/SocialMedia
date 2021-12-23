using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace App.Infrastructure.Entities
{
    public partial class NewsletterSubscriptionEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Coupon { get; set; }
        public string CouponStatus { get; set; }
    }
}
