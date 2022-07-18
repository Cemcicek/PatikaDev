using System;
using WebApi.DBOperations;
using WebApi.Entities;

namespace TestSetup
{
    public static class Authors
    {
        public static void AddAuthors(this BookStoreDbContext context)
        {
            context.Authors.AddRange(
            new Author{ Name = "Cem", Surname = "Çiçek", BirthDate = new System.DateTime(2000, 10, 12) },
            new Author{ Name = "Test", Surname = "Deneme", BirthDate = new DateTime(2000, 7, 3) });
        }
    }
}