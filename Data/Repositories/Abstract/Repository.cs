using Data.Context;
using Data.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Abstract
{
    public abstract class RepositoryBase
    {
        protected AppContextEF _context;

        public RepositoryBase(AppContextEF dbContext)
        {
            _context = dbContext;
        }
    }
}
