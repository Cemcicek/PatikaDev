using System;
using AutoMapper;
using FluentAssertions;
using TestSetup;
using WebApi.Application.Commands.BookOperriations.UpdateBook;
using WebApi.DBOperations;
using Xunit;

namespace WebApi.UnitTest.Application.BookOperations.Commands.UpdateBook
{
    public class UpdateBookCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public UpdateBookCommandTests(CommonTestFixture testFixture)
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;
        }

        [Fact]
        public void WhenAlreadyExistBookNotIdIsGiven_InvalidOperationException_ShouldBeReturn()
        {
            //arrange (hazırlık)
            
            UpdateBookCommand command = new UpdateBookCommand(_context);
            command.BookId = 987;
            
            // arc-assert(çalıştırma-doğrulama)
            FluentActions.Invoking(() => command.Handle())
            .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Kitap bulunamadı");


        }
    }
}