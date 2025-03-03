using System.Linq.Expressions;
using FluentValidation.Results;
using libraryProject.Business.Abstractions;
using libraryProject.Business.Validators;
using libraryProject.DataAccess.Repositories;
using libraryProject.Entities.Models;

namespace libraryProject.Business.Services
{
    public class LoanService : IManager<Loan>
    {

        private readonly LoanRepository _loanRepository;

        public LoanService(LoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }
        public void Create(Loan entity)
        {
            LoanValidator lVal = new();
            ValidationResult result = lVal.Validate(entity);
            if (!result.IsValid)
            {
                
                throw new Exception(string.Join(System.Environment.NewLine, result.Errors));
            }

            _loanRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var loan = _loanRepository.GetByID(id);
            if (loan == null)
            {
                throw new System.Exception("Bulunamadı.");
            }
            _loanRepository.Delete(id);
        }

        public IEnumerable<Loan> GetAll()
        {
            return _loanRepository.GetAll();
        }

        public Loan GetById(Guid id)
        {
            return _loanRepository.GetByID(id);
        }

        public bool IfEntityExists(Expression<Func<Loan, bool>> fiter)
        {
            return _loanRepository.IfEntityExists(fiter);
        }

        public void Update(Loan entity)
        {
            if (entity == null)
            {
                throw new Exception("Güncellenecek öğe bulunamadı.");
            }

            LoanValidator lVal = new();
            ValidationResult result = lVal.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join(System.Environment.NewLine, result.Errors));
            }

            _loanRepository.Update(entity);

        }
    }
}
