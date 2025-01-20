namespace Pikot.Wintermute.Domain;

public interface ICanVersion
{
    bool IsSaved { get; }
    bool IsProcessed { get; }
}