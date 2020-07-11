using BookStore.Data;
using BookStore.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly BookStoreDbContext context;

        public OrdersRepository(BookStoreDbContext context )
        {
            this.context = context;
        }

        public void Create(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
        }
    }
}
