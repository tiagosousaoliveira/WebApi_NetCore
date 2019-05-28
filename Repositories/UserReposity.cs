using System;
using System.Collections.Generic;
using System.Linq;
using AnyFit.Models;
using AnyFit.ViewModel;
using AnyFit.Repository.IContract;

using AnyFit.Repositories.Context;

namespace AnyFit.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AnyFitContext _context)
         :base(_context)
        {

        }
    }
}
