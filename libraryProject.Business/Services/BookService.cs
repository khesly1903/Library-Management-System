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
    // BookService sınıfı, kitaplarla ilgili iş mantığını içeren servis katmanıdır.
    // IManager<Book> arayüzünü implemente eder ve kitaplarla ilgili temel işlemleri sağlar.
    public class BookService : IManager<Book>
    {
        // Kitap verilerini yönetmek için BookRepository nesnesi kullanılır.
        private readonly BookRepository _bookRepository;

        // Constructor metodu: BookService sınıfı BookRepository bağımlılığını alır (Dependency Injection ile sağlanır).
        public BookService(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        // Yeni bir kitap ekler veya mevcut kitabın kopya sayısını artırır.
        public void Create(Book entity)
        {
            // Kitap doğrulama işlemi için Validator sınıfı kullanılır.
            BookValidator bVal = new();
            ValidationResult result = bVal.Validate(entity);

            // Eğer doğrulama başarısızsa, hata mesajlarını birleştirerek bir istisna fırlatılır.
            if (!result.IsValid)
            {
                throw new Exception(string.Join(Environment.NewLine, result.Errors));
            }

            // Aynı ISBN numarasına veya aynı kitap adı ve yazarın adı-soyadı kombinasyonuna sahip bir kitap var mı kontrol edilir.
            var existingBook = _bookRepository.GetAll().FirstOrDefault(b =>
            b.BookISBN == entity.BookISBN || // Aynı ISBN numarasına sahip kitap kontrol edilir.
            (b.BookName == entity.BookName && b.Author != null && entity.Author != null && b.Author.Name == entity.Author.Name && b.Author.Surname == entity.Author.Surname)); // Aynı kitap adı ve yazar bilgisine sahip kitap kontrol edilir.

            if (existingBook != null)
            {
                // Eğer kitap zaten varsa, mevcut kitabın toplam ve mevcut kopya sayıları artırılır.
                existingBook.TotalCopies += entity.TotalCopies;
                existingBook.AvailableCopies += entity.AvailableCopies;
                _bookRepository.Update(existingBook); // Güncellenmiş kitap bilgisi veritabanına kaydedilir.
            }
            else
            {
                // Eğer kitap veritabanında yoksa, yeni kitap olarak eklenir.
                _bookRepository.Create(entity);
            }
        }

        //Bu metod, belirtilen ID'ye sahip kitabı siler veya kopya sayısını azaltır. İlk olarak, verilen ID'ye sahip kitap veritabanından getirilir. Eğer kitap bulunamazsa, hata mesajı döndürülür.
        //Eğer kitabın birden fazla kopyası varsa, sadece kopya sayısı azaltılır. Eğer kitap tek kopya ise, tamamen silinir.

        // Belirtilen ID'ye sahip kitabı siler veya kopya sayısını azaltır.
        public void Delete(Guid id)
        {
            // Verilen ID'ye sahip kitap veritabanından getirilir.
            var book = _bookRepository.GetByID(id);

            // Eğer kitap bulunamazsa, hata mesajı döndürülür.
            if (book == null)
            {
                throw new Exception("Kitap bulunamadı.");
            }

            // Eğer kitabın birden fazla kopyası varsa, sadece kopya sayısı azaltılır.
            if (book.TotalCopies > 1)
            {
                book.TotalCopies -= 1; // Toplam kopya sayısı bir azaltılır.
                book.AvailableCopies -= 1; // Mevcut kopya sayısı bir azaltılır.
                _bookRepository.Update(book); // Güncellenmiş kitap bilgisi veritabanına kaydedilir.
            }
            else
            {
                // Eğer kitap tek kopya ise, tamamen silinir.
                _bookRepository.Delete(id);
            }
        }

        // Tüm kitapları getirir.
        public IEnumerable<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        // Belirtilen ID'ye sahip kitabı getirir.
        public Book GetById(Guid id)
        {
            // Eğer ID boş ise, hata fırlatılır.
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }

            return _bookRepository.GetByID(id); // ID'ye sahip kitap döndürülür.
        }

        // Belirtilen filtreye göre kitabın var olup olmadığını kontrol eder.
        public bool IfEntityExists(Expression<Func<Book, bool>> filter)
        {
            return _bookRepository.IfEntityExists(filter);
        }

        // Mevcut bir kitabı günceller.
        public void Update(Book entity)
        {
            // Eğer güncellenecek kitap nesnesi boş ise, hata fırlatılır.
            if (entity == null)
            {
                throw new Exception("Güncellenecek kitap bilgisi boş olamaz.");
            }

            // Kitap doğrulama işlemi gerçekleştirilir.
            BookValidator bVal = new();
            ValidationResult result = bVal.Validate(entity);

            // Eğer doğrulama başarısızsa, hata mesajlarını birleştirerek bir istisna fırlatılır.
            if (!result.IsValid)
            {
                throw new Exception(string.Join(Environment.NewLine, result.Errors));
            }

            // Kitap güncellenir.
            _bookRepository.Update(entity);
        }
    }
}
