using App.Infrastructure.Data;
using App.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Repositories
{
    public class NewsletterSubscriptionRepository : INewsletterSubscriptionRepository
    {
        private readonly Estado_PedidosContext _context;

        public NewsletterSubscriptionRepository(Estado_PedidosContext context)
        {
            _context = context;
        }
        public async Task CreateSubscription(NewsletterSubscriptionEntity subscription)
        {
            _context.NewsletterSubscriptions.Add(subscription);
            await _context.SaveChangesAsync();
        }
    }
}
