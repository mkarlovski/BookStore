using BookStore.Data;
using BookStore.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public Order GetOrder(string email,string orderCode)
        {
            return context.Orders
                .Include(x => x.BookOrders)
                    .ThenInclude(x => x.Book)
                        .FirstOrDefault(x => x.Email == email && x.OrderCode==orderCode);             
        }
    }
}
