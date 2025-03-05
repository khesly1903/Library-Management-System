using FluentValidation;
using libraryProject.Entities.Models;

namespace libraryProject.Business.Validators
{
    public class PublisherValidator : AbstractValidator<Publisher>
    {


        public PublisherValidator()
        {
            // PublisherName boş olamaz
            RuleFor(p => p.PublisherName)
                .NotEmpty().WithMessage("Yayınevi adı gereklidir.")
                .Matches(@"^[a-zA-ZÇİÜĞŞÖçüğşöı\s]+$").WithMessage("Yayınevi adı sadece harf içerebilir, sayı ve özel karakter içeremez.");

            // ContactNumber 10 haneli olmalı
            RuleFor(p => p.ContactNumber)
                .NotEmpty().WithMessage("İletişim numarası gereklidir.")
                .Matches(@"^\d{10}$").WithMessage("İletişim numarası 10 haneli olmalıdır.");

            // Address boş olamaz
            RuleFor(p => p.Address)
                .NotEmpty().WithMessage("Adres bilgisi gereklidir.");
        }
    }
}