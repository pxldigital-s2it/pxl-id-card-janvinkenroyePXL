using DigitalStudentCard.Core.Enums;

namespace DigitalStudentCard.Core.Models
{
    public class User
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public Role Role { get; set; }

        public string Email { get; set; }
    }
}
