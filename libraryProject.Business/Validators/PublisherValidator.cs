using FluentValidation;
using libraryProject.Entities.Models;

namespace libraryProject.Business.Validators
{
    internal class PublisherValidator : AbstractValidator<Publisher>
    {


        public PublisherValidator()
        {
            // PublisherName boş olamaz
            RuleFor(p => p.PublisherName)
                .NotEmpty().WithMessage("Yayınevi adı gereklidir.");

            // ContactNumber 10 haneli olmalı
            RuleFor(p => p.ContactNumber)
                .NotEmpty().WithMessage("İletişim numarası gereklidir.")
                .Matches(@"^\d{10}$").WithMessage("İletişim numarası 10 haneli olmalıdır.");

          
        }
    }
}