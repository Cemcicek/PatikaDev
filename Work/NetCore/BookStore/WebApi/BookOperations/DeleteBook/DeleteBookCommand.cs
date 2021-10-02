using System;
using System.Linq;
using WebApi.Common;
using WebApi.DBOperations;

namespace WebApi.BookOperriations.DeleteBook
{
    public class DeleteBookCommand
    {
        private readonly BookStoreDbContext _dbContex;
        public int BookId { get; set; }
        public DeleteBookCommand(BookStoreDbContext dbContext)
        {
            _dbContex = dbContext;
        }
        public void Handle()
        {
            var book = _dbContex.Books.SingleOrDefault(x => x.Id == BookId);
            if (book is null)
            {
                throw new InvalidOperationException("Silinecek Kitap Bulunamadı!");
            }
            _dbContex.Books.Remove(book);
            _dbContex.SaveChanges();
            
        }
    }
}