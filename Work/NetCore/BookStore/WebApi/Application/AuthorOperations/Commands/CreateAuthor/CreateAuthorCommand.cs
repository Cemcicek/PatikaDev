using System;
using System.Linq;
using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.AuthorOperations.Commands.CreateAuthor
{
    public class CreateAuthorCommand
    {
        public CreateAuthorModel Model { get; set; }
        private readonly IMapper _mapper;
        private readonly BookStoreDbContext _context;

        public CreateAuthorCommand(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Handle()
        {
            var author = _context.Authors.SingleOrDefault(x => x.Name == Model.Name && x.Surname == Model.Surname);

            if (author is not null)
                throw new InvalidOperationException("Yazar zaten mevcut!");

            Author newAuthor = _mapper.Map<Author>(Model);
            _context.Authors.Add(newAuthor);
            _context.SaveChanges();
        }

    }

    public class CreateAuthorModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
    }
}