using FluentValidation;
using libraryProject.Entities.Models;

namespace libraryProject.Business.Validators
{
    internal class SubjectValidator: AbstractValidator<Subject>
    {
        public SubjectValidator()
        {
            RuleFor(s => s.SubjectName)
                .NotEmpty().WithMessage("Konu adı zorunludur.");
        }
    }
}
