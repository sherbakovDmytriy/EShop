﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<TEntity> where TEntity : class
    {
        #region Get

        Task<IEnumerable<TEntity>> Get(int? limit = null);
        Task<IEnumerable<TEntity>> GetWithInclude(int? limit = null, params Expression<Func<TEntity, object>>[] includeProperties);

        Task<IEnumerable<TEntity>> GetWhere(Expression<Func<TEntity, bool>> predicate);
        Task<IEnumerable<TEntity>> GetWhereWithInclude(Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] includeProperties);

        Task<TEntity> FindById(int id);
        Task<TEntity> FirstWithInclude(params Expression<Func<TEntity, object>>[] includeProperties);

        #endregion

        #region CRUD

        void Create(TEntity item);
        void Update(TEntity item);
        void Remove(TEntity item);

        #endregion
    }
}