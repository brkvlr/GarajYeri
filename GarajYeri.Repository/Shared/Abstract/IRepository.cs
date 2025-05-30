﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GarajYeri.Repository.Shared.Abstract
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);

        T GetFirstOrDefault(Expression<Func<T, bool>> filter);

        T Add(T entity);
        T Update (T entity);
        T DeleteById(int id);
        T Delete(T entity);
        void Save();
    }
}
