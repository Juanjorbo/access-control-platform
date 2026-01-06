using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AccessControl.Api.Infrastructure;

namespace AccessControl.Api.Controllers;

[ApiController]
[Route("users")]
public class UsersController : ControllerBase
{
    private readonly AppDbContext _db;

    public UsersController(AppDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
        var users = await _db.Users.ToListAsync();
        return Ok(users);
    }
}
