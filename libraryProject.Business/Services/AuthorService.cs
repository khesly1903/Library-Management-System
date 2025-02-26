using libraryProject.Business.Abstractions;
using System.Linq.Expressions;
using libraryProject.Entities.Models;

namespace libraryProject.Business.Services
{
    public class AuthorService : IManager<Author>
    {
        public void Create(Author entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Author entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> GetAll()
        {
            throw new NotImplementedException();
        }

        public Author GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool IfEntityExists(Expression<Func<Author, bool>> fiter)
        {
            throw new NotImplementedException();
        }

        public void Update(Author entity)
        {
            throw new NotImplementedException();
        }
    }
}
