using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Presences.Domain
{
    public class Moment
    {
        public int Id { get; set; }
        [Required] [MinLength(3)] public string Name { get; set; }

        public MomentType MomentType { get; set; }
        
        public virtual List<MomentStudent> MomentStudents { get; set; }

    }
}