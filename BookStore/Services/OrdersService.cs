using BookStore.Data;
using BookStore.ModelDtos;
using BookStore.Repositories.Interfaces;
using BookStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly IOrdersRepository ordersRepository;
        private readonly IBookService bookService;

        public OrdersService(IOrdersRepository ordersRepository, IBookService bookService )
        {
            this.ordersRepository = ordersRepository;
            this.bookService = bookService;
        }

        public void Create(CreateOrderDto createOrderDto)
        {

            var books = bookService.GetByIds(createOrderDto.BookIds);

            var newOrder = new Order()
            {
                Name = createOrderDto.Name,
                Address = createOrderDto.Address,
                Email = createOrderDto.Email,
                Phone = createOrderDto.Phone,
                BookOrders = createOrderDto.BookIds.Select(x => new BookOrders {
                    BookId=x
                }).ToList(),
                FullPrice=books.Sum(x=>x.Price),
                OrderCode="TestCode"
            };

            ordersRepository.Create(newOrder);
        }
    }
}
