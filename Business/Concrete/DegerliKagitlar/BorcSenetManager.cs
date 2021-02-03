using Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BorcSenetManager : IBorcSenetService
    {
        public IDataResult<BorcSenet> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BorcSenet>> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Add(BorcSenet entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(BorcSenet entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(BorcSenet entity)
        {
            throw new NotImplementedException();
        }
    }
}
