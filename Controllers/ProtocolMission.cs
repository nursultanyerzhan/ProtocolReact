using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProtocolReact.Models;

namespace ProtocolReact.Controllers;

[ApiController]
public class ProtocolMissionController : ControllerBase
{
    private readonly WebPortalContext _db;

    public ProtocolMissionController(WebPortalContext db)
    {
        _db = db;
    }

    [Route("getProtocolMissions")]
    public async Task<ActionResult> GetList(Guid protocolMainId)
    {
        var list = await _db.ProtocolMissions.Where(r => r.ProtocolMainId == protocolMainId).ToListAsync();
        return Ok(list);
    }
}
