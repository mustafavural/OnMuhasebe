using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CariGrupManager : ICariGrupService
    {
        ICariGrupDal _cariGrupDal;

        public CariGrupManager(ICariGrupDal cariGrupDal)
        {
            _cariGrupDal = cariGrupDal;
        }

        public IResult Add(CariGrup cariGrup)
        {
            _cariGrupDal.Add(cariGrup);
            return new SuccessResult(Messages.SuccessMessages.CariAddedToGrup);
        }

        public IResult Delete(CariGrup cariGrup)
        {
            _cariGrupDal.Delete(cariGrup);
            return new SuccessResult(Messages.SuccessMessages.CariDeletedFromGrup);
        }

        public IResult Update(CariGrup cariGrup)
        {
            _cariGrupDal.Update(cariGrup);
            return new SuccessResult(Messages.SuccessMessages.CariTransferredToGrup);
        }

        public IDataResult<List<CariGrup>> GetListByCariGrupKodId(int cariGrupKodId)
        {
            return new SuccessDataResult<List<CariGrup>>(_cariGrupDal.GetAll(p => p.CariGrupKodId == cariGrupKodId));
        }

        public IDataResult<List<CariGrup>> GetByCariId(int cariId)
        {
            return new SuccessDataResult<List<CariGrup>>(_cariGrupDal.GetAll(p => p.CariId == cariId));
        }
    }
}