using FluentValidation;
using libraryProject.Entities.Models;

namespace libraryProject.Business.Validators
{
    public class ShelfValidator : AbstractValidator<Shelf>
    {
        public ShelfValidator()
        {
            // ShelftID boş olamaz ve geçerli bir Guid olmalı
            RuleFor(s => s.ShelftID)
                .NotEqual(Guid.Empty).WithMessage("Raf ID'si boş olamaz ve geçerli bir Guid olmalıdır.");
        }
    }
}
