using Business.Abstract;
using Business.Constans;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class StokGrupKodManager : IStokGrupKodService
    {
        IStokGrupKodDal _stokGrupKodDal;
        IStokGrupService _stokGrupService;

        public StokGrupKodManager(IStokGrupKodDal stokGrupKodDal, IStokGrupService stokGrupService)
        {
            _stokGrupKodDal = stokGrupKodDal;
            _stokGrupService = stokGrupService;
        }

        public IResult Add(StokGrupKod stokGrupKod)
        {
            _stokGrupKodDal.Add(stokGrupKod);
            return new SuccessResult(Messages.StokGrupKodAdded);
        }

        public IResult Delete(StokGrupKod stokGrupKod)
        {
            _stokGrupKodDal.Delete(stokGrupKod);
            return new SuccessResult(Messages.StokGrupKodDeleted);
        }

        public IDataResult<StokGrupKod> GetByAd(string stokGrupKodAd)
        {
            return new SuccessDataResult<StokGrupKod>(_stokGrupKodDal.Get(p => p.Ad == stokGrupKodAd));
        }

        public IDataResult<StokGrupKod> GetById(int stokGrupKodId)
        {
            return new SuccessDataResult<StokGrupKod>(_stokGrupKodDal.Get(p => p.Id == stokGrupKodId));
        }

        public IDataResult<StokGrupKod> GetByTur(string stokGrupKodTur)
        {
            return new SuccessDataResult<StokGrupKod>(_stokGrupKodDal.Get(p => p.Tur == stokGrupKodTur));
        }

        public IDataResult<List<StokGrupKod>> GetList()
        {
            return new SuccessDataResult<List<StokGrupKod>>(_stokGrupKodDal.GetAll());
        }

        public IDataResult<List<StokGrupKod>> GetListByStok(int stokId)
        {
            return new SuccessDataResult<List<StokGrupKod>>(_stokGrupKodDal.GetAll(p =>
            p.Id == _stokGrupService.GetByStokId(stokId).Data.Select(s => s.StokGrupKodId).Single()));
        }

        public IResult Update(StokGrupKod stokGrupKod)
        {
            _stokGrupKodDal.Update(stokGrupKod);
            return new SuccessResult(Messages.StokGrupKodUpdated);
        }
    }
}