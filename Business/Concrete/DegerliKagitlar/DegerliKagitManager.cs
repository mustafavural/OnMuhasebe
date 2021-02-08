using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
using Core.Utilities.Business;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class DegerliKagitManager<TEntity> : IDegerliKagitService<TEntity>
        where TEntity : DegerliKagit, new()
    {
        IDegerliKagitDal<TEntity> _degerliKagitDal;

        public DegerliKagitManager(IDegerliKagitDal<TEntity> degerliKagitDal)
        {
            _degerliKagitDal = degerliKagitDal;
        }

        #region BusinessRules
        private IResult CheckIfValidId(int id)
        {
            var result = _degerliKagitDal.Get(p => p.Id == id) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.DegerliKagitNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidTutar(decimal tutar)
        {
            var result = _degerliKagitDal.Get(p => p.Tutar == tutar) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.DegerliKagitTutarNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidVade(DateTime vade)
        {
            var result = _degerliKagitDal.Get(p => p.Vade == vade) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.DegerliKagitVadeNotExists);
            }
            return new SuccessResult();
        }
        #endregion

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<TEntity> GetById(int Id)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(Id));
            if (result != null)
                return (IDataResult<TEntity>)result;

            return new SuccessDataResult<TEntity>(_degerliKagitDal.Get(p => p.Id == Id));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<TEntity>> GetListByTutar(decimal tutar)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidTutar(tutar));
            if (result != null)
                return (IDataResult<List<TEntity>>)result;

            return new SuccessDataResult<List<TEntity>>(_degerliKagitDal.GetAll(p => p.Tutar == tutar));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<TEntity>> GetListByVade(DateTime vade)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidVade(vade));
            if (result != null)
                return (IDataResult<List<TEntity>>)result;

            return new SuccessDataResult<List<TEntity>>(_degerliKagitDal.GetAll(p => p.Vade == vade));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<TEntity>> GetList()
        {
            return new SuccessDataResult<List<TEntity>>(_degerliKagitDal.GetAll());
        }
    }
}