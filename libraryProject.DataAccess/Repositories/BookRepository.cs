using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libraryProject.DataAccess.Context;
using libraryProject.Entities.Models;

namespace libraryProject.DataAccess.Repositories
{
    public class BookRepository : GenericRepository<Book>
    {
        private readonly AppDBContext _dbContext;

        public BookRepository(AppDBContext db) : base(db)
        {
            _dbContext = db;
        }
    }
}
