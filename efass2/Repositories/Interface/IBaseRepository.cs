using System.Linq.Expressions;
using efass2.Models;

namespace efass2.Repositories.Interface;

    public interface IBaseRepository<T> where T : BaseEntity<int>
{
    IEnumerable<T> GetAll(Expression<Func<T, bool>>? predicate = null);
    T? Get(Expression<Func<T, bool>>? predicate = null);
    T Create(T entity);
    T Update(T entity);
    void Delete(T entity);
}
