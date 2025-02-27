using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FluentValidation;
using libraryProject.Entities.Models;
namespace libraryProject.Business.Validators;


internal class BookValidator: AbstractValidator<Book>
{
    public BookValidator()
    {
        RuleFor(b => b.BookName).NotEmpty().WithMessage("Book name is required.");
        RuleFor(b => b.BookISBN).NotEmpty().WithMessage("ISBN is required.");
        RuleFor(b => b.TotalCopies).GreaterThan(0).WithMessage("Total copies must be greater than 0.");
    }
}
