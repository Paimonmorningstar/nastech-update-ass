using efass2.Models;

namespace efass2.Repositories.Interface;

public interface IUnitOfWork
{
    BaseRepository<T> GetRepository<T>() where T : BaseEntity<int>;
    int SaveChanges();
    IDatabaseTransaction GetDatabaseTransaction();

}