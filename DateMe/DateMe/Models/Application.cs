using System.ComponentModel.DataAnnotations;

namespace DateMe.Models;

public class Application
{
    [Key]
    [Required]
    public int ApplicationID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Breed { get; set; }
    public string Color { get; set; }
    public bool SockFood { get; set; }
    
}

