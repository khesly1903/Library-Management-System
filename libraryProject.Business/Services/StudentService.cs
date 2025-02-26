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
    public class StudentService : IManager<Student>
    {
        public void Create(Student entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Student entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool IfEntityExists(Expression<Func<Student, bool>> fiter)
        {
            throw new NotImplementedException();
        }

        public void Update(Student entity)
        {
            throw new NotImplementedException();
        }
    }
}
