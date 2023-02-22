using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProtocolReact.Models;

namespace ProtocolReact.Controllers;

[ApiController]
public class ProtocolExecutingDateTypeController : ControllerBase
{
    private readonly WebPortalContext _db;

    public ProtocolExecutingDateTypeController(WebPortalContext db)
    {
        _db = db;
    }

    [Route("getProtocolExecutingDateTypes")]
    public async Task<ActionResult> GetList(Guid protocolMainId)
    {
        var list = await _db.ProtocolExecutingDateTypes.OrderBy(r => r.Order).ToListAsync();
        return Ok(list);
    }
}
