using DrillRoad.Contracts.Account;
using DrillRoad.Contracts.Repositories;
using DrillRoad.Entities.Account;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using DrillRoad.Contracts.Tables.Account;

namespace DrillRoad.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IAdditionalUserRepository _repo;

        public UserController(IAdditionalUserRepository repo)
        {
            _repo = repo;
        }

        // GET: /User?includeDetails=true
        [HttpGet]
        public async Task<ActionResult<List<UserDrillIdentity>>> GetAll(bool includeDetails = false)
        {
            var users = includeDetails ? 
                await _repo.GetAllUsersWithPersonalData() : 
                await _repo.GetAllUsers();

            if (users == null || !users.Any())
            {
                return NotFound("No users found.");
            }

            return Ok(users.ToList());
        }
        
        [HttpGet("{username}")]
        public async Task<ActionResult<UserDrillIdentity>> GetUser( string username, bool includeDetails = false)
        {
            var user = includeDetails ? 
                await _repo.GetUserDetails(username) : 
                await _repo.GetUserWithPersonalData(username);

            return Ok(user);
        }

        // PATCH: /User/{username}
        [HttpPatch("{username}")]
        public async Task<ActionResult> Update(string username, [FromBody] AdditionalUserInfoRow info)
        {
            if (info == null || string.IsNullOrWhiteSpace(username))
            {
                return BadRequest("Invalid user data or username.");
            }

            var existingUser = await _repo.GetUserDetails(username);
            if (existingUser == null)
            {
                return NotFound($"User with username '{username}' not found.");
            }

            await _repo.UpdateAsync(info, username);
            return NoContent(); // 204 No Content after successful update
        }
        
        [HttpDelete("{username}")]
        public async Task<ActionResult> Delete(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return BadRequest("Username cannot be empty.");
            }

            var user = await _repo.GetUserDetails(username);
            if (user == null)
            {
                return NotFound($"User with username '{username}' not found.");
            }

            await _repo.DeleteAsync(username);
            return NoContent(); // 204 No Content after successful deletion
        }
    }
}
