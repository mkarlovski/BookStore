using BookStore.Data;
using BookStore.ModelDtos;
using BookStore.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services.Interfaces
{
    public interface IBookService
    {
        List<BookDto> GetAll();
        void Create(BookDto bookDto);
        List<BookDto> GetByAuthor(string author);
        void Delete(int id);
        void Update(BookDto bookDto);
    }
}
