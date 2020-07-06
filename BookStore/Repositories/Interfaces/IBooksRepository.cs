using BookStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repositories.Interfaces
{
    public interface IBooksRepository
    {
        List<Book> GetAll();
        void Create(Book book);
        Book GetById(int id);
        List<Book> GetByAuthor(string author);
        void Delete(Book book);
    }
}
