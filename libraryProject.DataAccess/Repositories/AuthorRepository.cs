﻿using libraryProject.DataAccess.Context;
using libraryProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryProject.DataAccess.Repositories
{
    public class AuthorRepository : GenericRepository<Author>
    {
        private readonly AppDBContext _dbContext;
        public AuthorRepository(AppDBContext db) : base(db)
        {
            _dbContext = db;
        }
    }

}