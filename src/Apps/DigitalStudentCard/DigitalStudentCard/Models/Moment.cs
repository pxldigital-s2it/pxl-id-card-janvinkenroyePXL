using DigitalStudentCard.Core.Enums;
using System;
using System.Collections.Generic;

namespace DigitalStudentCard.Core.Models
{
    public class Moment
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public MomentType MomentType { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public List<Presence> Presences { get; set; }
    }
}