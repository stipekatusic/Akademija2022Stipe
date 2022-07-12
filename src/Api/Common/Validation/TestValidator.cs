using Domain.Entites;
using FluentValidation;

namespace Api.Common.Validation
{
    public class TestValidator : AbstractValidator<Test>
    {
        public TestValidator()
        {
            RuleFor(x => x.Text)
                .NotEmpty()
                .WithMessage("Text is required");
        }
    }
}
