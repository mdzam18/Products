using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Products.Infrastructure
{
    public class BaseRepository<T> where T : class
    {

        protected readonly DbContext _context;

        protected readonly DbSet<T> _dbSet;

        public BaseRepository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<List<T>> GetAllAsync(CancellationToken token)
        {
            return await _dbSet.ToListAsync(token);
        }

        public async Task<List<T>> GetAllAsync(CancellationToken token, Expression<Func<T, bool>> func)
        {
            return await _dbSet.Where(func).ToListAsync(token);
        }

        public async Task<T> GetAsync(CancellationToken token, params object[] key)
        {
            var tracked = await _dbSet.FindAsync(key, token);
            return tracked;
        }

        public async Task AddAsync(CancellationToken token, T entity)
        {
            await _dbSet.AddAsync(entity, token);
            await _context.SaveChangesAsync(token);
        }

        public void Attach(T entity)
        {
            _dbSet.Attach(entity);
        }

        public void Detach(T entity)
        {
            _context.Entry(entity).State = EntityState.Detached;
        }

    }
}