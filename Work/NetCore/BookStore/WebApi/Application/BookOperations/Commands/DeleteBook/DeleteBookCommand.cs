using System;
using System.Linq;
using WebApi.Common;
using WebApi.DBOperations;

namespace WebApi.Application.Commands.BookOperriations.DeleteBook
{
    public class DeleteBookCommand
    {
        private readonly IBookStoreDbContext _dbContex;
        public int BookId { get; set; }
        public DeleteBookCommand(IBookStoreDbContext dbContext)
        {
            _dbContex = dbContext;
        }
        public void Handle()
        {
            var book = _dbContex.Books.Where(p => p.Id == BookId).FirstOrDefault();
            if (book is null)
                throw new InvalidOperationException("Kitap bulunamadı");

            _dbContex.Books.Remove(book);
            _dbContex.SaveChanges();
            
        }
    }
}