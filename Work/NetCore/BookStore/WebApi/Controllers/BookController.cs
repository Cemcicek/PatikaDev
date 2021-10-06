using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using WebApi.BookOperriations.CreateBook;
using WebApi.BookOperriations.DeleteBook;
using WebApi.BookOperriations.GetBookDetail;
using WebApi.BookOperriations.GetBooks;
using WebApi.BookOperriations.UpdateBook;
using WebApi.DBOperations;
using static WebApi.BookOperriations.CreateBook.CreateBookCommand;
using static WebApi.BookOperriations.UpdateBook.UpdateBookCommand;
using FluentValidation;

namespace WebApi.AddControllers
{
    [ApiController]
    [Route("[controller]s")]
    public class BookController : ControllerBase
    {
        private readonly BookStoreDbContext _contex;
        private readonly IMapper _mapper;
        public BookController(BookStoreDbContext context, IMapper mapper)
        {
            _contex = context;
            _mapper = mapper;
        }
        
        [HttpGet]
        public IActionResult GetBooks()
        {
            GetBooksQuery query = new GetBooksQuery(_contex, _mapper);
            var result = query.Handle();
            
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            BookDetailViewModel result;
            GetBookDetailQuery query = new GetBookDetailQuery(_contex, _mapper);
            query.BookId = id;

            GetBookDetailQueryValidator validator = new GetBookDetailQueryValidator();
            validator.ValidateAndThrow(query);
            result = query.Handle();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddBook([FromBody] CreateBookModel newBook)
        {
            CreateBookCommand command = new CreateBookCommand(_contex, _mapper);
            command.Model = newBook;
            CreateBookCommandValidator validator = new CreateBookCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();

            // }
            // catch (Exception ex)
            // {
                
            //     return BadRequest(ex.Message);
            // }
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, [FromBody] UpdateBookModel updatedBook)
        {
            
            UpdateBookCommand command = new UpdateBookCommand(_contex);
            command.BookId = id;
            command.Model = updatedBook;

            UpdateBookCommandValidator validator = new UpdateBookCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            DeleteBookCommand command = new DeleteBookCommand(_contex);
            
            DeleteBookCommandValidator validator = new DeleteBookCommandValidator();
            validator.ValidateAndThrow(command);

            command.BookId = id;
            command.Handle();

            return Ok();
        }
    }
}