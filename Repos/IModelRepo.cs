﻿using Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repos
{
    public interface IModelRepo<T>
    {
        void Create(T entity);
        IQueryable<T> Read();
        Task<IQueryable<T>> GetAll();
        void Update(T entity);
        void testUpdate(T u, int Id);
        void Delete(int id);
        T GetByID(int id);
        Task<IQueryable<T>> FindByCondition(Expression<Func<T, bool>> expression);
    }
}
