using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Context;
using Data.Entities;
using Data.Repositories.Abstract;

namespace Data.Repositories.UserRepo
{
    class UserRepository : RepositoryBase, IUserRepository
    {
        public UserRepository(AppContextEF dbContext) : base(dbContext)
        {


        }

        public User GetUser(string userId)
        {
            return _context.Users.FirstOrDefault(x => x.Id == userId);
        }
    }
}
