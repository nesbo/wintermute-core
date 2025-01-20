namespace Pikot.Wintermute.Domain;

internal class Clock : IClock
{
    public DateTimeOffset UtcNow => DateTimeOffset.UtcNow;
}