namespace Pikot.Wintermute.Domain;

public interface IRepository<in TAggregate>
    where TAggregate : IAggregate
{
    void Add(TAggregate aggregate);
    Task SaveAsync(CancellationToken cancellationToken);
}