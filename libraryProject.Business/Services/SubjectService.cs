using FluentValidation.Results;
using libraryProject.Business.Abstractions;
using libraryProject.Business.Validators;
using libraryProject.DataAccess.Abstractions;
using libraryProject.DataAccess.Repositories;
using libraryProject.Entities.Models;
using System.Linq.Expressions;

namespace libraryProject.Business.Services
{
    public class SubjectService : IManager<Subject>
    {
        private readonly SubjectRepository _subjectRepository;
        public SubjectService(SubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }
        public void Create(Subject entity)
        {
            SubjectValidator sVal = new();
            ValidationResult result = sVal.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join(Environment.NewLine, result.Errors));
            }
            _subjectRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var subject = _subjectRepository.GetByID(id);
            if (subject == null)
            {
                throw new System.Exception("Bulunamadı.");
            }
            _subjectRepository.Delete(id);
        }

        public IEnumerable<Subject> GetAll()
        {
            return _subjectRepository.GetAll();
        }

        public Subject GetById(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }
            return _subjectRepository.GetByID(id);
        }

        public bool IfEntityExists(Expression<Func<Subject, bool>> fiter)
        {
            return _subjectRepository.IfEntityExists(fiter);
        }

        public void Update(Subject entity)
        {
            if (entity == null)
            {
                throw new Exception("Güncellenecek nesne boş olamaz.");
            }
            SubjectValidator sVal = new();
            ValidationResult result = sVal.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join(Environment.NewLine, result.Errors));
            }
            _subjectRepository.Update(entity);
        }
    }
}
