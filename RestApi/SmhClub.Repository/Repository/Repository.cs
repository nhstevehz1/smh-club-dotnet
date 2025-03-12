using SmhClub.Repository.IRepository;
using SmhClub.Repository.Common;
using SmhClub.Repository.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;


namespace SmhClub.Repository.Repository
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly SmhClubContext _context;

        public Repository(SmhClubContext context)
        {
            _context = context;
        }

        public IQueryable<T> Entities => _context.Set<T>();

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            return Task.CompletedTask;
        }

        public IQueryable<T?> GetAll(Expression<Func<T, bool>>? expression = null)
        {
            var result = _context.Set<T>().AsNoTracking();
            if (expression != null) {
                result = result.Where(expression);
            }

            return result;
        }

        public async Task<T?> GetByIdAsync(long id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T?> GetFirstAsync(Expression<Func<T, bool>> expression)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(expression);
        }

        public Task UpdateAsync(T entity)
        {
            _context.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            return Task.CompletedTask;
        }
    }
}
