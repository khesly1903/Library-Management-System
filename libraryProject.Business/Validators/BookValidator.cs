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
      .Matches(@"^(?:\d{9}[\dX]|\d{13})$").WithMessage("ISBN, 10 veya 13 haneli olmalıdır (ISBN-10 son karakter 'X' olabilir).");


        // TotalCopies 0'dan büyük olmalıdır
        RuleFor(b => b.TotalCopies)
        .GreaterThan(0).WithMessage("Toplam kopya sayısı 0'dan büyük olmalıdır.");


        // Author boş olamaz
        RuleFor(b => b.Author.Name).NotEmpty().WithMessage("Yazar adı gereklidir.");
        RuleFor(b => b.Author.Surname).NotEmpty().WithMessage("Yazar soyadı gereklidir.");

        // Shelf boş olamaz
        //RuleFor(b => b.Shelf.ShelfDescription).NotEmpty().WithMessage("Raf açıklaması gereklidir.");

        //publisher boş olamaz
        RuleFor(b => b.Publiser.PublisherName).NotEmpty().WithMessage("Yayınevi adı gereklidir.");


    }
}
