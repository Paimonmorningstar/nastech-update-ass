using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace efass2.Repositories;
    public class EntityDatabaseTransaction : Interface.IDatabaseTransaction
{
    private readonly IDbContextTransaction  _transaction;

    public EntityDatabaseTransaction(DbContext context)
    {
        _transaction = context.Database.BeginTransaction();
    }

    public void Commit()
    {
        _transaction.Commit();
    }

    public void Rollback()
    {
        _transaction.Rollback();
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}