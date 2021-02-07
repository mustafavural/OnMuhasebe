using Core.Utilities.Result;
using Entities;
using System.Collections.Generic;

namespace Business
{
    public class PersonelHareketManager : IPersonelHareketService
    {
        public PersonelHareketManager()
        {

        }

        public IResult Add(PersonelHareket entity)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(PersonelHareket entity)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<PersonelHareket> GetById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<PersonelHareket>> GetList()
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<PersonelHareket>> GetListByPersonelId(int personelId)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(PersonelHareket entity)
        {
            throw new System.NotImplementedException();
        }
    }
}