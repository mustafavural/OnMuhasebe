using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IStokService
    {
        IDataResult<Stok> GetById(int stokId);
        IDataResult<List<Stok>> GetList();
        IDataResult<List<Stok>> GetListByGrupKod(int grupKodId);
        IDataResult<List<Stok>> GetListByGrupAd(string grupKodAd);
        IResult Add(Stok stok);
        IResult Update(Stok stok);
        IResult Delete(Stok stok);
        [CachAspect(10), LogAspect(typeof(FileLogger)), PerformanceAspect(1)]
        IDataResult<List<Stok>> GetListByKDV(int KDV);
        [LogAspect(typeof(FileLogger)), PerformanceAspect(1)]
        IDataResult<Stok> GetByKod(string stokKod);
        [LogAspect(typeof(FileLogger)), PerformanceAspect(1)]
        IDataResult<Stok> GetByBarkod(string stokBarkod);
        [LogAspect(typeof(FileLogger)), PerformanceAspect(1)]
        IDataResult<Stok> GetByAd(string stokAd);
    }
}