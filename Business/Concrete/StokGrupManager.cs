using Business.Abstract;
using Business.Constans;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class StokGrupManager : IStokGrupService
    {
        IStokGrupDal _stokGrupDal;

        public StokGrupManager(IStokGrupDal stokGrupDal)
        {
            _stokGrupDal = stokGrupDal;
        }

        public IResult Add(StokGrup stokGrup)
        {
            _stokGrupDal.Add(stokGrup);
            return new SuccessResult(Messages.StokAddedToGrup);
        }

        public IResult Delete(StokGrup stokGrup)
        {
            _stokGrupDal.Delete(stokGrup);
            return new SuccessResult(Messages.StokDeletedFromGrup);
        }

        public IDataResult<List<StokGrup>> GetByStokGrupKodId(int stokGrupKodId)
        {
            return new SuccessDataResult<List<StokGrup>>(_stokGrupDal.GetAll(p =>
            p.StokGrupKodId == stokGrupKodId));
        }

        public IDataResult<List<StokGrup>> GetByStokId(int stokId)
        {
            return new SuccessDataResult<List<StokGrup>>(_stokGrupDal.GetAll(p =>
            p.StokId == stokId));
        }

        public IResult Update(StokGrup stokGrup)
        {
            _stokGrupDal.Update(stokGrup);
            return new SuccessResult(Messages.StokTransferredGrup);
        }
    }
}
