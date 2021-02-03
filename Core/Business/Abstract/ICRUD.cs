﻿using Core.Entities;
using Core.Utilities.Result;
using System.Collections.Generic;

namespace Core.Business.Abstract
{
    public interface ICRUD<TEntity> where TEntity : class, IEntity, new()
    {
        IDataResult<TEntity> GetById(int Id);
        IDataResult<List<TEntity>> GetList();
        IResult Add(TEntity entity);
        IResult Delete(TEntity entity);
        IResult Update(TEntity entity);
    }
}