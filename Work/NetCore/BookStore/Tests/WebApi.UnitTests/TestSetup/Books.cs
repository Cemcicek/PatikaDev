using System;
using WebApi.DBOperations;
using WebApi.Entities;

namespace TestSetup
{
    public static class Books
    {
        public static void AddBooks(this BookStoreDbContext context)
        {
            context.Books.AddRange(
            new Book{ Title = "Lean Startup", GenreId = 1, PageCount = 200, PublishDate = new DateTime(2021,09,09), AuthorId = 1 },
            new Book{ Title = "Hearland",     GenreId = 2, PageCount = 250, PublishDate = new DateTime(2020,09,09), AuthorId = 2 });
        }
    }
}