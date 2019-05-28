using System;
using System.Collections.Generic;
using System.Linq;

namespace AnyFit.Repository.IContract
{
    public interface IRepository<T>
    {
        T Register(T obj);
        void Delete(int id);
        T Update(T obj);
        T Find(T obj);
        List<T> FindAll();
    }
}