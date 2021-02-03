using Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class MusteriCekManager : IMusteriCekService
    {
        public IDataResult<MusteriCek> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MusteriCek>> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Add(MusteriCek entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(MusteriCek entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(MusteriCek entity)
        {
            throw new NotImplementedException();
        }
    }
}
