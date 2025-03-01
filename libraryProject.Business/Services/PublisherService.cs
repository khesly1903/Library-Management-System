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
    public class PublisherService : IManager<Publisher>
    {
        private readonly PublisherRepository _publisherRepository;
        public PublisherService(PublisherRepository publisherRepository)
        {
            _publisherRepository = publisherRepository;
        }
        public void Create(Publisher entity)
        {
            PublisherValidator pVal = new();
            ValidationResult result = pVal.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join(Environment.NewLine, result.Errors));
            }

            _publisherRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var publisher = _publisherRepository.GetByID(id);
            if (publisher == null)
            {
                throw new System.Exception("Bulunamadı.");
            }

            _publisherRepository.Delete(id);
        }

        public IEnumerable<Publisher> GetAll()
        {
            return _publisherRepository.GetAll();
        }

        public Publisher GetById(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }

            return _publisherRepository.GetByID(id);
        }

        public bool IfEntityExists(Expression<Func<Publisher, bool>> fiter)
        {
            return _publisherRepository.IfEntityExists(fiter);
        }

        public void Update(Publisher entity)
        {
            if (entity == null)
            {
                throw new Exception("Güncellenecek kayıt bulunamadı.");
            }
            PublisherValidator pVal = new();
            ValidationResult result = pVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join(Environment.NewLine, result.Errors));
            }
            _publisherRepository.Update(entity);
        }
    }
}
