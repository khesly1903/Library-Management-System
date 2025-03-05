using FluentValidation;
using libraryProject.Entities.Models;
namespace libraryProject.Business.Validators;


public class BookValidator: AbstractValidator<Book>
{
    public BookValidator()
    {
        // BookName boş olamaz
        RuleFor(b => b.BookName)
            .NotEmpty().WithMessage("Kitap adı gereklidir.");

        // BookISBN boş olamaz ve 10 ya da 13 haneli olmalıdır
        RuleFor(b => b.BookISBN)
      .NotEmpty().WithMessage("ISBN gereklidir.")
      .Length(10, 13).WithMessage("ISBN 10 ya da 13 haneli olmalıdır.");


        // TotalCopies 0'dan büyük olmalıdır
        RuleFor(b => b.TotalCopies)
        .GreaterThan(0).WithMessage("Toplam kopya sayısı 0'dan büyük olmalıdır.");

        RuleFor(b => b.Author).NotEmpty().WithMessage("Kitap yazarı gereklidir");
        RuleFor(b => b.Publiser).NotEmpty().WithMessage("Kitap yayınevi gereklidir");
        RuleFor(b => b.Shelf).NotEmpty().WithMessage("Kitap rafı gereklidir");




    }
}
