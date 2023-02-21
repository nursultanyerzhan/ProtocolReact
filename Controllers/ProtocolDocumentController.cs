using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProtocolReact.Models;

namespace ProtocolReact.Controllers;

[ApiController]
public class ProtocolDocumentController : ControllerBase
{
    private readonly WebPortalContext _db;

    public ProtocolDocumentController(WebPortalContext db)
    {
        _db = db;
    }

    [Route("getProtocolDocuments")]
    public async Task<ActionResult> GetList()
    {
        var list = await _db.Protocols.ToListAsync();
        return Ok(list);
    }
}
