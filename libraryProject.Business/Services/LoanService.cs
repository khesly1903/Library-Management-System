using libraryProject.Business.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace libraryProject.Business.Services
{
    public class LoanService : IManager<LoanService>
    {
        public void Create(LoanService entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LoanService> GetAll()
        {
            throw new NotImplementedException();
        }

        public LoanService GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool IfEntityExists(Expression<Func<LoanService, bool>> fiter)
        {
            throw new NotImplementedException();
        }

        public void Update(LoanService entity)
        {
            throw new NotImplementedException();
        }
    }
}
