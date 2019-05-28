using System;
using System.Collections.Generic;
using System.Linq;

using AnyFit.Models;
using AnyFit.Repository.IContract;

namespace AnyFit.Repository.IContract
{
    public interface IRepositoryWrapper
    {
      IUserRepository User { get; }
      void Save();
    }
}