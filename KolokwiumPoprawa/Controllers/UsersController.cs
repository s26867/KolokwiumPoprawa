using System.Runtime.CompilerServices;
using KolokwiumPoprawa.Services;
using Microsoft.AspNetCore.Mvc;

namespace KolokwiumPoprawa.Controllers;
[ApiController]
[Route("api/users/[controller]")]
public class UsersController(IDbService service) : ControllerBase
{
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetUsersDetails(int id)
    {
        return Ok(await service.GetUsers(id));
    }
}