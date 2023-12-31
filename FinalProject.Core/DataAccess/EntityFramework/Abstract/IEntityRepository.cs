﻿using FinalProject.Core.Entities;
using System.Linq.Expressions;

namespace FinalProject.Core.DataAccess.EntityFramework.Abstract
{
    public interface IEntityRepository<T>
        where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}