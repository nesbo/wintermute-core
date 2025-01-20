namespace Pikot.Wintermute.Domain;

public interface IEntityVersioned<TAggregate> : IEntity, ICanVersion
    where TAggregate : IAggregateVersioned
{
    int Version { get; }
}