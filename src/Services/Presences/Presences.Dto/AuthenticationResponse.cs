using Presences.Domain;

namespace Presences.DataTransfer;

public class AuthenticationResponse
{
    public string? Token { get; set; }
    public bool IsAuthenticated { get; set; }
    public User? User { get; set; }
}
