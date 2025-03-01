using FluentValidation.Results;
using libraryProject.Business.Abstractions;
using libraryProject.Business.Validators;
using libraryProject.DataAccess.Abstractions;
using libraryProject.DataAccess.Repositories;
using libraryProject.Entities.Models;
using System.Linq.Expressions;

namespace libraryProject.Business.Services
{
    public class ShelfService : IManager<Shelf>
    {

        private readonly ShelfRepository _shelfRepository;

        public ShelfService(ShelfRepository shelfRepository)
        {
            _shelfRepository = shelfRepository;
        }

        public void Create(Shelf entity)
        {
            ShelfValidator shelfValidator = new();
            ValidationResult result = shelfValidator.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join(Environment.NewLine, result.Errors));
            }
            _shelfRepository.Create(entity);
        }
        public void Delete(Guid id)
        {
            var shelf = _shelfRepository.GetByID(id);
            if (shelf == null)
            {
                throw new System.Exception("Bulunamadı.");
            }
        }

        public IEnumerable<Shelf> GetAll()
        {
            return _shelfRepository.GetAll();
        }

        public Shelf GetById(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }
            return _shelfRepository.GetByID(id);
        }

        public bool IfEntityExists(Expression<Func<Shelf, bool>> fiter)
        {
            return _shelfRepository.IfEntityExists(fiter);
        }

        public void Update(Shelf entity)
        {
            if (entity == null)
            {
                throw new Exception("Güncellenecek veri bulunamadı.");
            }
            ShelfValidator shelfValidator = new();
            ValidationResult result = shelfValidator.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join(Environment.NewLine, result.Errors));
            }
            _shelfRepository.Update(entity);
        }
    }
}
