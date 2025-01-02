using IdentityService.Core;
using IdentityService.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace IdentityService.Repositories
{
    //Generic Repository
    public class Repository<TEntity> : IRepository<TEntity>  
        where TEntity : class
    {

        protected readonly AppDbContext dbContext;
        public Repository(AppDbContext context)
        {

            dbContext = context;
        }

        public void Add(TEntity entity)
        {
            dbContext.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
           dbContext.AddRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> Predicate)
        {
            return dbContext.Set<TEntity>().Where(Predicate);

        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbContext.Set<TEntity>().ToList();
        }

        public TEntity getId(int id)
        {
            if (dbContext != null)
            {
                var res = dbContext.Set<TEntity>().Find(id);
                return res;
            }
            return null;
        }

        public void Remove(TEntity entity)
        {
            dbContext?.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            dbContext.RemoveRange(entities);
        }
    }
}
