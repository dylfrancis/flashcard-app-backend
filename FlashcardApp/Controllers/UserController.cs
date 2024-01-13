using FlashcardApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace FlashcardApp.Controllers;

[Route("users")]
public class UserController(ApplicationDbContext context) : ControllerBase
{
    private readonly ApplicationDbContext _context = context;

    [HttpGet]
    public IActionResult GetAll()
    {
        var users = _context.User.ToList();

        return Ok(users);
    }

    [HttpGet("{userId:int}")]
    public IActionResult GetById([FromRoute] int userId)
    {
        var user = _context.User.Find(userId);

        if (user == null)
        {
            return NotFound();
        }

        return Ok(user);
    }
}