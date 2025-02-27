using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using libraryProject.Entities.Models;


namespace libraryProject.Business.Validators
{
    internal class StudentValidator:AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(s => s.StudentName).NotEmpty().WithMessage("Student name is required.");
            RuleFor(s => s.StudentNumber).NotEmpty().WithMessage("Student number is required.");
        }

    }
}
