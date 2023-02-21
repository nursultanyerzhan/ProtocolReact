using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProtocolReact.Models;

namespace ProtocolReact.Controllers;

[ApiController]
public class ProtocolMainController : ControllerBase
{
    private readonly WebPortalContext _db;

    public ProtocolMainController(WebPortalContext db)
    {
        _db = db;
    }

    [Route("getProtocolMains")]
    public async Task<ActionResult> GetList(Guid protocolId)
    {
        var list = await _db.ProtocolMains.Where(r => r.ProtocolId == protocolId).ToListAsync();
        return Ok(list);
    }
}