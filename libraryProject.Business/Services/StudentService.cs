using FluentValidation.Results;
using libraryProject.Business.Abstractions;
using libraryProject.Business.Validators;
using libraryProject.DataAccess.Abstractions;
using libraryProject.DataAccess.Repositories;
using libraryProject.Entities.Models;
using System.Linq.Expressions;

namespace libraryProject.Business.Services
{
    public class StudentService : IManager<Student>
    {
        private readonly StudentRepository _studentRepository;

        public StudentService(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public void Create(Student entity)
        {
            StudentValidator sVal = new();
            ValidationResult result = sVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("/n", result.Errors));
            }

        }
        public void Delete(Student entity)
        {
            var student = _studentRepository.GetByID(entity.Id);

            if (student == null)
            {
                throw new System.Exception("Bulunamadı.");
            }

            _studentRepository.Delete(entity.Id);
        }

        public IEnumerable<Student> GetAll()
        {
            return _studentRepository.GetAll(); 
        }

        public Student GetById(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }

            return _studentRepository.GetByID(id);
        }

        public bool IfEntityExists(Expression<Func<Student, bool>> filter)
        {
            return _studentRepository.IfEntityExists(filter);
        }

        public void Update(Student entity)
        {
            if (entity == null)
            {
                throw new Exception("Güncellenecek öğrenci bilgisi boş olamaz.");
            }

            _studentRepository.Update(entity);
        }
    }
}
