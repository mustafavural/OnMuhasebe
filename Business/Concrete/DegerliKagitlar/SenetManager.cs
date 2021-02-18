using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
using Core.Utilities.Business;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class SenetManager<TEntity> : DegerliKagitManager<TEntity>, ISenetService<TEntity>
        where TEntity : Senet, new()
    {
        IDegerliKagitDal<TEntity> _senetDal;

        public SenetManager(IDegerliKagitDal<TEntity> senetDal)
            : base(senetDal)
        {
            _senetDal = senetDal;
        }

        #region BusinessRules
        private IResult CheckIfValidKod(string kod)
        {
            var result = _senetDal.Get(p => p.Kod == kod) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.DegerliKagitNotExists);
            }
            return new SuccessResult();
        }
        #endregion

        
        public IDataResult<TEntity> GetByKod(string kod)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidKod(kod));
            if (result != null)
                return (IDataResult<TEntity>)result;

            return new SuccessDataResult<TEntity>(_senetDal.Get(p => p.Kod == kod));
        }
    }
}