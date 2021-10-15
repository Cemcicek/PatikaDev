using System;
using System.Linq;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.AuthorOperations.Commands.UpdateAuthor
{
    public class UpdateAuthorCommand
    {
        public int AuthorId { get; set; }
        public UpdateAuthorModel Model { get; set; }
        private readonly IBookStoreDbContext _context;
        public UpdateAuthorCommand(IBookStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var author = _context.Authors.SingleOrDefault(x => x.Id == AuthorId);
            if (author is null)
            {
                throw new InvalidOperationException("Aradığınız yazar bulunamadı.");
            }

            author.Name = Model.Name.Trim() == default ? author.Name : Model.Name;
            author.Surname = Model.Surname.Trim() == default ? author.Surname : Model.Surname;
            author.BirthDate = Model.BirthDate != default ? Model.BirthDate : author.BirthDate;
            _context.SaveChanges();
        }
    }
    
    public class UpdateAuthorModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
    }
}