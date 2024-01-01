using System.Linq.Expressions;

namespace JWT.API.Domain.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        T GetById(int id);
        T Get(Expression<Func<T>> expression);
    }
}
