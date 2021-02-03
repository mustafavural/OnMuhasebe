using Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CekManager : ICekService
    {
        public IDataResult<Cek> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Cek>> GetList()
        {
            throw new NotImplementedException();
        }
        public IResult Add(Cek entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Cek entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Cek entity)
        {
            throw new NotImplementedException();
        }
    }
}
