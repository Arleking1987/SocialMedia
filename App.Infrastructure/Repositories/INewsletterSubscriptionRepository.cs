using App.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Repositories
{
   public interface INewsletterSubscriptionRepository
    {
        public Task CreateSubscription(NewsletterSubscriptionEntity subscription);
    }
}
