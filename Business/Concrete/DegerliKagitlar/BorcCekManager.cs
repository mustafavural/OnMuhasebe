using Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BorcCekManager : IBorcCekService
    {
        public IDataResult<BorcCek> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BorcCek>> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Add(BorcCek entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(BorcCek entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(BorcCek entity)
        {
            throw new NotImplementedException();
        }
    }
}
