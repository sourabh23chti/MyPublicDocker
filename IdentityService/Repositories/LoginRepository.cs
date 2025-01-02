using IdentityService.Core;
using IdentityService.Data;
using IdentityService.Model;
using System.Linq.Expressions;

namespace IdentityService.Repositories
{
    public class LoginRepository:Repository<ApplicationUser>, ILoginRepository
    {
        public LoginRepository(AppDbContext context)
            : base(context)
        {
            
        }

        public void Add(ApplicationUser entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<ApplicationUser> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ApplicationUser> Find(Expression<Func<ApplicationUser, bool>> Predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ApplicationUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public ApplicationUser getId(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ApplicationUser entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<ApplicationUser> entities)
        {
            throw new NotImplementedException();
        }
    }
}
