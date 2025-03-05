using FluentValidation;
using libraryProject.Entities.Models;
namespace libraryProject.Business.Validators
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {

            RuleFor(a => a.Name)
          .NotEmpty().WithMessage("Yazar adı boş olamaz.")
          .MinimumLength(2).WithMessage("Yazar adı en az 2 karakter olmalıdır.")
           .Matches(@"^[a-zA-ZÇİÜĞŞÖçüğşöı.\s]+$").WithMessage("Yazar adı sadece harf içerebilir, sayı ve özel karakter içeremez.");

            RuleFor(a => a.Surname)
           .NotEmpty().WithMessage("Yazar soyadı boş olamaz.")
           .MinimumLength(2).WithMessage("Yazar soyadı en az 2 karakter olmalıdır.")
           .Matches(@"^[a-zA-ZÇİÜĞŞÖçüğşöı.\s]+$").WithMessage("Yazar soyadı sadece harf içerebilir, sayı ve özel karakter içeremez.");

            RuleFor(a => a.Biography1)
           .MaximumLength(1000).WithMessage("Biyografi 1000 karakterden uzun olamaz.");
        }
    }
}
