using Ceyehat.Domain.AirlineAggregate.ValueObjects;
using Ceyehat.Domain.AirportAggregate.ValueObjects;
using Ceyehat.Domain.CityAggregate;
using Ceyehat.Domain.CityAggregate.ValueObjects;
using Ceyehat.Domain.CountryAggregate.ValueObjects;
using ErrorOr;
using MediatR;

namespace Ceyehat.Application.Cities.Commands.CreateCity;

public record CreateCityCommand(
    string? Name,
    CountryId CountryId,
    List<DistrictCommand> Districts) : IRequest<ErrorOr<City>>;

public record DistrictCommand(
    string? Name,
    CityId CityId,
    List<NeighborhoodCommand> Neighborhoods);

public record NeighborhoodCommand(
    string? Name,
    CityId CityId,
    DistrictId DistrictId,
    AirlineId? AirlineId,
    AirportId? AirportId);