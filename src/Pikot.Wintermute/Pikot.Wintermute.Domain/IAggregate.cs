namespace Pikot.Wintermute.Domain;

public interface IAggregate
{
    public int Id { get; }
    public DateTimeOffset CreatedAt { get; }
    public DateTimeOffset InsertedAt { get; }
}