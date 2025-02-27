using libraryProject.Entities.Models;
using libraryProject.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryProject.DataAccess.Repositories
{
    public class SubjectRepository : GenericRepository<Subject> 
    {
        
        private readonly AppDBContext _dbContext;
        public SubjectRepository(AppDBContext db) : base(db)
        {
            _dbContext = db;
        }   
    }
}
