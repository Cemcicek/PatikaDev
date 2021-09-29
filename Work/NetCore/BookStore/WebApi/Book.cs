using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi
{
    public class Book{
        public int Id { get; set; }
        public string Title { get; set; }
        public int GenreId { get; set; }
        //public Genre Genre { get; set; }
        //public int AuthorId { get; set; }
        //public Author Author { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }
    }
}