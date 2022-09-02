namespace DigitalStudentCard.Core.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int UserNumber { get; set; }
        public string UserName { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}

