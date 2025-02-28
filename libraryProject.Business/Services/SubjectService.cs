using libraryProject.Business.Abstractions;
using libraryProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace libraryProject.Business.Services
{
    public class SubjectService : IManager<Subject>
    {
        public void Create(Subject entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Subject> GetAll()
        {
            throw new NotImplementedException();
        }

        public Subject GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool IfEntityExists(Expression<Func<Subject, bool>> fiter)
        {
            throw new NotImplementedException();
        }

        public void Update(Subject entity)
        {
            throw new NotImplementedException();
        }
    }
}
