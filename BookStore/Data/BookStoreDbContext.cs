using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Data
{
    public class BookStoreDbContext :DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options)
        {

        }
            public DbSet<Book> Books { get; set; }
            public DbSet<Order> Orders { get; set; }
        public DbSet<BookOrders> BookOrders {get; set; }




    }
}
