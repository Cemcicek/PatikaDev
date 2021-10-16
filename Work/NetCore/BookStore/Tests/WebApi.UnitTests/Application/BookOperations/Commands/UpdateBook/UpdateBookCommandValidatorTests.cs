using System;
using FluentAssertions;
using TestSetup;
using WebApi.Application.Commands.BookOperriations.UpdateBook;
using Xunit;
using static WebApi.Application.Commands.BookOperriations.UpdateBook.UpdateBookCommand;

namespace WebApi.UnitTest.Application.BookOperations.Commands.UpdateBook
{
    public class UpdateBookCommandValidatorTests : IClassFixture<CommonTestFixture>
    {

        [Theory]
        [InlineData("Lord Of The", 0, 0, 0)]
        [InlineData("Lord Of The", 0, 1, 0)]
        [InlineData("Lord Of The", 0, 0, 1)]
        [InlineData("Lord Of The", 0, 1, 1)]
        [InlineData("Lord Of The", 1, 1, 0)]
        [InlineData("Lord Of The", 1, 0, 1)]
        [InlineData("Lord Of The", 1, -1, 1)]
        [InlineData("Lord Of The", -1, -1, -1)]
        [InlineData("", 0, 0, 0)]
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErrors(string title, int pageCount, int genreId, int authorId)
        {
            //arrage
            UpdateBookCommand command = new UpdateBookCommand(null);
            command.Model = new UpdateBookModel
            {
                Title = title,
                AuthorId = pageCount,
                GenreId = genreId,
                PageCount = authorId,
                PublishDate = DateTime.Now.AddYears(-1)
            };
            //act
            UpdateBookCommandValidator validationRules = new UpdateBookCommandValidator();
            var result = validationRules.Validate(command);

            //assert
            result.Errors.Count.Should().BeGreaterThan(0);


        }
    }
}