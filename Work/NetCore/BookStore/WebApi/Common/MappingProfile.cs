using AutoMapper;
using WebApi.Application.AuthorOperations.Commands.CreateAuthor;
using WebApi.Application.AuthorOperations.Queries.GetAuthorDetails;
using WebApi.Application.AuthorOperations.Queries.GetAuthors;
using WebApi.Application.GenreOperations.Commands.CreateGenre;
using WebApi.Application.GenreOperations.Queries.GetGenreDetail;
using WebApi.Application.GenreOperations.Queries.GetGenres;
using WebApi.Application.Queries.BookOperriations.GetBookDetail;
using WebApi.Application.Queries.BookOperriations.GetBooks;
using WebApi.Entities;
using static WebApi.Application.Commands.BookOperriations.CreateBook.CreateBookCommand;

namespace WebApi.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateBookModel, Book>();
            CreateMap<Book, BookDetailViewModel>()
                .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.Name))
                .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Author.Name))
                .ForMember(dest => dest.AuthorSurname, opt => opt.MapFrom(src => src.Author.Surname));
            CreateMap<Book, BoooksViewModel>()
                .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.Name))
                .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Author.Name))
                .ForMember(dest => dest.AuthorSurname, opt => opt.MapFrom(src => src.Author.Surname));
            
            CreateMap<Genre, GenresViewModel>();
            CreateMap<Genre, GenreDetailViewModel>();
            CreateMap<CreateGenreModel, Genre>();
        
            CreateMap<Author, AuthorsViewModel>();
            CreateMap<Author, AuthorDetailViewModel>();
            CreateMap<CreateAuthorModel, Author>();
        }
    }
}