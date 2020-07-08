using BookStore.Data;
using BookStore.Helpers;
using BookStore.ModelDtos;
using BookStore.Repositories.Interfaces;
using BookStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public class BookService : IBookService
    {
        private readonly IBooksRepository booksRepository;

        public BookService(IBooksRepository booksRepository)
        {
            this.booksRepository = booksRepository;
        }

        public void Create(BookDto bookDto)
        {
            var book=bookDto.ToBook();
            booksRepository.Create(book);
        }

        public void Delete(int id)
        {
            var book = booksRepository.GetById(id);
            if (book != null)
            {
                booksRepository.Delete(book);
            }
        }

        public List<BookDto> GetAll()
        {
            var dbBooks = booksRepository.GetAll();
            var bookDTO = dbBooks.Select(x => x.ToBookDto()).ToList();
            return bookDTO;
        }

        public List<BookDto> GetByAuthor(string author)
        {
           var dbBooks= booksRepository.GetByAuthor(author);
            return dbBooks.Select(x => x.ToBookDto()).ToList();
            
        }

        public BookDto GetById(int id)
        {
            var book = booksRepository.GetById(id);
            return book.ToBookDto();
        }

        public void Update(BookDto bookDto)
        {
            var book = booksRepository.GetById(bookDto.Id);
            if (book != null)
            {
                book.Title = bookDto.Title;
                book.Author = bookDto.Author;
                book.Description = bookDto.Description;
                book.Price = bookDto.Price;
                book.Genre = bookDto.Genre;
                book.Quantity = bookDto.Quantity;

                booksRepository.Update(book);

            }
        }
    }
}
