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
    public class PublisherService : IManager<Publisher>
    {
        public void Create(Publisher entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Publisher entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Publisher> GetAll()
        {
            throw new NotImplementedException();
        }

        public Publisher GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool IfEntityExists(Expression<Func<Publisher, bool>> fiter)
        {
            throw new NotImplementedException();
        }

        public void Update(Publisher entity)
        {
            throw new NotImplementedException();
        }
    }
}
