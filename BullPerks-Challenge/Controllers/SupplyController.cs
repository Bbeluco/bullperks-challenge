using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BullPerks_Challenge;

[ApiController]
[Authorize]
public class SupplyController : ControllerBase
{
    [HttpGet("/supply")]
    public IResult GetSupplyInfo() {
        return Results.Ok();
    }
}
