using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Messages;
using Business.Constans;
using System.Linq;

namespace Business.Concrete
{
    public class StokManager : IStokService
    {
        IStokDal _stokDal;
        IStokGrupService _stokGrupService;
        IStokGrupKodService _stokGrupKodService;

        public StokManager(IStokDal stokDal, IStokGrupService stokGrupService, IStokGrupKodService stokGrupKodService)
        {
            _stokDal = stokDal;
            _stokGrupService = stokGrupService;
            _stokGrupKodService = stokGrupKodService;
        }

        public IDataResult<Stok> GetById(int stokId)
        {
            return new SuccessDataResult<Stok>(_stokDal.Get(p => p.Id == stokId));
        }

        public IDataResult<Stok> GetByKod(string stokKod)
        {
            return new SuccessDataResult<Stok>(_stokDal.Get(p => p.Kod == stokKod));
        }

        public IDataResult<Stok> GetByBarkod(string stokBarkod)
        {
            return new SuccessDataResult<Stok>(_stokDal.Get(p => p.Barkod == stokBarkod));
        }

        public IDataResult<Stok> GetByAd(string stokAd)
        {
            return new SuccessDataResult<Stok>(_stokDal.Get(p => p.Ad == stokAd));
        }

        public IDataResult<List<Stok>> GetList()
        {
            return new SuccessDataResult<List<Stok>>(_stokDal.GetAll());
        }

        public IDataResult<List<Stok>> GetListByKDV(int KDV)
        {
            return new SuccessDataResult<List<Stok>>(_stokDal.GetAll(p => p.KDV == KDV));
        }

        public IDataResult<List<Stok>> GetListByGrupAd(string grupKodAd)
        {
            return new SuccessDataResult<List<Stok>>(_stokDal.GetAll(p =>
            _stokGrupService.GetByStokGrupKodId(
                _stokGrupKodService.GetByAd(grupKodAd).Data.Id).Data.Select(s => s.StokId).Contains(p.Id)));
        }

        public IDataResult<List<Stok>> GetListByGrupKod(int grupKodId)
        {
            return new SuccessDataResult<List<Stok>>(_stokDal.GetAll(p =>
            _stokGrupService.GetByStokGrupKodId(grupKodId).Data.Select(s => s.StokId).Contains(p.Id)));
        }

        public IResult Add(Stok stok)
        {
            _stokDal.Add(stok);
            return new SuccessResult(Messages.StokInserted);
        }

        public IResult Delete(Stok stok)
        {
            _stokDal.Delete(stok);
            return new SuccessResult(Messages.StokDeleted);
        }

        public IResult Update(Stok stok)
        {
            _stokDal.Update(stok);
            return new SuccessResult(Messages.StokUpdated);
        }
    }
}