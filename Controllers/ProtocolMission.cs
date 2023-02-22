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

    [Route("postProtocolMission")]
    [HttpPost]
    public string PostProtocolMission([FromForm] DtoProtocolMission data) //
    {
        ProtocolMission mission = new ProtocolMission();
        mission.CreatedDate = DateTime.Now;
        mission.Dedline = data.Dedline;
        mission.EventName = data.EventName;
        mission.ProtocolExecutingDateTypeId = data.ProtocolExecutingDateTypeId;
        mission.ProtocolMainId = data.ProtocolMainId;
        _db.ProtocolMissions.Add(mission);
        _db.SaveChanges();
        return "Ok";
    }
}

public class DtoProtocolMission
{
    public Guid ProtocolMainId { get; set; }
    public string EventName { get; set; } = "";
    public DateTime Dedline { get; set; }
    public int ProtocolExecutingDateTypeId { get; set; }
    public List<long> Executors { get; set; }
}
