namespace ContactManager002.Models
{
    public class Contact
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty; // Default value
        public string LastName { get; set; } = string.Empty;  // Default value
        public string Phone { get; set; } = string.Empty;     // Default value
        public string Email { get; set; } = string.Empty;     // Default value
        public string Category { get; set; } = string.Empty;  // Default value
    }


}
