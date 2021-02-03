using Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class DegerliKagitManager : IDegerliKagitService
    {
        public IDataResult<DegerliKagit> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<DegerliKagit>> GetList()
        {
            throw new NotImplementedException();
        }
        public IResult Add(DegerliKagit entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(DegerliKagit entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(DegerliKagit entity)
        {
            throw new NotImplementedException();
        }
    }
}