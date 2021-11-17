using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Presences.Domain
{
    public class Student : IdentityUser<int>
    {
        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }
        public virtual List<MomentStudent> MomentStudents { get; set; }
    }
}