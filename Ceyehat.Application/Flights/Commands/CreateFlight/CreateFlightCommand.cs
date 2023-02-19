using Ceyehat.Domain.AircraftAggregate.ValueObjects;
using Ceyehat.Domain.AirportAggregate.ValueObjects;
using Ceyehat.Domain.Enums;
using Ceyehat.Domain.FlightAggregate;
using Ceyehat.Domain.PriceAggregate.ValueObjects;
using ErrorOr;
using MediatR;

namespace Ceyehat.Application.Flights.Commands.CreateFlight;

public record CreateFlightCommand(
    string? FlightNumber,
    DateTime ScheduledDeparture,
    DateTime ScheduledArrival,
    FlightStatus Status,
    FlightType Type,
    DateTime? ActualDeparture,
    DateTime? ActualArrival,
    AircraftId AircraftId,
    AirportId DepartureAirportId,
    AirportId ArrivalAirportId,
    PriceId PriceId
) : IRequest<ErrorOr<Flight>>;