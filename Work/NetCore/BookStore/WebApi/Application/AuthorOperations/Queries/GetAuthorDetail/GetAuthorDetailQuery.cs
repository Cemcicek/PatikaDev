using System;
using System.Linq;
using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.AuthorOperations.Queries.GetAuthorDetails
{
    public class GetAuthorDetailQuery
    {
        public int AuthorId { get; set; }
        public readonly IBookStoreDbContext _context;
        public readonly IMapper _mapper;
        public GetAuthorDetailQuery(IBookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public AuthorDetailViewModel Handle()
        {
            var author = _context.Authors.Where(x => x.Id == AuthorId).FirstOrDefault();
            if (author is null)
            {
                throw new InvalidOperationException("Yazar bulunamadı");
            }
            AuthorDetailViewModel genreDetailViewModel = _mapper.Map<AuthorDetailViewModel>(author);
            return genreDetailViewModel;
        }
    }

    public class AuthorDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public System.DateTime BirthDay { get; set; }
    }
}