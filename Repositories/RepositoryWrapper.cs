using System;
using System.Collections.Generic;
using System.Linq;
using AnyFit.Repository.IContract;
using AnyFit.Repository;
using AnyFit.Repositories.Context;
using AnyFit.Models;

namespace AnyFit.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
      private AnyFitContext _anyFitContex;
      private IUserRepository _userRepository;
      
      public IUserRepository User {
        get 
        {
          if(_userRepository == null)
          {
            _userRepository = new UserRepository(_anyFitContex);
          }
          return _userRepository;
        }
      }

      public RepositoryWrapper(AnyFitContext _context)
      {
        _anyFitContex = _context;
      }
 
      public void Save()
      {
        _anyFitContex.SaveChanges();
      }
    }
}