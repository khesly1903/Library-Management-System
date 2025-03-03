using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libraryProject.DataAccess.Context;
using libraryProject.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace libraryProject.DataAccess.Repositories
{
    public class BookRepository : GenericRepository<Book>
    {
        private readonly AppDBContext _dbContext;

        public BookRepository(AppDBContext db) : base(db)
        {
            _dbContext = db;
        }

        public Book? GetByID(Guid id)
        {
            return _dbContext.Books
                .Include(b => b.Author)
                .Include(b => b.Shelf)
                .Include(b => b.Subject)
                .Include(b => b.Publiser)
                .FirstOrDefault(b => b.Id == id);
        }
    }
}
