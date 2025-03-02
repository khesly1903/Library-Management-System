using FluentValidation.Results; // FluentValidation kütüphanesinden doğrulama sonuçlarını kullanmak için eklenmiştir.
using libraryProject.Business.Abstractions; // İş katmanı için kullanılan soyutlama dosyalarını içeren namespace.
using libraryProject.Business.Validators; // Kitap doğrulamalarını yapan Validator sınıfını kullanmak için eklenmiştir.
using libraryProject.DataAccess.Abstractions; // Veri erişim katmanındaki soyutlama dosyalarını içeren namespace.
using libraryProject.DataAccess.Repositories; // Veri erişim katmanındaki repository sınıflarını kullanmak için eklenmiştir.
using libraryProject.Entities.Models; // Book gibi model sınıflarını kullanmak için eklenmiştir.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

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
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }
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
