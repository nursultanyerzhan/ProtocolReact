using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProtocolReact.Models;

namespace ProtocolReact.Controllers;

[ApiController]
public class UsersController : ControllerBase
{
    private readonly WebPortalContext _db;

    public UsersController (WebPortalContext db)
    {
        _db = db;
    }

    [Route("getUsers")]
    public async Task<ActionResult> GetList()
    {
        var list = await _db.Users.Where(r => r.OrgIdAd == "UDP").ToListAsync();
        return Ok(list);
    }
}
