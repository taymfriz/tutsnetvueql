using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using GoodBooks.Services;
using GoodBooks.Data.Models;
using GoodBooks.Web.RequestModels;

namespace GoodBooks.Web.Controllers
{
    [ApiController]
    // [Route("/api")]
    public class GoodBooksController : ControllerBase
    {

        private readonly ILogger<GoodBooksController> _logger;
        private readonly IBookService _bookService;

        public GoodBooksController(ILogger<GoodBooksController> logger, IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        [HttpGet("/api/books")]
        public ActionResult GetBooks() {
            var b = _bookService.GetAllBooks();
            return Ok(b);
        }

        [HttpGet("/api/book/{id}")]
        public ActionResult GetBook(int id) {
            var b = _bookService.GetBook(id);
            return Ok(b);
        }

        [HttpDelete("/api/book/{id}")]
        public ActionResult DeleteBook(int id) {
            _bookService.DeleteBook(id);
            return Ok();
        }


        [HttpPost("/api/book")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult CreateBook([FromBody] RequestBook rbook){
            var now = DateTime.UtcNow;
            var book = new Book {
                Author = rbook.Author,
                Title = rbook.Title,
                CreatedOn = now,
                UpdatedOn = now,
            };

            _bookService.AddBook(book); 
            // return Ok();
            return CreatedAtAction(nameof(CreateBook), new { id = 2 });
        }
    }
}
