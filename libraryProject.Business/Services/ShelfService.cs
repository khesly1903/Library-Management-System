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
    public class ShelfService : IManager<Shelf>
    {
        public void Create(Shelf entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Shelf entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Shelf> GetAll()
        {
            throw new NotImplementedException();
        }

        public Shelf GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool IfEntityExists(Expression<Func<Shelf, bool>> fiter)
        {
            throw new NotImplementedException();
        }

        public void Update(Shelf entity)
        {
            throw new NotImplementedException();
        }
    }
}
