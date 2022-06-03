using FluentValidation;
using LibraryApi.Models.Book;

namespace LibraryApi.Validations.Book
{
    public class AddBookViewModelValidator : AbstractValidator<AddBookViewModel>
    {
        public AddBookViewModelValidator()
        {
            RuleFor(p => p.Title).NotEmpty().NotNull()
                .WithMessage("Title could not be empty")
                .MaximumLength(50).WithMessage("Max allowd length is 50");

            RuleFor(p => p.Description)
                .MaximumLength(150).WithMessage("Max allowd length is 150");
        }
    }
}