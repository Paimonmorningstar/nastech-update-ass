using System.ComponentModel.DataAnnotations;

namespace efday1.Models
{
    public class Student : BaseEntity<int>
    {
        [Required]
        [StringLength(69)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(69)]
        public string LastName { get; set; } = null!;

        [Required]
        public string City { get; set; } = null!;

        [Required]
        public string State { get; set; } = null!;
    }

    public class StudentViewModel
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string City { get; set; } = null!;
    public string State { get; set; } = null!;
}
}