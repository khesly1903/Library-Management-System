using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FluentValidation;
using libraryProject.Entities.Models;
namespace libraryProject.Business.Validators;


internal class BookValidator: AbstractValidator<Book>
{
    public BookValidator()
    {
        RuleFor(b => b.BookName).NotEmpty().WithMessage("Book name is required.");
        // book title boş olamaz
        //ISBN 10 or 13
        RuleFor(b => b.BookISBN).NotEmpty().WithMessage("ISBN is required.");
        RuleFor(b => b.TotalCopies).GreaterThan(0).WithMessage("Total copies must be greater than 0.");

        //total copy 1 den küçük olamaz


        // bunların hepsi boş olmamalı
        /*    public int AvailableCopies { get; set; }
        public Author? Author { get; set; } // yazar 3 harften küçük olamaz
        public Shelf? Shelf { get; set; }
        public Subject? Subject{ get; set; }
        public Publisher? Publiser { get; set; }*/
    }
}
