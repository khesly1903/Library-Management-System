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
    public class BookService : IManager<Book>
    {
        public void Create(Book entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Book entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public Book GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool IfEntityExists(Expression<Func<Book, bool>> fiter)
        {
            throw new NotImplementedException();
        }

        public void Update(Book entity)
        {
            throw new NotImplementedException();
        }
    }
}
