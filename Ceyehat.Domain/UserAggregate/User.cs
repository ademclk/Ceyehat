using Ceyehat.Domain.Entities;

namespace Ceyehat.Domain.User;

public class User
{
    public Guid UserId { get; set; } = Guid.NewGuid();
    public string FirstName { get; init; } = null!;
    public string LastName { get; init; } = null!;
    public string Email { get; init; } = null!;
    public string Password { get; init; } = null!;
}