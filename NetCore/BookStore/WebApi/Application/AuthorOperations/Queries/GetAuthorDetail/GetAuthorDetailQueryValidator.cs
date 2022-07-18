using FluentValidation;
using WebApi.Application.AuthorOperations.Queries.GetAuthorDetails;

namespace WebApi.Application.AuthorOperations.Queries.GetAuthorDetail
{
    public class GetAuthorDetailQueryValidator : AbstractValidator<GetAuthorDetailQuery>
    {
        public GetAuthorDetailQueryValidator()
        {
            RuleFor(p => p.AuthorId).NotEmpty().NotNull().GreaterThan(0);
        }
    }
}