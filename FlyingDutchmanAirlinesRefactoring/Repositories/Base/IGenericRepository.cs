

using FlyingDutchmanAirlinesRefactoring.Domain.Models.BaseEntities;

namespace FlyingDutchmanAirlinesRefactoring.Repositories.Base
{
    public interface IGenericRepository<Key ,T> where T : IBaseEntity<Key>
    {
        Task<bool> AddAsync(T entity);
    }
}
