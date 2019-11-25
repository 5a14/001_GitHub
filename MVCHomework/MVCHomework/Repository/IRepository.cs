using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHomework.Repository
{
    public interface IRepository<T> where T : class
    {
        IUnitOfWork UnitOfWork { get; set; }

        IQueryable<T> LookupAll();
    }
}