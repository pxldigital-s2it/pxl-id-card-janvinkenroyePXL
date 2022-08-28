using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Presences.Domain;

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Role Role { get; set; }
}
