using Ceyehat.Domain.Common.Models;

namespace Ceyehat.Domain.FlightAggregate.ValueObjects;

public sealed class FlightId : ValueObject
{
    public Guid Value { get; }

    private FlightId(Guid value)
    {
        Value = value;
    }

    public static FlightId CreateUnique()
    {
        return new(Guid.NewGuid());
    }
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}