using AutoMapper;
using WebApi.DBOperations;
using System.Collections.Generic;
using System.Linq;
using WebApi.Entities;

namespace WebApi.Application.AuthorOperations.Queries.GetAuthors
{
    public class GetAuthorsQuery
    {
        public readonly BookStoreDbContext _context;
        public readonly IMapper _mapper;
        public GetAuthorsQuery(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<AuthorsViewModel> Handle()
        {
            var authors = _context.Authors.OrderBy(x => x.Id).ToList<Author>();
            List<AuthorsViewModel> returnObj = _mapper.Map<List<AuthorsViewModel>>(authors);
            return returnObj;
        }
    }
    public class AuthorsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public System.DateTime BirthDate { get; set; }
    }
}