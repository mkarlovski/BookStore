using BookStore.ModelDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services.Interfaces
{
    public interface IOrdersService
    {
        CreateOrderResponse Create(CreateOrderDto order);
        ViewOrderDto GetOrder(string email, string orderCode);
    }
}
