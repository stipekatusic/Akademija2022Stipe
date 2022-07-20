using Application.Common.Dtos;
using FluentValidation;

namespace Api.Common.Validation
{
    public class UserDtoValidator : AbstractValidator<UserDto>
    {
        public UserDtoValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("Ime je obavezno!");
        }
    }
}
