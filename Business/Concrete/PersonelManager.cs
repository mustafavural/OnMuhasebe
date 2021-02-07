using Core.Utilities.Result;
using Entities;
using System.Collections.Generic;

namespace Business
{
    public class PersonelManager : IPersonelService
    {
        public PersonelManager()
        {

        }

        public IResult Add(Personel entity)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(Personel entity)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Personel> GetById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Personel>> GetList()
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Personel entity)
        {
            throw new System.NotImplementedException();
        }
    }
}