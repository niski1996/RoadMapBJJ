using DrillRoad.Contracts.Enums;
using Microsoft.AspNetCore.Identity;

namespace DrillRoad.Contracts.Entities.Persons;

public class User : IdentityUser
{
    public required string Name { get; set; }
    public required string LastName { get; set; }
    public required string Password { get; set; }
    public required DateOnly BirthDate { get; set; }
    public Gender Gender{ get; set; }
}