using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IIrsaliyeService : IEvrakService<Irsaliye>, IADU<Irsaliye>
    {
        IDataResult<Irsaliye> GetByNo(string irsaliyeNo);
    }
}