using Core.Entities;
using Core.Utilities.Result;

namespace Core.Business.Abstract
{
    public interface IADU<TEntity> where TEntity : class, IEntity, new()
    {
        IResult Add(TEntity entity);
        IResult Delete(TEntity entity);
        IResult Update(TEntity entity);
    }
}