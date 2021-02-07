using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IFaturaService : IEvrakService<Fatura>, IADU<Fatura>
    {
        IDataResult<Fatura> GetByNo(string faturaNo);
    }
}