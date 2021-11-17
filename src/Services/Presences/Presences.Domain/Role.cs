using Microsoft.AspNetCore.Identity;

namespace Presences.Domain
{
    public class Role : IdentityRole<int>
    {
        public class Constants
        {
            public const string Admin = "admin";
            public const string Student = "student";
            public const string Lector = "lector";
        }
    }
}