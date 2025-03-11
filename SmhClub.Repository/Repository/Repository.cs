using SmhClub.Repository.IRepository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using SmhClub.Repository.Common;

namespace SmhClub.Repository.Repository
{


    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        public Task CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll(Expression<Func<T>>? expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
