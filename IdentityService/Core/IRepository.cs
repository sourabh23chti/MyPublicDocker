using Newtonsoft.Json.Linq;
using System.Linq.Expressions;

namespace IdentityService.Core
{
    public interface IRepository<TEntity> where TEntity: class
    {
        public TEntity getId(int id);
        public  IEnumerable<TEntity> GetAll();
        public IEnumerable<TEntity>Find(Expression<Func<TEntity,bool>>Predicate);


        void Add(TEntity entity);

        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);

        void RemoveRange(IEnumerable<TEntity> entities);





    }
}
