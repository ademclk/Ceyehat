namespace Ceyehat.Domain.Entities;

public class Passenger
{
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;

    public Customer Customer { get; set; } = null!;

    public List<BoardingPass> BoardingPasses { get; set; } = null!;
    public List<Relationship> Relationships { get; set; } = null!;
    public List<FlightTicket> FlightTickets { get; set; } = null!;
}