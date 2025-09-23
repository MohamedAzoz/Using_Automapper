using APP_Using__Automapper.Contexts;
using APP_Using__Automapper.DTOs;
using APP_Using__Automapper.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace APP_Using__Automapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly AppDbContext context;

        public BookController(IMapper _mapper,AppDbContext context)
        {
            mapper = _mapper;
            this.context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var Books = context.Books.ToList();
            //if (Books.Any())
            //{
                var books = mapper.Map<IEnumerable<BookDTO>>(Books);
                return Ok(books);
            //}
            //return BadRequest();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var Book = context.Books.SingleOrDefault(x=>x.Id==id);
            //if (Books.Any())
            //{
            var book = mapper.Map<BookDTO>(Book);
                return Ok(book);
            //}
            //return BadRequest();
        }
        [HttpPost]
        public IActionResult Add(BookDTO dTO)
        {
            var book = mapper.Map<Book>(dTO);
            context.Books.Add(book);
            context.SaveChanges();
                return Ok(book);
           
        }

    }
}
