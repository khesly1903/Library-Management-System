using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using FluentValidation;
using libraryProject.Entities.Models;

namespace libraryProject.Business.Validators
{
    public class LoanValidator:AbstractValidator<Loan>
    {
        public LoanValidator()
        {
            
            RuleFor(l => l.LoanDate)
                .NotEmpty().WithMessage("Ödünç alma tarihi gereklidir.");

            // ReturnDate, LoanDate'den sonra olmalıdır
            RuleFor(l => l.RetrunDate)
                .GreaterThan(l => l.LoanDate).WithMessage("Teslim tarihi, ödünç alma tarihinden sonra olmalıdır.")
                .LessThanOrEqualTo(l => l.LoanDate.AddDays(15)).WithMessage("Teslim tarihi, ödünç alma tarihinden 15 günden fazla olamaz.");

            // Student boş olamaz
            RuleFor(l => l.Student)
                .NotEmpty().WithMessage("Öğrenci gereklidir.");

            // BookId boş olamaz
            RuleFor(l => l.Book)
                .NotEmpty().WithMessage("Kitap gereklidir.");
            
        }
    }
}
