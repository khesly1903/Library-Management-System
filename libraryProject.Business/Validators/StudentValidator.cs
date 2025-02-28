using FluentValidation;
using libraryProject.Entities.Models;


namespace libraryProject.Business.Validators
{
    internal class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            
            RuleFor(s => s.StudentName)
              .NotEmpty().WithMessage("Öğrenci adı zorunludur.")
              .Matches(@"^[a-zA-Z\s]+$").WithMessage("Öğrenci adı sadece harf içerebilir, sayı ve özel karakter içeremez.");

            RuleFor(s => s.StudentSurname)
               .NotEmpty().WithMessage("Öğrenci soyadı zorunludur.")
               .Matches(@"^[a-zA-Z\s]+$").WithMessage("Öğrenci soyadı sadece harf içerebilir, sayı ve özel karakter içeremez.");

            RuleFor(s => s.StudentNumber)
            .NotEmpty().WithMessage("Öğrenci numarası zorunludur.")
            .Matches(@"^\d+$").WithMessage("Öğrenci numarası sadece sayılardan oluşmalıdır.");
            

        }

    }
}
