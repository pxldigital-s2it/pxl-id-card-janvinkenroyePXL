using Presences.Domain.Enums;
using Presences.Domain.Interfaces;

namespace Presences.Domain;

public class User
{
    public int UserNumber { get; set; }
    public string? UserName { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public Role Role { get; set; }
}
