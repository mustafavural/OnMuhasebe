using Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class SenetManager : ISenetService
    {
        public IDataResult<Senet> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Senet>> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Add(Senet entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Senet entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Senet entity)
        {
            throw new NotImplementedException();
        }
    }
}
