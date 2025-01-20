namespace Pikot.Wintermute.Domain;

public interface IEntity
{
    public long Id { get; }
    public DateTimeOffset CreatedAt { get; }
    public DateTimeOffset InsertedAt { get; }
}