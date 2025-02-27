using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using libraryProject.Entities.Models;
namespace libraryProject.Business.Validators
{
    internal class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {

            // 2 karakterden küçük olamaz
            RuleFor(a => a.Name)
                .NotEmpty().WithMessage("Yazar adı boş olamaz.");

            // 2 karakterden küçük olamaz
            RuleFor(a => a.Surname)
                .NotEmpty().WithMessage("Yazar soyadı boş olamaz.");

            RuleFor(a => a.Biography)
                .MaximumLength(1000).WithMessage("Biyografi 1000 karakterden uzun olamaz.");
        }
    }
}
