namespace Pikot.Wintermute.Domain;

public interface IClock
{
    DateTimeOffset UtcNow { get; }
}