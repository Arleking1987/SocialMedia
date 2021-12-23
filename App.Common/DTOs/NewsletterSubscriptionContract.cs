using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace App.Common.DTOs
{
    public class NewsletterSubscriptionContract
    {
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }
        public string Coupon { get; set; }
        public string CouponStatus { get; set; }
    }
}
