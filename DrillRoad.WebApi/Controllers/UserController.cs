using DrillRoad.Entities.Persons;
using Microsoft.AspNetCore.Mvc;

namespace DrillRoad.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    [HttpGet]
    public Task<Action<AdditionalUserInfo>> Get()
    {
        return default;
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