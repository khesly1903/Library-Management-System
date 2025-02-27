using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FluentValidation;
using libraryProject.Entities.Models;

namespace libraryProject.Business.Validators
{
    internal class LoanValidator:AbstractValidator<Loan>
    {
        public LoanValidator()
        {
            RuleFor(l => l.LoanDate).NotEmpty().WithMessage("Loan date is required.");
            RuleFor(l => l.RetrunDate).GreaterThan(l => l.LoanDate).WithMessage("Return date must be after loan date.");
        }
    }
}
