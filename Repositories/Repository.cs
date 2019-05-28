using System;
using System.Collections.Generic;
using System.Linq;
using AnyFit.Models;
using AnyFit.ViewModel;
using AnyFit.Repository.IContract;
using AnyFit.Repositories.Context;

using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AnyFit.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
      protected AnyFitContext _anyFitContext {get; set;}
      
        public Repository( AnyFitContext _context)
        {
          this._anyFitContext = _context;
        }

        public T Register(T obj)
        {
          return null;
        }

        public void Delete(int id)
        {

        }

        public T Update(T obj)
        {
          return null;
        }
        public T Find(T obj)
        {
          return null;
        }

        public List<T> FindAll()
        {
          return null;
        }
    }
}