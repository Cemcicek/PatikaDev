using System;
using FluentAssertions;
using TestSetup;
using WebApi.Application.Commands.BookOperriations.CreateBook;
using Xunit;
using static WebApi.Application.Commands.BookOperriations.CreateBook.CreateBookCommand;

namespace WebApi.UnitTest.Application.BookOperations.Commands.CreateBook
{
    public class CreateBookCommandValidatorTests : IClassFixture<CommonTestFixture>
    {
        [Theory]
        [InlineData("Lord of The Rings", 0, 0, 0)]
        [InlineData("Lord of The Rings", 0, 1, 1)]
        [InlineData("Lord of The Rings", 100, 0, 0)]
        [InlineData("", 0, 0, 0)]
        [InlineData("", 100, 1, 1)]
        [InlineData("", 0, 1, 1)]
        //[InlineData("Lor", 100, 1, 1)]
        [InlineData("Lord", 100, 0, 0)]
        [InlineData("Lord", 0, 1, 1)]
        [InlineData(" ", 100, 1, 1)]
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErrors(string title, int pageCount, int genreId, int authorId)
        {
            //arrage(Hazırlık)
            CreateBookCommand command = new CreateBookCommand(null, null);
            command.Model = new CreateBookModel
            {
                Title = title,
                PageCount = pageCount,
                PublishDate = DateTime.Now.Date.AddYears(-1),
                GenreId = genreId,
                AuthorId = authorId
            };
            //act(Çalıştırma)
            CreateBookCommandValidator validationRules = new CreateBookCommandValidator();
            var result = validationRules.Validate(command);

            //assert(Çalıştırma)
            result.Errors.Count.Should().BeGreaterThan(0);
        }

        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturnError()
        {
            CreateBookCommand command = new CreateBookCommand(null, null);
            command.Model = new CreateBookModel()
            {
                Title = "Lord of The Rings",
                PageCount = 100,
                PublishDate = DateTime.Now.Date,
                GenreId = 1,
                AuthorId = 1
            };

            CreateBookCommandValidator validator = new CreateBookCommandValidator();
            var result = validator.Validate(command);

            result.Errors.Count.Should().BeGreaterThan(0);
        }

        [Fact]
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnError()
        {
            CreateBookCommand command = new CreateBookCommand(null, null);
            command.Model = new CreateBookModel()
            {
                Title = "Lord of The Rings",
                PageCount = 100,
                PublishDate = DateTime.Now.Date.AddYears(-1),
                GenreId = 1,
                AuthorId = 1
            };

            CreateBookCommandValidator validator = new CreateBookCommandValidator();
            var result = validator.Validate(command);

            result.Errors.Count.Should().Equals(0);

        }
    }
}