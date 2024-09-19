using Microsoft.AspNetCore.Identity;

namespace RoadMapBJJ.Contracts.Entities.Persons;

public class User : IdentityUser
{
    public required string Name { get; set; }
    public required string LastName { get; set; }
    public required string Password { get; set; }
}