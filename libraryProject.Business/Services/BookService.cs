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

            var existingBook = _bookRepository.GetAll().FirstOrDefault(b =>
            b.BookISBN == entity.BookISBN || 
            (b.BookName == entity.BookName && b.Author != null && entity.Author != null && b.Author.Name == entity.Author.Name && b.Author.Surname == entity.Author.Surname)); 

            if (existingBook != null)
            {
                existingBook.TotalCopies = entity.TotalCopies;
                
                _bookRepository.Update(existingBook); 
            }
            else
            {
                _bookRepository.Create(entity);
            }
        }


        public void Delete(Guid id)
        {
            var book = _bookRepository.GetByID(id);

            if (book == null)
            {
                throw new Exception("Kitap bulunamadı.");
            }

            if (book.TotalCopies > 1)
            {
                book.TotalCopies -= 1; 

                _bookRepository.Update(book); 
            }
            else
            {
                _bookRepository.Delete(id);
            }
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

        public bool IfEntityExists(Expression<Func<Book, bool>> filter)
        {
            return _bookRepository.IfEntityExists(filter);
        }

        public void Update(Book entity)
        {
            if (entity == null)
            {
                throw new Exception("Güncellenecek kitap bilgisi boş olamaz.");
            }

            BookValidator bVal = new();
            ValidationResult result = bVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join(Environment.NewLine, result.Errors));
            }

           
            _bookRepository.Update(entity);
        }
    }
}
