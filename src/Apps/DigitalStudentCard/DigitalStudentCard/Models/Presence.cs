namespace DigitalStudentCard.Core.Models
{
    public class Presence
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int MomentId { get; set; }
        public Moment Moment { get; set; }
        public bool IsBlanco { get; set; }
    }
}

