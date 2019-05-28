using System;
using System.Collections.Generic;
using System.Linq;

namespace AnyFit.Business
{
    public interface IUserBusiness<T>
    {
        T Register(T obj);
        void Delete(int id);
        T Update(T obj);
        T Find(T obj);
        List<T> FindAll();
    }
}