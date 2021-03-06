﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.ModelDtos;
using BookStore.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService bookService;

        public BooksController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet]
        public IActionResult Get()  //po default e HTTPGET
        {
            var books = bookService.GetAll();

            return Ok(books);
        }

        [HttpGet]
        [Route("getByAuthor")]
        public IActionResult Get(string author)
        {
            var books = bookService.GetByAuthor(author);
            return Ok(books);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var book = bookService.GetById(id);
            return Ok(book);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Create(BookDto bookDto)
        {
            bookService.Create(bookDto);
            return Ok();
        }


        [HttpDelete]
        [Route("{id}")]
        [Authorize]

        public IActionResult Delete(int id)
        {
            bookService.Delete(id);
            return Ok();
        }

        [HttpPut]
        [Authorize]

        public IActionResult Update(BookDto bookDto)
        {
            bookService.Update(bookDto);
            return Ok();
        }
    }
}