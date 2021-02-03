using Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class MusteriSenetManager : IMusteriSenetService
    {
        public IDataResult<MusteriSenet> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MusteriSenet>> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Add(MusteriSenet entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(MusteriSenet entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(MusteriSenet entity)
        {
            throw new NotImplementedException();
        }
    }
}
