namespace Pikot.Wintermute.Domain;

public interface IAggregateVersioned : IAggregate, ICanVersion
{
    int Version { get; }
}