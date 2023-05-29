﻿using HuluMoviesAndTV.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuluMoviesAndTV.Repositories
{
    public interface IRepository<TEntity, TKey>
        where TEntity :BaseEntity
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(TKey key);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Save();
    }
}
