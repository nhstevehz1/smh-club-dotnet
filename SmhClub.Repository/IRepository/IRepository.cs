using SmhClub.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SmhClub.Repository.IRepository
{
    internal interface IRepository<T> where T : EntityBase
    {
        Task CreateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<T> GetByIdAsync(long id);
        Task UpdateAsync(T entity);
        IQueryable<T> GetAll(Expression<Func<T>>? expression = null);
    }
}
