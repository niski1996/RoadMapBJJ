using Microsoft.AspNetCore.Identity;

namespace RoadMapBJJ.Contracts.Entities.Persons;

public class User : IdentityUser
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}