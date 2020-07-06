using BookStore.Data;
using BookStore.ModelDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Helpers
{
    public static class ModelConverter
    {

        public static BookDto ToBookDto(this Book book)
        {
            return new BookDto
            {
                Id=book.Id,
                Title=book.Title,
                Description=book.Description,
                Author=book.Author,
                Price=book.Price,
                Quantity=book.Quantity,
                Genre=book.Genre

            };
        }

        public static Book ToBook(this BookDto book)
        {
            return new Book
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
                Author = book.Author,
                Price = book.Price,
                Quantity = book.Quantity,
                Genre = book.Genre

            };
        }
    }
}
