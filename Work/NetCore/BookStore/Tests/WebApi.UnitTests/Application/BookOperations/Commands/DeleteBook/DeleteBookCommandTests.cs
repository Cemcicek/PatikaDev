using System;
using System.Linq;
using AutoMapper;
using FluentAssertions;
using TestSetup;
using WebApi.Application.Commands.BookOperriations.DeleteBook;
using WebApi.DBOperations;
using Xunit;

namespace Application.BookOperations.Commands.DeleteBook
{
    public class DeleteBookCommandTest : IClassFixture<CommonTestFixture>
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public DeleteBookCommandTest(CommonTestFixture testFixture)
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;
        }

        [Theory]
        [InlineData(Int32.MaxValue)]
        [InlineData(Int32.MaxValue - 1)]
        [InlineData(Int32.MaxValue - 2)]
        public void WhenNotExistBookIdIsGiven_InvalidOperationException_ShouldBeReturn(int id)
        {
            // arrange(hazırlık)
            var command = new DeleteBookCommand(_context);
            command.BookId = id;
            
            // arc-assert(çalıştırma-doğrulama)
            FluentActions.Invoking(() => command.Handle())
            .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Kitap bulunamadı");
        }
    }
}