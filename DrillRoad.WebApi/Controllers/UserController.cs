using DrillRoad.Contracts.Account;
using DrillRoad.Contracts.Repositories;
using DrillRoad.Database.Repositories;
using DrillRoad.Entities.Persons;
using Microsoft.AspNetCore.Mvc;

namespace DrillRoad.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController(IAdditionalUserRepository repo) : ControllerBase
{
    [HttpGet]
    [Route("GetAll")]
    public async Task<ActionResult<List<DrillIdentityUser>>> GetAll()
    {
        var users = await repo.GetAllUsers(); // Fetch all users from repository
        return Ok(users.ToList()); // Return 200 OK with the list of users
    }
    
    [HttpGet]
    [Route("GetAllWithDetails")]
    public async Task<ActionResult<List<DrillIdentityUser>>> GetAllWithDetails()
    {
        var users = await repo.GetAllUsers(); // Fetch all users from repository
        return Ok(users.ToList()); // Return 200 OK with the list of users
    }
    [HttpPost]
    public Task<ActionResult> Post([FromBody] AdditionalUserInfo value)
    {
        return default;
    }

    [HttpDelete]
    public Task<ActionResult> Delete()
    {
        return default;
    }
}

public class AdditionalUserInfo
{
    Contact contact{get;set;}
    DateTime BirthDate {get;set;}
}