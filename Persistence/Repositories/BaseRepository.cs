using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    internal class BaseRepository<T> where T : Entity
    {
        protected readonly ReservationServiceDbContext _dbContext;

        public BaseRepository(ReservationServiceDbContext context) => _dbContext = context;

        public async Task<IEnumerable<T>> GetAllAsync() => await _dbContext.Set<T>().ToListAsync();

        public async Task<T?> GetByIdAsync(int id) => await _dbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id);

        public void Add(T entity) =>_dbContext.Set<T>().Add(entity);

        public void Remove(T entity) => _dbContext.Set<T>().Remove(entity);

        public T Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            return entity;
        }
    }
}
