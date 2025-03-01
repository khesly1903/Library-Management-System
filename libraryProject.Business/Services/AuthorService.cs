using FluentValidation;
using FluentValidation.Results;
using libraryProject.Business.Abstractions;
using libraryProject.Business.Validators;
using libraryProject.DataAccess.Abstractions;
using libraryProject.DataAccess.Repositories;
using libraryProject.Entities.Models;
using System.Linq.Expressions;

namespace libraryProject.Business.Services
{
    public class AuthorService : IManager<Author>
    {
        private readonly AuthorRepository _authorRepository;
        public AuthorService(AuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        public void Create(Author entity)
        {
            AuthorValidator aVal = new();
            ValidationResult result = aVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join(Environment.NewLine, result.Errors));
            }

            _authorRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var author = _authorRepository.GetByID(id);

            if (author == null)
            {
                throw new System.Exception("Bulunamadı.");
            }

            _authorRepository.Delete(id);
        }

        public IEnumerable<Author> GetAll()
        {
            return _authorRepository.GetAll();
        }

        public Author GetById(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }

            return _authorRepository.GetByID(id);
        }

        public bool IfEntityExists(Expression<Func<Author, bool>> filter)
        {
            return _authorRepository.IfEntityExists(filter);
        }

        public void Update(Author entity)
        {
            if (entity == null)
            {
                throw new Exception("Güncellenecek yazar bilgisi boş olamaz.");
            }
            AuthorValidator aVal = new();
            ValidationResult result = aVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join(Environment.NewLine, result.Errors));
            }
            _authorRepository.Update(entity);
        }
    }
}
