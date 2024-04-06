using FluentValidation;
using NoteBook.ViewModels;

namespace NoteBook.Models.Validators
{
    public class LoginValidator : AbstractValidator<Login>
    {
        public LoginValidator()
        {
            RuleFor(x => x.Username)
                .NotNull().WithMessage("Username mustn't be null")
                .NotEmpty().WithMessage("Username mustn't be empty")
                .MinimumLength(4).WithMessage("Username must be at least 4 digits long");

            RuleFor(x => x.Password)
                .NotNull().WithMessage("Password mustn't be null")
                .NotEmpty().WithMessage("Password mustn't be empty")
                .MinimumLength(6).WithMessage("Password must be at least 6 digits long");
        }
    }
}