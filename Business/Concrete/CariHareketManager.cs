using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation.Cariler;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class CariHareketManager : ICariHareketService
    {
        ICariHareketDal _cariHareketDal;

        public CariHareketManager(ICariHareketDal cariHareketDal)
        {
            _cariHareketDal = cariHareketDal;
        }

        [ValidationAspect(typeof(CariHareketValidator), Priority = 1)]
        public IResult Add(CariHareket cariHareket)
        {
            _cariHareketDal.Add(cariHareket);
            return new SuccessResult(Messages.SuccessMessages.CariActivityAdded);
        }

        [ValidationAspect(typeof(CariHareketValidator), Priority = 1)]
        public IResult Delete(CariHareket cariHareket)
        {
            _cariHareketDal.Delete(cariHareket);
            return new SuccessResult(Messages.SuccessMessages.CariActivityDeleted);
        }

        [ValidationAspect(typeof(CariHareketValidator), Priority = 1)]
        public IResult Update(CariHareket cariHareket)
        {
            _cariHareketDal.Add(cariHareket);
            return new SuccessResult(Messages.SuccessMessages.CariActivityUpdated);
        }

        public IDataResult<CariHareket> GetById(int cariHareketId)
        {
            return new SuccessDataResult<CariHareket>(_cariHareketDal.Get(p => p.Id == cariHareketId));
        }

        public IDataResult<decimal> GetTotalBorcOnCari(int cariId)
        {
            return new SuccessDataResult<decimal>(_cariHareketDal.GetAll(p => p.CariId == cariId).Select(s => s.Borc).Sum());
        }

        public IDataResult<decimal> GetTotalAlacakOnCari(int cariId)
        {
            return new SuccessDataResult<decimal>(_cariHareketDal.GetAll(p => p.CariId == cariId).Select(s => s.Alacak).Sum());
        }

        public IDataResult<List<CariHareket>> GetListByCariId(int cariId)
        {
            return new SuccessDataResult<List<CariHareket>>(_cariHareketDal.GetAll(p => p.CariId == cariId));
        }

        public IDataResult<List<CariHareket>> GetListByDate(DateTime cariHareketTarih)
        {
            return new SuccessDataResult<List<CariHareket>>(_cariHareketDal.GetAll(p => p.Tarih == cariHareketTarih));
        }
    }
}