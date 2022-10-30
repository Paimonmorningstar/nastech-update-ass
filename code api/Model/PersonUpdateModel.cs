namespace code_api.Model
{
    public class PersonUpdateModel
    {
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Gender { get; set; }
        public string? PhoneNumber { get; set; }
        public string? BirthPlace { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}