using System.ComponentModel.DataAnnotations;

namespace Practice.Models
{
    public class StudentAccount
    {
        [Key] // Define primary key
        public int Id { get; set; } // Assuming Id is the primary key property

        // Other properties
        public string? Name { get; set; }
        public string? Class { get; set; }
        public decimal Fee { get; set; }
    }
}
