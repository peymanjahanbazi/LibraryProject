using FluentValidation;
using LibraryApi.Models.Book;
using LibraryApi.Validations.Book;

namespace LibraryApi.Config;

public static class FluentValidationConfig
{
    public static void AddFluentValidation(this IServiceCollection services)
    {
        services.AddScoped<IValidator<AddBookViewModel>, AddBookViewModelValidator>();
    }
}