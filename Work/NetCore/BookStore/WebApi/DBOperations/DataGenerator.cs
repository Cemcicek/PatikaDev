using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApi.Entities;

namespace  WebApi.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var contex = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
            {
                if (contex.Books.Any())
                {
                    return;
                }
                contex.Authors.AddRange
                (
                    new Author
                    {
                        Name = "Cem",
                        Surname = "Çiçek",
                        BirthDate = new System.DateTime(2000, 10, 12)
                    },
                    new Author
                    {
                        Name = "Test",
                        Surname = "Deneme",
                        BirthDate = new DateTime(2000, 7, 3)
                    }
                );

                contex.Genres.AddRange(
                    new Genre{
                        Name = "Personel Growth"
                    },
                    new Genre{
                        Name = "Science Fiction"
                    },
                    new Genre{
                        Name = "Romance"
                    }
                );

                contex.Books.AddRange(
                new Book{
                    Title = "Lean Startup",
                    GenreId = 1,
                    PageCount = 200,
                    PublishDate = new DateTime(2021,09,09),
                    AuthorId = 1
                },
                new Book{
                    Title = "Hearland",
                    GenreId = 2,
                    PageCount = 250,
                    PublishDate = new DateTime(2020,09,09),
                    AuthorId = 2
                }
                );
                
                contex.SaveChanges();
            }
        }
    }
}