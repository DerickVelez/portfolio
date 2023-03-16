﻿using Bookstore.Data.Entitites;
using Bookstore.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        
        private static BooksService _BooksService{ get; set; } = new BooksService();

        [HttpGet]
        public List<Books> Get()
        {
            return _BooksService.GetBooks();
        }

        [HttpPost]

        public Books Add(Books books)
        {
            _BooksService.Add(books);
            return books;  
        }
    }
}
