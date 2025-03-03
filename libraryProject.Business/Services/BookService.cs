using System.Linq.Expressions;
using FluentValidation.Results;
using libraryProject.Business.Abstractions;
using libraryProject.Business.Validators;
using libraryProject.DataAccess.Repositories;
using libraryProject.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace libraryProject.Business.Services
{
    public class BookService : IManager<Book>
    {
        private readonly BookRepository _bookRepository;

        public BookService(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public void Create(Book entity)
        {
            BookValidator bVal = new();
            ValidationResult result = bVal.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join(Environment.NewLine, result.Errors));
            }
            
            _bookRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var book = _bookRepository.GetByID(id);
            if (book == null)
            {
                throw new Exception("Bulunamadı.");
            }
            _bookRepository.Delete(id);

        }

        public IEnumerable<Book> GetAll()
        {
            return _bookRepository.GetAll();

        }

        public Book GetById(Guid id)
        {
            return _bookRepository.GetByID(id);

        }

        public bool IfEntityExists(Expression<Func<Book, bool>> fiter)
        {
            return _bookRepository.IfEntityExists(fiter);

        }

        public void Update(Book entity)
        {
            BookValidator bVal = new();
            ValidationResult result = bVal.Validate(entity);
            if (result.IsValid)
            {
                _bookRepository.Update(entity);
            }
            else
            {
                throw new Exception(string.Join(Environment.NewLine, result.Errors));
            }



        }

       


    }
}
