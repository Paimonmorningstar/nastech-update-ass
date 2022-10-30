namespace efass2.Repositories.Interface;

public interface IDatabaseTransaction : IDisposable
{
    void Commit();
    void Rollback();
}
