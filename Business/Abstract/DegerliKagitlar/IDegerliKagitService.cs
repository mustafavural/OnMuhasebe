﻿using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IDegerliKagitService<TEntity> : IGet<TEntity>
        where TEntity : DegerliKagit, new()
    {
        IDataResult<List<TEntity>> GetListByVade(DateTime vade);
        IDataResult<List<TEntity>> GetListByTutar(decimal tutar);
    }
}