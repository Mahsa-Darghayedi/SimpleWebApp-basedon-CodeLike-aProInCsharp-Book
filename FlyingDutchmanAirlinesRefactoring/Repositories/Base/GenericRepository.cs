using FlyingDutchmanAirlinesRefactoring.DataAccess.Context;
using FlyingDutchmanAirlinesRefactoring.Domain.Models.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace FlyingDutchmanAirlinesRefactoring.Repositories.Base
{
    public class GenericRepository<Key, T> : IGenericRepository<Key, T> where T : BaseEntity<Key>
    {
        private FlyingDutchManDbContext _context;
        private DbSet<T> _dbSet;
        public GenericRepository(FlyingDutchManDbContext contex)
        {
            _context = contex;
            _dbSet = _context.Set<T>();
        }
        public async Task<bool> AddAsync(T entity)
        {
            ArgumentNullException.ThrowIfNull(entity, nameof(entity));
            try
            {
                await _dbSet.AddAsync(entity);
                await _context.SaveChangesAsync();   
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
